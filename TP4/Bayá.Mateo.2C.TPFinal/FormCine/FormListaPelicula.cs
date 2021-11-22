using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace FormCine
{
    public partial class FormListaPelicula : Form
    {
        List<Pelicula> peliculas = new List<Pelicula>();
        FormIngreso formIngresoPadre;
        FormCompraEntradas formCompraEntradas;
        FormAnalisisBaseDeDatos formAnalisisBaseDeDatos;
        Pelicula peliculaElegida;
        FormTicket formTicket;
        string connectionString = "Server=.;Database=Pelis;Trusted_Connection=True;";
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        bool isLogOut= false;

        public FormListaPelicula(FormIngreso formIngreso):this(false,formIngreso)
        { }
        public FormListaPelicula(bool adminIniciado,FormIngreso formIngreso)
        {
            InitializeComponent();
            this.formIngresoPadre = formIngreso;
            if(adminIniciado)
            {
                analisisDeBaseDeDatosToolStripMenuItem.Visible = true;
                analisisDeBaseDeDatosToolStripMenuItem.Enabled = true;
                btnComprar.Visible = false;
                btnComprar.Enabled = false;
            }
            if(!adminIniciado)
            {
                analisisDeBaseDeDatosToolStripMenuItem.Visible = false;
                analisisDeBaseDeDatosToolStripMenuItem.Enabled = false;
                btnComprar.Visible = true;
                btnComprar.Enabled = true;
            }
        }

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            try
            {
                peliculas = SqlHandler.LeerPeliculas(connectionString);
                if(!(FormIngreso.UsuarioLogeado is null))
                {
                    descargarTicketsToolStripMenuItem.Visible = true;
                    descargarTicketsToolStripMenuItem.Enabled = true;
                    cerrarSesionToolStripMenuItem.Visible = true;
                    cerrarSesionToolStripMenuItem.Enabled = true;
                }
                else
                {
                    descargarTicketsToolStripMenuItem.Visible = false;
                    descargarTicketsToolStripMenuItem.Enabled = false;
                    cerrarSesionToolStripMenuItem.Visible = false;
                    cerrarSesionToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            CargarListaAListBox();
        }
        /// <summary>
        /// Metodo de instancia que carga las peliculas de la lista peliculas a lstPeliculas
        /// </summary>
        public void CargarListaAListBox()
        {
            foreach(Pelicula pelicula in peliculas)
            {
                lstPeliculas.Items.Add(pelicula.Nombre);
            }
        }

        private void lstPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenarFormulario();
        }

        /// <summary>
        /// Si hay un index valido seleccionado este metodo de instancia averigua si la lista tiene una pelicula de mismo nombre que el valor del item seleccionado de lstPeliculas,
        /// en cuyo caso lo visualiza en el formulario
        /// </summary>
        public void RellenarFormulario()
        {
            if (lstPeliculas.SelectedIndex >= 0)
            {
                foreach (Pelicula pelicula in peliculas)
                {
                    if (String.Compare(pelicula.Nombre,lstPeliculas.SelectedItem.ToString())==0)
                    {
                        peliculaElegida = pelicula;
                        peliculaElegida.VisitasCambiada += SumarVisitasSQL;
                        txtTitulo.Text = peliculaElegida.Nombre;
                        txtDuracion.Text = peliculaElegida.Duracion.ToString();
                        txtRanking.Text = peliculaElegida.Ranking.ToString();
                        peliculaElegida.Visitas++;
                        txtVisitas.Text = peliculaElegida.Visitas.ToString();
                        txtDescripcion.Text = peliculaElegida.Descripcion;
                        break;
                    }
                }
            }
        }

        private void SumarVisitasSQL(Pelicula pelicula)
        {
            try
            {
                SqlHandler.ModificarPeliculaVisitas(connectionString,pelicula.Id,pelicula.Visitas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (lstPeliculas.SelectedIndex < 0)
            {
                MessageBox.Show("Elija pelicula para comprar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                formCompraEntradas = FormGenerico<FormCompraEntradas>.IsActivatedSignleton<Pelicula>(formCompraEntradas,peliculaElegida);
                formCompraEntradas.Show();
            }
        }

        private void abrirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.SpecialFolder.MyDocuments.ToString();
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Ticket.xml",
                Filter = "Xml Files (*.xml)|*.xml",
                Title = "Seleccione su ticket"
            };
            if(Directory.Exists(path))
            {
                openFileDialog.InitialDirectory = path;
            }
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    Comprador comprador = Ticket.LeerTicket(openFileDialog.FileName);
                    formTicket = FormGenerico<FormTicket>.IsActivatedSignleton<Comprador>(formTicket, comprador);
                    formTicket.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void descargarTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancellationToken cancellation = cancellationTokenSource.Token;
            Task task = Task.Run(() => ObtenerTicketsEnParalelo(cancellation));
        }

        private void ObtenerTicketsEnParalelo(CancellationToken cancellationToken)
        {
            try
            {
                List<Comprador> tickets = SqlHandler.ObtenerCompradorDeBaseDeDatos(connectionString, FormIngreso.UsuarioLogeado.Id);
                foreach (Comprador item in tickets)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                    Ticket.ArmarTicket(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Su descarga finalizó correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.isLogOut = true;
            this.Close();
        }

        private void analisisDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAnalisisBaseDeDatos = FormGenerico<FormAnalisisBaseDeDatos>.IsActivatedSingleton(formAnalisisBaseDeDatos);
            formAnalisisBaseDeDatos.Show();
        }

        private void FormListaPelicula_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isLogOut)
            {
                cancellationTokenSource.Cancel();
                this.formIngresoPadre.ObtenerError.Clear();
                this.formIngresoPadre.Show();
            }
            else
            {
                if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if(!(formIngresoPadre is null))
                    {
                        cancellationTokenSource.Cancel();
                        formIngresoPadre.Close();
                    }
                }
            }
        }
    }
}

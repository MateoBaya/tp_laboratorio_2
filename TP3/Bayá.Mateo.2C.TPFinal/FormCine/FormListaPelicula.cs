using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        Pelicula peliculaElegida;
        FormTicket formTicket;


        public FormListaPelicula(FormIngreso formIngreso):this(false,formIngreso)
        { }
        public FormListaPelicula(bool iniciadoSesion,FormIngreso formIngreso)
        {
            InitializeComponent();
            this.formIngresoPadre = formIngreso;
            if(iniciadoSesion==true)
            {
                modificarBaseDeDatosToolStripMenuItem.Visible = true;
                analisisDeBaseDeDatosToolStripMenuItem.Visible = true;
            }
        }

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula(1,"Batman",120,480,4,"Gran pelicula por un gran director");
            Pelicula pelicula2 = new Pelicula(2, "Json vs Xml", 200, 4, 2, "Malisima");
            Pelicula pelicula3 = new Pelicula(3, "Json vs Xml 2",180,50,3,"Como siguen haciendo esta pelicula");
            Pelicula pelicula4 = new Pelicula(4,"Json vs Xml 3",80,354,((float)4.6),"Al menos tiene una duracion normal esta vez");
            Pelicula pelicula5 = new Pelicula(5,"Spiderman",100,10000,5,"Gran pelicula, un clasico del cine de superheroes");
            Pelicula pelicula6 = new Pelicula(6,"Alien",90,4800,5,"Un clasico del terror");
            Pelicula pelicula7 = new Pelicula(7,"The Room",80,59,1,"Nadie sabe por que esta pelicula se hizo, pero salio");
            Pelicula pelicula8 = new Pelicula(8,"X-men",90,1500,3,"Buena pelicula, envejecio algo mal");


            peliculas.Agregar(pelicula);
            peliculas.Agregar(pelicula2);
            peliculas.Agregar(pelicula3);
            peliculas.Agregar(pelicula4);
            peliculas.Agregar(pelicula5);
            peliculas.Agregar(pelicula6);
            peliculas.Agregar(pelicula7);
            peliculas.Agregar(pelicula8);


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

        private void FormListaPelicula_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quiere salir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (!(formIngresoPadre is null))
                {
                    formIngresoPadre.Close();
                }
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
    }
}

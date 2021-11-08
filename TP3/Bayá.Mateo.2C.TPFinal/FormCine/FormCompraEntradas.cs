using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCine
{
    public partial class FormCompraEntradas : Form
    {
        Pelicula peliculaElegida;
        FormExito formExito;

        public FormCompraEntradas()
        {
            InitializeComponent();
        }
        public FormCompraEntradas(Pelicula  pelicula):this()
        {
            peliculaElegida = pelicula;
        }

        private void pctbLess_Click(object sender, EventArgs e)
        {
            MoreOrLessCantidad('-');
        }

        private void pctbMore_Click(object sender, EventArgs e)
        {
            MoreOrLessCantidad('+');
        }

        /// <summary>
        /// Metodo que valida si debe sumarse o restarse la cantidad de entradas
        /// </summary>
        /// <param name="sumaOResta">Parametro de caracacter que sera validado</param>
        public void MoreOrLessCantidad(char sumaOResta)
        {
            if(sumaOResta=='+')
            {
                if(int.TryParse(txtCantidad.Text, out int cantidad)&&cantidad<8)
                {
                    cantidad++;
                    txtCantidad.Text = cantidad.ToString();
                }
            }
            else if(sumaOResta=='-')
            {
                if (int.TryParse(txtCantidad.Text, out int cantidad)&&cantidad>1)
                {
                    cantidad--;
                    txtCantidad.Text = cantidad.ToString();
                }
            }
        }
        private void FormCompraEntradas_Load(object sender, EventArgs e)
        {
            try
            {
                txtTitulo.Text = peliculaElegida.Nombre;
                txtDuracion.Text = peliculaElegida.Duracion.ToString();
                txtDescripcion.Text = peliculaElegida.Descripcion;


                List<string> listaDeHorarios = new StringBuilder(Pelicula.ElegirHorarioDisponible()).StringBuilderToList();
                foreach(string linea in listaDeHorarios)
                {
                    cmbHorarios.Items.Add(linea);
                }
                
                cmbTipoDePelicula.Items.Add("2D");
                cmbTipoDePelicula.Items.Add("3D");
                cmbTipoDePelicula.Items.Add("4D");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtCantidad.Text, out int cantidadEntradas);
                Entrada entrada = new Entrada(0,peliculaElegida,cmbTipoDePelicula.Text,cantidadEntradas);
                Comprador comprador = new Comprador(0,entrada,txtNombreCompleto.Text,cmbHorarios.Text);
                formExito = FormGenerico<FormExito>.IsActivatedSignleton<string>(formExito, Ticket.ArmarTicket(comprador));
                if(!(formExito is null))
                {
                    formExito.Show();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

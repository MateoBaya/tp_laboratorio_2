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
    public partial class FormTicket : Form
    {
        Comprador comprador;
        public FormTicket()
        {
            InitializeComponent();
        }
        public FormTicket(Comprador comprador) : this()
        {
            this.comprador = comprador;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            
            txtNombreCompleto.Text = comprador.NombreComprador;
            txtTitutlo.Text = comprador.Entrada.Pelicula.Nombre;
            txtCantidadEntradas.Text = comprador.Entrada.Cantidad.ToString();
            txtDimensiones.Text = comprador.Entrada.DimensionesPelicula;
            txtHorario.Text = comprador.HorarioElegido;
            txtPrecio.Text = comprador.Precio.ToString();
            
        }
    }
}

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
    public partial class FormRegistrarse : Form
    {
        string connectionString = "Server=.;Database=Pelis;Trusted_Connection=True;";

        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                SqlHandler.RegistrarUsuario(connectionString,new UsuarioRegistrado(txtNombre.Text,int.Parse(txtDni.Text),txtUsuario.Text,txtContraseña.Text,cmbGenero.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

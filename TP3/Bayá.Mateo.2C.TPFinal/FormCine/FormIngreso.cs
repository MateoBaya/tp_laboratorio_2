using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Clase 10: Excepciones
///Las excepciones están utilizadas en distintos espacios de los proyectos, desde algunas propiedades de las diferentes clases, los formularios y el Test Unitario que comprueba 
///que las propiedades designadas lanzan una excepción creada personal llamada PeliculaMalCargadaException de manera correcta. Las propiedades de la clase Película tienen varias 
///implementaciones de esta excepción.
///Clase 11: Prueba Unitaria
///La prueba unitaria está llamada TestCine y tiene actualmente dos métodos de prueba (en la instancia de TP4 planeo crear tests para mi base de datos y sus distintas tablas, 
///entre estas tablas estarían la tabla de películas, las de usuarios, la de tickets creados).
///Clase 12: Tipos Genéricos
///Los tipos genéricos fueron implementados en la clase estática FormGenerico que permite realizar formularios siguiendo el patrón de diseño singleton 
///(si no existe lo crea, si existe lo reenvia), donde se realizó una sobrecarga de método para que se puedan crear constructores con un parámetro de tipo genérico, 
///algo que se utilizó mucho para que varios formularios compartan información
///Clase 13: Interfaces
///Creada la interfaz IOrdenamiento cumple dos funciones, le obliga a crear una propiedad Id de solo lectura a todos las clases que la implementen, 
///permitiendo relacionarse con una base de datos, sin que pueda alterarse el id (único) de la base de datos, además de que al ser de solo lectura fuerza a que este id 
///no sea visible por el serializador de xml. La otra función de esta interfaz es que se implemente un método de ordenamiento por Id, que por ahora no tiene relevancia 
///pero al manejar base de datos se utilizará.
///Clase 14: Archivos y Serialización
///La clase estática Ticket es la que tiene el manejo de archivos y de serialización Xml, esta clase es llamada a través de la consola Test y de los formulario 
///de creación y lectura de Tickets (formuario FormCompraEntrada crea los Tickets y los formularios FormExito y FormListaPelicula (este se debe al uso del ToolStripMenu Abrir Archivo)).
/// </summary>
namespace FormCine
{
    public partial class FormIngreso : Form
    {
        FormListaPelicula formListaPelicula;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public FormIngreso()
        {
            InitializeComponent();
        }

        private void pctbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctbClose_MouseEnter(object sender, EventArgs e)
        {
            pctbClose.Image = Properties.Resources.redcross;
        }

        private void pctbClose_MouseLeave(object sender, EventArgs e)
        {
            pctbClose.Image = Properties.Resources._1487086345_cross_81577;
        }

        private void btnNoSesion_Click(object sender, EventArgs e)
        {
            formListaPelicula = new FormListaPelicula(this);
            formListaPelicula.Show();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="admin"&&txtContraseña.Text=="admin")
            {
                formListaPelicula = new FormListaPelicula(true,this);
                errorIniciarSesion.Clear();
                formListaPelicula.Show();
                this.Hide();
            }
            else
            {
                errorIniciarSesion.SetError(btnIniciarSesion, "Error en la carga de usuario o contraseña");
            }
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

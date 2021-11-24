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

/// <summary>
///Clase 10: Excepciones
///Las excepciones están utilizadas en distintos espacios de los proyectos, desde algunas propiedades de las diferentes clases, los formularios y el Test Unitario 
///que comprueba que las propiedades designadas lanzan una excepción creada personal llamada PeliculaMalCargadaException de manera correcta. 
///Las propiedades de la clase Película tienen varias implementaciones de esta excepción.
///Clase 11: Prueba Unitaria
///La prueba unitaria está llamada TestCine y tiene actualmente dos métodos de prueba (en la instancia de TP4 planeo crear tests para mi base de datos y sus distintas tablas, 
///entre estas tablas estarían la tabla de películas, las de usuarios, la de tickets creados).
///Clase 12: Tipos Genéricos
///Los tipos genéricos fueron implementados en la clase estática FormGenerico que permite realizar formularios siguiendo el patrón de diseño singleton 
///(si no existe lo crea, si existe lo reenvia), donde se realizó una sobrecarga de método para que se puedan crear constructores con un parámetro de tipo genérico, 
///algo que se utilizó mucho para que varios formularios compartan información
///Clase 13: Interfaces
///Creada la interfaz IOrdenamiento cumple dos funciones, le obliga a crear una propiedad Id de solo lectura a todos las clases que la implementen, 
///permitiendo relacionarse con una base de datos, sin que pueda alterarse el id (único) de la base de datos, además de que al ser de solo lectura fuerza a que este id no sea 
///visible por el serializador de xml.
///Clase 14: Archivos y Serialización
///La clase estática Ticket es la que tiene el manejo de archivos y de serialización Xml, 
///esta clase es llamada a través de la consola Test y de los formulario de creación y lectura de Tickets (formuario FormCompraEntrada 
///crea los Tickets y los formularios FormExito y FormListaPelicula (este se debe al uso del ToolStripMenu Abrir Archivo)).
///Clase 15 y 16: Base de Datos
///La clase estática SqlHandler es la que se encarga de (a través de sus métodos estáticos) conectar con la base de datos y retornar la información necesitada de las tablas. 
///Esta clase se utiliza en muchos formularios, desde el de listarPeliculas, hasta el de análisis de datos.
///Clase 17: Delegados y expresiones lambda
///Se utilizó un delegado en la clase Pelicula, con objetivo a usarse en un evento de suma de visitas. Mientras que la expresión Lambda se utilizó en algunas propiedades 
///de Usuario Registrado en su get, pero más principalmente se usó la expresión Lambda en el test unitario TestCine que permite, en el  método TestSumarVisitas, 
///crear un método anónimo simulando un botón que haya sumado una visita como lo hace el formulario de películas.
///Clase 18:Hilos
///Los hilos se utilizaron para poder realizar una descarga de tickets en la nube, mientras que todavía sea utilizable la aplicación, al hacerlo en simultáneo la descarga 
///se detiene correctamente al cerrar el formulario usando un token de cancelación. Esta descarga se encuentra en el formulario ListarPeliculas
///Clase 19:Eventos
///Los eventos se utilizan constantemente en formularios, pero el evento personalizado para la clase Peliculas se invoca cuando alguien intenta sumar un número de visitas 
///a través de la propiedad Visitas.
///Clase 20:Métodos de extensión
///Estos no fueron creados para la instancia de TP4, ya que su uso tenía importancia desde un principio para alterar el comportamiento de la clase Lista y de la clase 
///StringBuilder, se pueden encontrar en las clases StringBuidlerExtension y ListExtension.
/// </summary>
namespace FormCine
{
    public partial class FormIngreso : Form
    {
        string connectionString = "Server=.;Database=Pelis;Trusted_Connection=True;";
        FormListaPelicula formListaPelicula;
        FormRegistrarse formRegistrarse;

        static UsuarioRegistrado usuarioLogeado;


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

        public ErrorProvider ObtenerError
        {
            get
            {
                return this.errorIniciarSesion;
            }
        }

        public static UsuarioRegistrado UsuarioLogeado
        {
            get
            {
                return FormIngreso.usuarioLogeado;
            }
            set
            {
                FormIngreso.usuarioLogeado = value;
            }
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
            FormIngreso.usuarioLogeado = null;
            formListaPelicula = new FormListaPelicula(this);
            formListaPelicula.Show();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                FormIngreso.UsuarioLogeado = UsuarioRegistrado.AveriguarLogeo(txtUsuario.Text, txtContraseña.Text, SqlHandler.LeerUsuarios(connectionString));
                if(FormIngreso.UsuarioLogeado.Usuario == "admin" && FormIngreso.UsuarioLogeado.Contraseña == "admin")
                {
                    formListaPelicula = new FormListaPelicula(true,this);
                    formListaPelicula.Show();
                    this.Hide();
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
                else
                {
                    formListaPelicula = new FormListaPelicula(this);
                    formListaPelicula.Show();
                    this.Hide();
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
            }
            catch (UsuarioMalCargadoException)
            {
                errorIniciarSesion.SetError(btnIniciarSesion, "Usuario o contraseña incorrecta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            formRegistrarse = FormGenerico<FormRegistrarse>.IsActivatedSingleton(formRegistrarse);
            formRegistrarse.Show();
        }
    }
}

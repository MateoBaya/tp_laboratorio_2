using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
namespace Entidades
{
    public class Pelicula : IOrdenamiento
    {
        private readonly int id;
        private string nombre;
        private int duracion;
        private int visitas;
        private float ranking;
        private string descripcion;

        /// <summary>
        /// Constuctor de instancia por defecto, utilizado para la serialización xml
        /// </summary>
        public Pelicula()
        { }
        /// <summary>
        /// Constructor de instancia que instancia todos los atributos de la clase a través de los parametros
        /// </summary>
        /// <param name="id">Parametro de tipo entero que instanciará el atributo id</param>
        /// <param name="nombre">Parametro de tipo string que instanvciará el atributo nombre</param>
        /// <param name="duracion">Parametro de tipo entero que instanciará el atributo duracion de la película</param>
        /// <param name="visitas">Parametro de tipo entero que instanciará el atributo visitas de la película</param>
        /// <param name="ranking">Parametro de tipo float que instanciará el atributo ranking de la película</param>
        /// <param name="descripcion">Parametro de tipo string que instanciará el atributo descripción</param>
        public Pelicula(int id, string nombre, int duracion, int visitas, float ranking, string descripcion)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Duracion = duracion;
            this.visitas = visitas;
            this.Ranking = ranking;
            this.Descripcion = descripcion;
        }

        /// <summary>
        /// Propiedad de tipo entero solo lectura que devuelve el atributo id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        /// <summary>
        /// Propiedad de tipo string lectura y escritura que devuelve y modifica el atributo nombre según validaciones que si no se cumplen lanza una excepcion PeliculaMalCargadaExcepcion
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value.Length<50&& !(String.IsNullOrEmpty(value)))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new PeliculaMalCargadaException("Cargue el nombre completo correctamente");
                }
            }
        }
        /// <summary>
        /// Propiedad de tipo entero lectura y escritura que retorna y modifica el atributo duración según validaciones que si no se cumplen lanza una excepcion PeliculaMalCargadaExcepcion
        /// </summary>
        public int Duracion
        {
            get
            {
                return this.duracion;
            }
            set
            {
                if(value.ToString().Length<=3&&value>60)
                {
                    this.duracion = value;
                }
                else
                {
                    throw new PeliculaMalCargadaException("La duracion esta fuera de rango");
                }
            }
        }
        /// <summary>
        /// Propiedad de tipo entero lectura y escritura que retorna y modifica el atributo visitas según validaciones que si no secumplen lanza una excepcion PeliculaMalCargadaExcepcion,
        /// esta propiedad es ignorada por el serializador xml
        /// </summary>
        [XmlIgnore]
        public int Visitas
        {
            get
            {
                return this.visitas;
            }
            set
            {
                if(value==this.visitas+1)
                {
                    this.visitas = value;
                }
                else
                {
                    throw new PeliculaMalCargadaException("No puede agregar mas de 1 visita a la vez");
                }
            }
        }
        /// <summary>
        /// Propiedad de tipo float lectura y escritura que retorna y modifica el atributo ranking según validaciones que si no secumplen lanza una excepcion PeliculaMalCargadaExcepcion,
        /// esta propiedad es ignorada por el serializador xml
        /// </summary>
        [XmlIgnore]
        public float Ranking
        {
            get
            {
                return this.ranking;
            }
            set
            {
                if(value<=5&&value>=0)
                {
                    float.TryParse(value.ToString("0.0"),out this.ranking);
                }
                else
                {
                    throw new PeliculaMalCargadaException("El ranking esta fuera de parametros");
                }
            }
        }

        /// <summary>
        /// Propiedad de tipo string lectura y escritura que retorna y modifica el atributo visitas,
        /// esta propiedad es ignorada por el serializador xml
        /// </summary>
        [XmlIgnore]
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        /// <summary>
        /// Método que construye un stringbuilder de horarios aleatorios
        /// </summary>
        /// <returns>Retorna el stringbuilder en tipo string</returns>
        public static string ElegirHorarioDisponible()
        {
            string[] horarios = { "12:00","12:30","13:15","14:00","15:45","16:20","17:00","17:50","18:30","19:15","20:00","21:15" };
            int cantHorarios;
            string horarioDistinto;
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            cantHorarios=random.Next(4,7);
            for(int i = 0; i<cantHorarios;i++)
            {
                horarioDistinto = horarios[random.Next(0, 11)];
                if (!(sb.Contains(horarioDistinto)))
                {
                    sb.AppendLine(horarioDistinto);
                }
            }
            sb=sb.Sort();
            return sb.ToString();
        }

        /// <summary>
        /// Método de instancia que permite usarse en una función Sort de listas
        /// </summary>
        /// <param name="valor1">Parametro de tipo entero que se verificará</param>
        /// <param name="valor2">Parametro de tipo entero que se verificará</param>
        /// <returns></returns>
        public int OrdenarPorId(int valor1, int valor2)
        {
            if (valor1 > valor2)
            {
                return 1;
            }
            else if (valor1 < valor2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

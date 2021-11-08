using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Entidades
{
    public class Comprador : IOrdenamiento
    {
        private readonly int id;
        private Entrada entrada;
        private string nombreComprador;
        private int precio;
        private string horarioElegido;

        /// <summary>
        /// Propiedad de tipo entero solo lectura que retorna el id de la clase
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        /// <summary>
        /// Propiedad de tipo string lectura y escritura que devuelve y modifica el nombreComprador si se respetan ciertas validaciones
        /// </summary>
        public string NombreComprador
        {
            get
            {
                return this.nombreComprador;
            }
            set
            {
                if(!(String.IsNullOrEmpty(value))&&value.Length<=50&&!(Regex.IsMatch(value, @"\d")))
                {
                    this.nombreComprador = value;
                }
                else
                {
                    throw new PeliculaMalCargadaException("Cargue el nombre hasta 50 caracteres y sin numeros");
                }
            }
        }
        /// <summary>
        /// Propiedad de tipo Entrada lectura y escritura que modifica la referencia del atributo entrada de clase Entrada segun ciertas validaciones
        /// </summary>
        public Entrada Entrada
        {
            get
            {
                return this.entrada;
            }
            set
            {
                if(value!=null&&value.Id>=0)
                {
                    this.entrada = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de tipo entero escritura y lectura que modifica el valor del atributo precio segun ciertas validaciones
        /// </summary>
        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value>0)
                {
                    this.precio=CalcularPrecio(this.Entrada.DimensionesPelicula);
                }
            }
        }
        /// <summary>
        /// Propiedad de tipo string escritura y lectura que modifica el valor del atributo horarioElegido
        /// </summary>
        public string HorarioElegido
        {
            get
            {
                return this.horarioElegido;
            }
            set
            {
                if(!(String.IsNullOrEmpty(value)))
                {
                    this.horarioElegido = value;
                }
                else
                {
                    throw new PeliculaMalCargadaException("No eligio ningun horario");
                }
            }
        }
        /// <summary>
        /// Constructor de instancia por defecto, utilizado para la serlización xml
        /// </summary>
        public Comprador()
        { }
        /// <summary>
        /// Constructor de instancia que instancia todos los atributos a través de parametros, excepto el de precio que se asigna a través de la función CalcularPrecio
        /// </summary>
        /// <param name="id">Parametro de tipo entero que se asignara al atributo id</param>
        /// <param name="entrada">Parametro de tipo Entrada que se asignara al atributo entrada</param>
        /// <param name="nombreComprador">Parametro de tipo string que se asingará al atributo nombreComprador</param>
        /// <param name="horarioElegido"><Parametro de tipo string qque se asignará al atributo horarioElegido/param>
        public Comprador(int id,Entrada entrada,string nombreComprador,string horarioElegido)
        {
            this.id = id;
            this.Entrada = entrada;
            this.NombreComprador = nombreComprador;
            this.Precio = CalcularPrecio(this.Entrada.DimensionesPelicula);
            this.HorarioElegido = horarioElegido;
        }
        /// <summary>
        /// Este método de instancia genera un precio a través de validar las dimensiones pasadas por parametro
        /// </summary>
        /// <param name="dimensiones">Parametro de tipo string que será validado</param>
        /// <returns>Retorna el valor del precio final</returns>
        private int CalcularPrecio(string dimensiones)
        {
            int precio=0;
            if(dimensiones == "2D")
            {
                precio = 700 * this.Entrada.Cantidad;
            }
            else if(dimensiones == "3D")
            {
                precio = 1200 * this.Entrada.Cantidad;
            }
            else if(dimensiones == "4D")
            {
                precio = 1700 * this.Entrada.Cantidad;
            }
            return precio;
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

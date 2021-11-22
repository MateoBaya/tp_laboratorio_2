using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrada : IOrdenamiento
    {
        private readonly int id;
        private Pelicula pelicula;
        private CantDimensionesPelicula dimensiones;
        private int cantidad;

        /// <summary>
        /// Constructor de instancia por defecto, se utiliza para la serialización xml
        /// </summary>
        public Entrada() { }
        /// <summary>
        /// /Constructor de instancia que instancia todos los atributos a través de los parámetros
        /// </summary>
        /// <param name="id">Parametro de tipo entero que se </param>
        /// <param name="pelicula"></param>
        /// <param name="dimensiones"></param>
        /// <param name="cantidad"></param>
        public Entrada(int id, Pelicula pelicula, string dimensiones, int cantidad)
        {
            this.id = id;
            this.Pelicula = pelicula;
            this.DimensionesPelicula = dimensiones;
            this.Cantidad = cantidad;
        }

        /// <summary>
        /// Propiedad de tipo entero solo lectura que retorna el atributo id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        /// <summary>
        /// Propiedad de tipo Pelicula lectura y escritura que retorna y modifica el atributo pelicula según validaciones
        /// </summary>
        public Pelicula Pelicula
        {
            get
            {
                return this.pelicula;
            }
            set
            {
                if(!(value is null))
                {
                    this.pelicula = value;
                }
            }
        }
        /// <summary>
        /// Propiedad de tipo string lectura y escritura que retorna y modifica las dimensiones de la entrada a trávés de los métodos ObtenerDimensiones y el constructor de
        /// CantDimensionesPelicula que utiliza string
        /// </summary>
        public string DimensionesPelicula
        {
            get
            {
                return this.ObtenerDimensiones();
            }
            set
            {
                this.dimensiones = new CantDimensionesPelicula(value);
            }
        }

        /// <summary>
        /// Método que devuelve las dimensiones del atributo dimensiones en formato string usando ToString
        /// </summary>
        /// <returns>Retorna el string de dimensiones</returns>
        private string ObtenerDimensiones()
        {
            if (!(this.dimensiones is null))
            {
                return this.dimensiones.ToString();
            }
            return "";
        }

        /// <summary>
        /// Propiedad de tipo entero lectura y escritura que retorna y modifica la cantidad de entradas
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if (value > 0 && value <= 8)
                {
                    this.cantidad = value;
                }
            }
        }
        /// <summary>
        /// Método de instancia que permite usarse en una función Sort de listas
        /// </summary>
        /// <param name="valor1">Parametro de tipo entero que se verificará</param>
        /// <param name="valor2">Parametro de tipo entero que se verificará</param>
        /// <returns></returns>
        public int OrdenarPorId(int valor1,int valor2)
        {
            if(valor1>valor2)
            {
                return 1;
            }
            else if(valor1<valor2)
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

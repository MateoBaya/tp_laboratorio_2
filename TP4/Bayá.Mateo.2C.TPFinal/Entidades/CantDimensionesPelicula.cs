using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase de instancia que maneja el tipo de entrada (2D,3D,4D)
    /// </summary>
    public class CantDimensionesPelicula
    {
        CantidadDimensiones cantDimensiones;

        public enum CantidadDimensiones
        {
            DosDimensiones,
            TresDimensiones,
            CuatroDimensiones
        }

        /// <summary>
        /// Constructor de instancia que inicializa el atributo cantDimensiones de la clase
        /// </summary>
        /// <param name="cantDimensiones">Parametro de tipo CantidadDimensiones que inicializará al atributo de la clase</param>
        public CantDimensionesPelicula(CantidadDimensiones cantDimensiones)
        {
            this.cantDimensiones = cantDimensiones;
        }
        /// <summary>
        /// Constructor de instancia que inicializa el atributo cantDimensiones ustilizando la funcion StringToCantDimensiones
        /// </summary>
        /// <param name="cantDimensiones">Parametro de tipo string que será convertido a CantDimensiones para instanciar el atributo</param>
        public CantDimensionesPelicula(string cantDimensiones)
        {
            StringToCantidadDimensiones(cantDimensiones);
        }

        /// <summary>
        /// Propiedad de tipo CantidadDimensiones lectura y escritura que permite modificar el atributo cantDimensiones
        /// </summary>
        public CantidadDimensiones Dimensiones
        {
            get
            {
                return this.cantDimensiones;
            }
            set
            {
                this.cantDimensiones = value;
            }
        }

        /// <summary>
        /// Este método de instancia convierte el atributo cantDimensiones en un string legible
        /// </summary>
        /// <returns>Retorna el string traducido del atributo cantDimensiones</returns>
        private string CantidadDimensionesToString()
        {
            if (this.Dimensiones == CantidadDimensiones.DosDimensiones)
            {
                return "2D";
            }
            else if (this.Dimensiones == CantidadDimensiones.TresDimensiones)
            {
                return "3D";
            }
            else if (this.Dimensiones == CantidadDimensiones.CuatroDimensiones)
            {
                return "4D";
            }
            return null;
        }

        /// <summary>
        /// Este método de instancia convierte un string legible a el tipo CantidadDimensiones asignando el valor a través de la propiedad Dimensiones,
        /// si no se puede convertir correctamente lanza una excepcion de tipo PeliculaMalCargadaException
        /// </summary>
        /// <param name="cantidadDimensiones">Parametro de tipo string que será convertido a CantDimensiones</param>
        private void StringToCantidadDimensiones(string cantidadDimensiones)
        {
            if (!(cantidadDimensiones is null))
            {
                if (cantidadDimensiones == "2D")
                {
                    this.Dimensiones = CantidadDimensiones.DosDimensiones;
                }
                else if (cantidadDimensiones == "3D")
                {
                    this.Dimensiones = CantidadDimensiones.TresDimensiones;
                }
                else if (cantidadDimensiones == "4D")
                {
                    this.Dimensiones = CantidadDimensiones.CuatroDimensiones;
                }
                else
                {
                    throw new PeliculaMalCargadaException("No se ingresaron dimensiones posibles");
                }
            }
            else
            {
                throw new PeliculaMalCargadaException("El atributo dimensiones fue nulo");
            }
        }
        /// <summary>
        /// Método de instancia que utiliza el método CantidadDimensionesToString para convertir CantDimensiones a string
        /// </summary>
        /// <returns>Retorna las dimensiones en tipo string</returns>
        public override string ToString()
        {
            return CantidadDimensionesToString();
        }

    }
}

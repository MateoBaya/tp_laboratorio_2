using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Excepcion específica para todos los errores que tengan que ver con la carga de peliculas, entradas y compradores
    /// </summary>
    public class PeliculaMalCargadaException : Exception
    {
        public PeliculaMalCargadaException(string message) : base(message)
        {
        }

        public PeliculaMalCargadaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

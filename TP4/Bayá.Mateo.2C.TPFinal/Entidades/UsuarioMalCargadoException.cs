using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioMalCargadoException : Exception
    {
        public UsuarioMalCargadoException(string message) : base(message)
        {
        }

        public UsuarioMalCargadoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

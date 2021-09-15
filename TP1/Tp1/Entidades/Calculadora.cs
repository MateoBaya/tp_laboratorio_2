using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if(operador != '+' && operador != '-' && operador != '*')
            {
                operador = '+';
            }
            return operador;
        }

        public static double Operador()
        {

        }
    }
}

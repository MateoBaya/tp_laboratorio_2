using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        Operando():this(0)
        {}
        Operando(double numero)
        {
            this.numero = numero;
        }
        Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        private static double ValidarOperando(string strNumero)
        {
            double retorno;
            if(!double.TryParse(strNumero,out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }
        private static bool EsBinario(string binario)
        {
            int contador=0;
            foreach(char caracter in binario)
            {
                if(caracter=='1'||caracter=='0')
                {
                    contador++;
                }
                else
                {
                    break;
                }
            }
            return (contador==binario.Length);
        }
        public string BinarioDecimal(string binario)
        {
            if(!EsBinario(binario))
            {
                return "Valor Invalido";
            }


        }
    }
}

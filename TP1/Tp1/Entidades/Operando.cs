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
        public Operando():this(0)
        {}
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
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
            if (!int.TryParse(binario,out _))
            {
                return false;
            }
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
        public static string BinarioDecimal(string binario)
        {
            if(!EsBinario(binario))
            {
                return "Valor Invalido";
            }
            int potencia=binario.Length-1;
            double acum=0;
            for (int i=0;i<binario.Length;i++)
            {
                if(binario[i]=='1')
                {
                    acum += Math.Pow(2,potencia);
                }
                potencia--;
            }
            return acum.ToString();
        }
        public static string DecimalBinario(string numero)
        {
            StringBuilder resultado = new StringBuilder();
            if(!double.TryParse(numero,out double num))
            {
                return "Valor Invalido";
            }
            while(num>=1)
            {
                num=Math.Abs((int)num);
                if (num%2==1)
                {
                    resultado.Insert(0,'1');
                }
                else if(num%2==0)
                {
                    resultado.Insert(0,'0');
                }
                num /= 2;
            }
            return resultado.ToString();
        }
        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }
        public static double operator +(Operando n1,Operando n2)
        {
            return (n1.numero + n2.numero);
        }
        public static double operator -(Operando n1,Operando n2)
        {
            return (n1.numero - n2.numero);
        }
        public static double operator *(Operando n1,Operando n2)
        {
            return (n1.numero * n2.numero);
        }
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0){return double.MinValue;}
            return (n1.numero / n2.numero);
        }
    }
}

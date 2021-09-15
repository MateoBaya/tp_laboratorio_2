using System;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0;
            string saludo = "1010";
            foreach (char caracter in saludo)
            {
                if (caracter == '1' || caracter == '0')
                {
                    contador++;
                }
                else
                {
                    break;
                }
            }
            if(contador==saludo.Length)
            { 
                Console.WriteLine(saludo.Length);
            }
        }
    }
}

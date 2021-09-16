using System;
using System.Text;
namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario="11010";
            int potencia = binario.Length - 1;
            double acum = 0;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    acum += Math.Pow(2, potencia);
                }
                potencia--;
            }
            Console.WriteLine(acum.ToString());
        }
    }
}

using System;
using System.Text;
namespace Tp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder resultado = new StringBuilder();
            if (!double.TryParse("", out double num))
            {
                Console.WriteLine("ERROR");
            }
            while (num >= 1)
            {
                num = Math.Abs((int)num);
                if (num % 2 == 1)
                {
                    resultado.Insert(0, '1');
                }
                else if (num % 2 == 0)
                {
                    resultado.Insert(0, '0');
                }
                num /= 2;
            }
            Console.WriteLine(resultado.ToString());
        }
    }
}

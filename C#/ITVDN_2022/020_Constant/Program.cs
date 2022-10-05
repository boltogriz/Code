using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double d = 3, l = Math.PI * d;
            Console.WriteLine($"pi = {pi}");
            Console.WriteLine($"Длина окружности с диаметров {d} см., равна {l} см.");
            {
                const int constant = 255;
                byte variable = constant;
                Console.WriteLine(variable);
            }
            {
                const double constant = 255.99;
                byte variable = (byte)constant;
                Console.WriteLine(variable);
            }

            Console.ReadKey();
        }
    }
}

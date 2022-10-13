using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Цикл n = {counter}");
                counter++;
            }

            Console.WriteLine($"После цикла n = {counter}");
            Console.ReadKey();
        }
    }
}

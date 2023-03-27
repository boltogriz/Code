using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, n = 2;
            try
            {
                a = a / (2 - n);
                Console.WriteLine(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("Оброботка исключения.");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

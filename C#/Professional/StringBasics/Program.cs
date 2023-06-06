using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var my = CultureInfo.CurrentCulture;
            var ua = new CultureInfo("uk-UA");

            var complex = new Complex(12.3456, 1234.5678);
            string stringCOmplex = complex.ToString("F", my);
            Console.WriteLine(stringCOmplex);

            stringCOmplex = complex.ToString("F2", ua);
            Console.WriteLine(stringCOmplex);

            Console.WriteLine("\nОтладочный вывод:\n{0:TEST}", complex);
            //
            Console.ReadKey();
        }
    }
}

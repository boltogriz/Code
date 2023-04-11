using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Program
    {
        //
        static void Main(string[] args)
        {
            dynamic variable = 1;
            Console.WriteLine(variable);
            variable = "Hello world";
            Console.WriteLine(variable);
            variable = DateTime.Now;
            Console.WriteLine(variable);
            Console.ReadLine();
        }
    }
}

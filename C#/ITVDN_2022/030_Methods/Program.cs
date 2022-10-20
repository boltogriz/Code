using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Methods
{
    internal class Program
    {
        static byte Increment(byte argument)
        {
            argument += 1;
            return argument;
        }
        static void Main(string[] args)
        {
            byte variable = 1;
            byte result = Increment(variable);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

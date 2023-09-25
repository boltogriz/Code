using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enumerable enumerable = new Enumerable();
            enumerable[0] = "Element A";
            enumerable[1] = "Element B";
            enumerable[2] = "Element C";
            enumerable[3] = "Element D";
            enumerable[4] = "Element E";
            enumerable[5] = "Element F";

            foreach (var item in enumerable) 
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}

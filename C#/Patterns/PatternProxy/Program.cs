using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHuman op = new Operator();
            IHuman surrogat = new Surrogat(op);
            surrogat.Request();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass partialClass1 = new PartialClass();
            partialClass1.Method1();
            partialClass1.Method2();
            Console.ReadKey();
        }
    }
}

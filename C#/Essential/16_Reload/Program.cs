using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Reload
{
    class MyClassA : Object
    { }
    class MyClassB: object
    { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Object instanceA = new MyClassA();
            object instanceB = new MyClassB();
            //
            Console.ReadKey();
        }
    }
}

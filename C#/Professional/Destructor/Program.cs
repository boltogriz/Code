using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Destructor
{
    class SomeClass
    {
        ~ SomeClass() 
        {
            Console.WriteLine("SomeClass thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("SomeClass_Destructor");
            Console.ReadKey();
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: {0}", Thread.CurrentThread.ManagedThreadId);
            SomeClass itamce = new SomeClass();
            GC.Collect();
            Console.ReadKey();

        }
    }
}

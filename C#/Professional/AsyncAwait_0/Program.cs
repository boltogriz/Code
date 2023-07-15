using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            MyClass myClass = new MyClass();
            myClass.OperationAsync();

            Console.ReadKey();
        }
    }
}

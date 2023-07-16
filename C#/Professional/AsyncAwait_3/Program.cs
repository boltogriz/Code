using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.OperationAsync();
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadKey();
        }
    }
}

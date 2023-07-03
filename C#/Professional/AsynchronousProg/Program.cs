using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Action myDelegate = new Action(Method);
            IAsyncResult asyncResult = myDelegate.BeginInvoke(null, null);

            for (int i = 0; i < 80; i++) 
            { 
                Thread.Sleep(1000);
                Console.Write(" 1 ");
            }
            myDelegate.EndInvoke(asyncResult);
        }

        private static void Method()
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(1000);
                Console.Write(" 2 ");
            }
        }
    }
}

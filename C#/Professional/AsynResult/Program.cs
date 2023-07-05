using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);
            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);
            while(!asyncResult.IsCompleted) 
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            //int result = myDelegate.EndInvoke(asyncResult);
            //Console.WriteLine("Результ = " + result);

            asyncResult.AsyncWaitHandle.WaitOne();
            Console.WriteLine("Thread main");
            int result = myDelegate.EndInvoke(asyncResult);
            Console.WriteLine("Результ = " + result);
            Console.ReadLine();
        }

        private static int Sum(int arg1, int arg2)
        {
            Console.WriteLine("d");
            Thread.Sleep(5000);
            return arg1 + arg2;
        }
    }
}

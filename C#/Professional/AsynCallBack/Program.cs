using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynCallBack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thred {0}", Thread.CurrentThread.Name);

            var func = new Func<int, int, int>(Sum);
            func.BeginInvoke(1, 2, CallBack, func);
            Console.ReadKey();
        }

        private static void CallBack(IAsyncResult ar)
        {
            Func<int, int, int> caller = (Func<int, int, int>)ar.AsyncState;
            Console.WriteLine("Thread CallBack {0}", caller.EndInvoke(ar));
        }

        private static int Sum(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}

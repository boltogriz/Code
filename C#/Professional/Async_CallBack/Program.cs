using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_CallBack
{
    internal class Program
    {
        static void CallBack(IAsyncResult asyncResult)
        {
            Console.WriteLine("Callbak: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Информация связанная с асихронной операцией - " + asyncResult.AsyncState);
        }
        static void Method()
        {
            Console.WriteLine("\n Вторичный поток: {0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }
            Console.WriteLine("Вторичный поток завершен");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первичный поток: {0}", Thread.CurrentThread.ManagedThreadId);

            Action action = new Action(Method);
            Action action2 = new Action(Method);
            AsyncCallback callback = new AsyncCallback(CallBack);

            action.BeginInvoke(callback, "Hello world!");


            Console.ReadKey();
        }
    }
}

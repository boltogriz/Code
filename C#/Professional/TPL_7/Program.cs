using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_7
{
    internal class Program
    {
        static void MyTask(object arg)
        {
            CancellationToken token = (CancellationToken)arg;
          
            token.ThrowIfCancellationRequested();

            Console.WriteLine("MyTask starts");

            for (int i = 0; i < 80; i++) 
            { 
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("\nToken Cancel");
                    token.ThrowIfCancellationRequested();
                }

                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine("MyTask end");
        }
        static void Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken cancellation = tokenSource.Token;
            Task task = new Task(MyTask, cancellation);

            task.Start();

            Thread.Sleep(200);

            try 
            { 

                tokenSource.Cancel();
                task.Wait();

            }
            catch(AggregateException ex) 
            { 
                if (task.IsCanceled)
                    Console.WriteLine("Token true, Second thread cancelled");
                Console.WriteLine(ex.StackTrace);
            }


            Console.WriteLine("Main end");

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_5
{
    struct Context
    {
        public int a;
        public int b;

    }
    internal class Program
    {
        static int Sum(object arg)
        {
            int a = ((Context)arg).a;
            int b = ((Context)arg).b;

            Thread.Sleep(2000);

            return a + b;
        }
        static void Doing()
        {
            for(int i = 0; i < 100; i++) 
            {
                Console.Write(".");
                Thread.Sleep(25);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Context context;
            context.a = 2;
            context.b = 3;

            Task<int> task;

            task = new Task<int>(Sum, context);
            task.Start();

            Console.WriteLine(task.Result);

            Console.ReadKey();
        }


    }
}

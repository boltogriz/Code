using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Reflection;

namespace TPL_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");

            //TaskScheduler scheduler = TaskScheduler.Default;
            TaskScheduler scheduler = new DelayTaskScheduler();
            TaskFactory factory = new TaskFactory(scheduler);
            Task task = factory.StartNew(MyTask);

            TaskAwaiter awaiter = task.GetAwaiter();

            while(!awaiter.IsCompleted) 
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.ReadKey();
        }

        private static void MyTask()
        {
            Console.WriteLine("MyTask");
            for(int i = 0; i < 10; i++) 
            {
                Thread.Sleep(100);
                Console.Write("+");
            }
        }
    }
}

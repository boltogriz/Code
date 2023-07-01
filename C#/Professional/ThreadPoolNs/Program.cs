using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolNs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Report();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));
            Report();

            ThreadPool.QueueUserWorkItem(Task2);
            Report();

            Thread.Sleep(3000);
            Console.WriteLine("End");

            Console.ReadLine();
        }

        private static void Task2(object state)
        {
            Thread.CurrentThread.Name = "1";
            Console.WriteLine("Starting thread {0}\n", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} has end work", Thread.CurrentThread.Name);
        }

        private static void Task1(object state)
        {
            Thread.CurrentThread.Name = "2";
            Console.WriteLine("Starting thread {0}\n", Thread.CurrentThread.Name);
            Thread.Sleep(500);
            Console.WriteLine("Thread {0} has end work", Thread.CurrentThread.Name);
        }

        private static void Report()
        {
            Thread.Sleep(200);
            int availableWorkThread, availableIOThreads, maxWorkThreads, maxIOThreads;
            ThreadPool.GetAvailableThreads(out availableWorkThread, out availableIOThreads);
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);
            Console.WriteLine("Available worked thread pool: {0} of {1}", availableWorkThread, maxWorkThreads);
            Console.WriteLine("Available input-output threads: {0} of {1}", availableIOThreads, maxIOThreads);
        }
    }
}

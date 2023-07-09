using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_1
{
    internal class Program
    {
        static void MyTask()
        {
            Console.WriteLine("MyTask: CurrentId {0} - ManagedThreadId {1}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("MyTask: CurrentId {0} end - ManagedThreadId {1} end", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main: Task.CurrentId = {0}", Task.CurrentId == null ? "null" : Task.CurrentId.ToString());

            Task task1 = new Task(MyTask); 
            Task task2 = new Task(MyTask);

            task1.Start();
            task2.Start();

            Console.WriteLine("Id task1: " + task1.Id);
            Console.WriteLine("Id task2: " + task2.Id);

            Console.ReadKey();
        }
    }
}

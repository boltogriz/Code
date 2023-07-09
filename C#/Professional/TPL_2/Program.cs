using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_2
{
    internal class Program
    {
        static void MyTask()
        {
            Thread.Sleep(5000);
        }
        static void Main(string[] args)
        {
            Task task = new Task(MyTask);
            Console.WriteLine(task.Status);

            task.Start();
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Thread.Sleep(1000);
            Console.WriteLine(task.Status);

            Console.ReadKey();
        }
    }
}

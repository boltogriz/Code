using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TLP_4
{
    internal class Program
    {
        static void MyTask()
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(25);
                Console.Write(".");
            }
        }
        static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(MyTask);

            //TaskFactory factory = new TaskFactory();
            //Task task = factory.StartNew(MyTask);
            task.Wait();
            task.Dispose();

            Console.ReadKey();
        }
    }
}

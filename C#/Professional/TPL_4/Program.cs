using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_4
{
    internal class Program
    {
        static void MyTask()
        {
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("+");
            }
        }
        static void ContinuationTask(Task task) 
        { 
            for (int count =0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("-");
            }
        }
        static void Main(string[] args)
        {
            Action action = new Action(MyTask);
            Task task = new Task(action);

            Action<Task> continuation = new Action<Task>(ContinuationTask);
            Task taskContinuation = task.ContinueWith(continuation);

            task.Start();

            Console.ReadKey();
        }
    }
}

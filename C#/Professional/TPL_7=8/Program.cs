using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TPL_8
{
    internal class Program
    {
        static int MyTask()
        {
            byte result = 255;
            checked
            {
                result += 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(MyTask);
            Action<Task<int>> continuation;

            continuation = t => Console.WriteLine("Result: " + task.Result);
            task.ContinueWith(continuation, TaskContinuationOptions.OnlyOnRanToCompletion);

            continuation = t => Console.WriteLine("Inter Exception: " + task.Exception.InnerException);
            task.ContinueWith(continuation, TaskContinuationOptions.OnlyOnFaulted);

            task.Start();

            Console.ReadKey();
        }
    }
}

using System.Threading.Tasks;
using System.Threading;
using System;

namespace AsyncAwait_1
{
    internal class MyClass
    {
        public MyClass()
        {
        }
        public void Operation()
        {
            Console.WriteLine("ThreadID: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Begin");
            Thread.Sleep(1000);
            Console.WriteLine("End");
        }
        public async void OperationAsync()
        {
            Console.WriteLine("(Part 1) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            Task task = new Task(Operation);
            task.Start();
            await task;
            Console.WriteLine("(Part 2) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
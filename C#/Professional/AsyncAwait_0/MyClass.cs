using System.Threading.Tasks;
using System.Threading;
using System;

namespace AsyncAwait_0
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
            Task task = new Task(Operation);
            task.Start();
            await task;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_2
{
    internal class MyClass
    {
        int Operation()
        {
            Console.WriteLine("Operatin ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            return 2 + 2;
        }

        public void OperationAsync()
        {
            Task<int> task = Task<int>.Factory.StartNew(Operation);
            TaskAwaiter<int> await = task.GetAwaiter();
            Action continuation = () => Console.WriteLine("Result {0}", await.GetResult());
            await.OnCompleted(continuation);
        }
    }
}

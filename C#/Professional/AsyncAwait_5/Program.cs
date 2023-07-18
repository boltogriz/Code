using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_5
{
    class MyClass
    {
        int Operation()
        {
            Thread.Sleep(1000);
            return 2 + 2;
        }

        public async Task<int> OperationAsync()
        {
            return await Task<int>.Factory.StartNew(Operation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Task<int> task = myClass.OperationAsync();
            task.ContinueWith(t => { Console.WriteLine("Result: " + t.Result); });
            Console.ReadKey();
        }
    }
}

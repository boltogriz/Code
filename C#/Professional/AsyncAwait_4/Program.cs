using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_4
{
    class MyClass
    {
        public void Operation()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Основная задача");
        }
        public async Task OperationAsync()
        {
            await Task.Factory.StartNew(Operation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Task task = my.OperationAsync();
            task.ContinueWith(t => { Console.WriteLine("\nПродолжение задачи"); });
            Console.ReadLine();
        }
    }
}

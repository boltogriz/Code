using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_6
{
    class MyClass
    {
        double Operation(object argument)
        {
            Thread.Sleep(2000);
            return (double)argument * (double)argument;
        }
        public async Task<double> OperationAsync(double argument)
        {
            return await Task<double>.Factory.StartNew(Operation, argument);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Task<double> task = myClass.OperationAsync(5);
            task.ContinueWith(t => { Console.WriteLine("Result: " + t.Result); });
            Console.ReadKey();
        }
    }
}

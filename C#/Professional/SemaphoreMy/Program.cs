using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreMy
{
    internal class Program
    {
        static Semaphore pool;
        static void Function(object number)
        {
            pool.WaitOne();
            Console.WriteLine("Поток {0} занял слот семафора.", number);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} -----> освободил слот.", number);
            pool.Release();
        }
        static void Main(string[] args)
        {
            pool = new Semaphore(5, 10, "MySemafore");
            for(int i = 1; i <= 40; i++) 
            { 
                new Thread(Function).Start(i);
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
    }
}

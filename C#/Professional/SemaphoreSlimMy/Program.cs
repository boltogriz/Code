using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreSlimMy
{
    internal class Program
    {
        static SemaphoreSlim pool;
        static void Function(object number)
        {
            pool.Wait();
            Console.WriteLine("Поток {0} занял слот семафора.", number);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} -----> освободил слот.", number);
            pool.Release();
        }
        static void Main(string[] args)
        {
            pool = new SemaphoreSlim(2, 4);
            for (int i = 0;i <= 8; i++) 
            { 
                new Thread(Function).Start(i);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutexSample
{
    internal class Program
    {
        static Mutex mutex = new Mutex(false, "MyMutex");
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Function);
                threads[i].Name = i.ToString();
                threads[i].Start();
            }
            Console.ReadLine();
        }

        private static void Function()
        {
            mutex.WaitOne();
            Console.WriteLine("Поток {0} Зашел в защищенную область.", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} покинул защищенную область.\n", Thread.CurrentThread.Name);
            mutex.ReleaseMutex();
        }
    }
}

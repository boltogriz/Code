using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterLocked
{
    internal class Program
    {
        static long counter;
        //static object block = new object();
        static void Procedure()
        {
            for (int i = 0; i < 1000000; i++) 
            {
                Interlocked.Increment(ref counter);
                //lock (block) 
                //{ 
                //    counter++;
                //}
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ожидаемое значение счетчика = 10000000");
            Thread[] threads = new Thread[10];
            for (int i=0; i < threads.Length; i++) 
            {
                (threads[i] = new Thread(Procedure)).Start();
            }
            for (int i=0; i < threads.Length;i++) 
            {
                threads[i].Join();
            }
            Console.WriteLine("Реальное значение счетчика  = {0}", counter);

            Console.ReadKey();
        }
    }
}

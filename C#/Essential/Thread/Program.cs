using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void WriteSecond()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Thread ID {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();
            WriteSecond();
            Console.ReadLine();
        }
    }
}

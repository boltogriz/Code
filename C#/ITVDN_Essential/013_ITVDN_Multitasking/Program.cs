using System;
using System.Threading;

namespace _013_ITVDN_Multitasking
{
    internal class Program
    {
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new String(' ', 10) + "Secondary");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();
            while (true)
            {
                Console.WriteLine("Primary");
            }
        }
    }
}
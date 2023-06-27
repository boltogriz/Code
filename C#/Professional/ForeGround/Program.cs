using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForeGround
{
    internal class Program
    {
        static void Procedure()
        {
            for (int i = 0; i < 1000; i++) 
            { 
                Thread.Sleep(10);
                Console.Write(".");
            }
            Console.WriteLine("\nЗавершение вторичного потока.");
        }
        static void Main(string[] args)
        {
            var thread = new Thread(Procedure);
            thread.IsBackground = false;
            thread.Start();
            Thread.Sleep(500);
            Console.WriteLine("Завершение главного потока");
            //Console.ReadKey();
        }
    }
}

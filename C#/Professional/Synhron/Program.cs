using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synhron
{

 
    internal class Program
    {
        static volatile bool stop;
        static void Main(string[] args)
        {

            Thread threa = new Thread(Function);
            threa.Start();
            Thread.Sleep(2000);

            stop = true;
            Console.WriteLine("Main: ожидание завершения вторичного потока.");
            threa.Join();
            Console.ReadKey();
               
        }

        private static void Function()
        {
            int x = 0;
            while (!stop) 
            {
                x++;
            }
            Console.WriteLine("Function: поток остановлен при x = {0}.", x);
        }
    }
}

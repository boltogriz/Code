using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSampleMul
{
    internal class Program
    {
        //[ThreadStatic]
        public static int counter;
        public static void Method()
        {
            if (counter < 100)
            {
                counter++;
                Console.WriteLine(counter + " - СТАРТ ---- " + Thread.CurrentThread.GetHashCode());
                Thread thread = new Thread(Method);
                thread.Start();
                thread.Join();
            }
            Console.WriteLine("Поток {0} завершился. ", Thread.CurrentThread.GetHashCode());
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(Method);
            thread.Start();
            thread.Join();
            Console.WriteLine("Первичный поток завершил работу. ");
            Console.ReadLine();
        }
    }
}

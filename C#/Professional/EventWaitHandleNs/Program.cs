using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventWaitHandleNs
{
    internal class Program
    {
        static AutoResetEvent auto = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread thread = new Thread(Function);
            thread.Start();
            Thread.Sleep(1000);

            Console.WriteLine("Press any key for switching to AutoReset");
            Console.ReadKey();
            auto.Set();

            Console.WriteLine("Press any key for switching to AutoReset");
            Console.ReadKey();
            auto.Set();

            Console.ReadLine();
        }

        private static void Function()
        {
            Console.WriteLine("Red light");
            auto.WaitOne();

            Console.WriteLine("Yellow light");
            auto.WaitOne();

            Console.WriteLine("Green light");
        }
    }
}

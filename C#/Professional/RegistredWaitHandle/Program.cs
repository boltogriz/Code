using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RegistredWaitHandle
{
    internal class Program
    {
        static void Function(object state, bool timedOut)
        {
            Console.WriteLine("Signal");
        }
        static void Main(string[] args)
        {
            AutoResetEvent auto = new AutoResetEvent(false);
            WaitOrTimerCallback callback = new WaitOrTimerCallback(Function);
            RegisteredWaitHandle handle = ThreadPool.RegisterWaitForSingleObject(auto, callback, null, 1000, false);

            Console.WriteLine("S - сигнал, Q - выход");
            while (true)
            {
                string operation = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                if (operation == "S")
                {
                    auto.Set();
                }
                if (operation == "Q")
                {
                    handle.Unregister(auto);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

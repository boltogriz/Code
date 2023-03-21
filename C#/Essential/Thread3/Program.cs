using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread3
{
    internal class Program
    {
        static void Method()
        {
            while (true)
            {
                Console.WriteLine("Secondary");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Method);
            Thread thread = new Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primery");
                Thread.Sleep(500);
            }
        }
    }
}

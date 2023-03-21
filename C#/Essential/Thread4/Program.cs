using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading;

namespace Thread4
{
    class MyClass
    {
        object block = new object();
        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Поток # {0}: шаг {1}", hash, i);
                    Thread.Sleep(100);
                }
                Console.WriteLine(new String('-', 20));
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            for(int i = 0; i < 3; i++)
            {

                new Thread(instance.Method).Start();
                //instance.Method();
            }
            Thread.Sleep(500);
            Console.ReadKey();
        }
    }
}

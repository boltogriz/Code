using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread5
{
    class MyRandom
    {
       public int myRandom = new Random().Next();
    }
    class MyClass
    {
        object block = new object();
        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();
            int x = new Random().Next();
            Monitor.Enter(block);
            Thread.Sleep(100);
            Console.WriteLine(new String('-', 20));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток # {0}: шаг {1}", hash, i);
                Console.WriteLine(x);
                Thread.Sleep(100);
            }
            Console.WriteLine(new String('-', 20));
            Monitor.Exit(block);
        }
    }



    internal class Program
    {
        static object block2 = new object();
        static void Method2(object instance)
        {
            int hash = Thread.CurrentThread.GetHashCode();
            MyRandom myRandom = (MyRandom)instance;
            int x = myRandom.myRandom;
            lock (block2)
            {
                Console.WriteLine(new String('+', 20));
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("+ Поток # {0}: шаг {1}", hash, i);
                    Console.WriteLine("+"+x);
                    //Thread.Sleep(100);
                }
                Console.WriteLine(new String('+', 20));
            }

        }

        static void Main(string[] args)
        {
            ParameterizedThreadStart prS = new ParameterizedThreadStart(Method2);
            MyClass instance = new MyClass();
            for (int i = 0; i < 3; i++)
            {

                object x = new MyRandom();
                new Thread(prS).Start(new MyRandom());
                //instance.method();
            }
            for (int i = 0; i < 3; i++)
            {

                new Thread(instance.Method).Start();
                //instance.Method();
            }

            Thread.Sleep(500);
            Console.ReadKey();
        }
    }
}

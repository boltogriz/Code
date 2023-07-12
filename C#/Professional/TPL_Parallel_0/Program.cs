using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Parallel_0
{
    internal class Program
    {
        static int[] myArray = new int[100];
        static void MyTask1()
        {
            Console.WriteLine("MyTask1");
            for (int i = 0; i < 10; i++) 
            { 
                Thread.Sleep(10);
                Console.Write("+");
            }
            Console.WriteLine("MyTask1 end");
        }
        static void MyTask2()
        {
            Console.WriteLine("MyTask2");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");
            }
            Console.WriteLine("MyTask2 end");
        }

        static void MyTask3(int y)
        {
            myArray[y] = y;
            Console.Write(y+" ");
        }

        static void ParallelFor(Action<int> action, int i)
        {
            Parallel.For(0, i, action);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main");

            int[] data = new int[100];

            Action<int> action = MyTask3;

            ParallelFor(action, myArray.Length);

            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 1;

            Console.WriteLine("Кол логических ядер CPU: " + Environment.ProcessorCount);

            Console.ReadKey();

            Parallel.Invoke(parallelOptions, MyTask1, MyTask2);

            parallelOptions.MaxDegreeOfParallelism = Environment.ProcessorCount > 2 ? Environment.ProcessorCount - 1 : 1;
            Parallel.Invoke(parallelOptions, MyTask1, MyTask2, MyTask2, MyTask1);

            foreach(int i in myArray)
                Console.Write(i);

            PullArray pullArray = new PullArray();

            Parallel.For(0, pullArray.myArray.Length, pullArray.MyTask);

            foreach(int i in pullArray.myArray) 
                Console.Write(i);

            Parallel.Invoke(parallelOptions, pullArray.MyTask1);

            Parallel.For(0, data.Length, SetArray);

            void SetArray(int i)
            {
                data[i] = i * i * i / 123;
            }

            foreach(int i in data)
                Console.Write(i + " ");

            Parallel.For(0, data.Length, i => data[i] = i);

            foreach (int i in data)
                Console.Write("_" + i + "_ ");

            Console.ReadLine();
        }
    }
}

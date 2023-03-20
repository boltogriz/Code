using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads3
{
    internal class Case1
    {
        public string name;
        public int number;
    }
    internal class Program
    {
        static void WriteSecond(object argument)
        {
            Case1 case1 = (Case1)argument;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(case1.name + " - " + case1.number);
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            Case1 case1 = new Case1();
            case1.name = "Сундук";
            case1.number = 1;
            thread.Start(case1);
            Thread.Sleep(500);
            Console.ReadKey();
        }
    }
}

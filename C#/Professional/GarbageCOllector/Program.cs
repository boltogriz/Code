using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GarbageCOllector
{
    internal class Program
    {
        static void AuxiliaryMethod()
        {
            OtherObject[] objects = new OtherObject[1000];
            for (int i = 0; i < objects.Length; i++) 
            {
                objects[i] = new OtherObject();
                Thread.Sleep(5);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Система поддерживает {0} поколения.", (GC.MaxGeneration + 1));
            Console.WriteLine(new string('-', 40));
            NormalObject normalObject = new NormalObject();

            new Thread(AuxiliaryMethod).Start();

            for (int i = 0;i < 30;i++) 
            {
                Console.Write("Поколение "+GC.GetGeneration(normalObject));
                Console.WriteLine(" | Размер кучи "+GC.GetTotalMemory(false) / 1024);
                Thread.Sleep(100);
            }
            Console.WriteLine(new string ('-', 40));
            Console.WriteLine(GC.CollectionCount(0));
            Console.WriteLine(GC.CollectionCount(1));
            Console.WriteLine(GC.CollectionCount(2));
            Console.ReadLine();
        }
    }
}

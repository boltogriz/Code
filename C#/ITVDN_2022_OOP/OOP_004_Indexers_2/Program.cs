using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_004_Indexers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance[0, 0] = 777;
            for (int i = 0; i < instance.GetLength(0); i++)
            {
                for (int j = 0; j <instance.GetLength(1); j++)
                {
                Console.WriteLine(instance[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}

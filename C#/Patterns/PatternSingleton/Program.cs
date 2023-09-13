using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();
    

            instance1.SingletonOperation();

            Console.WriteLine(instance1.GetSingletonData());
            Console.WriteLine(instance2.GetSingletonData());
            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrivedClass instance = new DrivedClass();
            Console.WriteLine(instance.publicField);
            instance.Show();
            Console.WriteLine(new string('-', 20));
            DrivedClass instance2 = new DrivedClass(1, 2);
            Console.WriteLine(instance2.baseNumber);
            Console.WriteLine(instance2.drivedField);
            DrivedClass instance3 = new DrivedClass(3);
            Console.WriteLine(instance3.baseNumber);
            Console.ReadKey();
        }
    }
}

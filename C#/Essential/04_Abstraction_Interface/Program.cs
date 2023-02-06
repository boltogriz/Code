using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.Method();
            AbstractClass1 instance1 = new ConcreteClassB();
            instance1.Method();
            instance1.Operation();
            Console.WriteLine(new string('-', 20));
            AbstractBaseClass instance2 = new DerivedClass();
            instance2.AbstractMethod();
            instance2.VirtualMethod();
            instance2.SimpleMethod();
            Console.ReadKey();
        }
    }
}

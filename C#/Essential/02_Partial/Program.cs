using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Partial
{
    class MyClass
    {
        MyClass my = null;

        private void Method()
        {
            Console.WriteLine("Hello");
        }
        public void CallMethod()
        {
            my = new MyClass();
            my.Method();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass partialClass1 = new PartialClass();
            partialClass1.Method1();
            partialClass1.Method2();
            Console.WriteLine(new String('-', 20));
            MyClass my = new MyClass();
            my.CallMethod();
            Console.WriteLine(new String('-', 20));
            Class4 class4 = new Class4();
            Class3 class3 = new Class3();
            class3.Name = "По ком звонит колокол";
            class4.Book = class3;
            Console.WriteLine(class4.Book.Name);
            Console.WriteLine(new String('-', 20));
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();
            Console.ReadKey();
        }
    }
}

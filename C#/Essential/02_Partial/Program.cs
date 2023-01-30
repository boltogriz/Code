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
            Console.ReadKey();
        }
    }
}

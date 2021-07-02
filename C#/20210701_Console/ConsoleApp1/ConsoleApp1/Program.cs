using System;

namespace ConsoleApp1
{
    class MyClass
    {
        public int field;
        public void Method() 
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.field = 1;
            a.Method();

            MyClass b = new MyClass();
            b.field = 2;
            b.Method();
        }
    }
}

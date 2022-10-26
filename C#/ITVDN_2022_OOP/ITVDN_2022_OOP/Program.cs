using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_2022_OOP
{
    internal class Program
    {
        class MyClass
        {
            public int field;
            public void Method()
            { 
                Console.WriteLine(field);
            }
        }
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.field = 1;
            a.Method();
            Console.WriteLine(a.field);
            MyClass b = new MyClass();
            b.field = 2;
            b.Method();
            Console.WriteLine(b.field);
            Console.ReadKey();
        }
    }
}

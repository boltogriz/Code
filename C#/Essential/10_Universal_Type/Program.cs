using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Universal_Type
{
     class MyClass<T>
    {
        public T field;
        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            myClass.Method();
            MyClass<string> myClass1 = new MyClass<string>();
            myClass1.field = "filed";
            myClass1.Method();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Universal_Type
{
    delegate R MyDelegate<T, R>(T t);
     class MyClass<T>
    {
        public T field;
        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
        public T2 Method2<T2>(T2 field)
        {
            T2 filed1 = field;
            Console.WriteLine(filed1.GetType() + " Method2<T2>");
            return filed1;
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
            myClass.Method2<int>(32);
            MyClass<int> myClass2 = myClass;
            MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(myClass2.Method2<int>);
            int i = myDelegate(33);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}

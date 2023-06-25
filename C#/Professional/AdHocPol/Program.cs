using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdHocPol
{
    public class Class1 { public void Method() { Console.WriteLine("Class 1"); } }
    public class Class2 { public void Method() { Console.WriteLine("Class 2"); } public void Method2() { Console.WriteLine("Class 2"); } }
    public class Class3 { public void Method() { Console.WriteLine("Class 3"); } }
    interface IInterface { void Method(); }
    class MyClass1 : Class1, IInterface { }
    class MyClass2 : Class2, IInterface { }
    class MyClass3 : Class3, IInterface { }
    internal class Program
    {
        static void Main(string[] args)
        {
            IInterface[] array = { new MyClass1(), new MyClass2(), new MyClass3() };
            foreach (IInterface item in array)
            {
                item.Method();
            }
            IInterface inst1 = new MyClass1();
            inst1.Method();
            inst1 = new MyClass2();
            inst1.Method();

            Console.ReadKey();
        }
    }
}

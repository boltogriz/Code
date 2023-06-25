using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdHocPolimorfizm
{
    public class Class1 { public void Method() { Console.WriteLine("Class 1"); } }
    public class Class2 { public void Method() { Console.WriteLine("Class 2"); } }
    public class Class3 { public void Method() { Console.WriteLine("Class 3"); } }
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic[] array = { new Class1(), new Class2(), new Class3() };
            foreach (dynamic item in array) 
            { 
                item.Method();
            }

            object inst1 = new Class1();
            inst1 = new Class2();
            Console.ReadKey();
        }
    }
}

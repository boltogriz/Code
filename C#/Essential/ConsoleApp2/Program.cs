extern alias L1;
extern alias L2;
using System;
using ClassLibrary1;
using ClassLibrary2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            class1.Method();
            Class2 class2 = new Class2();
            class2.Method();
            L1.Library.Class1 class11 = new L1.Library.Class1();
            L2.Library.Class1 class12 = new L2.Library.Class1();
            class11.Method();
            class12.Method();
            Console.ReadLine();
        }
    }
}

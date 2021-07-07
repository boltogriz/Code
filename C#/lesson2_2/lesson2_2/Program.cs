using System;
using anotherspace;

namespace lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            anotherspace.MyClass MyObject = 
                new anotherspace.MyClass();
            MyObject.a = 1;
            MyObject.Console();
            MyObject.Show(args);
        }
    }
}

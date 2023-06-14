using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest_1
{
    class MyClass
    {

    }
    internal class Program
    {

        static void Main(string[] args)
        
        {
            MyClass myClass = new MyClass();
            Type type;

            type = myClass.GetType();
            Console.WriteLine(type);

            type = Type.GetType("TypeTest_1.MyClass");
            Console.WriteLine(type);

            type = typeof(MyClass);
            Console.WriteLine(type);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyClassSpae;


namespace _18_SpaceName
{
    using MyClass1 = MyClassSpae.MyClass;
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            System.Console.WriteLine("Hello world");
            System.Console.ReadKey();
            MyClass1 myClass = new MyClass1();
        }
    }
}

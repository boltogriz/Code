using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_002
{
    [My("XXXX", "YYYY")]
    class BaseClass
    {

    }
    [My("First", "31/01/2008")]
    [My("Second", "31/01/2008")]
    class MyClass : BaseClass { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            object[] atributes = type.GetCustomAttributes(typeof(MyAttribute), true);
            foreach(MyAttribute attribute in atributes) 
            {
                Console.WriteLine(attribute.Text + " " + attribute.Data);
                attribute.Method();
            }
            Console.ReadKey();
        }
    }
}

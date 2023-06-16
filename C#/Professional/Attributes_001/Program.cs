using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Attributes_001
{
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [My("2/31/2007", Number = 2)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.Method();

            Type type = typeof(MyClass);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (MyAttribute attribute in attributes) 
            {
                Console.WriteLine("{0} - {1}", attribute.Date, attribute.Number);
            }


            MethodInfo typeMethod = type.GetMethod("Method", BindingFlags.Public | BindingFlags.Static);
            object[] attributesMethod = typeMethod.GetCustomAttributes(typeof(MyAttribute),false);
            foreach (MyAttribute attribute in attributesMethod)
            {
                Console.WriteLine("{0} - {1}", attribute.Date, attribute.Number);
            }

            Console.ReadLine();
        }
    }
}

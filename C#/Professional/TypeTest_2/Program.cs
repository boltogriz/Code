using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest_2
{
    internal class Program
    {
        
        static void ListVariosStats(Class1 c1)
        {
            Type t = c1.GetType();
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
        }
        static void ListMethod(Class1 c1) 
        { 
            Type t = typeof(Class1);
            MethodInfo[] mi = t.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (MethodInfo m2 in mi) 
            {
                Console.WriteLine(m2.Name);
            }
            MethodInfo methodC = t.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            methodC.Invoke(c1, new object[] { "Hello", "world1"});
        }

        static void Main(string[] args)
        {
            LibDll.Show();
            Class1 instance = new Class1();

            ListVariosStats(instance);
            Console.WriteLine();
            ListMethod(instance);


            Console.ReadKey();
        }
    }
}

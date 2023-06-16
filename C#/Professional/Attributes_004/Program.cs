using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            object[] attributes = assembly.GetCustomAttributes(false);
            foreach (Attribute attribute in attributes) 
            {
                Console.WriteLine(attribute.GetType().Name);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
        public static void ExtensionMethod(this int value)
        {
            Console.WriteLine(value);
        }
    }
}

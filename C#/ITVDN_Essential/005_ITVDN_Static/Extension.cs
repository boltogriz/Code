using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ITVDN_Static
{
    static class Extension
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
        public static void ExtensionMethod(this int value, int vale2)
        {
            Console.WriteLine(value + vale2);
        }
    }
}

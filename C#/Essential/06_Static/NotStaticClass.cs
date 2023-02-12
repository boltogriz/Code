using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    internal class NotStaticClass
    {
        public static int field;
        public void Method()
        {
            Console.WriteLine("Static field {0}", field);
        }
        public NotStaticClass()
        {
            field = 0;
        }
        public static void MethodStatic()
        {
            Console.WriteLine("Static Method()");
        }
    }
}

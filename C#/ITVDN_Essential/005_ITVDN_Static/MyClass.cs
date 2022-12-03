using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ITVDN_Static
{
    static class MyClass
    {
        public static int field;
        public static int Field
        {
            get { return field; }
            set { field = value; }
        }
        public static void Method(this string value)
        {
            Console.WriteLine(value);
        }
        static MyClass()
        {
            field = 0;
        }
        public static MyClass2 CreadClass()
        {
            return new MyClass2();
        }
    }
}

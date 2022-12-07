using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_ITVDN_Delegate
{
    public class MyClass
    {
        public string Method(string text)
        {
            string arg = "MyClass.Method() ";
            Console.WriteLine(arg + text);
            return arg + text;
        }
        public string Method2(string text)
        {
            string arg = "MyClass.Method2() ";
            Console.WriteLine(arg + text);
            return arg + text;
        }
    }
}

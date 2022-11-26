using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ITVDN_Essential
{
    partial class PartialClass
    {
        PartialClass my;
        public readonly string field = "hello";
        private void Method()
        {
            Console.WriteLine("Method");
        }
        public PartialClass()
        {
            field += " world";
        }
        partial void PartialMethod()
        {
            Console.WriteLine("PartialMethod");
            Console.WriteLine(field);
        }
        public void MethodFromPart2()
        {
            my = new PartialClass();
            my.Method();
            PartialMethod();
            MyMethod();
        }
    }
}

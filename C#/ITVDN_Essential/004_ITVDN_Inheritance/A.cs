using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ITVDN_Inheritance
{
    internal class A
    {
        public int field1;
        public int baseNumber;
        public virtual void Method()
        {
            Console.WriteLine("class a filed1 = {0}", field1);
            Console.WriteLine("Method A");
        }
        public virtual void MethodASeald()
        {
            Console.WriteLine("sealed");
        }
        public A()
        {
            Console.WriteLine("конструктор A по умолчанию");
        }
        public A(int baseNumber)
        {
            this.baseNumber = baseNumber;
            Console.WriteLine("A");
        }
    }
}

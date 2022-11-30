using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_ITVDN_Inheritance
{
    internal class B : A
    {
        public int field2;
        public B()
        {
            Console.WriteLine("конструктор B");
            field1 = 1;
        }
        public B(int baseNumber1, int baseNumber2) 
            : base(baseNumber1)
        {
            this.baseNumber = baseNumber1 + baseNumber2;

        }
        public void Show()
        {
            Console.WriteLine("Class B field 1 from Class a = {0}", field1);
            Console.WriteLine("baseNumber = {0}", this.baseNumber);
        }
        public override void Method()
        {
            base.Method();
            Console.WriteLine("Method B");
        }
        public sealed override void MethodASeald()
        {
            base.MethodASeald();
            Console.WriteLine("B");
        }
    }
}

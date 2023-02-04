using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class DrivedClass : BaseClass, ICloneable
    {
        public int drivedField;
        public int field4;
        public int field5;
        // конструктор
        public DrivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
        public DrivedClass(int number1, int number2)
            : base(number1)
        {
            drivedField = number2;
        }
        public DrivedClass(int number2) 
        {
            drivedField = number2;
        }
        public void NewShow()
        {
            Console.WriteLine("DrivedClass.NewShow()");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Method()
        {
            Console.WriteLine("Method form DrivedClass");
        }
        public override void MethodVirtual()
        {
            base.MethodVirtual();
            Console.WriteLine("MethodVirtual() from DrivedClass");
        }
        public void NVMethod()
        {
            Console.WriteLine("NV from DrivedClass");
        }
        public static void MethodStatic()
        {
            Console.WriteLine("Static Method");
        }
    }
}

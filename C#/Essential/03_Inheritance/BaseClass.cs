using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class BaseClass
    {
        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";
        public int baseNumber;
        public int field1;
        public int field2;
        public int field3;

        public BaseClass()
        {
            Console.WriteLine("BaseClass()");
        }
        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
            Console.WriteLine("BaseClass(int)");
        }
        
        public void Show()
        {
            Console.WriteLine(privateField);
        }
        public void Method()
        {
            Console.WriteLine("Method form BaseClass");
        }
        public virtual void MethodVirtual()
        {
            Console.WriteLine("MethodVirtual() from BaseClass");
        }
        public void NVMethod()
        {
            Console.WriteLine("NV from BaseClass");
        }
    }
}

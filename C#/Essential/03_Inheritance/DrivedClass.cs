using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class DrivedClass : BaseClass
    {
        public int drivedField;
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
    }
}

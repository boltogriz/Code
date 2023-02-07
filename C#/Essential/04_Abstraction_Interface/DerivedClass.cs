using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction_Interface
{
    internal class DerivedClass : AbstractBaseClass
    {
        string s = "FIRTS";
        public DerivedClass()
        {
            Console.WriteLine("3 DerivedClass()");
            s = "SECOND";
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod");
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod {0}", s);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction_Interface
{
    abstract class AbstractBaseClass
    {
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }
        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }
        abstract public void AbstractMethod();
        public AbstractBaseClass()
        {
            Console.WriteLine("1 AbstractClass()");
            this.AbstractMethod();
            Console.WriteLine("2 AbstractClass()");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    abstract class AbstractClass
    {
        public static AbstractClass CreataObject()
        {
            return new ConcreteClass();
        }
        public abstract void Method();

    }
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("AbstractClass.Method");
        }
    }
}

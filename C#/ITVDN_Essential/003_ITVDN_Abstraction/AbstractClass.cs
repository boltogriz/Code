using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ITVDN_Abstraction
{
    abstract class AbstractClassC
    {
        public AbstractClassC()
        {
            Console.WriteLine("1 AbstractClassC()");
            this.AbstractMethod();
            Console.WriteLine("2 AbstractClass()");
        }
        public abstract void AbstractMethod();
    }
}

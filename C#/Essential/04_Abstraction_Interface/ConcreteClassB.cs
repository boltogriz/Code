using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction_Interface
{
    internal class ConcreteClassB : AbstractClass1
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }
}

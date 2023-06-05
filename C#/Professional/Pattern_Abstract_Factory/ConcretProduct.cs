using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory
{
    internal class ConcreteProduct : AbstractProduct
    {
        public override void Operation()
        {
            Console.WriteLine("Some work...");
        }
    }
}

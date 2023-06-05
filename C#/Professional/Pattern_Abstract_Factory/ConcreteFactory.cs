using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory
{
    internal class ConcreteFactory : AbstractFactory
    {
        public override AbstractProduct CreatProduct()
        {
            return new ConcreteProduct();
        }
    }
}

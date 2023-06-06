using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory_2
{
    internal class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreatBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreatWater()
        {
            return new CocaColaWater();
        }
    }
}

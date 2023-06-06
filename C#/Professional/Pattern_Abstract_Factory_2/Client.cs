using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory_2
{
    internal class Client
    {
        private AbstractBottle bottle;
        private AbstractWater water;

        public Client(AbstractFactory factory)
        {
            water = factory.CreatWater();
            bottle = factory.CreatBottle();
        }
        public void Run()
        {
            bottle.Interact(water);
        }
    }
}

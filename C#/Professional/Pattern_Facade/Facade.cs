using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Facade
{
    internal class Facade
    {
        ElementA elementA;
        ElementB elementB;
        internal void HelloWorld()
        {
            elementA = new ElementA();
            elementB = new ElementB();

            elementA.Hello();
            elementB.World();
        }
    }
}

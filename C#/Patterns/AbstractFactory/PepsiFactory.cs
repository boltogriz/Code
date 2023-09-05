using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class PepsiFactory : AbstractFatory
    {

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
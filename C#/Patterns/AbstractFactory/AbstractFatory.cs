using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractFatory
    {
        public abstract AbstractBottle CreateBottle();

        public abstract AbstractWater CreateWater();

        public abstract AbstractCover CreateCover();
    }
}
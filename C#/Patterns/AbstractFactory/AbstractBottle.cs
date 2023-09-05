using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater a, AbstractCover cover);
    }
}
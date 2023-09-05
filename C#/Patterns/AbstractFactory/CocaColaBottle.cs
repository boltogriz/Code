using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater a, AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + a + " " + cover);
        }
    }
}
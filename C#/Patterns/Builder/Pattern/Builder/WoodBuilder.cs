using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class WoodBuilder : Builder
    {
        private House house = new House();

        public override void BuildBasement()
        {
            house.Add(new WoodBasement());
        }

        public override void BuildRoof()
        {
            house.Add(new WoodRoof());
        }

        public override void BuildStorey()
        {
            house.Add(new WoodStorey());
        }

        public override House GetResult()
        {
            return house;
        }
    }
}
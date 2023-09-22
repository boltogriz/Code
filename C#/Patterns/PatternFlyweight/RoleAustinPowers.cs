using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFlyweight
{
    public class RoleAustinPowers : Flyweight
    {
        private Flyweight flyweight;

        public override void Greeting(string speech)
        {
            this.flyweight.Greeting(speech);
        }
        public RoleAustinPowers(Flyweight flyweight) 
        { 
            this.flyweight = flyweight;
        }
    }
}
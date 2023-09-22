using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFlyweight
{
    public class RoleDoctorEvil : Flyweight
    {
        private Flyweight flyweight;

        public RoleDoctorEvil(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            this.flyweight.Greeting(speech);
        }
    }
}
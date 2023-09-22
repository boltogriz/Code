using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFlyweight
{
    public class ActorMieMyers : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}
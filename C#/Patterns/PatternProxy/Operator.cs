using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternProxy
{
    public class Operator : IHuman
    {
        public override void Request()
        {
            Console.WriteLine("Operator");
        }
    }
}
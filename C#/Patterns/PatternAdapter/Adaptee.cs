using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternAdapter
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee");
        }
    }
}
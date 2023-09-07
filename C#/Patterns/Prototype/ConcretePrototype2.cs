using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
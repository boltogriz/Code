using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id)
            : base(id) 
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(this.Id);
        }
    }
}

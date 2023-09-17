using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public class Leaf : Component
    {
        public Leaf(string name)
            :base(name)
        {
            
        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override Component GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public override void Operation()
        {
            Console.WriteLine(name);
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
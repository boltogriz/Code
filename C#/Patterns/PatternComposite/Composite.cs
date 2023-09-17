using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public class Composite : Component
    {
        public Composite(string name)
            : base(name)
        { }

        public ArrayList nodes = new ArrayList();

        public override void Add(Component c)
        {
            nodes.Add(c);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine(name);
            foreach (Component c in nodes) 
            { 
                c.Operation();
            }
        }

        public override void Remove(Component c)
        {
            nodes.Remove(c);
        }
    }
}
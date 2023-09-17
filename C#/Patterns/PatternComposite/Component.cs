using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public abstract class Component
    {
        public string name;

        public abstract void Add(Component c);
        public Component(string name)
        {
            this.name = name;
        }
        public abstract Component GetChild(int index);
        public abstract void Operation();
        public abstract void Remove(Component c);
    }
}
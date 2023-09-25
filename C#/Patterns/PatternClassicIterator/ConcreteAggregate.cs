using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternClassicIterator
{
    internal class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();
        public override object this[int index] 
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public override int Count 
        { 
            get { return items.Count; } 
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
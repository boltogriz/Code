using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PatternIterator
{
    public class Enumerable : IEnumerable
    {
        private ArrayList items = new ArrayList();

        public object this[int index]
        { 
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
    }
}
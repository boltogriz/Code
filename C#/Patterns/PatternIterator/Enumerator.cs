using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternIterator
{
    public class Enumerator : IEnumerator
    {
        int current = -1;
        Enumerable enumerable;

        public Enumerator(Enumerable enumerable)
        {
            this.enumerable = enumerable;
        }
        object IEnumerator.Current
        { 
            get { return enumerable[current]; } 
        }


        public bool MoveNext()
        {
            if (current < enumerable.Count - 1)
            {
                current++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
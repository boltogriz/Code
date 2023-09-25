using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternIterator
{
    public interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }
}
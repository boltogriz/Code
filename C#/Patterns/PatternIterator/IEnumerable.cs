using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternIterator
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
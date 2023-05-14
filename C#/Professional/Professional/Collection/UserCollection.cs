using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P_00_Collection
{
    internal class UserCollection : IEnumerable, IEnumerator
    {
        readonly Element[] elements = new Element[4];
        public Element this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
        int position = -1;

        // Реализация интерфейса IEnumerator и IEnumerable
        object IEnumerator.Current
        { 
            get { return elements[position]; } 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }

        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}

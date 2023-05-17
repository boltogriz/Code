using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollecttionUserGener
{
    internal class UserCollection<T> : ICollection<T>
    {
        T[] elements = new T[0];
        public int Count 
        { 
            get { return elements.Length; } 
        }

        public bool IsReadOnly 
        { 
            get { return false; } 
        }

        public void Add(T item)
        {
            var newArray = new T[elements.Length + 1];
            elements.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = item;
            elements = newArray;
        }

        public void Clear()
        {
            elements = new T[0];
        }

        public bool Contains(T item)
        {
            foreach(var element in elements)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
            //return elements.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
           return ((IEnumerable<T>)elements).GetEnumerator();
        }

        public bool Remove(T item)
        {
            if (this.Contains(item))
            {
                int counter = 0;
                var array = new T[elements.Length - 1];
                for(int i = 0; i < elements.Length; i++)
                {
                    if (!(elements[i].Equals(item)))
                    {
                        array[counter] = elements[i];
                        counter++;
                    }
                }
                elements = array;
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
    }
}

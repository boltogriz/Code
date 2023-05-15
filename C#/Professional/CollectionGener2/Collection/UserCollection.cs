using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionGener2
{
    public class UserCollection<T>
    {
        readonly T[] elements = new T[4];
        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
        int position = -1;

        //Реализация интерфейсов
        //public T Current
        //{
        //    get { return elements[position]; }
        //}
        //public object Current
        //{ 
        //    get { return elements[position]; }
        //}

        public void Dispose()
        {
            Reset();
        }

        //public bool MoveNext()
        //{
        //    if (position < elements.Length - 1)
        //    {
        //        position++;
        //        return true;
        //    }
        //    ((IEnumerator)this).Reset();
        //    return false;
        //}

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            //while(true)
            //{
            //    if (position < elements.Length - 1 ) 
            //    { 
            //        position++;
            //        yield return elements[position];
            //    }
            //    else
            //    {
            //        Reset();
            //        yield break;
            //    }
            //}

            //foreach (var element in elements)
            //{
            //    yield return element;
            //}

            return elements.GetEnumerator();

        }

        //public IEnumerator GetEnumerator()
        //{
        //    return this;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionGener3
{
    public class UserCollection<T>
    {
        T[] elements;
        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }
        public UserCollection()
        {
            this.elements = new T[4];
            this.position = -1;
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
            Enumerator enumerator = new Enumerator(0);
            enumerator.@this = (UserCollection<T>)this;
            return enumerator;

        }
        private sealed class Enumerator : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int state;
            private object current;
            public UserCollection<T> @this;
            public Enumerator(int state)
            {
                this.state = state;
            }
            public bool MoveNext()
            {
                switch (this.state)
                {
                    case 0:
                        this.state = -1;
                        break;
                    case 1:
                        this.state = -1;
                        break;

                    default:
                        goto Label_00A0;
                }
                if (this.@this.position < (this.@this.elements.Length - 1))
                {
                    this.@this.position++;
                    this.current = this.@this.elements[this.@this.position];
                    this.state = 1;
                    return true;
                }
                this.@this.Reset();
            Label_00A0:
                return false;
            }
            void IEnumerator.Reset() 
            {
                throw new NotSupportedException();
            }
            void IDisposable.Dispose()
            { 
            }

            object IEnumerator<object>.Current
            { 
                get 
                { 
                    return this.current; 
                } 
            }
            object IEnumerator.Current { get { return this.current; } }
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return this;
        //}
    }
}

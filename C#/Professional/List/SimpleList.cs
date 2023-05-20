using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListCollection
{
    internal class SimpleList : IList
    {
        private readonly object[] contents = new object[8];
        private int count;
        public SimpleList()
        {
            count = 0;
        }
        #region Ilits Members
        // IList
        public object this[int index] { get => contents[index]; set => contents[index] = value; }

        public bool IsReadOnly => false;

        public bool IsFixedSize => true;

        public int Count => count;

        public object SyncRoot => null;

        public bool IsSynchronized => false;

        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;
                return (count - 1);
            }
            return -1;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                    return true;
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i <= Count; i++)
            {
                array.SetValue(contents[i], j);
                j++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            //return contents.GetEnumerator();
            for (int i = 0; i < Count; i++)
            {
                yield return contents[i];
            }
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
                if (contents[i] == value)
                    return i;
            return -1;
        }

        public void Insert(int index, object value)
        {
            if((count +1 <= contents.Length) && (index < Count) && (index >= 0))
            {
                count++;
                for (int i = Count - 1; i > Count; i--)
                {
                    contents[i] = contents[i - 1];
                }
                contents[index] = value;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                    contents[i] = contents[i + 1];
                count--;

            }
        }
        #endregion region
        public void PrintContents()
        {
            Console.WriteLine("Список имеет емкость {0} и в настоящее время имеет {1} элементов.", contents.Length, count);
            Console.WriteLine("Список содержит:");
            for(int i = 0; i < Count;i++)
                Console.WriteLine(" {0}", contents[i]);
            Console.WriteLine("\n" + new string('-',55));
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollectionProject
{
    public class Element
    {
        private string name;
        private int field1;
        private int field2;
        public Element(string s, int a, int b)
        {
            name = s;
            field1 = a;
            field2 = b;
        }
        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }
        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class UserCollection : IEnumerable, IEnumerator
    {
         Element[] elementsArray = null;
        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }
        public void Power()
        {
            Console.WriteLine("Power");
        }
        int position = -1;
        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return elementsArray[position]; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}

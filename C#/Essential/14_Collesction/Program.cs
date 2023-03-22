using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14_Collesction
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
    internal class Program
    {
        static void Main(string[] args)
        {
            UserCollection myCollection = new UserCollection();
            int[] arrays = { 1, 2, 3};
            foreach (int element in arrays)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element, element, element);
            }
            Console.Write(new String('-', 20) + "\n");
            foreach (int element in arrays)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element, element, element);
            }
            Console.Write(new String('-', 20) + "\n");
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            //Console.Write(new String('-', 20) + "\n");
            myCollection.Reset();
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            Console.Write(new String('-', 20) + "\n");

            UserCollection myElementsCollection = new UserCollection();
            IEnumerable enumerable = myElementsCollection as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            enumerator.Reset();
            Console.Write(new String('-', 20) + "\n");
            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }
            Console.ReadKey();
        }
    }
}

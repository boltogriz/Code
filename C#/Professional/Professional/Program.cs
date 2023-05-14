using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P_00_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element element0 = new Element(0, 0);
            Element element1 = new Element(0, 1);
            Element element2 = new Element(1, 0);
            Element element3 = new Element(1, 1);

            UserCollection collection = new UserCollection();
            collection[0] = element0;
            collection[1] = element1;
            collection[2] = element2;
            collection[3] = element3;

            foreach(Element element in collection) 
            {
                Console.WriteLine("FieldA = {0}, FieldB = {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-',20));

            IEnumerator enumerator = (collection as IEnumerable).GetEnumerator();
            while(enumerator.MoveNext()) 
            { 
                Element element = enumerator.Current as Element;
                Console.WriteLine("FieldA = {0}, FieldB = {1}", element.FieldA, element.FieldB);
            }

            Console.ReadKey();
        }
    }
}

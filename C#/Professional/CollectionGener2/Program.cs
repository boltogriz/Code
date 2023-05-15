using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGener2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserCollection<Element> collection = new UserCollection<Element>();
            collection[0] = new Element(1, 1);
            collection[1] = new Element(2, 2);
            collection[2] = new Element(3, 3);
            collection[3] = new Element(4, 4);

            foreach (Element element in collection)
            {
                Console.WriteLine($"{element.FieldA} - {element.FieldB}");
            }
            foreach (Element element in collection)
            {
                Console.WriteLine($"_{element.FieldA} - {element.FieldB}");
            }
            Console.ReadKey();
        }
    }
}

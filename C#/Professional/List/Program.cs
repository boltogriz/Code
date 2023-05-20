using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Elements
    {
        public int FolderA;
        public int FolderB;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Elements element0 = new Elements() { FolderA = 1, FolderB = 1 };
            Elements element1 = new Elements() { FolderA = 2, FolderB = 2 };
            Elements element2 = new Elements() { FolderA = 3, FolderB = 3 };
            Elements element3 = new Elements() { FolderA = 4, FolderB = 3 };
            Elements element4 = new Elements() { FolderA = 5, FolderB = 3 };
            Elements element5 = new Elements() { FolderA = 6, FolderB = 3 };

            var collection = new SimpleList() { element3, element4, element5 };
            collection.Add(element0);
            collection.Add(element1);
            collection.Add(element2);

            foreach (Elements item in collection)
            {
                Console.WriteLine("{0} - {1}", item.FolderA, item.FolderB);
            }
            Console.WriteLine(collection.Count);

            Console.WriteLine(new string('-', 20));

            collection.Remove(element1);

            foreach (Elements item in collection)
            {
                Console.WriteLine("{0} - {1}", item.FolderA, item.FolderB);
            }
            Console.WriteLine(collection.Count);

            collection.PrintContents();

            Console.ReadKey();
        }
    }
}

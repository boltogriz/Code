using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollectionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable enumerl = UserCollection.Power();
            foreach (string element in enumerl)
            {
                Console.WriteLine(element);
            }
            //IEnumerable enumerable = UserCollection.Power();
            //IEnumerator enumerator = enumerable.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    String element = enumerator.Current as String;
            //    Console.WriteLine(element);
            //}
            //
            //
            Console.ReadKey();
        }
    }
}

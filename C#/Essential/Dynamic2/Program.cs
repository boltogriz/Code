using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic2
{
    class UserCollection
    {
        public static IEnumerable Generator()
        {
            yield return new { key = 0, value = "Zero" };
            yield return new { key = 1, value = "One" };
            yield return new { key = 2, value = "Two" };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(dynamic item in UserCollection.Generator()) 
            {
                Console.WriteLine("{0}, {1}", item.key, item.value);
            }
            Console.ReadKey();
        }
    }
}

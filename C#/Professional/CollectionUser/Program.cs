using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserCollection collection = new UserCollection();
            foreach (Object item in collection) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-',20));
            Object[] arr = new object[collection.Count];
            collection.CopyTo(arr, 0);
            foreach (Object item in arr)
            { 
                Console.WriteLine(item); 
            }
            Console.ReadLine();

        }
    }
}

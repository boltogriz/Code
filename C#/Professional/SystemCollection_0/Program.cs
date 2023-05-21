using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SystemCollection_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            string s = "hello";
            list.Add(s);
            list.Add("hi");
            list.Add(50);
            list.Add(new object());
            var anArray = new[] { "more", "or", "list" };
            list.AddRange(anArray);
            var anotherArray = new[] {new object(), new ArrayList()};
            list.AddRange(anotherArray);
            list.Insert(3, "Hey all");
            var moreString = new[] { "good", "moreString", "addMoreString" };
            list.InsertRange(3, moreString);
            list.Remove("hello");
            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

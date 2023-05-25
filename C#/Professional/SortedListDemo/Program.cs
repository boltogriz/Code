using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sort = new SortedList();
            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4thd";
            sort["fourth"] = "4thd";
            foreach(DictionaryEntry entry in sort) 
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }
            Console.ReadKey();
        }
    }
}

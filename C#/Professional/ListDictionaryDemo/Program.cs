using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new ListDictionary();
            emailLookup["sbishp@contos.com"] = "Bishop, Scott";
            emailLookup["chess@contos.com"] = "Hell, Christian";
            emailLookup["djmup@contos.com"] = "Jump, Dan";
            foreach(DictionaryEntry entry in emailLookup) 
            {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value);
            }

            var emailLookup2 = new HybridDictionary();
            emailLookup2["sbishp@contos.com"] = "Bishop, Scott";
            emailLookup2["chess@contos.com"] = "Hell, Christian";
            emailLookup2["djmup@contos.com"] = "Jump, Dan";
            foreach (DictionaryEntry entry in emailLookup2)
            {
                Console.WriteLine("{0} - {1}", entry.Key, entry.Value);
            }
            Console.ReadKey();
        }
    }
}

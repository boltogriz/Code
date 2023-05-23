using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDemo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();
            emailLookup.Add("sbishp@cont.com", "Bishop, Scott");
            emailLookup["s.bishop@gm.com"] = "Bishop, Scott";
            emailLookup["surik@gm.com"] = "----";
            Console.WriteLine(emailLookup["s.bishop@gm.com"]);
            foreach (object email in emailLookup) 
            {
                Console.WriteLine(((DictionaryEntry)email).Key + " - " + ((DictionaryEntry)email).Value);
            }
            foreach (object email in emailLookup.Values)
            {
                Console.WriteLine(email);
            }
            Console.ReadKey();

        }
    }
}

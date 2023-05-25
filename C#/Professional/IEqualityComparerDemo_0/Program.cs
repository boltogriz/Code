using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEqualityComparerDemo_0
{
    public class InsensitiveComparer : IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dehash = new Hashtable(new InsensitiveComparer());
            dehash["First"] = "1st";
            dehash["Second"] = "2nd";
            dehash["Third"] = "3rd";
            dehash["Fourth"] = "4th";
            dehash["fourth"] = "4TH";
            Console.WriteLine(dehash.Count);
            Console.ReadKey();
        }
    }
}

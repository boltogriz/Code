using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCollection_1
{
    class DescendingComparer : IComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = comparer.Compare(y, x);
            //int result = (int)y - (int)x;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Sort(new DescendingComparer());
            //list.Sort();
            foreach(var item in  list) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

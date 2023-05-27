using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ListGen
{
    class MyReverseComparer<T> : Comparer<T>
    {
        public override int Compare(T x, T y)
        {
            return y.GetHashCode() - x.GetHashCode();
        }
    }
    static class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3 };
            var reverseCompare = new MyReverseComparer<int>();

            int number = intList[0];
            Console.WriteLine("Original List");
            intList.PrintList();
            intList.Sort(new Comparison<int>((x, y) => y - x));
            intList.PrintList();


            string text = "sdf";
            text.ShowText();
            ShowText(text);


            Console.ReadKey();
        }
        private static void PrintList<T>(this IEnumerable<T> intList)
        {
            foreach (T i in intList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-', 20));
        }

        private static void ShowText(this string text)
        {
            Console.WriteLine(text);
        }
    }
}

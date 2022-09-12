using System;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;

namespace Beginner
{
    class Program
    {
        private static string text;
        public static void TextConShow(object states)
        {
            text = "asdf";
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
             System.Threading.Timer t = new System.Threading.Timer(new TimerCallback(TextConShow));
             t.Change(2000, 5000);
             Console.ReadLine();
        }
    }
}

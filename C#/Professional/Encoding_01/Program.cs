using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoding_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var swUtf7 = new StreamWriter("text.txt", true, Encoding.UTF7);
            swUtf7.WriteLine("Hellow, world!");
            swUtf7.Close();

            var swUtf8 = new StreamWriter("text.txt", true, Encoding.UTF8);
            swUtf8.WriteLine("Hellow, world!");
            swUtf8.Close();

            var swUtf16 = new StreamWriter("text.txt", true, Encoding.Unicode);
            swUtf16.WriteLine("Hellow, world!");
            swUtf16.Close();

            var swutf32 = new StreamWriter("text.txt", true, Encoding.UTF32);
            swutf32.WriteLine("Hellow, world!");
            swutf32.Close();

            //File.WriteAllText("text.txt", "Hello World!", Encoding.BigEndianUnicode);

            Console.WriteLine(File.ReadAllText("text.txt"));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace BitVector32Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitVector32.Section firstSection = BitVector32.CreateSection(10);
            BitVector32.Section secondSection = BitVector32.CreateSection(50, firstSection);
            BitVector32.Section thirdSection = BitVector32.CreateSection(500, secondSection);
            BitVector32.Section fourthSection = BitVector32.CreateSection(500, thirdSection);
            var packedBits = new BitVector32(0);

            packedBits[firstSection] = 10;
            packedBits[secondSection] = 50;
            packedBits[thirdSection] = 500;
            packedBits[fourthSection] = 499;

            Console.WriteLine(packedBits[fourthSection]);
            Console.WriteLine(packedBits[secondSection]);
            Console.WriteLine(packedBits[thirdSection]);
            Console.WriteLine(packedBits[fourthSection]);
            Console.WriteLine(packedBits);

            Console.ReadKey();

        }
    }
}

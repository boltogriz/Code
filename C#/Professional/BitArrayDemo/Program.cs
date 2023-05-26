using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray bits = new BitArray(3);
            bits[0] = false;
            bits[1] = false;
            bits[2] = true;
            Console.WriteLine(bits.Length);
            bits.Length = 4;
            bits[3] = false;
            Console.WriteLine(bits.Length);

            var moreBits = new BitArray(4);
            moreBits[0] = true;
            moreBits[1] = true;
            moreBits[2] = true;
            moreBits[3] = true;

            BitArray xorBits = bits.Xor(moreBits);

            foreach (bool bit in xorBits) 
            {
                Console.WriteLine(bit);
            }
            Console.ReadKey();
        }
    }
}

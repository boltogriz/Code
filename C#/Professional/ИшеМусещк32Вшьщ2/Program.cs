using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitVector32Dimo3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vector = new BitVector32(0);
            int firstBit = BitVector32.CreateMask();
            int secondBit = BitVector32.CreateMask(firstBit);
            int thirdBit = BitVector32.CreateMask(secondBit);
            Console.WriteLine(firstBit + " " + secondBit + " " + thirdBit);

            vector[firstBit] = true;
            vector[secondBit] = true;

            Console.WriteLine("{0} должно быть 3", vector.Data);
            Console.WriteLine(vector.ToString());

            var newVector = new BitVector32(4);
            Console.WriteLine(newVector);

            bool bit1 = newVector[firstBit];
            bool bit2 = newVector[secondBit];
            bool bit3 = newVector[thirdBit];

            Console.WriteLine("{0} должно быть 4", newVector.Data);
            Console.WriteLine(newVector.ToString());

            Console.ReadKey();
        }
    }
}

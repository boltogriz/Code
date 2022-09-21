using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte augend = 1, addend = 2;
            int sum = augend + addend;

            byte minuend = 5, subrtahend = 3;
            int difference = minuend - subrtahend;

            byte multiplicand = 2, mulpiplier = 3;
            int product = multiplicand * mulpiplier;

            byte dividend = 9, divisor = 2;
            float quotient = ((float)dividend / divisor) * -1;
            int remainder = dividend % divisor;

            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
        }
    }
}

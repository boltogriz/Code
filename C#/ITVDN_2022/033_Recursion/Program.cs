using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _033_Recursion
{
    internal class Program
    {
        static void Operation(int counter)
        {
            counter--;
            Console.WriteLine("A: {0}", counter); ;
            if(counter != 0)
            {
                Operation(counter);
            }
            Console.WriteLine("B: {0}", counter); ;
        }
        static BigInteger Factorial(BigInteger number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        static int Fibonacci(int number)
        {
            if(number < 2)
            {
                return number;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }
        static BigInteger FactorialFor(BigInteger number)
        {
            BigInteger intermediateRusalt = 1;
            for (BigInteger factor = 2; factor <= number; factor++)
            {
                intermediateRusalt = intermediateRusalt * factor;
            }
            return intermediateRusalt;
        }
        static void Main(string[] args)
        {
            Operation(3);

            BigInteger number = 1000;
            Console.WriteLine($"{number}! = {Factorial(number)}");
            Console.WriteLine();

            Console.WriteLine($"{number}! = {FactorialFor(number)}");
            Console.WriteLine();
            
            for (int i = 0; i < 10; i++)
            {
                int fibonacci = Fibonacci(i);
                Console.WriteLine(fibonacci);
            }
            Console.ReadKey();
        }
    }
}

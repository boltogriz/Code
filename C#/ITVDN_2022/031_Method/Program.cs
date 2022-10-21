using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_Method
{
    internal class Program
    {
        static void Method(int parametar)
        {
            parametar++;
            Console.WriteLine($"Method parametar = {parametar}");

        }
        static void MethodNameParam(int parametar)
        {
            parametar++;
            Console.WriteLine($"MethodNameParam parametar = {parametar}");

        }
        static void MethodRef(ref int parametar)
        {
            parametar++;
            Console.WriteLine($"MethodRef parametar = {parametar}");

        }
        static void MethodIn(in int parametar)
        {
            //parametar++;
            Console.WriteLine($"MethodIn parametar = {parametar}");

        }
        static void MethodOut(out int parametar)
        {
            parametar = 0;
            parametar++;
            Console.WriteLine($"MethodOut parametar = {parametar}");

        }
        static void MethodParam(string text, params int[] elements)
        {
            Console.WriteLine(text);
            for (int i = 0; i < elements.Length; i++)
                Console.Write($"{elements[i]} ");
        }
        static void Main(string[] args)
        {
            int variable = 0;
            Method(variable);
            MethodNameParam(parametar: variable);
            Console.WriteLine($"variable = {variable}");
            
            Console.WriteLine();
            int variableRef = 0;
            MethodRef(ref variableRef);
            Console.WriteLine($"variableRef = {variableRef}");

            Console.WriteLine();
            int variableIn = 0;
            MethodIn(in variableIn);
            Console.WriteLine($"variableIn = {variableIn}");

            Console.WriteLine();
            MethodOut(out int variableOut);
            Console.WriteLine($"variableOut = {variableOut}");

            Console.WriteLine();
            string text = "Texted field";
            MethodParam( text, 2, 3, 4, 5);

            Console.ReadKey();
        }
    }
}

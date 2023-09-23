using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int result = 0;

            result = calculator.Add(2);
            Console.WriteLine(result);



            result = calculator.Sub(3);
            Console.WriteLine(result);

            result = calculator.Add(8);
            Console.WriteLine("метод сложения: " + result);

            result = calculator.Left(2);
            Console.WriteLine("метод остатка от 2: " + result);

            result = calculator.Add(8);
            Console.WriteLine("метод сложения: " + result);

            result = calculator.Undo(2);
            Console.WriteLine(result);

            result = calculator.Redo(2);
            Console.WriteLine(result);

            

            

            Console.ReadKey();
        }
    }
}

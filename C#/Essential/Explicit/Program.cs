using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit
{
    struct Digit
    {
        public byte value;
        Digit(byte value)
        {
            this.value = value;
        }
        //public static explicit operator Digit(byte argument)
        //{
        //    Digit digit = new Digit(argument);
        //    return digit;
        //}
        public static implicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }
        public override string ToString()
        {
            return this.value.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            byte variable = 1;
            //Digit digit = (Digit)variable;
            Digit digit = variable;
            Console.WriteLine(digit);
            Console.ReadKey();
        }
    }
}

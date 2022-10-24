using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_GOTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            goto Label;
        //Console.WriteLine("1");
        //Console.WriteLine("1");
        //Console.WriteLine("1");
        Label:
            Console.WriteLine("End");

            byte[] agesList = { 23, 30, 35 };
            int index = 0;
            LoopWhile:
            if (index < agesList.Length)
            {
                byte age = agesList[index];
                Console.WriteLine(age);
                index++;
                goto LoopWhile;
            }
            Console.ReadKey();
        }
    }
}

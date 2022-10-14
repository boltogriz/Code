using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] ageList = { 23, 30, 35 };
            //byte age = ageList[0];
            ageList[2] = 55;
            int index = 0;
            while (index < 3)
            {
                byte ages = ageList[index];
                Console.WriteLine(ages);
                index++;
            }
            Console.ReadKey();
        }
    }
}

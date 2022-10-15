using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            }
            {
                Console.Write("введите размер массива: ");
                int length = Convert.ToInt32(Console.ReadLine());
                byte[] array = new byte[length];
                int index = 0;
                while (index < array.Length)
                {
                    array[index] = (byte)index;
                    Console.WriteLine($"{array[index]}");
                    index++;
                }
                 
            }
            {
                int[] array = { 0, 1, 2, 3, 4, 5 };
                for(int index = 0; index < array.Length; index++)
                {
                    Console.Write($"{array[index]} ");
                }    
            }
            Console.ReadKey();
        }
    }
}

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
            {
                int[,] array = {
                                    { 1, 2 },
                                    { 3, 4 },
                                    { 5, 6 }
                                };
                int numberOfLines = array.GetLength(0), numberOfColumns = array.GetLength(1);
                Console.WriteLine();
                Console.WriteLine();
                for (int y = 0; y < numberOfLines; y++)
                {
                    for (int x = 0; x < numberOfColumns; x++)
                    {
                        int element = array[y, x];
                        Console.Write($"{element} ");
                    }
                    Console.WriteLine();
                }
            }
            {
                byte[,,] array = new byte[3, 3, 3]
                {
                    {
                        { 1, 2, 3},
                        { 4, 5, 6},
                        { 7, 8, 9}
                    },
                    {
                        { 1, 2, 3},
                        { 4, 5, 6},
                        { 7, 8, 9}
                    },
                    {
                        { 1, 2, 3},
                        { 4, 5, 6},
                        { 7, 8, 9}
                    }
                };
                for (int i = 0; i < array.GetLength(0); i++)
                    for (int j = 0; j < array.GetLength(1); j++)
                        for (int k = 0; k < array.GetLength(2); k++)
                            Console.Write($"{array[i, j, k]} ");
            }
            Console.ReadKey();
        }
    }
}

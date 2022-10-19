using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                byte[] array0 = new byte[] { 1, 2, 3 };
                byte[] array1 = new byte[] { 4, 5, 6 };
                byte[] array2 = new byte[] { 7, 8, 9 };
                byte[][] array = new byte[3][] { array0, array1, array2 };
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write($"{array[i][j]} ");
                    }
                }
            }
            {
                Console.WriteLine();
                byte[] array0 = new byte[] { 1, 2, 3 };
                byte[] array1 = new byte[] { 4, 5, 6 };
                byte[] array2 = new byte[] { 7, 8, 9 };
                byte[][] array = new byte[3][];
                array[0] = array0;
                array[1] = array1;
                array[2] = array2;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write($"{array[i][j]} ");
                    }
                }
            }
            {
                Console.WriteLine();
                byte[] array0 = new byte[] { 1, 2, 3 };
                byte[] array1 = new byte[] { 4, 5, 6 };
                byte[] array2 = new byte[] { 7, 8, 9 };
                byte[][] array = new byte[3][]
                    {
                     new byte[] { 1, 2, 3 },
                     new byte[] { 4, 5, 6 },
                     new byte[] { 7, 8, 9 }
                    };
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write($"{array[i][j]} ");
                    }
                }
            }

            {
                Console.WriteLine();
                byte[,] array0 = new byte[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                byte[,] array1 = new byte[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                byte[,] array2 = new byte[,] { { 1, 2, 3 }, { 4, 5, 9 } };
                byte[][,] array = new byte[3][,] { array0, array1, array2 };
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array[i].GetLength(0); j++)
                        for (int k = 0; k < array[i].GetLength(1); k++)
                            Console.Write($"{array[i][j, k]} ");
            }
            {
                Console.WriteLine("\n====\n");
                //byte[,] array0 = new byte[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                //byte[,] array1 = new byte[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                //byte[,] array2 = new byte[,] { { 1, 2, 3 }, { 4, 5, 9 } };
                //byte[][,] array = new byte[3][,] { array0, array1, array2 };
                byte[][,] array = new byte[3][,];
                array[0] = new byte[,]{ { 1, 2, 3 }, { 4, 5, 6 } };
                array[1] = new byte[,]{ { 1, 2, 3 }, { 4, 5, 6 } };
                array[2] = new byte[,]{ { 1, 2, 3 }, { 4, 5, 6 } };
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array[i].GetLength(0); j++)
                        for (int k = 0; k < array[i].GetLength(1); k++)
                            Console.Write($"{array[i][j, k]} ");
            }
            {
                Console.WriteLine();
                Console.WriteLine();

                byte[,][,] array = new byte[3, 2][,] ;
                array[0, 0] = new byte[,] { { 1, 2, 3}, {1, 2, 3 } };
                array[0, 1] = new byte[,] { { 1, 2}, {1, 2 } };
                array[1, 0] = new byte[,] { { 1, 2, 3}, {1, 2, 3 } };
                array[1, 1] = new byte[,] { { 1, 2, 3, 4}, {1, 2, 3, 4 } };
                array[2, 0] = new byte[,] { { 1, 2, 3}, {1, 2, 3 } };
                array[2, 1] = new byte[,] { { 1, 2, 3}, {1, 2, 3 } };
                array[2, 1] = new byte[,] { { 1}, {1} };
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array[i, j].GetLength(0); k++)
                        {
                            for (int l = 0; l < array[i, j].GetLength(1); l++)
                            { 
                                Console.Write($"{array[i, j][k, l]} "); 
                            }
                        Console.WriteLine();
                        }
                    }
                }
            }
            {
                Console.WriteLine();
                Console.WriteLine();
                byte[,] array01 = new byte[,] { { 1,2,3 },{ 1,2,3 } };
                byte[,][,] array = new byte[3, 2][,];
                array[0, 0] = new byte[,] { { 1, 2, 3 }, { 1, 2, 3 } };
                array[0, 1] = new byte[,] { { 1, 2 }, { 1, 2 } };
                array[1, 0] = new byte[,] { { 1, 2, 3 }, { 1, 2, 3 } };
                array[1, 1] = new byte[,] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
                array[2, 0] = new byte[,] { { 1, 2, 3 }, { 1, 2, 3 } };
                array[2, 1] = new byte[,] { { 1, 2, 3 }, { 1, 2, 3 } };
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array[i, j].GetLength(0); k++)
                        {
                            for (int l = 0; l < array[i, j].GetLength(1); l++)
                            {
                                Console.Write($"{array[i, j][k, l]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            {
                byte[,] array0 = new byte[2, 5], array1 = new byte[4, 5], array2 = new byte[3, 10],
                                 array3 = new byte[2, 5], array4 = new byte[4, 5], array5 = new byte[4, 1],
                                 array6 = new byte[2, 5], array7 = new byte[4, 5], array8 = new byte[3, 10],
                                 array9 = new byte[2, 5], array10 = new byte[4, 5], array11 = new byte[3, 10], array12 = new byte[2,20];
                byte[,][,] ja1 = new byte[3,2][,] { { array0, array1}, { array2, array3}, {array5, array6} }; 
                byte[,][,] ja2 = new byte[3,2][,] { { array7, array8}, { array9, array10}, {array11, array12 } };
                byte[][,][,] jaggedArray = new byte[2][,][,] { ja1, ja2 };
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                    {
                        for (int k = 0; k < jaggedArray[i].GetLength(1); k++)
                        {
                            for (int l = 0; l < jaggedArray[i][j, k].GetLength(0); l++)
                            {
                                for (int m = 0; m < jaggedArray[i][j, k].GetLength(1); m++)
                                {
                                    Console.Write($"{jaggedArray[i][j, k][l, m]}");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            {
                byte[,][,] array;
                byte[,] array0 = new byte[2, 3];
                byte[,] array1 = new byte[6, 3];
                array = new byte[2, 3][,] 
                            {
                                {
                                    array0, array1, array0
                                },
                                {
                                    array0, array0, array0
                                }
                                
                            };
            }
            {
                Console.WriteLine();
                int[][] array;
                array = new int[4][];
                array[0] = new int[3];
                array[1] = new int[6];
                array[2] = new int[9];
                array[3] = new int[12];
                /*int[][] array = new int[4][] 
                { 
                    new int[3],
                    new int[6],
                    new int[9],
                    new int[12]
                };*/
                int x = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        x++; 
                        array[i][j] = x;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }

            }
            {
                Console.WriteLine();
                int[][] array;
                int x = 4;
                array = new int[x][];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new int[i + 1];
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }

            }
            {
                Console.WriteLine();
                int[][,] array;
                int x = 4;
                int y = 0;
                array = new int[x][,];
                for (int i = 0; i < array.Length; i++)
                {
                    y++;
                    array[i] = new int[i + 1, y];
                    for (int j = 0; j < array[i].GetLength(0); j++)
                    {
                        for (int k = 0; k < array[i].GetLength(1); k++)
                        {
                            Console.Write($"{array[i][j, k]} ");
                        }
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }

            }
            {
                int[][,] array;
                array = new int[2][,];
                array[0] = new int[2,3] { { 1, 2, 3 },{ 1, 2, 3 } };
            }
            Console.ReadKey();
        }
    }
}

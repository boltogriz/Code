using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _026_RawMaterialPlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int numberOfTypesOfTile, numberOfTypesOfMaterials;
            {
                Console.Write("Введите количество разновидностей пликти: ");
                numberOfTypesOfTile = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество видов сырья для изготовления плитки: ");
                numberOfTypesOfMaterials = Convert.ToInt32(Console.ReadLine());
            }
            decimal[,] A = new decimal[numberOfTypesOfTile, numberOfTypesOfMaterials];
            string[,] ANamesTitle = new string[numberOfTypesOfTile, 1];
            string [,] ANames = new string[1, numberOfTypesOfMaterials];
            decimal[,] B = new decimal[numberOfTypesOfMaterials, 1];
            decimal[] C = new decimal[numberOfTypesOfTile];
            decimal[,] Z = new decimal[numberOfTypesOfTile, 1];
            for (int i = 0; i < ANames.GetLength(1); i++)
            {
                Console.Write($"Введите название сырь № {i + 1}: ");
                ANames[0, i] = Console.ReadLine();
            }
            for (int i = 0; i < ANamesTitle.GetLength(0); i++)
            {
                Console.Write($"Введите название плитки под № {i + 1}: ");
                ANamesTitle[i, 0] = Console.ReadLine();
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"Введите количество {ANames[0, j]} для плитки {ANamesTitle [i, 0]} (кг.): ");
                    A[i, j] = Convert.ToDecimal(Console.ReadLine());
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                Console.Write($"Введите цену {ANames[0, i]} (руб.): ");
                B[i, 0] = Convert.ToDecimal(Console.ReadLine());
            }
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write($"Введите планируемы объем выпуска плитки {ANamesTitle[i, 0]} (в штуках): ");
                C[i] = Convert.ToDecimal(Console.ReadLine());
            }
            // Z CalculateTotalCostoOfMaterial (A, B, C, Z)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.GetLength(1); j++)
                        Z[i, 0] += A[i, j] * B[j, 0];
                decimal P = 0;
                for (int i = 0; i < Z.GetLength(0); i++)
                    P += C[i] * Z[i, 0];
                Console.WriteLine($"Общая стоимость сырья = {P:C2}");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_SalesReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Запросить и принять план продаж
            decimal plan;
            {
                Console.Write("Введите план продаж (в руб.): ");
                plan = Convert.ToDecimal(Console.ReadLine());
            }
            //2. Запросить и принять список фамилий продажников
            string[] surnameArray;
            {
                Console.WriteLine("Введите фамили сотрудников через запятую: ");
                string surnames = Console.ReadLine(); ;
                surnameArray = surnames.Split(',');
                for (int i = 0; i < surnameArray.Length; i++)
                    surnameArray[i] = surnameArray[i].Trim();
            }
            //3. Запросить и принять список сумм продаж для каждого продажкника
            decimal[][] jaggedArray;
            {
                jaggedArray = new decimal[surnameArray.Length][];
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    Console.WriteLine($"Введите через запятую суммы продаж которые совершил {surnameArray[i]}");
                    string sums = Console.ReadLine();
                    string[] sumsArray = sums.Split(',');
                    jaggedArray[i] = new decimal[sumsArray.Length];
                    for (int j = 0; j < sumsArray.Length; j++)
                    {
                        string sum = sumsArray[j].Trim();
                        jaggedArray[i][j] = Convert.ToDecimal(sum);
                    }
                }
            }
            //4. Формирование массива общих сумм продаж по каждому продажнику
            decimal[] totalsumsArray;
            {
                totalsumsArray = new decimal[jaggedArray.Length];
                for (int i = 0; i < totalsumsArray.Length; i++)
                {
                    decimal totalSum = 0;
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        totalSum += jaggedArray[i][j];
                    }
                    totalsumsArray[i] = totalSum;
                }
            }
            //5. Формирование массива общих сумм продаж по каждому продажнику
            {
                for (int i = 0; i < totalsumsArray.Length; i++)
                {
                    Console.Write($"{surnameArray[i]} продал товара на сумму {totalsumsArray[i]} руб. ");
                    decimal persent;
                    if (totalsumsArray[i] < plan)
                    {
                        persent = (plan - totalsumsArray[i]) / (plan / 100);
                        Console.WriteLine($"План недовыполнен на {persent} %");
                    }
                    else if (totalsumsArray[i] == plan)
                    {
                        Console.WriteLine($"План выполнен на 100%");
                    }
                    else if (totalsumsArray[i] > plan)
                    {
                        persent = (totalsumsArray[i] - plan) / (plan / 100);
                        Console.WriteLine($"План перевыполнен на {persent} %");
                    }
                }
            }
            //6. Формирование отчета о минимальной и максимальной продаже для каждого сейла
            {
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    Array.Sort(jaggedArray[i]);
                    int lastIndex = jaggedArray[i].Length - 1;
                    Console.WriteLine($"{surnameArray[i]}: Мин. продажа = {jaggedArray[i][0]}, Макс. продажа {jaggedArray[i][lastIndex]}");
                }
            }
            Console.ReadKey();
        }
    }
}

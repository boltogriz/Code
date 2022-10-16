using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_RawMaterialPlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            decimal plannedCostOfTiles1, plannedCostOfTiles2, plannedCostOfTiles3;
            {
                decimal sandForTail1 = 5, sandForTail2 = 3, sandForTail3 = 2;
                decimal clayForTail1 = 4, clayForTail2 = 7, clayForTail3 = 6;
                decimal sandPrice = 70, clayPrice = 50;
                decimal plannedVolumeOfTiles1 = 80, plannedVolumeOfTiles2 = 140, plannedVolumeOfTiles3 = 60;
                plannedCostOfTiles1 = (sandForTail1 * sandPrice + clayForTail1 * clayPrice) * plannedVolumeOfTiles1;
                plannedCostOfTiles2 = (sandForTail2 * sandPrice + clayForTail2 * clayPrice) * plannedVolumeOfTiles2;
                plannedCostOfTiles3 = (sandForTail3 * sandPrice + clayForTail3 * clayPrice) * plannedVolumeOfTiles3;

            }
            decimal totalCost = plannedCostOfTiles1 + plannedCostOfTiles2 + plannedCostOfTiles3;
            Console.WriteLine($"Общая стоимость сырья = {totalCost:C2}");

            Console.ReadKey();
        }
    }
}

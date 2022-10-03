using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_WinOpportunity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomTotalCost;
            {
                int roomLength = 5,
                    roomWidth = 4,
                    roomArea = roomLength * roomWidth,
                    parguetPrice = 5000,
                    layingParquetPrice = 600,
                    parquetCost = roomArea * parguetPrice,
                    layingParquetCost = roomArea * layingParquetPrice;
                roomTotalCost = parquetCost + layingParquetCost;
            }
            int kitchenTotalCost;
            {
                int kitchenLength = 4,
                    kitchenWidth = 3,
                    kitchenArea = kitchenLength * kitchenWidth,
                    tilePrice = 4000,
                    layingTilesPrice = 700,
                    tileCost = kitchenArea * tilePrice,
                    layingTilesCost = kitchenArea * layingTilesPrice;
                kitchenTotalCost = tileCost + layingTilesCost; 
            }
            int totalCost = roomTotalCost + kitchenTotalCost;

            Console.WriteLine(totalCost);
            Console.ReadKey();


        }
    }
}

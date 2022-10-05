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
                int roomArea;
                {
                    const int ROOM_LENGTH = 5, ROOM_WIDTH = 4;
                    roomArea = ROOM_LENGTH * ROOM_WIDTH;
                }
                int parquetCost;
                {
                    const int PARQUET_PRICE = 5000;
                    parquetCost = roomArea * PARQUET_PRICE;
                }
                int layingParquetCost;
                {
                    int layingParquetPrice = 600;
                    layingParquetCost = roomArea * layingParquetPrice;
                }
                roomTotalCost = parquetCost + layingParquetCost;
            }
            int kitchenTotalCost;
            {
                int kitchenArea;
                {
                    int kitchenLength = 4,
                        kitchenWidth = 3;
                    kitchenArea = kitchenLength * kitchenWidth;
                }
                int tileCost;
                {
                    int tilePrice = 4000;
                    tileCost = kitchenArea * tilePrice;
                }
                int layingTilesCost;
                {
                    int layingTilesPrice = 700;
                    layingTilesCost = kitchenArea * layingTilesPrice;
                }
                kitchenTotalCost = tileCost + layingTilesCost;
            }
            int totalCost = roomTotalCost + kitchenTotalCost;

            Console.WriteLine(totalCost);
            Console.ReadKey();


        }
    }
}

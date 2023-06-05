using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame();
            var maze = mazeGame.CreateMaze();

            string way;

            bool room1Done = false;
            bool room2Done = false;

            int numberRoom = 1;
            MapSite side;
            while (true)
            {   
                if (room1Done == false) 
                {
                    numberRoom = 1;
                    Console.WriteLine("Ты вошел в первую комнату");
                }
                room1Done = true;
                way = Console.ReadLine().ToString();
                switch (way)
                {
                    case "north":
                        maze.RoomNo(numberRoom).GetSide(Direction.North).Enter();
                        side = maze.RoomNo(numberRoom).GetSide(Direction.North);
                        if (side is Door)
                        {
                            room1Done = true;
                            numberRoom = 2;
                            Console.WriteLine("Ты вошел во вторую комнату");
                        }
                        break;
                    case "west":
                        maze.RoomNo(numberRoom).GetSide(Direction.West).Enter();
                        side = maze.RoomNo(numberRoom).GetSide(Direction.West);
                        if (side is Door)
                        {
                            room1Done = true;
                            numberRoom = 2;
                            Console.WriteLine("Ты вошел во вторую комнату");
                        }
                        break;
                    case "east":
                        maze.RoomNo(numberRoom).GetSide(Direction.East).Enter();
                        side = maze.RoomNo(numberRoom).GetSide(Direction.East);
                        if (side is Door)
                        {
                            room1Done = true;
                            numberRoom = 2;
                            Console.WriteLine("Ты вошел во вторую комнату");
                        }
                        break;
                    case "sourth":
                        maze.RoomNo(numberRoom).GetSide(Direction.South).Enter();
                        side = maze.RoomNo(numberRoom).GetSide(Direction.South);
                        if (side is Door)
                        {
                            room1Done = true;
                            numberRoom = 2;
                            Console.WriteLine("Ты вошел во вторую комнату");
                        }
                        break;
                    default:
                        break;

                }
            }

            Console.ReadKey();

        }
    }
}

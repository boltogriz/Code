using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExampl
{
    public readonly struct Coords
    {
        public Coords(int x, int y) 
        {
            X = x;
            Y = y;
        }
        public double X { get; }
        public double Y { get; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Coords coords = new Coords(10, 20);
            Coords coords2 = coords;

            Console.WriteLine(coords.ToString());
            Console.ReadKey();
        }
    }
}

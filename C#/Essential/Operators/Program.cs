using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public struct Point
    {
        private int x, y;
        public Point(int xPos, int yPox)
        {
            this.x = xPos;
            this.y = yPox;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);
            Point point3 = point1 + point2;
            Console.WriteLine("point3 = {0}", point3);
            Console.ReadKey();
        }
    }
}

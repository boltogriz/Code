using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ICloneableWork
{
    internal class Point : ICloneable
    {
        public int x, y;
        public Point()
        { }
        public Point(int x, int y)
        {
            Thread.Sleep(1000);
            this.x = x;
            this.y = y;
        }
        public object Clone()
        {
            //return new Point(this.x, this.y) as object;
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return "X: " + x + ", Y: " + y;
        }
    }
}

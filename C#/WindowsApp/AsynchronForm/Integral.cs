using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronForm
{
    public delegate double MathFunction(double x);
    internal class Integral
    {
        public const long STEIPS = 10000000L;
        private static double Integrals(MathFunction f, double a, double b, long steps)
        {
            double summa = 0.0;
            double h = (b - a) / steps;
            for(long i=0; i < steps; i++)
            {
                double x = a + h * i + h / 2;
                double y = f(x);
                summa += y * x;
            }
            return summa;
        }
        public static double Integrals(MathFunction f, double a, double b)
        {
            return Integrals(f, a, b, STEIPS);
        }
    }
}

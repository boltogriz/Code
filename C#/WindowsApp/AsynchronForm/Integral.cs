using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronForm
{
    public delegate double MathFunction(double x);
    public class Integral
    {
        private long currenStep;
        public long STEIPS = 100000000L;
        public long CurrenStep 
        {
            get { return currenStep; } 
        }
        private double Calculate(MathFunction f, double a, double b, long steps)
        {
            double summa = 0.0;
            double h = (b - a) / steps;
            for(currenStep = 0; currenStep < steps; currenStep++)
            {
                double x = a + h * currenStep + h / 2;
                double y = f(x);
                summa += y;
            }
            summa *= h;
            return summa;
        }
        public double Calculate(MathFunction f, double a, double b)
        {
            return Calculate(f, a, b, STEIPS);
        }
    }
}

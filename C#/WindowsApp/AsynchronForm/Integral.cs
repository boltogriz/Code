using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronForm
{
    public delegate double MathFunction(double x);
    public class Integral
    {
        private long currenStep;
        public long STEIPS = 100000000L;
        public double summaEnable;
        public long CurrenStep 
        {
            get { return currenStep; } 
        }
        private double Calculate(MathFunction f, double a, double b, BackgroundWorker worker, long steps)
        {
            long i = 0;
            double summa = 0.0;
            double h = (b - a) / steps;
            for(currenStep = 0; currenStep < steps; currenStep++)
            {
                double x = a + h * currenStep + h / 2;
                double y = f(x);
                summa += y;
                if (currenStep != 0 &&(currenStep == steps * 5 / 6 || currenStep == steps * 4 / 6 || currenStep == steps * 3 / 6 || currenStep == steps * 2 / 6 || currenStep == steps * 1 / 6 || currenStep + 1 == steps))
                {
                    i = ((currenStep + 1) / 10000000) * 10;
                    worker.ReportProgress((int)i);
                    //MessageBox.Show(((int)i).ToString());
                }
                if (worker.CancellationPending)
                {
                    summa = 0;
                    break;
                }

  


            }

            summa *= h;
            summaEnable = summa;

            return summa;
        }
        public double Calculate(MathFunction f, double a, double b, BackgroundWorker worker)
        {
            return Calculate(f, a, b, worker, STEIPS);
        }
    }
}

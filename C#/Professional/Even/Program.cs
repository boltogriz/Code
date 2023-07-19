using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Counter
    {
        public event EventHandler ThresholdReached;

        protected virtual void OnThresholdReached(EventArgs e) 
        { 
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, e);
        }
        public void Start(EventArgs arg) 
        { 
            OnThresholdReached(arg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            
            c.Start(EventArgs.Empty);

            Console.ReadKey();
        }

        private static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class GraficFunction : ScrollableControl
    {
        public delegate double MathFunctionDelegate(double x);
        public event MathFunctionDelegate Function;
        private double a, b;
        public double LowerBorder
        {
            get
            { return a; }
            set 
            { 
                a = value;
            }
        }
        public double UpperBorder
        {
            get
            { return b; }
            set
            {
                b = value;
            }
        }
        public GraficFunction()
        {
            InitializeComponent();

        }
        public GraficFunction(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        GraphicsPath gp;
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (Function != null)
            {
                Pen pen = new Pen(Color.Black);
                pe.Graphics.DrawPath(pen, gp);
            }

            base.OnPaint(pe);

        }
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            if (Function != null)
            {
                double w = this.UpperBorder - this.LowerBorder;
                double h = w / this.Width;
                gp = new GraphicsPath();
                double x0 = LowerBorder;
                double y0 = UpperBorder;
                double s = Width / w;
                for (int i = 1; i < this.Width; i++)
                {
                    double x = LowerBorder + h * i;
                    double y = Function(x);
                    gp.AddLine((int)(x0 * s), this.Height - (int)(y0 * s), (int)(x * s), this.Height - (int)(y * s));
                    x0 = x;
                    y0 = y;
                }
                

            }
            base.OnInvalidated(e);
        }
    }
}

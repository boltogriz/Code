using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCom
{
    public partial class NumeralTextBox : TextBox
    {
        public NumeralTextBox()
        {
            InitializeComponent();
            Value = 0;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public double Value
        {
            get
            {
                if(base.Text != "")
                    return double.Parse(base.Text);
                else
                    return 0.0;
            }
            set
            {
                base.Text = value.ToString();
            }
        }
        private double correctVale = 0.0;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            correctVale = Value;
            base.OnKeyDown(e);


        }
        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                double.Parse(base.Text);
                correctVale = Value;
            }
            catch(FormatException) 
            {
                Value = correctVale;
            }
            base.OnTextChanged(e);
        }
    }
}

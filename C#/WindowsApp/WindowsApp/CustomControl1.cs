using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    [ToolboxBitmap(typeof(CustomControl1), "Сеньор Помидор.png")]
    public partial class CustomControl1 : TextBox
    {
    
        public delegate void InvalidUserEntryEvent(object sender, EventArgs e);
        public event InvalidUserEntryEvent InvalidUserEntry;
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        protected virtual void OnInvalidUserEntry(KeyPressEventArgs e)
        {
            if (InvalidUserEntry != null)
            {
                InvalidUserEntry(this, e);
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            int asciiInteger = Convert.ToInt32(e.KeyChar);
            if (asciiInteger >= 47 && asciiInteger <= 57)
            {
                e.Handled = false;
                return;
            }
            if (asciiInteger == 8)
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
            OnInvalidUserEntry(e);
        }
        public int ValueNumber
        {
            get 
            {
                    return int.Parse(this.Text);
            }
            set
            {
                this.Text = value.ToString();
            }
        }
        public override string Text 
        { 
            get => base.Text;
            set 
            {
                try
                {
                    int.Parse(value);
                    base.Text = value;
                    return;
                }
                catch
                { }
                if (value == null)
                {
                    base.Text = value;
                    return;
                }
            }
        }
    }
}

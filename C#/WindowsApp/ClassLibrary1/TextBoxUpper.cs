using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    [ToolboxBitmap(typeof(TextBoxUpper), "abc.ico")]
    public partial class TextBoxUpper : TextBox
    {
        public TextBoxUpper()
        {
            InitializeComponent();
        }

        public TextBoxUpper(IContainer components)
        {
            components.Add(this);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char ch = e.KeyChar.ToString().ToUpper()[0];
            base.OnKeyPress(new KeyPressEventArgs(ch));
            this.Text = base.Text;
        }
        public override string Text 
        { 
            get => base.Text;
            set
            {
                if (value != null) 
                { 
                    base.Text = value.ToUpper();
                }
                else
                {
                    base.Text = value;
                }
            } 
        }


    }
}

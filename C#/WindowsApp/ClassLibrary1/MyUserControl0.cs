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
    public partial class MyUserControl0 : UserControl
    {
        [Category("Data")]
        public string TextBox2Text
        {
            get
            {
                return textBox2.Text;
            }
            set
            { 
                textBox2.Text = value;
            }
        }
        public MyUserControl0()
        {
            InitializeComponent();
        }
    }
}

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
    public partial class Form4 : Form
    {
        Form5 form5;
        MDIParent1 mdipParent1;
        public Form4()
        {
            InitializeComponent();
            mdipParent1 = new MDIParent1();
            mdipParent1.Show();
            form5 = new Form5();
            form5.MdiParent = mdipParent1;
            form5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form3 : WindowsApp.Form2
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.form2.Close();
            this.FormExit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MyCom;

namespace COMObject
{
    public partial class Form1 : Form
    {
        private ApplicationClass app;
        public Form1()
        {
            InitializeComponent();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            app = new ApplicationClass();
            app.Visible = true;
            label1.Text = app.Cells[1,3].ToString() ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (app != null)
            { 
                app.Quit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            MessageBox.Show(test.CalculateAverage(2, 3).ToString());
        }
    }
}

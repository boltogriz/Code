using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        public void FormExit() 
        {
            Dispose();   
        }

        public Form2()
        {
            InitializeComponent();
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //this.Close();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

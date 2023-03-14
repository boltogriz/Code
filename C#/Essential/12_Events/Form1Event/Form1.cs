using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Events.Form1Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка: " + sender.ToString(), "Чем нажали: " + e.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 Нажата кнопка: " + sender.ToString(), "Чем нажали: " + e.ToString());
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

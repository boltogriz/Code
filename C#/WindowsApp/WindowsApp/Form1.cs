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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
        static void FuncM()
        {
            MessageBox.Show("test");
        }
        static async Task Func()
        {
            Task task = Task.Factory.StartNew(FuncM);
            await task;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Task task = Task.Factory.StartNew(() => MessageBox.Show("Show"));
            var fun = Func();
        }
    }
}

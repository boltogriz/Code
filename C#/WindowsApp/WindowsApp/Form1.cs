using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace WindowsApp
{
    public partial class Form1 : Form
    {
        static public Form2 form2;
        

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            buttonShow.Click += ShowMessage;
      
        }
        private void ShowMessage(object send, EventArgs e)
        {
   
            MessageBox.Show(e.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            if (radioButton1.Checked)
                MessageBox.Show("Show");
            //form2.Show();
            //
            form2.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
        private void LocationComboBox(int x, int y)
        {
            comboBox1.Location = new System.Drawing.Point(x, y);
        }
        int key;
        private void MoveComboBox()
        {
            int x;
            int y;
            x = comboBox1.Location.X;
            y = comboBox1.Location.Y;
            switch (key)
            {
                case 37:
                    x--;
                    LocationComboBox(x, y);
                    break;
                case 38:
                    y--;
                    LocationComboBox(x, y);
                    break;
                case 39:
                    x++;
                    LocationComboBox(x, y);
                    break;
                case 40:
                    y++;
                    LocationComboBox(x, y);
                    break;
            }
        }
        


        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {

            key = e.KeyValue;
            timer1.Stop();
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveComboBox();

        }

        private void buttonShow_KeyDown(object sender, KeyEventArgs e)
        {

        }
       
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MoveComboBox();
            key = e.KeyValue;
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "X "+e.Location.X.ToString() + ", Y " + e.Location.Y.ToString();
            //MessageBox.Show(statusStrip1.Text);



        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

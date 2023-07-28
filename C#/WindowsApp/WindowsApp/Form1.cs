using System;
using System.CodeDom;
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
        private Form4 form4;
        private ListBoxMaker listBoxMaker;
        static public Form2 form2;
        private event EventHandler PushBotton;
        MyButton myButton = new MyButton();
        int y;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            buttonShow.Click += ShowMessage;
            PushBotton += FunctionPushBotton;
            PushBotton += AddItemList;
            listBoxMaker = new ListBoxMaker(listBox1);
            form4 = new Form4();
            y = myButton.Location.Y;
        }

        private void AddItemList(object sender, EventArgs e)
        {
            listBox1.Items.Add(sender.ToString());
            listBox1.Items.Add(e.ToString());
        }

        private void FunctionPushBotton(object sender, EventArgs e)
        {
            MessageBox.Show("Event");
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

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBoxMaker.Add(comboBox1);
            listBoxMaker.Add(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxMaker.Remove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnPushBotton(sender, e);
        }

        private void OnPushBotton(object obj, EventArgs e)
        {
            EventHandler handle = PushBotton;
            handle?.Invoke(obj, e);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add((string)e.Data.GetData(DataFormats.Text));


        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            Button myButton2 = new Button();
            myButton2.Location = new System.Drawing.Point(1, 300);

            myButton2.Name = "MyButton2";
            myButton2.Size = new System.Drawing.Size(112, 32);
            myButton2.TabIndex = 0;
            myButton2.Text = "MyButton2";
            myButton2.UseVisualStyleBackColor = true;
           
            this.Controls.Add(myButton2);
            this.Controls.Add(myButton);

            TextBox myText = new TextBox();
            myText.Location = new Point(25, 250);
            this.Controls.Add(myText);

            y += 29;

            this.Controls.Add(new MyButton(y));
            ResumeLayout();
        }
    }
}

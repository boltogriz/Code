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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value++;            
            if (progressBar2.Value < 100)
                progressBar2.Value++;
        }
        private void InitializeTimer()
        {
            timer1.Interval = 100;
            timer1.Start();
            timer1.Enabled = false;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security;

namespace AsynchronForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numeralTextBoxA.Value = 0.0;
            numeralTextBoxB.Value = Math.PI/2;
        }

        private Integral integral;
        private void buttonIntegral_Click(object sender, EventArgs e)
        {
            //Thread t = new Thread(new ThreadStart(IntegralCalculate));
            //t.Start();
            //Thread progressThrea = new Thread(new ThreadStart(ProgressThrea));
            //progressThrea.Start();

            //string r = await Task.Run(IntegralCalculate);
            //labelResult.Text = r;
            //int b = await Task.Run(ProgressThrea);
            //progressBar1.Value = 50;
            //var threadParameters = new System.Threading.ThreadStart(delegate { IntegralCalculate(); });
            //var thread2 = new Thread(threadParameters);
            //var thread3 = new Thread(ProgressThrea);
            //thread3.Start();
            // thread2.Start();
            var t1 = new Task(IntegralCalculate);
            var t2 = new Task(ProgressThrea);
 
            t1.Start();
            t2.Start();



        }
        private void ProgressThrea()
        {
            if (progressBar1.InvokeRequired) 
            {
                Action safeWrite = ProgressThrea;
                progressBar1.Invoke(safeWrite);
            }
            else 
            {
                while (progressBar1.Value < 100)
                {
                    //if (integral != null)
                    //{
                        progressBar1.Value += 10;
        

                    //}
                
                }
            }
        }
        private void IntegralCalculate()
        {
            if (labelResult.InvokeRequired) 
            {
                Action safeWrite = delegate { IntegralCalculate(); };
                labelResult.Invoke(safeWrite);
            }
            else
            {
                integral = new Integral();
                double r = integral.Calculate(new MathFunction(Math.Sin), numeralTextBoxA.Value, numeralTextBoxB.Value);
                labelResult.Text = r.ToString();
            }

        }

    }
}

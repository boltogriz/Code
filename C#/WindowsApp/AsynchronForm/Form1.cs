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
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;

        }

        private Integral integral;
        private async void buttonIntegral_Click(object sender, EventArgs e)
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
            //var t1 = new Task(IntegralCalculate);
            //var t2 = new Task(ProgressThrea);

            //t1.Start();
            //t2.Start();
            labelResult.Text = "___";

                if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();



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
            //if (labelResult.InvokeRequired) 
            //{
            //    Action safeWrite = delegate { IntegralCalculate(); };
            //    labelResult.Invoke(safeWrite);
            //}
            //else
            //{
            //    integral = new Integral();
            //    double r = integral.Calculate(new MathFunction(Math.Sin), numeralTextBoxA.Value, numeralTextBoxB.Value);
            //    labelResult.Text = r.ToString();
            //}
            integral = new Integral();
            //double r = integral.Calculate(new MathFunction(Math.Sin), numeralTextBoxA.Value, numeralTextBoxB.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                labelResult.Text = "Отмена";
                progressBar1.Value = 0;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true) 
            {
                e.Cancel = true;
            }
            else
            {
                integral = new Integral();
                //worker.ReportProgress(10);
                double r = integral.Calculate(new MathFunction(Math.Sin), numeralTextBoxA.Value, numeralTextBoxB.Value, worker);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelResult.Text = integral.summaEnable.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelResult.Text = integral.summaEnable.ToString();
            if (backgroundWorker1.WorkerSupportsCancellation == true)
                labelResult.Text = "Отменен Пользователем!!!!_";
            backgroundWorker1.WorkerSupportsCancellation = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage <= 100 && e.ProgressPercentage >= 0)
              progressBar1.Value = e.ProgressPercentage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace BackgroundWorkerSample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker _worker;
        int result;
        public MainWindow()
        {
            InitializeComponent();
            _worker = new BackgroundWorker();
            _worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            _worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;

        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Title = result.ToString();
            if (e.Cancelled)
                this.Title = "Cancelled";
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            result = 0;
            for (int i=0; i <= 100; i++)
            {
                Thread.Sleep(50);
                result += i;
                if (_worker.CancellationPending) 
                { 
                    e.Cancel = true;
                    return;
                }
                _worker.ReportProgress(i);
            }
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            _worker.CancelAsync();
        }
    }
}

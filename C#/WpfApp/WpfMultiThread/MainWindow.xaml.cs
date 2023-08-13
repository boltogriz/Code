using System;
using System.Collections.Generic;
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

namespace WpfMultiThread
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonNewThread_Click(object sender, RoutedEventArgs e)
        {
            Thread th = new Thread(UpdateTextWrong);
            th.Start();
        }
        string str;
        private void UpdateTextWrong()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            str = "Text";

            //txt.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (Action)delegate () { txt.Text = "Text"; });
            
            ThreadStart threadStart = new ThreadStart(WorkerMethod);
            this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, threadStart);

        }

        private void WorkerMethod()
        {
            txt.Text = str;
        }
    }
}

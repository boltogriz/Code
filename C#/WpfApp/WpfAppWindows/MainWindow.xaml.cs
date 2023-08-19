using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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

namespace WpfAppWindows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += new System.ComponentModel.CancelEventHandler(WindowMain_Closing);
            Left = Properties.Settings.Default.WindowsPosition.Left;
            Top = Properties.Settings.Default.WindowsPosition.Top;

            Width = Properties.Settings.Default.WindowsPosition.Width;
            Height = Properties.Settings.Default.WindowsPosition.Height;

            Title = Properties.Settings.Default.Title;
        }

        private void WindowMain_Closing(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.WindowsPosition = this.RestoreBounds;
            //Properties.Settings.Default.Title = Title;
            Properties.Settings.Default.Save();
        }

        private void buttonModalShow_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1("Модальный");
            window.ShowDialog();
        }

        private void buttonNoModalShow_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1("Немодальное");
            window.Show();
        }
    }
}

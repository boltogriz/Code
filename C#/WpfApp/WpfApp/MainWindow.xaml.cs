using System;
using System.Collections.Generic;
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

namespace WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели свое имя");
            }
            else
            {
                MessageBox.Show($"Привет, {textBoxName.Text}!");
            }
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Rectangle)
                (sender as Rectangle).Fill = Brushes.Yellow;
            else if (sender is TextBox)
                labelTitle.Content = "В фокусе";
        }

        private void Rectangle_MouseLeav(object sender, MouseEventArgs e)
        {
            if(sender is Rectangle)
                (sender as Rectangle).Fill = Brushes.SkyBlue;
            else if (sender is TextBox)
                labelTitle.Content = "Вне фокуса";
        }


    }
}

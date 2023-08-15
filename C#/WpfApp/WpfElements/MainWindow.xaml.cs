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

namespace WpfElements
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

        private void txtA_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void txtB_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void txtB_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (textBlockA == null)
            {
                return;
            }

             textBlockA.Text = String.Format(
                    "Выбрано с позиции {0}; количество символов -- {1}: текст --\"{2}\"",
                    txtB.SelectionStart,
                    txtB.SelectionLength,
                    txtB.SelectedText);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    sb.AppendLine(item.Content + " отмечен. ");
                }
            }
            textBlockA.Text = sb.ToString();
            Console.WriteLine("sdf");

        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("sdf");
            if(e.OriginalSource is CheckBox)
            {
                lst.SelectedItem = e.OriginalSource;
            }
            textBlockA.Text = String.Format("Позиция {0}. \r\n Состояние {1}", 
                lst.SelectedItem, ((CheckBox)lst.SelectedItem).IsChecked);
        }
    }
}

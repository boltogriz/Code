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

namespace WpfAppContent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(chk_Checked));
            AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(chk_Unchecked));
        }

        private void chk_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = e.OriginalSource as CheckBox;
            DependencyObject dpObj = LogicalTreeHelper.FindLogicalNode(stak, chk.Content.ToString());
            ((FrameworkElement)dpObj).Visibility = Visibility.Visible;
        }

        private void chk_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = e.OriginalSource as CheckBox;
            DependencyObject dpObj = LogicalTreeHelper.FindLogicalNode(stak, chk.Content.ToString());
            ((FrameworkElement)dpObj).Visibility = Visibility.Hidden;
        }

        private void chkLongText_Checked(object sender, RoutedEventArgs e)
        {
            cmdPrev.Content = "<-----";
            cmdNext.Content = "----->";
        }

        private void chkLongText_Unchecked(object sender, RoutedEventArgs e)
        {
            cmdPrev.Content = "Назад";
            cmdNext.Content = "Вперед";
        }

        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

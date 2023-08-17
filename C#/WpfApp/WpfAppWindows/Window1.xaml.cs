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
using System.Windows.Shapes;

namespace WpfAppWindows
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ListItemAction listItemAction;

        public Window1()
        {
            InitializeComponent();
            listItemAction = (ListItemAction)this.Resources["listItemAction1"];
            listItemAction.addItem("initial");
        }
        public Window1(string str)
        {
            InitializeComponent();
            listItemAction = (ListItemAction)this.Resources["listItemAction1"];
            listItemAction.addItem("initial");
        }

        private void Window_Activated(object sender, EventArgs e)
        {



        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}

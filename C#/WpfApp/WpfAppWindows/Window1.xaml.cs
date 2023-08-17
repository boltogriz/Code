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
        }
        public Window1(string str)
            : this()
        {
            listItemAction = (ListItemAction)this.Resources["listItemAction1"];
            Title = str;
            listItemAction.ItemAction[0] = "Init";
            listBox2.Items.Add("III");
            listBox2.Height = 50;
            //listBox2.Items.Add("InitializaComponent");
            //listBox.ItemsSource = listItemAction.ItemAction;
            MessageBox.Show(listBox2.Items[0].ToString());
        }

        private void Window_Activated(object sender, EventArgs e)
        {

            listItemAction.ItemAction[1] = "act4444";
            //listBox2.Items.Add("Activated");
            listItemAction.Str = "Act";
            listBox2.Items.Add("III");

        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            listItemAction.ItemAction[2] = "act444dddd4";
            //listBox2.Items.Add("GotFocus");
            listItemAction.Str = "Fou";
            listBox2.Items.Add("III");
        }
    }
}

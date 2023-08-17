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
            listItemAction.ItemAction.Add("InitializaComponent");
            //listBox.ItemsSource = listItemAction.ItemAction;
            //MessageBox.Show(listItemAction.ItemAction[0].ToString());
            //MessageBox.Show(listBox.Items[0].ToString());
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            listItemAction.ItemAction.Add("Activated");
        }
    }
}

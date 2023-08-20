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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += new ExecutedRoutedEventHandler(binding_Executed);
            this.CommandBindings.Add(binding);
        }

        private void binding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New");
        }        
        private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open");
        }
    }
}

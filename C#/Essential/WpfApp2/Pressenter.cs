using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Pressenter
    {
        Model model;
        MainWindow mainWindow;
        public Pressenter (MainWindow mainWindow)
        { 
            model = new Model ();
            this.mainWindow = mainWindow;
            this.mainWindow.someEvent += MainWindow_someEvent;
        }

        private void MainWindow_someEvent(object? sender, EventArgs e)
        {
            this.mainWindow.textBlox1.Text = model.SomeMethod(this.mainWindow.textBlox1.Text);
        }
    }
}

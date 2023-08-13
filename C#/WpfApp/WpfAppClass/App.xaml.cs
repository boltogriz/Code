using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppClass
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private List<Document> documents = new List<Document>();
        public List<Document> Documents
        {
            get { return documents; }
            set { documents = value; }
        }
        public App()
        {
            this.Startup += new StartupEventHandler(App_Startup);
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            Debug.WriteLine("----> StarUP");
        }
        protected override void OnActivated(EventArgs e)
        {
            Debug.WriteLine("----> OnActivated");
        }
    }
}

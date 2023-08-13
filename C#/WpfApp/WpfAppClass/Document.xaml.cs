﻿using System;
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

namespace WpfAppClass
{
    /// <summary>
    /// Логика взаимодействия для Document.xaml
    /// </summary>
    public partial class Document : Window
    {
        public Document()
        {
            InitializeComponent();
        }
        public void SetContent(string content) 
        { 
            this.Content = content;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            (Application.Current as App).Documents.Remove(this);
        }
    }
}

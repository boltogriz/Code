using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppProperty
{
    internal class MyFirstControl : FrameworkElement
    {
        public static DependencyProperty DataProperty;

        static MyFirstControl()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(MyFirstControl));

        }
        public int Data
        {
            get
            {
                return (int)GetValue(DataProperty);
            }
            set 
            { 
                SetValue(DataProperty, value); 
            }
        }





    }
}

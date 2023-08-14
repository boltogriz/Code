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
    internal class MySecondControl : FrameworkElement
    {

        public static DependencyProperty DataPropertyStr;
        static MySecondControl()
        {

            DataPropertyStr = DependencyProperty.Register("DataStr", typeof(string), typeof(MySecondControl));
        }

        public string DataStr
        {
            get
            {
                return (string)GetValue(DataPropertyStr);
            }
            set
            {
                SetValue(DataPropertyStr, value);
            }
        }

        public string StringValue { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppWindows
{
    internal class ListItemAction : INotifyPropertyChanged
    {
        public List<string> itemAction = new List<string>();

        public List<string> addItem(string str)
        {
            itemAction.Add(str);
            OnPropertyChanced("itemAction");
            return itemAction;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanced([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}

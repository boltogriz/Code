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
        private string[] itemAction = new string[10];
        public string str = "sfsdf";
        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
                OnPropertyChanced("Str");
            }
        }
        public string[] ItemAction 
        { 
            get 
            {  
                return itemAction; 
            } 
            set 
            {
                str = this.itemAction[0].ToLower();
                itemAction = value;
                OnPropertyChanced("ItemAction");
            } 
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

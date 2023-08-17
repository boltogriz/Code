using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWindows
{
    internal class ListItemAction : INotifyCollectionChanged
    {
        public List<string> itemAction = new List<string>();
        public List<string> ItemAction { get {  return itemAction; } set { itemAction = value; } }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void OnPropertyChanced([CallerMemberName] string prop = "")
        {

        }
    }
}

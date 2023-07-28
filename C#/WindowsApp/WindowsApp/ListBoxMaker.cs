using System;
using System.Windows.Forms;

namespace WindowsApp
{
    internal class ListBoxMaker
    {
        private ListBox listBox1;

        public ListBoxMaker(ListBox listBox1)
        {
            this.listBox1 = listBox1;
        }
        /// <summary>
        /// в listbox добавляет значение из combobox
        /// </summary>
        /// <param name="comboBox1">добавит в лист</param>
        internal void Add(ComboBox comboBox1)
        {
            if (comboBox1.SelectedItem != null && comboBox1.Items[comboBox1.SelectedIndex].ToString() != "")
                listBox1.Items.Add(comboBox1.SelectedItem);
        }

        internal void Add(TextBox textBox1)
        {
            if (textBox1.Text != "")
                listBox1.Items.Add((string)textBox1.Text);
        }

        internal void Remove()
        {
            if (listBox1.Items.Count - 1 >= 0 && listBox1.SelectedItem == null)
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
            }
            else if (listBox1.Items.Count - 1 >= 0 && listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            }
        }
    }
}
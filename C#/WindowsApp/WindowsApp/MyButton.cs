using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    internal class MyButton : Button
    {
        public MyButton()
        {

            Location = new System.Drawing.Point(8, 330);
            Name = "ByButton";
            Size = new System.Drawing.Size(84, 29);
            TabIndex = 14;
            Text = "myButton";
            UseVisualStyleBackColor = true;
        }
        public MyButton(int y)
            : this()
        {
            Location = new System.Drawing.Point(this.Location.X, y);
            Text = "myB" + y.ToString();
        }
    }
}

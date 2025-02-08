using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatcherMessageBox
{
    public class NonBlockingMessageBox : Form
    {
        private Label messageLabel;
        private Button okButton;

        public NonBlockingMessageBox(string message, string title)
        {
            this.Text = title;
            this.Size = new System.Drawing.Size(300, 150);

            messageLabel = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            okButton = new Button
            {
                Text = "OK",
                Dock = DockStyle.Bottom
            };

            okButton.Click += (sender, e) => this.Close();

            this.Controls.Add(messageLabel);
            this.Controls.Add(okButton);
        }

        public static void ShowNonBlocking(string message, string title)
        {
            var messageBox = new NonBlockingMessageBox(message, title);
            messageBox.Show();
        }
    }
}

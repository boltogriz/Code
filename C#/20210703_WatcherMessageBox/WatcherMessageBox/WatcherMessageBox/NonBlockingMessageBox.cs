using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatcherMessageBox
{
    public class NonBlockingMessageBox : Form
    {
        private Label messageLabel;
        private Button okButton;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x08000000; // WS_EX_NOACTIVATE
                return createParams;
            }
        }

        public NonBlockingMessageBox(string message, string title)
        {
            Text = title;
            Size = new System.Drawing.Size(300, 150);
            StartPosition = FormStartPosition.CenterScreen;

            messageLabel = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            TopMost = true;

            okButton = new Button
            {
                Text = "OK",
                Dock = DockStyle.Bottom
            };

            okButton.Click += (sender, e) => this.Close();

            Controls.Add(messageLabel);
            Controls.Add(okButton);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.Activate(); // Активируем форму при клике мышью
        }

        // Добавляем метод для обработки потери фокуса, 
        // чтобы форма оставалась поверх окон даже при потере фокуса
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.TopMost = true;
        }
    }
}

using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class CustomMessageBox : Form
{
    private Label labelMessage;
    private Button buttonOK;

    public CustomMessageBox(string message, string title)
    {
        // Настройка формы
        this.Text = title;
        this.Size = new Size(300, 150);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.Manual;
        this.Icon = WatcherMessageBox.Properties.Resources.icons8_mail_48s;

        // Позиционирование формы в нижнем правом углу экрана
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        this.Location = new Point(screen.Right - this.Width, screen.Bottom - this.Height);

        // Создание и настройка Label для отображения сообщения
        labelMessage = new Label();
        labelMessage.Text = message;
        labelMessage.AutoSize = false;
        labelMessage.TextAlign = ContentAlignment.MiddleCenter;
        labelMessage.Dock = DockStyle.Fill;;

        // Создание и настройка кнопки OK
        buttonOK = new Button();
        buttonOK.Text = "OK";
        buttonOK.DialogResult = DialogResult.OK;
        buttonOK.Dock = DockStyle.Bottom;
        
        buttonOK.Click += (sender, e) => this.Close();

        


        // Добавление элементов управления на форму
        this.Controls.Add(labelMessage);
        this.Controls.Add(buttonOK);
    }

    // Переопределение метода, чтобы окно не активировалось
    protected override bool ShowWithoutActivation => true;


    public static void Show(string message, string title)
    {
        CustomMessageBox customMessageBox = new CustomMessageBox(message, title);
        customMessageBox.Show();
        customMessageBox.TopMost = true;
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.SuspendLayout();
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.ResumeLayout(false);

    }
}

// Использование CustomMessageBox

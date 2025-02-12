using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class CustomMessageBox : Form
{
    private Label labelMessage;
    private Button buttonOK;

    private bool _disposed = false;
    private IntPtr _handle;

    // Win32 API константы и импорты
    private const int GWL_EXSTYLE = -20;
    private const int WS_EX_NOACTIVATE = 0x08000000;
    private const int WS_EX_TOPMOST = 0x00000008;

    [DllImport("user32.dll")]
    private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    private const uint SWP_NOACTIVATE = 0x0010;
    private const uint SWP_NOMOVE = 0x0002;
    private const uint SWP_NOSIZE = 0x0001;

    public CustomMessageBox(string message, string title)
    {
        // Устанавливаем стили окна
        int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
        exStyle |= WS_EX_NOACTIVATE | WS_EX_TOPMOST;
        SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);

        // Гарантированно устанавливаем поверх всех окон без активации
        SetWindowPos(
            this.Handle,
            HWND_TOPMOST,
            0, 0, 0, 0,
            SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE
        );

        this.TopMost = true;

        // Настройка формы
        this.Text = title;
        this.Size = new Size(300, 150);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.Manual;
        this.Icon = WatcherMessageBox.Properties.Resources.icons8_mail_48s;

        this.Load += Form1_Load;
        this.FormClosing += Form1_FormClosing;

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
        buttonOK.TabStop = false;
        buttonOK.Select();
        
        buttonOK.Click += (sender, e) => this.Close();

        // Добавление элементов управления на форму
        this.Controls.Add(labelMessage);
        this.Controls.Add(buttonOK);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _handle = this.Handle;
        // ... остальной код из Load
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= WS_EX_NOACTIVATE | WS_EX_TOPMOST;
            return cp;
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Освобождаем ресурсы при закрытии формы
        Dispose(true);
    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Освобождаем управляемые ресурсы
                //if (components != null)
                //{
                    //components.Dispose();
                //}

                // Отписываемся от событий
                this.Load -= Form1_Load;
                this.FormClosing -= Form1_FormClosing;
            }

            // Освобождаем неуправляемые ресурсы
            if (_handle != IntPtr.Zero)
            {
                SetWindowLong(_handle, GWL_EXSTYLE, GetWindowLong(_handle, GWL_EXSTYLE) & ~(WS_EX_NOACTIVATE | WS_EX_TOPMOST));
                _handle = IntPtr.Zero;
            }

            _disposed = true;
        }

        base.Dispose(disposing);
    }

    // Переопределение метода, чтобы окно не активировалось
    protected override bool ShowWithoutActivation => true;


    public static void Show(string message, string title)
    {
        CustomMessageBox customMessageBox = new CustomMessageBox(message, title);
        customMessageBox.Show();
        // Повторно применяем настройки после показа
        SetWindowPos(
            customMessageBox.Handle,
            HWND_TOPMOST,
            0, 0, 0, 0,
            SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE
        );
    }
}

// Использование CustomMessageBox

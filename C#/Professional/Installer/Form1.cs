using System.Configuration.Install;
using System.ServiceProcess;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Installer
{
    public partial class Form1 : Form
    {
        private ServiceController controller;
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Install_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Выберите файл с NT-службой");
            }
            else
            {
                try
                {
                    ManagedInstallerClass.InstallHelper(new string[] { openFileDialog1.FileName });
                    MessageBox.Show("Сервис " + openFileDialog1.SafeFileName + " установлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Uninstal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Выберите файл с NT-службой");
            }
            else
            {
                try
                {
                    ManagedInstallerClass.InstallHelper(new string[] { @"/u", openFileDialog1.FileName });
                    MessageBox.Show("Сервис " + openFileDialog1.SafeFileName + " деинсталирован!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "[===== TEST SERVICE ======]";
                controller.Start();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
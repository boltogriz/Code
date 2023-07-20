using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Configuration.Install;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private ServiceController controller;
        public Form1()
        {
            InitializeComponent();
        }









        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "[===== TEST SERVICE ======]";
                controller.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Browse_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Install_Click_1(object sender, EventArgs e)
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

        private void Unistal_Click(object sender, EventArgs e)
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

        private void Start_Click_1(object sender, EventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "[===== TEST SERVICE ======]";
                controller.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

namespace Installer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            Browse = new Button();
            Install = new Button();
            Uninstal = new Button();
            Start = new Button();
            Stop = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 0;
            // 
            // Browse
            // 
            Browse.Location = new Point(243, 12);
            Browse.Name = "Browse";
            Browse.Size = new Size(75, 23);
            Browse.TabIndex = 1;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // Install
            // 
            Install.Location = new Point(12, 55);
            Install.Name = "Install";
            Install.Size = new Size(75, 23);
            Install.TabIndex = 2;
            Install.Text = "Install";
            Install.UseVisualStyleBackColor = true;
            Install.Click += Install_Click;
            // 
            // Uninstal
            // 
            Uninstal.Location = new Point(134, 55);
            Uninstal.Name = "Uninstal";
            Uninstal.Size = new Size(75, 23);
            Uninstal.TabIndex = 3;
            Uninstal.Text = "Uninstall";
            Uninstal.UseVisualStyleBackColor = true;
            Uninstal.Click += Uninstal_Click;
            // 
            // Start
            // 
            Start.Location = new Point(12, 96);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 4;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(134, 96);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 5;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 144);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(Uninstal);
            Controls.Add(Install);
            Controls.Add(Browse);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "ServiceIU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Browse;
        private Button Install;
        private Button Uninstal;
        private Button Start;
        private Button Stop;
        private OpenFileDialog openFileDialog1;
    }
}
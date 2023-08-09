namespace AsynchronForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numeralTextBoxA = new MyCom.NumeralTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeralTextBoxB = new MyCom.NumeralTextBox();
            this.buttonIntegral = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeralTextBoxA
            // 
            resources.ApplyResources(this.numeralTextBoxA, "numeralTextBoxA");
            this.numeralTextBoxA.Name = "numeralTextBoxA";
            this.numeralTextBoxA.Value = 0D;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numeralTextBoxB
            // 
            resources.ApplyResources(this.numeralTextBoxB, "numeralTextBoxB");
            this.numeralTextBoxB.Name = "numeralTextBoxB";
            this.numeralTextBoxB.Value = 0D;
            // 
            // buttonIntegral
            // 
            resources.ApplyResources(this.buttonIntegral, "buttonIntegral");
            this.buttonIntegral.Name = "buttonIntegral";
            this.buttonIntegral.UseVisualStyleBackColor = true;
            this.buttonIntegral.Click += new System.EventHandler(this.buttonIntegral_Click);
            // 
            // labelResult
            // 
            resources.ApplyResources(this.labelResult, "labelResult");
            this.labelResult.Name = "labelResult";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonIntegral);
            this.Controls.Add(this.numeralTextBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeralTextBoxA);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCom.NumeralTextBox numeralTextBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyCom.NumeralTextBox numeralTextBoxB;
        private System.Windows.Forms.Button buttonIntegral;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}


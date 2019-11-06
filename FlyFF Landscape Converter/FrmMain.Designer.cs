namespace FlyFF_Landscape_Converter
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.btnBrowseInput);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 47);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(410, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(347, 19);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 8;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(91, 21);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(250, 20);
            this.txtInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // resultImage
            // 
            this.resultImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultImage.Location = new System.Drawing.Point(3, 16);
            this.resultImage.Name = "resultImage";
            this.resultImage.Size = new System.Drawing.Size(425, 232);
            this.resultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultImage.TabIndex = 0;
            this.resultImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.btnBrowseOutput);
            this.groupBox3.Controls.Add(this.txtOutput);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Export";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(410, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(347, 19);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 11;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(99, 21);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(242, 20);
            this.txtOutput.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Directory";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(300, 16);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 465);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlyFF Landscape Converter";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox resultImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
    }
}


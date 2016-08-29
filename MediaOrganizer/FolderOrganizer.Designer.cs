namespace MediaOrganizer
{
    partial class FolderOrganizer
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmd_openOriginPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmd_openDestinationPath = new System.Windows.Forms.Button();
            this.cmd_process = new System.Windows.Forms.Button();
            this.chb_moveFiles = new System.Windows.Forms.CheckBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prg_progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_openOriginPath
            // 
            this.cmd_openOriginPath.Location = new System.Drawing.Point(622, 35);
            this.cmd_openOriginPath.Name = "cmd_openOriginPath";
            this.cmd_openOriginPath.Size = new System.Drawing.Size(75, 23);
            this.cmd_openOriginPath.TabIndex = 0;
            this.cmd_openOriginPath.Text = "Open...";
            this.cmd_openOriginPath.UseVisualStyleBackColor = true;
            this.cmd_openOriginPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(516, 20);
            this.textBox2.TabIndex = 2;
            // 
            // cmd_openDestinationPath
            // 
            this.cmd_openDestinationPath.Location = new System.Drawing.Point(622, 61);
            this.cmd_openDestinationPath.Name = "cmd_openDestinationPath";
            this.cmd_openDestinationPath.Size = new System.Drawing.Size(75, 23);
            this.cmd_openDestinationPath.TabIndex = 3;
            this.cmd_openDestinationPath.Text = "Open...";
            this.cmd_openDestinationPath.UseVisualStyleBackColor = true;
            this.cmd_openDestinationPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_process
            // 
            this.cmd_process.Location = new System.Drawing.Point(622, 106);
            this.cmd_process.Name = "cmd_process";
            this.cmd_process.Size = new System.Drawing.Size(75, 23);
            this.cmd_process.TabIndex = 4;
            this.cmd_process.Text = "Process!";
            this.cmd_process.UseVisualStyleBackColor = true;
            this.cmd_process.Click += new System.EventHandler(this.button3_Click);
            // 
            // chb_moveFiles
            // 
            this.chb_moveFiles.AutoSize = true;
            this.chb_moveFiles.Location = new System.Drawing.Point(533, 110);
            this.chb_moveFiles.Name = "chb_moveFiles";
            this.chb_moveFiles.Size = new System.Drawing.Size(83, 17);
            this.chb_moveFiles.TabIndex = 5;
            this.chb_moveFiles.Text = "Move Files?";
            this.chb_moveFiles.UseVisualStyleBackColor = true;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(9, 19);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(696, 203);
            this.txt_log.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Origin Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination Path:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmd_process);
            this.groupBox1.Controls.Add(this.chb_moveFiles);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmd_openOriginPath);
            this.groupBox1.Controls.Add(this.cmd_openDestinationPath);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_log);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 229);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prg_progressBar);
            this.groupBox3.Location = new System.Drawing.Point(12, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 55);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // prg_progressBar
            // 
            this.prg_progressBar.Location = new System.Drawing.Point(9, 19);
            this.prg_progressBar.Name = "prg_progressBar";
            this.prg_progressBar.Size = new System.Drawing.Size(696, 23);
            this.prg_progressBar.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "FolderOrganizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cmd_openOriginPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cmd_process;
        private System.Windows.Forms.CheckBox chb_moveFiles;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button cmd_openDestinationPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar prg_progressBar;
    }
}
namespace MediaOrganizer
{
    partial class DateDiffCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_initialDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_realDate = new System.Windows.Forms.DateTimePicker();
            this.cmd_calculate = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_testDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Date:";
            // 
            // dtp_initialDate
            // 
            this.dtp_initialDate.Location = new System.Drawing.Point(85, 19);
            this.dtp_initialDate.Name = "dtp_initialDate";
            this.dtp_initialDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_initialDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Real Date:";
            // 
            // dtp_realDate
            // 
            this.dtp_realDate.Location = new System.Drawing.Point(85, 50);
            this.dtp_realDate.Name = "dtp_realDate";
            this.dtp_realDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_realDate.TabIndex = 3;
            // 
            // cmd_calculate
            // 
            this.cmd_calculate.Location = new System.Drawing.Point(210, 97);
            this.cmd_calculate.Name = "cmd_calculate";
            this.cmd_calculate.Size = new System.Drawing.Size(75, 23);
            this.cmd_calculate.TabIndex = 4;
            this.cmd_calculate.Text = "Calculate";
            this.cmd_calculate.UseVisualStyleBackColor = true;
            this.cmd_calculate.Click += new System.EventHandler(this.cmd_calculate_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(210, 126);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(75, 20);
            this.txt_result.TabIndex = 5;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_testDate);
            this.groupBox1.Controls.Add(this.dtp_initialDate);
            this.groupBox1.Controls.Add(this.txt_result);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmd_calculate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_realDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // lbl_testDate
            // 
            this.lbl_testDate.AutoSize = true;
            this.lbl_testDate.Location = new System.Drawing.Point(8, 129);
            this.lbl_testDate.Name = "lbl_testDate";
            this.lbl_testDate.Size = new System.Drawing.Size(47, 13);
            this.lbl_testDate.TabIndex = 6;
            this.lbl_testDate.Text = "testDate";
            // 
            // DateDiffCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 182);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DateDiffCalculator";
            this.Text = "DateDiffCalculator";
            this.Load += new System.EventHandler(this.DateDiffCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_initialDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_realDate;
        private System.Windows.Forms.Button cmd_calculate;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_testDate;
    }
}
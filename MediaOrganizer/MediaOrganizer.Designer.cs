﻿namespace MediaOrganizer
{
    partial class MediaOrganizer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaOrganizer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trv_folders = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lsv_files = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmd_openPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dtp_newDate = new System.Windows.Forms.DateTimePicker();
            this.cmd_changeDate = new System.Windows.Forms.Button();
            this.chb_overwrite = new System.Windows.Forms.CheckBox();
            this.chb_createdDate = new System.Windows.Forms.CheckBox();
            this.chb_modifiedDate = new System.Windows.Forms.CheckBox();
            this.chb_accesedDate = new System.Windows.Forms.CheckBox();
            this.chb_takenDate = new System.Windows.Forms.CheckBox();
            this.txt_filenamePattern = new System.Windows.Forms.TextBox();
            this.chb_filenameDate = new System.Windows.Forms.CheckBox();
            this.txt_filenameSubstring = new System.Windows.Forms.TextBox();
            this.lbl_filenameDatePreview = new System.Windows.Forms.Label();
            this.cmb_otherDate = new System.Windows.Forms.ComboBox();
            this.chb_dateFromOther = new System.Windows.Forms.CheckBox();
            this.cmd_folderOrganizer = new System.Windows.Forms.Button();
            this.pic_imagePreview = new System.Windows.Forms.PictureBox();
            this.cmb_drives = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagePreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 111);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trv_folders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsv_files);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 570);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // trv_folders
            // 
            this.trv_folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_folders.ImageIndex = 0;
            this.trv_folders.ImageList = this.imageList1;
            this.trv_folders.Location = new System.Drawing.Point(0, 0);
            this.trv_folders.Name = "trv_folders";
            this.trv_folders.SelectedImageIndex = 0;
            this.trv_folders.Size = new System.Drawing.Size(300, 570);
            this.trv_folders.TabIndex = 0;
            this.trv_folders.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "education-folder-icon-23346-16x16.ico");
            this.imageList1.Images.SetKeyName(1, "copy-icon-4771-16x16.ico");
            this.imageList1.Images.SetKeyName(2, "1472216525_image.ico");
            this.imageList1.Images.SetKeyName(3, "1472216473_youtube.ico");
            this.imageList1.Images.SetKeyName(4, "1472216538_12.File.ico");
            // 
            // lsv_files
            // 
            this.lsv_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsv_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_files.FullRowSelect = true;
            this.lsv_files.Location = new System.Drawing.Point(0, 0);
            this.lsv_files.Name = "lsv_files";
            this.lsv_files.Size = new System.Drawing.Size(960, 570);
            this.lsv_files.SmallImageList = this.imageList1;
            this.lsv_files.TabIndex = 0;
            this.lsv_files.UseCompatibleStateImageBehavior = false;
            this.lsv_files.View = System.Windows.Forms.View.Details;
            this.lsv_files.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.lsv_files.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.lsv_files.DoubleClick += new System.EventHandler(this.lsv_files_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Created Date";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Modified Date";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Taken Date";
            // 
            // cmd_openPath
            // 
            this.cmd_openPath.Location = new System.Drawing.Point(70, 16);
            this.cmd_openPath.Name = "cmd_openPath";
            this.cmd_openPath.Size = new System.Drawing.Size(75, 23);
            this.cmd_openPath.TabIndex = 1;
            this.cmd_openPath.Text = "Open...";
            this.cmd_openPath.UseVisualStyleBackColor = true;
            this.cmd_openPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_newDate
            // 
            this.dtp_newDate.Location = new System.Drawing.Point(6, 19);
            this.dtp_newDate.Name = "dtp_newDate";
            this.dtp_newDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_newDate.TabIndex = 2;
            // 
            // cmd_changeDate
            // 
            this.cmd_changeDate.Location = new System.Drawing.Point(213, 19);
            this.cmd_changeDate.Name = "cmd_changeDate";
            this.cmd_changeDate.Size = new System.Drawing.Size(115, 23);
            this.cmd_changeDate.TabIndex = 3;
            this.cmd_changeDate.Text = "Change!";
            this.cmd_changeDate.UseVisualStyleBackColor = true;
            this.cmd_changeDate.Click += new System.EventHandler(this.cmd_ChangeDate_Click);
            // 
            // chb_overwrite
            // 
            this.chb_overwrite.AutoSize = true;
            this.chb_overwrite.Location = new System.Drawing.Point(6, 22);
            this.chb_overwrite.Name = "chb_overwrite";
            this.chb_overwrite.Size = new System.Drawing.Size(77, 17);
            this.chb_overwrite.TabIndex = 4;
            this.chb_overwrite.Text = "Overwrite?";
            this.chb_overwrite.UseVisualStyleBackColor = true;
            // 
            // chb_createdDate
            // 
            this.chb_createdDate.AutoSize = true;
            this.chb_createdDate.Location = new System.Drawing.Point(6, 19);
            this.chb_createdDate.Name = "chb_createdDate";
            this.chb_createdDate.Size = new System.Drawing.Size(89, 17);
            this.chb_createdDate.TabIndex = 5;
            this.chb_createdDate.Text = "Created Date";
            this.chb_createdDate.UseVisualStyleBackColor = true;
            // 
            // chb_modifiedDate
            // 
            this.chb_modifiedDate.AutoSize = true;
            this.chb_modifiedDate.Location = new System.Drawing.Point(6, 36);
            this.chb_modifiedDate.Name = "chb_modifiedDate";
            this.chb_modifiedDate.Size = new System.Drawing.Size(92, 17);
            this.chb_modifiedDate.TabIndex = 6;
            this.chb_modifiedDate.Text = "Modified Date";
            this.chb_modifiedDate.UseVisualStyleBackColor = true;
            // 
            // chb_accesedDate
            // 
            this.chb_accesedDate.AutoSize = true;
            this.chb_accesedDate.Location = new System.Drawing.Point(6, 53);
            this.chb_accesedDate.Name = "chb_accesedDate";
            this.chb_accesedDate.Size = new System.Drawing.Size(94, 17);
            this.chb_accesedDate.TabIndex = 7;
            this.chb_accesedDate.Text = "Accesed Date";
            this.chb_accesedDate.UseVisualStyleBackColor = true;
            // 
            // chb_takenDate
            // 
            this.chb_takenDate.AutoSize = true;
            this.chb_takenDate.Location = new System.Drawing.Point(6, 71);
            this.chb_takenDate.Name = "chb_takenDate";
            this.chb_takenDate.Size = new System.Drawing.Size(83, 17);
            this.chb_takenDate.TabIndex = 8;
            this.chb_takenDate.Text = "Taken Date";
            this.chb_takenDate.UseVisualStyleBackColor = true;
            // 
            // txt_filenamePattern
            // 
            this.txt_filenamePattern.Location = new System.Drawing.Point(6, 45);
            this.txt_filenamePattern.Name = "txt_filenamePattern";
            this.txt_filenamePattern.Size = new System.Drawing.Size(87, 20);
            this.txt_filenamePattern.TabIndex = 9;
            // 
            // chb_filenameDate
            // 
            this.chb_filenameDate.AutoSize = true;
            this.chb_filenameDate.Location = new System.Drawing.Point(213, 47);
            this.chb_filenameDate.Name = "chb_filenameDate";
            this.chb_filenameDate.Size = new System.Drawing.Size(120, 17);
            this.chb_filenameDate.TabIndex = 10;
            this.chb_filenameDate.Text = "Get From Filename?";
            this.chb_filenameDate.UseVisualStyleBackColor = true;
            // 
            // txt_filenameSubstring
            // 
            this.txt_filenameSubstring.Location = new System.Drawing.Point(99, 45);
            this.txt_filenameSubstring.Name = "txt_filenameSubstring";
            this.txt_filenameSubstring.Size = new System.Drawing.Size(35, 20);
            this.txt_filenameSubstring.TabIndex = 11;
            // 
            // lbl_filenameDatePreview
            // 
            this.lbl_filenameDatePreview.AutoSize = true;
            this.lbl_filenameDatePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filenameDatePreview.Location = new System.Drawing.Point(138, 53);
            this.lbl_filenameDatePreview.Name = "lbl_filenameDatePreview";
            this.lbl_filenameDatePreview.Size = new System.Drawing.Size(11, 9);
            this.lbl_filenameDatePreview.TabIndex = 12;
            this.lbl_filenameDatePreview.Text = "...";
            // 
            // cmb_otherDate
            // 
            this.cmb_otherDate.FormattingEnabled = true;
            this.cmb_otherDate.Items.AddRange(new object[] {
            "Created Date",
            "Modified Date",
            "Accesed Date",
            "Taken Date"});
            this.cmb_otherDate.Location = new System.Drawing.Point(6, 69);
            this.cmb_otherDate.Name = "cmb_otherDate";
            this.cmb_otherDate.Size = new System.Drawing.Size(128, 21);
            this.cmb_otherDate.TabIndex = 13;
            // 
            // chb_dateFromOther
            // 
            this.chb_dateFromOther.AutoSize = true;
            this.chb_dateFromOther.Location = new System.Drawing.Point(213, 71);
            this.chb_dateFromOther.Name = "chb_dateFromOther";
            this.chb_dateFromOther.Size = new System.Drawing.Size(104, 17);
            this.chb_dateFromOther.TabIndex = 14;
            this.chb_dateFromOther.Text = "Get From Other?";
            this.chb_dateFromOther.UseVisualStyleBackColor = true;
            // 
            // cmd_folderOrganizer
            // 
            this.cmd_folderOrganizer.Location = new System.Drawing.Point(6, 15);
            this.cmd_folderOrganizer.Name = "cmd_folderOrganizer";
            this.cmd_folderOrganizer.Size = new System.Drawing.Size(97, 23);
            this.cmd_folderOrganizer.TabIndex = 15;
            this.cmd_folderOrganizer.Text = "Folder Organizer";
            this.cmd_folderOrganizer.UseVisualStyleBackColor = true;
            this.cmd_folderOrganizer.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_imagePreview
            // 
            this.pic_imagePreview.Location = new System.Drawing.Point(6, 17);
            this.pic_imagePreview.Name = "pic_imagePreview";
            this.pic_imagePreview.Size = new System.Drawing.Size(115, 73);
            this.pic_imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imagePreview.TabIndex = 16;
            this.pic_imagePreview.TabStop = false;
            // 
            // cmb_drives
            // 
            this.cmb_drives.FormattingEnabled = true;
            this.cmb_drives.Location = new System.Drawing.Point(6, 17);
            this.cmb_drives.Name = "cmb_drives";
            this.cmb_drives.Size = new System.Drawing.Size(58, 21);
            this.cmb_drives.TabIndex = 17;
            this.cmb_drives.SelectedIndexChanged += new System.EventHandler(this.cmb_drives_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_createdDate);
            this.groupBox1.Controls.Add(this.chb_modifiedDate);
            this.groupBox1.Controls.Add(this.chb_accesedDate);
            this.groupBox1.Controls.Add(this.chb_takenDate);
            this.groupBox1.Location = new System.Drawing.Point(790, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 96);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties to Modify:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_newDate);
            this.groupBox2.Controls.Add(this.cmd_changeDate);
            this.groupBox2.Controls.Add(this.txt_filenamePattern);
            this.groupBox2.Controls.Add(this.txt_filenameSubstring);
            this.groupBox2.Controls.Add(this.cmb_otherDate);
            this.groupBox2.Controls.Add(this.chb_dateFromOther);
            this.groupBox2.Controls.Add(this.chb_filenameDate);
            this.groupBox2.Controls.Add(this.lbl_filenameDatePreview);
            this.groupBox2.Location = new System.Drawing.Point(918, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 96);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Date Value:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pic_imagePreview);
            this.groupBox3.Location = new System.Drawing.Point(561, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 96);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Preview";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chb_overwrite);
            this.groupBox4.Location = new System.Drawing.Point(695, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 96);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmb_drives);
            this.groupBox5.Controls.Add(this.cmd_openPath);
            this.groupBox5.Location = new System.Drawing.Point(12, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 96);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Explore Path:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmd_folderOrganizer);
            this.groupBox6.Location = new System.Drawing.Point(171, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(111, 96);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Additional Tools:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_log);
            this.groupBox7.Location = new System.Drawing.Point(288, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(267, 96);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Log:";
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(6, 15);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(255, 75);
            this.txt_log.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "MediaOrganizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagePreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trv_folders;
        private System.Windows.Forms.ListView lsv_files;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button cmd_openPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker dtp_newDate;
        private System.Windows.Forms.Button cmd_changeDate;
        private System.Windows.Forms.CheckBox chb_overwrite;
        private System.Windows.Forms.CheckBox chb_createdDate;
        private System.Windows.Forms.CheckBox chb_modifiedDate;
        private System.Windows.Forms.CheckBox chb_accesedDate;
        private System.Windows.Forms.CheckBox chb_takenDate;
        private System.Windows.Forms.TextBox txt_filenamePattern;
        private System.Windows.Forms.CheckBox chb_filenameDate;
        private System.Windows.Forms.TextBox txt_filenameSubstring;
        private System.Windows.Forms.Label lbl_filenameDatePreview;
        private System.Windows.Forms.ComboBox cmb_otherDate;
        private System.Windows.Forms.CheckBox chb_dateFromOther;
        private System.Windows.Forms.Button cmd_folderOrganizer;
        private System.Windows.Forms.PictureBox pic_imagePreview;
        private System.Windows.Forms.ComboBox cmb_drives;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_log;
    }
}


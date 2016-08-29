using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaOrganizer
{
    public partial class FolderOrganizer : Form
    {
        public FolderOrganizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "") { textBox1.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "") { textBox2.Text = folderBrowserDialog1.SelectedPath; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_log.Text = txt_log.Text + "Init." + Environment.NewLine;

            string originPath = textBox1.Text;
            string destinationPath = textBox2.Text;
            String[] allFiles = System.IO.Directory.GetFiles(originPath, "*.*", SearchOption.AllDirectories);

            txt_log.Text = txt_log.Text + "I have found files: " + allFiles.Length.ToString() + Environment.NewLine;

            prg_progressBar.Maximum = allFiles.Length;
            prg_progressBar.Step = 1;
            prg_progressBar.Value = 0;

            foreach (String item in allFiles)
            {
                FileInfo file = new FileInfo(item);
                DateTime date = DateTime.Now;

                if (file.Extension.ToLower() == ".jpg")
                {
                    try
                    {
                        date = DateTime.Parse(MediaOrganizer.GetDateTakenFromImage(item));
                    }
                    catch
                    {
                        txt_log.Text = txt_log.Text + "Error getting Taken Date from:" + file.FullName + Environment.NewLine;
                        continue;
                    }
                }

                if (file.Extension.ToLower() == ".mov" || file.Extension.ToLower() == ".mp4" || file.Extension.ToLower() == ".avi" || file.Extension.ToLower() == ".3gp")
                {
                    date = file.LastWriteTime;
                }

                string year = date.Year.ToString();
                string month = date.Month.ToString();
                string day = date.Day.ToString();

                if (Directory.Exists(destinationPath) == false) { Directory.CreateDirectory(destinationPath); }
                if (Directory.Exists(destinationPath + "\\" + year) == false) { Directory.CreateDirectory(destinationPath + "\\" + year); }
                if (Directory.Exists(destinationPath + "\\" + year + "\\" + month) == false) { Directory.CreateDirectory(destinationPath + "\\" + year + "\\" + month); }

                if (File.Exists(destinationPath + "\\" + year + "\\" + month + "\\" + file.Name) == false)
                {
                    if (chb_moveFiles.Checked == true)
                    {
                        System.IO.File.Move(file.FullName, destinationPath + "\\" + year + "\\" + month + "\\" + file.Name);
                    }
                    else
                    {
                        System.IO.File.Copy(file.FullName, destinationPath + "\\" + year + "\\" + month + "\\" + file.Name);
                    }
                }

                prg_progressBar.PerformStep();
            }

            txt_log.Text = txt_log.Text + "Finish." + Environment.NewLine;
        }
    }
}

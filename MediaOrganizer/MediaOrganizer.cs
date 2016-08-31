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
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Globalization;

namespace MediaOrganizer
{
    public partial class MediaOrganizer : Form
    {
        private static Regex r = new Regex(":");
        private DirectoryInfo path;
        private ListViewColumnSorter lvwColumnSorter;
        private TreeNodeMouseClickEventArgs currentNode;

        public MediaOrganizer()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lsv_files.ListViewItemSorter = lvwColumnSorter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PopulateTreeView();

            foreach (DriveInfo item in System.IO.DriveInfo.GetDrives())
            {
                if (item.DriveType == DriveType.Fixed || item.DriveType == DriveType.Removable)
                {
                    if (item.IsReady == true)
                    {
                        cmb_drives.Items.Add(item.Name);
                    }
                }
            } 

            if (cmb_drives.Items.Count > 0) { cmb_drives.SelectedIndex = 0; }

            dtp_newDate.Format = DateTimePickerFormat.Custom;
            dtp_newDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";

        }

        private void PopulateTreeView()
        {
            trv_folders.Nodes.Clear();

            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(path.FullName);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                rootNode.ImageIndex = 0;
                rootNode.Name = info.Name;
                GetDirectories(info.GetDirectories(), rootNode);
                trv_folders.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            nodeToAddTo.Nodes.Clear();

            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                aNode.Name = subDir.Name;

                /*try
                {
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                }
                catch
                {
                    
                }*/

                nodeToAddTo.Nodes.Add(aNode);
                aNode.ImageIndex = 0;
                nodeToAddTo.Expand();
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DirectoryInfo currentDirectory = (DirectoryInfo)e.Node.Tag;

            try
            {
                GetDirectories(currentDirectory.GetDirectories(), e.Node);
            }
            catch { return; }

            currentNode = e;
            TreeNode newSelected = e.Node;
            lsv_files.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                          {new ListViewItem.ListViewSubItem(item, "Directory"),
                   new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lsv_files.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                if (chb_mediaOnly.Checked) { if (!MediaFunctions.isMediaFile(file.Extension)) { continue; } }

                int iconNumber = 4;

                if (MediaFunctions.isImageFile(file.Extension)) { iconNumber = 2; }
                if (MediaFunctions.isVideoFile(file.Extension)) { iconNumber = 3; }

                item = new ListViewItem(file.Name, iconNumber);

                String takenDateString;
                if (MediaFunctions.isImageFile(file.Extension)) { takenDateString = GetDateTakenFromImage(file.FullName); }
                else { takenDateString = ""; }

                subItems = new ListViewItem.ListViewSubItem[]
                          { new ListViewItem.ListViewSubItem(item, file.Extension),
                            new ListViewItem.ListViewSubItem(item, file.CreationTimeUtc.ToString()),
                            new ListViewItem.ListViewSubItem(item, file.LastWriteTimeUtc.ToString()),
                            new ListViewItem.ListViewSubItem(item, takenDateString),
                            new ListViewItem.ListViewSubItem(item, file.FullName),
                            new ListViewItem.ListViewSubItem(item, file.DirectoryName)
                          };
                item.SubItems.AddRange(subItems);
                lsv_files.Items.Add(item);
            }

            lsv_files.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        //retrieves the datetime WITHOUT loading the whole image
        public static String GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                try
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    //return DateTime.Parse(dateTaken);
                    return dateTaken;
                }
                catch { return ""; }
            }
        }

        public static void SetDateTakenFromImage(string path, DateTime newDate)
        {
            string new_path;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                Encoding _Encoding = Encoding.UTF8;
                //PropertyItem propItem = null;
                var propItem = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));

                propItem.Id= 36867;
                propItem.Len = 20;
                propItem.Type = 2;
                propItem.Value = _Encoding.GetBytes(newDate.ToString("yyyy:MM:dd HH:mm:ss") + '\0');

                //myImage.RemovePropertyItem(36867);
                myImage.SetPropertyItem(propItem);

                new_path = System.IO.Path.GetDirectoryName(path) + "\\" + System.IO.Path.GetFileName(path) + ".temp";

                //myImage.Save(fs, ImageFormat.Jpeg);
                myImage.Save(new_path);
                myImage.Dispose();
            }

                System.IO.File.Delete(path);
                System.IO.File.Copy(new_path, path);
                System.IO.File.Delete(new_path);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
            {
                path = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                PopulateTreeView();
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lsv_files.Sort();
        }

        private void cmd_ChangeDate_Click(object sender, EventArgs e)
        {
            if (pic_imagePreview.Image != null) { pic_imagePreview.Image.Dispose(); }
            pic_imagePreview.Image = null;

            DateTime newDate = dtp_newDate.Value;
            bool overWrite = chb_overwrite.Checked;

            foreach (ListViewItem item in lsv_files.SelectedItems)
            {
                string filePath = item.SubItems[5].Text;
                string filePathDestination = item.SubItems[6].Text + "\\adjusted\\" + item.Text;

                //TAKE DATE FROM FILENAME
                if (chb_filenameDate.Checked)
                {
                    newDate = GetDateFromFilename(item.Text);
                }

                FileInfo file = null;

                //TAKE DATE FROM ANOTHER FIELD
                if (chb_dateFromOther.Checked)
                {
                    file = new FileInfo(filePath);

                    switch (cmb_otherDate.Text)
                    {
                        case "Created Date":
                            newDate = file.CreationTimeUtc; break;
                        case "Modified Date":
                            newDate = file.LastWriteTimeUtc; break;
                        case "Accessed Date":
                            newDate = file.LastAccessTimeUtc; break;
                        case "Taken Date":
                            newDate = DateTime.Parse(GetDateTakenFromImage(filePath)); break;
                        default:
                            break; 
                    }

                    file = null;
                }

                //TAKE DATE FROM DATEDIFF CALCULATION
                if (chb_dateDiff.Checked)
                {
                    int secondsDiff = Convert.ToInt32(txt_dateDiff.Text);
                    newDate = newDate.AddSeconds(secondsDiff);
                }

                //OVERWRITE FILE
                if (overWrite == false)
                {
                    if (System.IO.Directory.Exists(item.SubItems[6].Text + "\\adjusted\\") == false)
                    {
                        System.IO.Directory.CreateDirectory(item.SubItems[6].Text + "\\adjusted\\");
                    }

                    if (System.IO.File.Exists(filePathDestination)) { System.IO.File.Delete(filePathDestination); }
                    System.IO.File.Copy(filePath, filePathDestination);
                    filePath = filePathDestination;
                }

                //BACKUP
                file = new FileInfo(filePath);
                DateTime createdDate = file.CreationTimeUtc;
                DateTime modifiedDate = file.LastWriteTimeUtc;
                DateTime accessedDate = file.LastAccessTimeUtc;
                //file = null;

                //CHANGE TAKEN DATE
                if (chb_takenDate.Checked == true && MediaFunctions.isImageFile(file.Extension))
                {
                    SetDateTakenFromImage(filePath, newDate);
                    //file = new FileInfo(filePath);
                    file.CreationTimeUtc = createdDate;
                    file.LastWriteTimeUtc = modifiedDate;
                    file.LastAccessTimeUtc = accessedDate;
                    //file = null;
                }

                //file = new FileInfo(filePath);

                //CHANGE FILE DATES
                if (chb_createdDate.Checked == true) { file.CreationTimeUtc = newDate; }
                if (chb_modifiedDate.Checked == true) { file.LastWriteTimeUtc = newDate; }
                if (chb_accessedDate.Checked == true) { file.LastAccessTimeUtc = newDate; }
            }

            treeView1_NodeMouseClick(null, currentNode);
            TreeNode selectedNode = trv_folders.SelectedNode;
            //treeView1.Nodes.Clear();
            //PopulateTreeView();

            //treeView1.ExpandAll();
            //treeView1.SelectedNode = selectedNode;
        }

        private DateTime GetDateFromFilename (string filename)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;

                string dateString = filename;

                string[] separators = { "," };
                string SubFormat = txt_filenameSubstring.Text;
                string[] substringValues = SubFormat.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string subString = dateString.Substring(Convert.ToInt32(substringValues[0]), Convert.ToInt32(substringValues[1]));


                string format = txt_filenamePattern.Text;

                DateTime result = DateTime.ParseExact(subString, format, provider);

                return result;
            }
            catch
            {
                return DateTime.Now;
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (chb_filenameDate.Checked)
            {
                lbl_filenameDatePreview.Text = GetDateFromFilename(lsv_files.FocusedItem.Text).ToString();
            }

            if (lsv_files.FocusedItem.SubItems.Count >= 5)
            {
                if (lsv_files.FocusedItem.SubItems[5].ToString().ToLower().Contains(".jpg"))
                {
                    string imagePath = lsv_files.FocusedItem.SubItems[5].Text;
                    //pic_imagePreview.Image = new Bitmap(imagePath);

                    Image img;
                    using (var bmpTemp = new Bitmap(imagePath)) { img = new Bitmap(bmpTemp); pic_imagePreview.Image = img; }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderOrganizer f = new FolderOrganizer();
            f.Show();
        }

        private void cmb_drives_SelectedIndexChanged(object sender, EventArgs e)
        {
            path = new DirectoryInfo(cmb_drives.SelectedItem.ToString());
            PopulateTreeView();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            splitContainer1.Height = this.Height - 175;
        }

        private void lsv_files_DoubleClick(object sender, EventArgs e)
        {
            if (lsv_files.FocusedItem.SubItems[1].Text == "Directory")
            {
                TreeNode node = currentNode.Node;
                TreeNode newNode = node.Nodes[node.Nodes.IndexOfKey(lsv_files.FocusedItem.Text)];
                TreeNodeMouseClickEventArgs newArgs = new TreeNodeMouseClickEventArgs(newNode, MouseButtons.Right, 2, 10, 10);
                treeView1_NodeMouseClick(null, newArgs);
            }
        }

        private void cmd_dateDiffCalculator_Click(object sender, EventArgs e)
        {
            DateDiffCalculator dateDiffCalculator = new DateDiffCalculator();
            dateDiffCalculator.Show();
        }
    }
}

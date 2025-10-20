using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace Giao_dien_chinh
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                pathdisk = drive.Name;
                TreeNode root = new TreeNode(pathdisk);
                TreeDirectory.Nodes.Add(root);
                if (drive.Name == "D:\\") 
                {
                    LoadExplorer(root);
                }
                root.Text = drive.VolumeLabel + " (" + pathdisk + ")";
                root.Name = drive.Name;
            }
        }

        string pathdisk;

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                DirectoryInfo[] listfolder = new DirectoryInfo(root.Text).GetDirectories();
                string[] listfile = Directory.GetFiles(root.Text);
                foreach (string item in listfile)
                {
                    FileInfo file = new FileInfo(item);
                    TreeNode filenode = new TreeNode(item);
                    root.Nodes.Add(filenode);
                    filenode.Name = item;
                    filenode.Text = file.Name;
                }
                foreach (DirectoryInfo item in listfolder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode folder = new TreeNode(item.FullName);
                        root.Nodes.Add(folder);
                        LoadExplorer(folder);
                        folder.Name = item.FullName;
                        folder.Text = item.Name;
                    }
                }
            }
            catch
            {
                return;
            }
        }


        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            while (!attr.HasFlag(FileAttributes.Directory) || node != null)
            {
                try
                {
                    attr = File.GetAttributes(node.Name);
                }
                catch (System.NullReferenceException)
                {
                    break;
                }
                node = node.NextNode;
            }
        }

        private void treeDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(node.Name);
                    if (fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                    {
                        FilePictureContent.Visible = true;
                        txtFileContent.Visible = false;
                        FilePictureContent.Load(node.Name);
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        FilePictureContent.Visible = false;
                        txtFileContent.Visible = true;
                        FileStream fs = new FileStream(node.Name, FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(fs);
                        txtFileContent.Text = reader.ReadToEnd();
                        reader.Close();
                        fs.Close();
                    }
                    else if (fileInfo.Extension == ".docx" || fileInfo.Extension == ".doc")
                    {
                        FilePictureContent.Visible = false;
                        txtFileContent.Visible = true;
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        Document fileword = app.Documents.Open(node.Name);
                        txtFileContent.Text = fileword.Content.Text;
                        app.Quit();
                    }
                    

                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Not a picture file.", "Notice");
                }
            }
        }
    }
}

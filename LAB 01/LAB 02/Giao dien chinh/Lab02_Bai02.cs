using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien_chinh
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int DemTu(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            int Dem = 0;
            bool inWord = false;

            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c))
                    inWord = false;
                else if (!inWord)
                {
                    inWord = true;
                    Dem++;
                }
            }
            return Dem;
        }

        private int DemKyTu(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) 
               return 0;

            int Dem = 0;
            foreach (char c in text)
            {
                if (char.IsLetterOrDigit(c))
                    Dem++;
            }
            return Dem;
        }

        private void Read_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = "file.txt";

                if (!File.Exists(path))
                {
                    MessageBox.Show("Không tìm thấy file.txt trong thư mục chương trình!");
                    return;
                }

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    // Ghi ten file
                    FileName.Text = Path.GetFileName(path);

                    // Ghi kich thuoc 
                    long size = fs.Length;
                    Size.Text = $"{size} bytes";

                    // Ghi duong dan
                    URL.Text = Path.GetFullPath(path);

                    // Dem so dong
                    int DemDong = 0;
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8, true, 1024, leaveOpen: true))
                    {
                        while (sr.ReadLine() != null)
                        {
                            DemDong++;
                        }
                        LineCount.Text = $"{DemDong}";
                    }

                    fs.Seek(0, SeekOrigin.Begin); //Dua con tro ve dau file

                    // Dem tu va ky tu
                    using (StreamReader sr1 = new StreamReader(fs))
                    {
                        string noidung = sr1.ReadToEnd();
                        NoiDung.Text = noidung;

                        int demtu = DemTu(noidung);
                        WordCount.Text = $"{demtu}";

                        int demkitu = DemKyTu(noidung);
                        CharacterCount.Text = $"{demkitu}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file: {ex.Message}");
            }
        }

    }
}





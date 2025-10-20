using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien_chinh
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader("input1.txt"))
                {
                    NoiDung.Text = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"Lỗi đọc file: {ex.Message}");
            }
        }

        private void Ghi_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter ("output1.txt"))
                {
                    writer.Write(NoiDung.Text.ToUpper());
                }
                MessageBox.Show($"Đã ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file: {ex.Message}");
            }
        }
    }
}


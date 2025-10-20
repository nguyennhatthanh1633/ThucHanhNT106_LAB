using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }
        private void XuatThongTin_Click(object sender, EventArgs e)
        {
        
                string str = NhapThongTin.Text;
                string[] arr = str.Trim().Split(',');
                HoTen.Text = arr[0].Trim();

                DiemTP.Text = "";
                float[] diem = new float[arr.Length - 1];
                bool valid = true;

                for (int i = 1; i < arr.Length; i++)
                {
                    string s = arr[i].Trim().Replace(",", ".");
                    diem[i - 1] = float.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
                    DiemTP.Text += "Môn " + i + ": " + diem[i - 1] + "  ";
                }


                if (!valid) return;


                float max = diem.Max();
                float min = diem.Min();
                Max.Text = max.ToString();
                Min.Text = min.ToString();

                float dtb = diem.Average();
                DTB.Text = dtb.ToString("F2");

                int count_pass = diem.Count(d => d >= 5);
                int count_fail = diem.Length - count_pass;
                Dau.Text = count_pass.ToString();
                KhongDau.Text = count_fail.ToString();

                string xeploai = "Yếu";
                if (dtb >= 8 && diem.All(d => d >= 6.5))
                    xeploai = "Giỏi";
                else if (dtb >= 6.5 && diem.All(d => d >= 5)) 
                    xeploai = "Khá";
                else if (dtb >= 5 && diem.All(d => d >= 3.5)) 
                    xeploai = "Trung bình";

                XepLoai.Text = xeploai;
        }


        private void Xoa_Click(object sender, EventArgs e)
        {
            NhapThongTin.Text = String.Empty;
            HoTen.Text = String.Empty;
            DiemTP.Text = String.Empty;
            DTB.Text = String.Empty;
            Min.Text = String.Empty;
            Max.Text = String.Empty;
            Dau.Text = String.Empty;
            KhongDau.Text = String.Empty;
            XepLoai.Text = String.Empty;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

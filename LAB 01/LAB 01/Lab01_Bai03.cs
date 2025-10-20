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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(NhapSo.Text.Trim(), out number )&& number >= 0 && number <= 9)
            {
                string Chu = " ";
                switch (number)
                {
                    case 0: 
                        Chu = "Không";
                        break;
                    case 1:
                        Chu = "Một";
                        break;
                    case 2:
                        Chu = "Hai";
                        break;
                    case 3:
                        Chu = "Ba";
                        break;
                    case 4:
                        Chu = "Bốn";
                        break;
                    case 5:
                        Chu = "Năm";
                        break;
                    case 6:
                        Chu = "Sáu";
                        break;
                    case 7:
                        Chu = "Bảy";
                        break;
                    case 8:
                        Chu = "Tám";
                        break;
                    case 9:
                        Chu = "Chín";
                        break;
                }
                KetQua.Text = Chu;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            NhapSo.Text = String.Empty;
            KetQua.Text = String.Empty;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Lab01_Bai3_1 : Form
    {
        public Lab01_Bai3_1()
        {
            InitializeComponent();
        }

        private string[] donvi = { "", "nghìn", "triệu", "tỷ" };
        private string[] so = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private string DocBaSo(int n)
        {
            int Tram = n / 100;
            int Chuc = (n % 100) / 10;
            int DonVi = n % 10;
            string kq = "";

            if (Tram > 0)
            {
                kq += so[Tram] + " trăm";
                if (Chuc == 0 && DonVi > 0)
                    kq += " lẻ";
            }

            if (Chuc > 1)
            {
                kq += " " + so[Chuc] + " mươi";
                if (DonVi == 1) kq += " mốt";
                else if (DonVi == 5) kq += " lăm";
                else if (DonVi > 0) kq += " " + so[DonVi];
            }
            else if (Chuc == 1)
            {
                kq += " mười";
                if (DonVi == 1) kq += " một";
                else if (DonVi == 5) kq += " lăm";
                else if (DonVi > 0) kq += " " + so[DonVi];
            }
            else if (Chuc == 0 && DonVi > 0)
            {
                kq += " " + so[DonVi];
            }

            return kq.Trim();
        }

        private string DocSoNguyen(long n)
        {
            if (n == 0) return "không";

            string kq = "";
            int i = 0;

            while (n > 0)
            {
                int block = (int)(n % 1000);
                if (block > 0)
                {
                    string tmp = DocBaSo(block);
                    if (donvi[i] != "") tmp += " " + donvi[i];
                    kq = tmp + " " + kq;
                }
                n /= 1000;
                i++;
            }

            return kq.Trim();
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            try
            {
                long number = long.Parse(DocSo.Text);
                if (number < 0 || number > 999999999999)
                {
                    MessageBox.Show("Vui lòng nhập số có tối đa 12 chữ số!");
                    return;
                }
                KetQua.Text = DocSoNguyen(number);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DocSo.Text = String.Empty;
            KetQua.Text = String.Empty;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
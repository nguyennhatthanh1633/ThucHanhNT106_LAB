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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void XemCung_Click(object sender, EventArgs e)
        {
            DateTime NgaySinh = NgayThangNam.Value;
            int Ngay = NgaySinh.Day;
            int Thang = NgaySinh.Month;

            string Cung = "";

            switch (Thang)
            {
                case 1:
                    if (Ngay >= 20)
                        Cung = "Bảo Bình";
                    else 
                        Cung = "Ma Kết";
                    break;
                case 2:
                    if (Ngay >= 19)
                        Cung = "Song Ngư";
                    else
                        Cung = "Bảo Bình";
                    break;
                case 3:
                    if (Ngay >= 21)
                        Cung = "Bạch Dương";
                    else
                        Cung = "Song Ngư";
                    break;
                case 4:
                    if (Ngay >= 20)
                        Cung = "Kim Ngưu";
                    else
                        Cung = "Bạch Dương";
                    break;
                case 5:
                    if (Ngay >= 21)
                        Cung = "Song Tử";
                    else
                        Cung = "Kim Ngưu";
                    break;
                case 6:
                    if (Ngay >= 21)
                        Cung = "Cự Giải";
                    else
                        Cung = "Song Tử";
                    break;
                case 7:
                    if (Ngay >= 23)
                        Cung = "Sư Tử";
                    else
                        Cung = "Cự Giải";
                    break;
                case 8:
                    if (Ngay >= 23)
                        Cung = "Xử Nữ";
                    else
                        Cung = "Sư Tử";
                    break;
                case 9:
                    if (Ngay >= 23)
                        Cung = "Thiên Bình";
                    else
                        Cung = "Xử Nữ";
                    break;
                case 10:
                    if (Ngay >= 23)
                        Cung = "Thiên Yết";
                    else
                        Cung = "Thiên Bình";
                    break;
                case 11:
                    if (Ngay >= 22)
                        Cung = "Nhân Mã";
                    else
                        Cung = "Thiên Yết";
                    break;
                case 12:
                    if (Ngay >= 22)
                        Cung = "Ma Kết";
                    else
                        Cung = "Nhân Mã";
                    break;
            }
            KetQua.Text = Cung.ToString();
        }
    }
}

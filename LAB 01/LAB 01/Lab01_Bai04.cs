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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button && (c.Name.StartsWith("A") || c.Name.StartsWith("B") || c.Name.StartsWith("C")))
                {
                    c.Click += ChonGhe;           
                    c.BackColor = Color.LightGray; 
                }
            }
        }

        List<string> GheDaChon = new List<string>();

        private void ChonGhe(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string Ghe = btn.Name; 

            if (btn.BackColor == Color.LightGray) 
            {
                btn.BackColor = Color.Red;
                GheDaChon.Add(Ghe);
            }
            else if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.LightGray;
                GheDaChon.Remove(Ghe);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            HoTenKhachHang.Text = String.Empty;
            PhongChieu.Text = String.Empty;
            TenPhim.Text = String.Empty;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MuaVe_Click(object sender, EventArgs e)
        {
            string TenKH = HoTenKhachHang.Text.Trim();
            string tenPhim = TenPhim.Text;
            string Phong = PhongChieu.Text;

            if (string.IsNullOrEmpty(TenKH) || string.IsNullOrEmpty(tenPhim) || string.IsNullOrEmpty(Phong))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng, phim và phòng!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GheDaChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, int> GiaPhim = new Dictionary<string, int>()
             {
                 { "Đào, phở và piano", 45000 },
                 { "Mai", 100000 },
                 { "Gặp lại chị bầu", 70000 },
                 { "Tarot", 90000 }
            };

            Dictionary<string, List<string>> PhongChieuPhim = new Dictionary<string, List<string>>()
            {
                   { "Đào, phở và piano", new List<string>{ "1", "2", "3" } },
                   { "Mai", new List<string>{ "2", "3" } },
                   { "Gặp lại chị bầu", new List<string>{ "1" } },
                   { "Tarot", new List<string>{ "3" } }
            };

            if (!PhongChieuPhim.ContainsKey(tenPhim))
            {
                MessageBox.Show("Phim chưa có thông tin phòng chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!PhongChieuPhim[tenPhim].Contains(Phong))
            {
                MessageBox.Show($"Phim {tenPhim} không chiếu ở phòng {Phong}!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int GiaChuan = GiaPhim[tenPhim];

            int TongTien = 0;
            foreach (string Ghe in GheDaChon)
            {
                if (Ghe == "A1" || Ghe == "A5" || Ghe == "C1" || Ghe == "C5")
                    TongTien += GiaChuan / 4; 
                else if (Ghe == "B2" || Ghe == "B3" || Ghe == "B4")
                    TongTien += GiaChuan * 2; 
                else
                    TongTien += GiaChuan;      
            }

            KQHoTen.Text = TenKH;
            KQPhim.Text = tenPhim;
            KQPhong.Text = Phong;
            KQGhe.Text = string.Join(", ", GheDaChon);
            KQTien.Text = TongTien.ToString("N0") + " đ";

            foreach (string ghe in GheDaChon)
            {
                Button btn = this.Controls.Find(ghe, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Gray;
                }
            }

            GheDaChon.Clear();
        }


    }
}


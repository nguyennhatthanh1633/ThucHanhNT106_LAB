using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien_chinh
{
    public partial class Lab02_Bai05 : Form
    {
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        public class DuLieu
        {
            public string TenPhim;
            public int GiaVe;
            public int PhongChieu;
            public string ChoNgoi;

            public DuLieu()
            {

            }
        }

        public class NoiDung
        {
            public string TenPhim;
            public int GiaVe;
            public int PhongChieu;
            public string ChoNgoi;
            public int TongSoVe = 15;
            public int VeDaBan;
            public int VeTon;
            public float TyLe;
            public long DoanhThu;
            public int XepHang;

            public NoiDung()
            {

            }

            public string Show()
            {
                string noidung = "";
                noidung += "Tên phim: " + TenPhim + Environment.NewLine;
                noidung += "Giá vé: " + GiaVe.ToString() + Environment.NewLine;
                noidung += "Phòng chiếu: " + PhongChieu.ToString() + Environment.NewLine;
                noidung += "Ghế đã bán: " + ChoNgoi + Environment.NewLine;
                noidung += "Tổng số vé: " + TongSoVe.ToString() + Environment.NewLine;
                noidung += "Vé đã bán: " + VeDaBan.ToString() + Environment.NewLine;
                noidung += "Vé còn lại: " + VeTon.ToString() + Environment.NewLine;
                noidung += "Tỷ lệ bán vé: " + (TyLe * 100).ToString("0.##") + " %" + Environment.NewLine;
                noidung += "Doanh thu: " + DoanhThu.ToString() + Environment.NewLine;
                noidung += "Xếp hạng doanh thu: " + XepHang.ToString() + Environment.NewLine;
                noidung += "------------------------------------------" + Environment.NewLine;
                return noidung;
            }
        }

        List<DuLieu> DanhSachDL = new List<DuLieu>();
        List<NoiDung> DanhSachND = new List<NoiDung>();

        private void Doc_Click(object sender, EventArgs e)
        {
            string noidung = "";
            try
            {
                string Input = "D:\\Năm 2_Học kỳ 1\\Lập trình mạng căn bản\\NT106 LAB\\LAB 02\\Giao dien chinh\\bin\\Debug\\input5.txt";
                noidung = File.ReadAllText(Input);
                DocDL.Text = noidung;
                MessageBox.Show("Đọc file thành công!");
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn file để đọc!");
            }

            List<string> DanhSach = new List<string>();
            foreach (var dulieu in noidung.Split('\n'))
            {
                string dong = dulieu.Trim();
                if (!string.IsNullOrEmpty(dong))
                    DanhSach.Add(dong);
            }

            DanhSachDL.Clear();
            for (int i = 0; i < DanhSach.Count; i += 4)
            {
                DuLieu danhSachDL = new DuLieu();
                danhSachDL.TenPhim = DanhSach[i];
                danhSachDL.GiaVe = int.Parse(DanhSach[i + 1]);
                danhSachDL.PhongChieu = int.Parse(DanhSach[i + 2]);
                danhSachDL.ChoNgoi = DanhSach[i + 3];
                DanhSachDL.Add(danhSachDL);
            }
        }


        private void Ghi_Click(object sender, EventArgs e)
        {
            foreach(var dulieu in DanhSachDL)
            {
                NoiDung noidung = new NoiDung();
                noidung.TenPhim = dulieu.TenPhim;
                noidung.GiaVe = dulieu.GiaVe;
                noidung.PhongChieu = dulieu.PhongChieu;
                noidung.ChoNgoi = dulieu.ChoNgoi;

                List<string> chongoi = new List<string>();
                foreach(var cho in noidung.ChoNgoi.Split(' '))
                {
                    chongoi.Add(cho);
                }
                noidung.VeDaBan = chongoi.Count;
                noidung.VeTon = noidung.TongSoVe - chongoi.Count;
                noidung.TyLe = (float)noidung.VeDaBan / noidung.TongSoVe;
                long Tong = 0;
                foreach(var cho in chongoi)
                {
                    if (cho == "A1" || cho == "A5" || cho == "C1" || cho == "C5")
                        Tong += noidung.GiaVe / 4;
                    else
                    {
                        if (cho == "B2" || cho == "B3" || cho == "B4")
                            Tong += noidung.GiaVe * 2;
                        else
                            Tong += noidung.GiaVe;
                    }
                }
                noidung.DoanhThu = Tong;
                DanhSachND.Add(noidung);
            }

            DanhSachND.Sort((a, b) => b.DoanhThu.CompareTo(a.DoanhThu));
            int i = 1;
            foreach (NoiDung noidung in DanhSachND)
            {
                noidung.XepHang = i;
                i++;
            }
            foreach(NoiDung noidung in DanhSachND)
            {
                KetQua.Text += noidung.Show();
            }

            string Output = "D:\\output5.txt";
            using (StreamWriter writer = new StreamWriter(Output))
            {
                writer.Write(KetQua.Text);
            }
        }
    }
}

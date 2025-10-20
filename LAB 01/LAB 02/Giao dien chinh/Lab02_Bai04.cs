using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Giao_dien_chinh.Lab02_Bai04;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Giao_dien_chinh
{
    
    public partial class Lab02_Bai04 : Form
    {
        [Serializable]
        public class SinhVien
        {
            public string HoTen { get; set; }
            public int MSSV { get; set; }
            public string SDT { get; set; }
            public float Diem1 { get; set; }
            public float Diem2 { get; set; }
            public float Diem3 { get; set; }
            public float DTB { get; set; }

            public SinhVien() { }
            public SinhVien(string hoten, int mssv, string sdt, float d1, float d2, float d3)
            {
                HoTen = hoten;
                MSSV = mssv;
                SDT = sdt;
                Diem1 = d1;
                Diem2 = d2;
                Diem3 = d3;
                DTB = 0;
            }

            public void TinhDTB()
            {
                DTB = (Diem1 + Diem2 + Diem3) / 3;
            }

            public override string ToString()
            {
                return $"Sinh viên: {HoTen,-20} \r\n MSSV: {MSSV} \r\n SĐT: {SDT} \r\n Môn 1: {Diem1} \r\n Môn 2: {Diem2} \r\n Môn 3: {Diem3} \r\n ĐTB: {DTB:F2}";
            }
        }

        private List<SinhVien> DanhSach = new List<SinhVien>();
        private int Trang = 0;

        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string HoTen = Name1.Text.Trim();
            string SDT = Phone1.Text.Trim();
            float diem1, diem2, diem3;
            int MSSV;

            if (!int.TryParse(ID1.Text, out MSSV)|| ID1.Text.Length != 8) //ktra MSSV
            {
                MessageBox.Show( "Mã số sinh viên phải có đúng 8 chữ số!");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(SDT, @"^0\d{9}$")) //ktra sdt 
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!");
                return;
            }
            string d1 = Course11.Text.Replace('.', ',');
            string d2 = Course21.Text.Replace('.', ',');
            string d3 = Course31.Text.Replace('.', ',');
            if (!float.TryParse(d1, out diem1) || diem1 < 0 || diem1 > 10 ||
                !float.TryParse(d2, out diem2) || diem2 < 0 || diem2 > 10 ||
                !float.TryParse(d3, out diem3) || diem3 < 0 || diem3 > 10) //ktra diem so
            {
                MessageBox.Show("Điểm các môn phải nằm trong khoảng 0 - 10!");
                return;
            }

            SinhVien sv = new SinhVien
            {
                HoTen = HoTen,
                MSSV = MSSV,
                SDT = SDT, 
                Diem1 = diem1,
                Diem2 = diem2,
                Diem3 = diem3
            };
            sv.TinhDTB(); 

            DanhSach.Add(sv);
            MessageBox.Show("Đã thêm sinh viên vào danh sách!");
            ClearInput();
        }

        private void ClearInput()
        {
            Name1.Clear();
            ID1.Clear();
            Phone1.Clear();
            Course11.Clear();
            Course21.Clear();
            Course31.Clear();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var sv in DanhSach)
                    sv.TinhDTB();

                string json = JsonSerializer.Serialize(DanhSach);
                File.WriteAllText("input4.txt", json);
                MessageBox.Show("Ghi file input4.txt thành công!");
                HienThiTrang(Trang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText("input4.txt");
                DanhSach = JsonSerializer.Deserialize<List<SinhVien>>(json);

                foreach (var SV in DanhSach) //Tinh diem trung binh
                    SV.TinhDTB();

                string Outputjson = JsonSerializer.Serialize(DanhSach); //Ghi ra output4.txt
                File.WriteAllText("output4.txt", Outputjson);
                MessageBox.Show("Đọc file & ghi output4.txt thành công!");
                HienThiTrang(0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }
        private void HienThiTrang(int trang)
        {
            NoiDung.Clear();

            foreach (var svItem in DanhSach)
            {
                NoiDung.AppendText(svItem.ToString() + Environment.NewLine);
                NoiDung.AppendText(Environment.NewLine); 
            }

            if (DanhSach == null || DanhSach.Count == 0) return;
            if (trang < 0 || trang >= DanhSach.Count) return;

            SinhVien sv = DanhSach[trang];
            Name2.Text = sv.HoTen;
            ID2.Text = sv.MSSV.ToString();
            Phone2.Text = sv.SDT;
            Course12.Text = sv.Diem1.ToString();
            Course22.Text = sv.Diem2.ToString();
            Course32.Text = sv.Diem3.ToString();
            Average2.Text = sv.DTB.ToString("F2");

            TrangHT.Text = $"{trang + 1}";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            if (Trang > 0)
            {
                Trang--;
                HienThiTrang(Trang);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Trang < DanhSach.Count - 1)
            {
                Trang++;
                HienThiTrang(Trang);
            }
        }

    }
}

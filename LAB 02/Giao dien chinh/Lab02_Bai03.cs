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
    public partial class Lab02_Bai03 : Form
    {

        string pathInput = "input3.txt";
        string pathOutput = "output3.txt";

        public Lab02_Bai03()
        {
            InitializeComponent();
            if (!File.Exists(pathInput))
            {
                File.WriteAllText(pathInput, "");
            }

            if (!File.Exists(pathOutput))
            {
                File.WriteAllText(pathOutput, "");
            }
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            string pathInput = "input3.txt";
            try
            {
                using (StreamReader reader = new StreamReader("input3.txt"))
                {
                    string noidung = File.ReadAllText(pathInput);
                    NoiDung.Text = noidung;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file: {ex.Message}");
            }
        }

        private void Ghi_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("output3.txt"))
                {
                    writer.Write(KetQua.Text.ToUpper());
                }
                MessageBox.Show($"Đã ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file: {ex.Message}");
            }
        }

        private void TinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Dong = NoiDung.Lines;
                List<string> ketqua = new List<string>();

                foreach (string dong in Dong)
                {
                    if (string.IsNullOrWhiteSpace(dong)) continue;

                    double kq = TinhBieuThuc(dong);
                    ketqua.Add($"{dong} = {kq}");
                }

                KetQua.Text = string.Join(Environment.NewLine, ketqua);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tính toán: {ex.Message}");
            }
        }

        private double TinhBieuThuc(string noidung)
        {
            noidung = noidung.Replace(" ", ""); //bo khoang trang
            return TinhCongTru(noidung);
        }

        private double TinhCongTru(string noidung)
        {
            double GiaTri = TinhNhanChia(noidung, out string ConLai);
            noidung = ConLai;

            while(noidung.Length >0 )
            {
                char ToanTu = noidung[0];
                if (ToanTu != '+' && ToanTu != '-')
                    break;
                noidung = noidung.Substring(1);

                double Phai = TinhNhanChia(noidung, out ConLai);
                noidung = ConLai;

                if (ToanTu == '+')
                    GiaTri += Phai;
                else
                    GiaTri -= Phai;
            }
            return GiaTri;
        }

        private double TinhNhanChia (string noidung, out string ConLai)
        {
            double GiaTri = LaySoHoacNgoac(noidung, out ConLai);

            while (ConLai.Length > 0)
            {
                char ToanTu = ConLai[0];
                if (ToanTu != '*' && ToanTu != '/')
                    break;
                ConLai = ConLai.Substring(1);

                double right = LaySoHoacNgoac(ConLai, out ConLai);

                if (ToanTu == '*') 
                    GiaTri *= right;
                else 
                    GiaTri /= right;
            }
            return GiaTri;
        }

        private double LaySoHoacNgoac(string noidung, out string ConLai)
        {
            noidung = noidung.Trim(); //bo khoang trang

            if (noidung[0] == '(')
            {
                int Dem = 1;
                int i = 1;
                while (i < noidung.Length && Dem > 0)
                {
                    if (noidung[i] == '(')
                        Dem++;
                    else if (noidung[i] == ')')
                        Dem--;
                    i++;
                }

                string trongNgoac = noidung.Substring(1, i - 2);
                ConLai = noidung.Substring(i);
                return TinhCongTru(trongNgoac);
            }

            int j = 0;
            if (noidung[0] == '-')
                j++;

            while (j < noidung.Length && (char.IsDigit(noidung[j]) || noidung[j] == '.'))
                j++;

            double GiaTri = double.Parse(noidung.Substring(0, j));
            ConLai = noidung.Substring(j);
            return GiaTri;
        }

    }
}


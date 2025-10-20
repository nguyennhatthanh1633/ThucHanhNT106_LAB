using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB_01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void Lab01_Bai05_Load(object sender, EventArgs e)
        {
            LuaChon.Items.Add("Bảng cửu chương");
            LuaChon.Items.Add("Tính các giá trị");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            NhapA.Text = String.Empty;
            NhapB.Text = String.Empty;
            LuaChon.Text = string.Empty;
            KetQua.Text = string.Empty;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TinhCacGiaTri_Click(object sender, EventArgs e)
        {
            int A = int.Parse(NhapA.Text);
            int B = int.Parse(NhapB.Text);

            if (LuaChon.SelectedItem != null && LuaChon.SelectedItem.ToString() == "Tính toán các giá trị")
            {
                int k = A - B;
                long giaiThua = 1;
                for (int i = 1; i <= k; i++)
                    giaiThua *= i;

                long tong = 0;
                for (int i = 1; i <= B; i++)
                    tong += (long)Math.Pow(A, i);

                KetQua.Text = $"(A - B)! = {giaiThua}\r\nTổng S = {tong}";
            }
            else if (LuaChon.SelectedItem != null && LuaChon.SelectedItem.ToString() == "Bảng cửu chương")
            {
                int hieu = B - A;
                if (hieu <= 0)
                {
                    KetQua.Text = $"Không thể in bảng cửu chương của số {hieu} (≤ 0)";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"--- Bảng cửu chương {hieu} ---");
                    for (int j = 1; j <= 9; j++)
                    {
                        sb.AppendLine($"{hieu} x {j} = {hieu * j}");
                    }
                    KetQua.Text = sb.ToString();
                }
            }
        }
    }
}

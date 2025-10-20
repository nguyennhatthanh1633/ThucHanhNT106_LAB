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
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MonAn.Text))
            {
                DanhSach.Items.Add(MonAn.Text);
                MonAn.Clear();
            }
            else
                MessageBox.Show("Vui òng nhập món ăn!");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            MonAn.Text = String.Empty;
            DanhSach.Text = String.Empty;
            KetQua.Text = String.Empty;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimMonAn_Click(object sender, EventArgs e)
        {
            if(DanhSach.Items.Count > 0)
            {
                Random rd = new Random();
                int index = rd.Next(DanhSach.Items.Count);
                KetQua.Text = DanhSach.Items[index].ToString();
            }
            else
                MessageBox.Show("Danh sách món ăn trống!");
        }
    }
}
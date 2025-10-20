using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien_chinh
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 Bai01 = new Lab02_Bai01();
            Bai01.Show();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 Bai02 = new Lab02_Bai02();
            Bai02.Show();
        }

        private void Bai03_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 Bai03 = new Lab02_Bai03();
            Bai03.Show();
        }

        private void Bai04_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 Bai04 = new Lab02_Bai04();
            Bai04.Show();
        }

        private void Bai05_Click_1(object sender, EventArgs e)
        {
            Lab02_Bai05 Bai05 = new Lab02_Bai05();
            Bai05.Show();
        }

        private void Bai06_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 Bai06 = new Lab02_Bai06();
            Bai06.Show();
        }

        private void Bai07_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 Bai07 = new Lab02_Bai07();
            Bai07.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_01
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            num3.Text = String.Empty;
            max.Text = String.Empty;
            min.Text = String.Empty;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            double so1, so2, so3;

            if (!double.TryParse(num1.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out so1) ||
                !double.TryParse(num2.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out so2) ||
                !double.TryParse(num3.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out so3))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double maximum = so1;
            double minimum = so1;

            if (so2 > maximum) maximum = so2;
            if (so3 > maximum) maximum = so3;

            if (so2 < minimum) minimum = so2;
            if (so3 < minimum) minimum = so3;

            max.Text = maximum.ToString();
            min.Text = minimum.ToString();
        }

    }
}

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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(textBox1.Text.Trim());
                int num2 = Int32.Parse(textBox2.Text.Trim());

                long sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
    }
}

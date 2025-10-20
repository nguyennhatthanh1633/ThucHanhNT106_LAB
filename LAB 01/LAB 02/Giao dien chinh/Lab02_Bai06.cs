using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Giao_dien_chinh
{
    public partial class Lab02_Bai06 : Form
    {
        string dbPath = "Lab02_Bai06.db";
        string connectionString = @"Data Source=Lab02_Bai06.db;Version=3;";
        SQLiteConnection Connect = null;

        public Lab02_Bai06()
        {
            InitializeComponent();
            CaiDatListView();
            TaoCoSoDuLieu();
        }

        private void CaiDatListView()
        {
            //Cấu hình ListView Món ăn
            DSMA.View = View.Details;
            DSMA.FullRowSelect = true;
            DSMA.GridLines = true;
            DSMA.Columns.Clear();
            DSMA.Columns.Add("Mã món ăn", 80);
            DSMA.Columns.Add("Tên món ăn", 150);
            DSMA.Columns.Add("Hình ảnh", 200);
            DSMA.Columns.Add("Mã NCC", 80);

            //Cấu hình ListView Người cung cấp
            DSNCC.View = View.Details;
            DSNCC.FullRowSelect = true;
            DSNCC.GridLines = true;
            DSNCC.Columns.Clear();
            DSNCC.Columns.Add("Mã NCC", 80);
            DSNCC.Columns.Add("Họ tên", 150);
            DSNCC.Columns.Add("Quyền hạn", 120);
        }

        //Tạo cơ sở dữ liệu và bảng nếu chưa có
        private void TaoCoSoDuLieu()
        {
            try
            {
                if (!File.Exists(dbPath))
                {
                    SQLiteConnection.CreateFile(dbPath);
                    MessageBox.Show("Đã tạo file cơ sở dữ liệu mới: Lab02_Bai06.db");
                }

                using (Connect = new SQLiteConnection(connectionString))
                {
                    Connect.Open();

                    string sql = @"
                        CREATE TABLE IF NOT EXISTS NguoiCungCap (
                            MaNguoiCungCap TEXT PRIMARY KEY,
                            HoTen TEXT NOT NULL,
                            QuyenHan TEXT
                        );

                        CREATE TABLE IF NOT EXISTS MonAn (
                            MaMonAn TEXT PRIMARY KEY,
                            TenMonAn TEXT NOT NULL,
                            HinhAnh TEXT,
                            MaNguoiCungCap TEXT,
                            FOREIGN KEY (MaNguoiCungCap) REFERENCES NguoiCungCap(MaNguoiCungCap)
                        );
                    ";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, Connect))
                        cmd.ExecuteNonQuery();

                    //Thêm dữ liệu mẫu nếu chưa có
                    string checkData = "SELECT COUNT(*) FROM NguoiCungCap;";
                    using (SQLiteCommand cmd = new SQLiteCommand(checkData, Connect))
                    {
                        long count = (long)cmd.ExecuteScalar();
                        if (count == 0)
                            ThemDuLieuMau();
                    }

                    Connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void ThemDuLieuMau()
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    //Thư mục lưu hình ảnh
                    string imageFolder = @"D:\Images";

                    //Tạo thư mục nếu chưa có
                    if (!Directory.Exists(imageFolder))
                        Directory.CreateDirectory(imageFolder);


                    string sqlInsert = @"
                INSERT INTO NguoiCungCap VALUES
                ('NCC01', 'Nguyễn Văn A', 'Chủ quán'),
                ('NCC02', 'Trần Thị B', 'Phụ bếp'),
                ('NCC03', 'Lê Văn C', 'Đầu bếp');

                INSERT INTO MonAn VALUES
                ('MA01', 'Phở bò', 'D:\\Images\\phobo.jpg', 'NCC01'),
                ('MA02', 'Bún nước lèo', 'D:\\Images\\bunnuocleo.jpg', 'NCC02'),
                ('MA03', 'Cơm hến', 'D:\\Images\\comhen.jpg', 'NCC03'),
                ('MA04', 'Mỳ Quảng', 'D:\\Images\\myquang.jpg', 'NCC02'),
                ('MA05', 'Cơm tấm', 'D:\\Images\\comtam.jpg', 'NCC03');
            ";

                    using (SQLiteCommand cmd = new SQLiteCommand(sqlInsert, conn))
                        cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã thêm dữ liệu mẫu (đường dẫn ảnh: D:\\Images)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu mẫu: " + ex.Message);
            }
        }


        //Hiển thị danh sách món ăn
        private void DanhsachMonAn_Click(object sender, EventArgs e)
        {
            ShowDanhSachMonAn();
        }

        private void ShowDanhSachMonAn()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM MonAn";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        DSMA.Items.Clear();
                        while (reader.Read())
                        {
                            string MaMonAn = reader["MaMonAn"].ToString();
                            string TenMonAn = reader["TenMonAn"].ToString();
                            string HinhAnh = reader["HinhAnh"].ToString();
                            string MaNguoiCungCap = reader["MaNguoiCungCap"].ToString();

                            ListViewItem item = new ListViewItem(MaMonAn);
                            item.SubItems.Add(TenMonAn);
                            item.SubItems.Add(HinhAnh);
                            item.SubItems.Add(MaNguoiCungCap);
                            DSMA.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc danh sách món ăn: {ex.Message}");
            }
        }

        //Hiển thị danh sách nhà cung cấp
        private void DanhsachNguoiCungCap_Click(object sender, EventArgs e)
        {
            ShowDanhSachNguoiCungCap();
        }

        private void ShowDanhSachNguoiCungCap()
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM NguoiCungCap", conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        DSNCC.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MaNguoiCungCap"].ToString());
                            item.SubItems.Add(reader["HoTen"].ToString());
                            item.SubItems.Add(reader["QuyenHan"].ToString());
                            DSNCC.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc danh sách người cung cấp: {ex.Message}");
            }
        }

        //Tìm ngẫu nhiên 1 món ăn
        private void TimMonAn_Click(object sender, EventArgs e)
        {
            if (DSMA.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống!");
                return;
            }

            Random random = new Random();
            int index = random.Next(0, DSMA.Items.Count);

            string maMonAn = DSMA.Items[index].SubItems[0].Text;
            string tenMonAn = DSMA.Items[index].SubItems[1].Text;
            string maNCC = DSMA.Items[index].SubItems[3].Text;

            string tenNguoiCungCap = GetTenNguoiCungCap(maNCC);
            string hinhAnh = GetImagePathOfSelectedMonAn(maMonAn);

            //Hiển thị thông tin
            TenMonAn.Text = tenMonAn;
            TenNguoiCungCap.Text = tenNguoiCungCap;

            try
            {
                if (!string.IsNullOrEmpty(hinhAnh) && File.Exists(hinhAnh))
                {
                    HinhAnh.Image = Image.FromFile(hinhAnh);
                    HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    HinhAnh.Image = null;
                    MessageBox.Show("Không tìm thấy hình ảnh: " + hinhAnh);
                }
            }
            catch
            {
                HinhAnh.Image = null;
            }
        }

        private string GetImagePathOfSelectedMonAn(string MaMonAn)
        {
            string imagePath = "";
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT HinhAnh FROM MonAn WHERE MaMonAn = @MaMonAn", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMonAn", MaMonAn);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                imagePath = reader["HinhAnh"].ToString();
                        }
                    }
                }
            }
            catch { }
            return imagePath;
        }

        private string GetTenNguoiCungCap(string MaNguoiCungCap)
        {
            string tenNCC = "";
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT HoTen FROM NguoiCungCap WHERE MaNguoiCungCap = @MaNCC", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNCC", MaNguoiCungCap);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                tenNCC = reader["HoTen"].ToString();
                        }
                    }
                }
            }
            catch { }
            return tenNCC;
        }
    }
}

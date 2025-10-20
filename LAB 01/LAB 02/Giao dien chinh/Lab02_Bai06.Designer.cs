namespace Giao_dien_chinh
{
    partial class Lab02_Bai06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DanhsachMonAn = new System.Windows.Forms.Button();
            this.DanhsachNguoiCungCap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TimMonAn = new System.Windows.Forms.Button();
            this.TenMonAn = new System.Windows.Forms.TextBox();
            this.TenNguoiCungCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DSNCC = new System.Windows.Forms.ListView();
            this.DSMA = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.HinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhsachMonAn
            // 
            this.DanhsachMonAn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DanhsachMonAn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachMonAn.Location = new System.Drawing.Point(23, 33);
            this.DanhsachMonAn.Name = "DanhsachMonAn";
            this.DanhsachMonAn.Size = new System.Drawing.Size(231, 39);
            this.DanhsachMonAn.TabIndex = 0;
            this.DanhsachMonAn.Text = "Danh sách món ăn";
            this.DanhsachMonAn.UseVisualStyleBackColor = false;
            this.DanhsachMonAn.Click += new System.EventHandler(this.DanhsachMonAn_Click);
            // 
            // DanhsachNguoiCungCap
            // 
            this.DanhsachNguoiCungCap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DanhsachNguoiCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachNguoiCungCap.Location = new System.Drawing.Point(671, 33);
            this.DanhsachNguoiCungCap.Name = "DanhsachNguoiCungCap";
            this.DanhsachNguoiCungCap.Size = new System.Drawing.Size(346, 39);
            this.DanhsachNguoiCungCap.TabIndex = 0;
            this.DanhsachNguoiCungCap.Text = "Danh sách người cung cấp ";
            this.DanhsachNguoiCungCap.UseVisualStyleBackColor = false;
            this.DanhsachNguoiCungCap.Click += new System.EventHandler(this.DanhsachNguoiCungCap_Click);
            // 
            // TimMonAn
            // 
            this.TimMonAn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimMonAn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimMonAn.Location = new System.Drawing.Point(505, 320);
            this.TimMonAn.Name = "TimMonAn";
            this.TimMonAn.Size = new System.Drawing.Size(141, 40);
            this.TimMonAn.TabIndex = 0;
            this.TimMonAn.Text = "Tìm món ăn";
            this.TimMonAn.UseVisualStyleBackColor = false;
            this.TimMonAn.Click += new System.EventHandler(this.TimMonAn_Click);
            // 
            // TenMonAn
            // 
            this.TenMonAn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMonAn.Location = new System.Drawing.Point(238, 407);
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Size = new System.Drawing.Size(294, 30);
            this.TenMonAn.TabIndex = 1;
            // 
            // TenNguoiCungCap
            // 
            this.TenNguoiCungCap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNguoiCungCap.Location = new System.Drawing.Point(238, 470);
            this.TenNguoiCungCap.Name = "TenNguoiCungCap";
            this.TenNguoiCungCap.Size = new System.Drawing.Size(294, 30);
            this.TenNguoiCungCap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người cung cấp:";
            // 
            // DSNCC
            // 
            this.DSNCC.HideSelection = false;
            this.DSNCC.Location = new System.Drawing.Point(667, 85);
            this.DSNCC.Name = "DSNCC";
            this.DSNCC.Size = new System.Drawing.Size(481, 206);
            this.DSNCC.TabIndex = 3;
            this.DSNCC.UseCompatibleStateImageBehavior = false;
            // 
            // DSMA
            // 
            this.DSMA.HideSelection = false;
            this.DSMA.Location = new System.Drawing.Point(23, 85);
            this.DSMA.Name = "DSMA";
            this.DSMA.Size = new System.Drawing.Size(558, 206);
            this.DSMA.TabIndex = 3;
            this.DSMA.UseCompatibleStateImageBehavior = false;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Location = new System.Drawing.Point(698, 320);
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Size = new System.Drawing.Size(432, 215);
            this.HinhAnh.TabIndex = 4;
            this.HinhAnh.TabStop = false;
            // 
            // Lab02_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1162, 560);
            this.Controls.Add(this.HinhAnh);
            this.Controls.Add(this.DSMA);
            this.Controls.Add(this.DSNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TenNguoiCungCap);
            this.Controls.Add(this.TenMonAn);
            this.Controls.Add(this.DanhsachNguoiCungCap);
            this.Controls.Add(this.TimMonAn);
            this.Controls.Add(this.DanhsachMonAn);
            this.Name = "Lab02_Bai06";
            this.Text = "Lab02_Bai06";
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DanhsachMonAn;
        private System.Windows.Forms.Button DanhsachNguoiCungCap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button TimMonAn;
        private System.Windows.Forms.TextBox TenMonAn;
        private System.Windows.Forms.TextBox TenNguoiCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView DSNCC;
        private System.Windows.Forms.ListView DSMA;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox HinhAnh;
    }
}
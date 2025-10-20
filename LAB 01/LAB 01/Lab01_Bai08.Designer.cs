namespace LAB_01
{
    partial class Lab01_Bai08
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
            this.NhapMonAn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonAn = new System.Windows.Forms.TextBox();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.TimMonAn = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.DanhSach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NhapMonAn
            // 
            this.NhapMonAn.AutoSize = true;
            this.NhapMonAn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapMonAn.Location = new System.Drawing.Point(36, 45);
            this.NhapMonAn.Name = "NhapMonAn";
            this.NhapMonAn.Size = new System.Drawing.Size(122, 21);
            this.NhapMonAn.TabIndex = 0;
            this.NhapMonAn.Text = "Nhập món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Món ăn hôm nay:";
            // 
            // MonAn
            // 
            this.MonAn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonAn.Location = new System.Drawing.Point(175, 38);
            this.MonAn.Name = "MonAn";
            this.MonAn.Size = new System.Drawing.Size(244, 28);
            this.MonAn.TabIndex = 1;
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.SystemColors.Info;
            this.KetQua.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(278, 385);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(377, 28);
            this.KetQua.TabIndex = 1;
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Them.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(331, 85);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(88, 40);
            this.Them.TabIndex = 2;
            this.Them.Text = "THÊM";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // TimMonAn
            // 
            this.TimMonAn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimMonAn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimMonAn.Location = new System.Drawing.Point(40, 237);
            this.TimMonAn.Name = "TimMonAn";
            this.TimMonAn.Size = new System.Drawing.Size(150, 40);
            this.TimMonAn.TabIndex = 2;
            this.TimMonAn.Text = "TÌM MÓN ĂN";
            this.TimMonAn.UseVisualStyleBackColor = false;
            this.TimMonAn.Click += new System.EventHandler(this.TimMonAn_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Thoat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(331, 237);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(88, 40);
            this.Thoat.TabIndex = 2;
            this.Thoat.Text = "THOÁT";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Xoa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(212, 237);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(88, 40);
            this.Xoa.TabIndex = 2;
            this.Xoa.Text = "XÓA";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // DanhSach
            // 
            this.DanhSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSach.FormattingEnabled = true;
            this.DanhSach.ItemHeight = 23;
            this.DanhSach.Location = new System.Drawing.Point(444, 37);
            this.DanhSach.Name = "DanhSach";
            this.DanhSach.Size = new System.Drawing.Size(211, 303);
            this.DanhSach.TabIndex = 3;
            // 
            // Lab01_Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(724, 453);
            this.Controls.Add(this.DanhSach);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.TimMonAn);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.MonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NhapMonAn);
            this.Name = "Lab01_Bai08";
            this.Text = "Lab01_Bai08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NhapMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MonAn;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button TimMonAn;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.ListBox DanhSach;
    }
}
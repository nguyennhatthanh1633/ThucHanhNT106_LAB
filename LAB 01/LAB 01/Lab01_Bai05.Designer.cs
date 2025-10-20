namespace LAB_01
{
    partial class Lab01_Bai05
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
            this.Nhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NhapA = new System.Windows.Forms.TextBox();
            this.NhapB = new System.Windows.Forms.TextBox();
            this.LuaChon = new System.Windows.Forms.ComboBox();
            this.TinhCacGiaTri = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nhap
            // 
            this.Nhap.AutoSize = true;
            this.Nhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Nhap.Location = new System.Drawing.Point(44, 64);
            this.Nhap.Name = "Nhap";
            this.Nhap.Size = new System.Drawing.Size(84, 24);
            this.Nhap.TabIndex = 0;
            this.Nhap.Text = "Nhập A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(388, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập B:";
            // 
            // NhapA
            // 
            this.NhapA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapA.Location = new System.Drawing.Point(134, 47);
            this.NhapA.Multiline = true;
            this.NhapA.Name = "NhapA";
            this.NhapA.Size = new System.Drawing.Size(167, 41);
            this.NhapA.TabIndex = 1;
            // 
            // NhapB
            // 
            this.NhapB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapB.Location = new System.Drawing.Point(480, 47);
            this.NhapB.Multiline = true;
            this.NhapB.Name = "NhapB";
            this.NhapB.Size = new System.Drawing.Size(170, 41);
            this.NhapB.TabIndex = 1;
            // 
            // LuaChon
            // 
            this.LuaChon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuaChon.FormattingEnabled = true;
            this.LuaChon.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán các giá trị"});
            this.LuaChon.Location = new System.Drawing.Point(275, 140);
            this.LuaChon.Name = "LuaChon";
            this.LuaChon.Size = new System.Drawing.Size(199, 27);
            this.LuaChon.TabIndex = 2;
            // 
            // TinhCacGiaTri
            // 
            this.TinhCacGiaTri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TinhCacGiaTri.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhCacGiaTri.ForeColor = System.Drawing.Color.Navy;
            this.TinhCacGiaTri.Location = new System.Drawing.Point(48, 238);
            this.TinhCacGiaTri.Name = "TinhCacGiaTri";
            this.TinhCacGiaTri.Size = new System.Drawing.Size(236, 43);
            this.TinhCacGiaTri.TabIndex = 3;
            this.TinhCacGiaTri.Text = "TÍNH CÁC GIÁ TRỊ";
            this.TinhCacGiaTri.UseVisualStyleBackColor = false;
            this.TinhCacGiaTri.Click += new System.EventHandler(this.TinhCacGiaTri_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Xoa.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.Navy;
            this.Xoa.Location = new System.Drawing.Point(337, 238);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(126, 43);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "XÓA";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Thoat.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.Color.Navy;
            this.Thoat.Location = new System.Drawing.Point(524, 238);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(126, 43);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "THOÁT";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(118, 44);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(428, 338);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(118, 44);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(5, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "KẾT QUẢ:";
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.Color.LightCyan;
            this.KetQua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(134, 337);
            this.KetQua.Multiline = true;
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(516, 257);
            this.KetQua.TabIndex = 6;
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(688, 625);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.TinhCacGiaTri);
            this.Controls.Add(this.LuaChon);
            this.Controls.Add(this.NhapB);
            this.Controls.Add(this.NhapA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nhap);
            this.Name = "Lab01_Bai05";
            this.Text = "Lab01_Bai05";
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhapA;
        private System.Windows.Forms.TextBox NhapB;
        private System.Windows.Forms.ComboBox LuaChon;
        private System.Windows.Forms.Button TinhCacGiaTri;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KetQua;
    }
}
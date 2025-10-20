namespace LAB_01
{
    partial class Lab01_Bai06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai06));
            this.label1 = new System.Windows.Forms.Label();
            this.NgayThangNam = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.XemCung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(235, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "12 CUNG HOÀNG ĐẠO";
            // 
            // NgayThangNam
            // 
            this.NgayThangNam.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayThangNam.Location = new System.Drawing.Point(470, 230);
            this.NgayThangNam.Name = "NgayThangNam";
            this.NgayThangNam.Size = new System.Drawing.Size(260, 28);
            this.NgayThangNam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(227, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày, tháng, năm sinh: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(227, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CUNG HOÀNG ĐẠO: ";
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KetQua.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.ForeColor = System.Drawing.Color.Navy;
            this.KetQua.Location = new System.Drawing.Point(470, 305);
            this.KetQua.Multiline = true;
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(261, 33);
            this.KetQua.TabIndex = 3;
            // 
            // XemCung
            // 
            this.XemCung.BackColor = System.Drawing.Color.Goldenrod;
            this.XemCung.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemCung.ForeColor = System.Drawing.SystemColors.Window;
            this.XemCung.Location = new System.Drawing.Point(338, 379);
            this.XemCung.Name = "XemCung";
            this.XemCung.Size = new System.Drawing.Size(292, 42);
            this.XemCung.TabIndex = 4;
            this.XemCung.Text = "XEM CUNG HOÀNG ĐẠO ";
            this.XemCung.UseVisualStyleBackColor = false;
            this.XemCung.Click += new System.EventHandler(this.XemCung_Click);
            // 
            // Lab01_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 582);
            this.Controls.Add(this.XemCung);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NgayThangNam);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai06";
            this.Text = "Lab01_Bai06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NgayThangNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Button XemCung;
    }
}
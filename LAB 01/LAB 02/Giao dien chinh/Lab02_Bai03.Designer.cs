namespace Giao_dien_chinh
{
    partial class Lab02_Bai03
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
            this.Doc = new System.Windows.Forms.Button();
            this.Ghi = new System.Windows.Forms.Button();
            this.TinhToan = new System.Windows.Forms.Button();
            this.NoiDung = new System.Windows.Forms.TextBox();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Doc
            // 
            this.Doc.BackColor = System.Drawing.Color.MistyRose;
            this.Doc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.DarkRed;
            this.Doc.Location = new System.Drawing.Point(125, 53);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(130, 42);
            this.Doc.TabIndex = 0;
            this.Doc.Text = "ĐỌC FILE";
            this.Doc.UseVisualStyleBackColor = false;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Ghi
            // 
            this.Ghi.BackColor = System.Drawing.Color.MistyRose;
            this.Ghi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghi.ForeColor = System.Drawing.Color.DarkRed;
            this.Ghi.Location = new System.Drawing.Point(382, 53);
            this.Ghi.Name = "Ghi";
            this.Ghi.Size = new System.Drawing.Size(130, 42);
            this.Ghi.TabIndex = 0;
            this.Ghi.Text = "GHI FILE";
            this.Ghi.UseVisualStyleBackColor = false;
            this.Ghi.Click += new System.EventHandler(this.Ghi_Click);
            // 
            // TinhToan
            // 
            this.TinhToan.BackColor = System.Drawing.Color.MistyRose;
            this.TinhToan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhToan.ForeColor = System.Drawing.Color.DarkRed;
            this.TinhToan.Location = new System.Drawing.Point(642, 53);
            this.TinhToan.Name = "TinhToan";
            this.TinhToan.Size = new System.Drawing.Size(152, 42);
            this.TinhToan.TabIndex = 0;
            this.TinhToan.Text = "TÍNH TOÁN";
            this.TinhToan.UseVisualStyleBackColor = false;
            this.TinhToan.Click += new System.EventHandler(this.TinhToan_Click);
            // 
            // NoiDung
            // 
            this.NoiDung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDung.Location = new System.Drawing.Point(34, 181);
            this.NoiDung.Multiline = true;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(833, 164);
            this.NoiDung.TabIndex = 1;
            // 
            // KetQua
            // 
            this.KetQua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(34, 419);
            this.KetQua.Multiline = true;
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(833, 164);
            this.KetQua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nội dung file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả tính toán:";
            // 
            // Lab02_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(901, 622);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.NoiDung);
            this.Controls.Add(this.TinhToan);
            this.Controls.Add(this.Ghi);
            this.Controls.Add(this.Doc);
            this.Name = "Lab02_Bai03";
            this.Text = "Lab02_Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Ghi;
        private System.Windows.Forms.Button TinhToan;
        private System.Windows.Forms.TextBox NoiDung;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace Giao_dien_chinh
{
    partial class Lab02_Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.Doc = new System.Windows.Forms.Button();
            this.Ghi = new System.Windows.Forms.Button();
            this.DocDL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(197, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG VÉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Nhập thông tin phim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(349, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Nội dung:";
            // 
            // KetQua
            // 
            this.KetQua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(361, 166);
            this.KetQua.Multiline = true;
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(362, 694);
            this.KetQua.TabIndex = 1;
            // 
            // Doc
            // 
            this.Doc.BackColor = System.Drawing.SystemColors.Info;
            this.Doc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.Maroon;
            this.Doc.Location = new System.Drawing.Point(93, 899);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(164, 48);
            this.Doc.TabIndex = 2;
            this.Doc.Text = "ĐỌC DỮ LIỆU";
            this.Doc.UseVisualStyleBackColor = false;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Ghi
            // 
            this.Ghi.BackColor = System.Drawing.SystemColors.Info;
            this.Ghi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghi.ForeColor = System.Drawing.Color.Maroon;
            this.Ghi.Location = new System.Drawing.Point(474, 899);
            this.Ghi.Name = "Ghi";
            this.Ghi.Size = new System.Drawing.Size(164, 48);
            this.Ghi.TabIndex = 2;
            this.Ghi.Text = "GHI DỮ LIỆU";
            this.Ghi.UseVisualStyleBackColor = false;
            this.Ghi.Click += new System.EventHandler(this.Ghi_Click);
            // 
            // DocDL
            // 
            this.DocDL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDL.Location = new System.Drawing.Point(34, 166);
            this.DocDL.Multiline = true;
            this.DocDL.Name = "DocDL";
            this.DocDL.Size = new System.Drawing.Size(268, 694);
            this.DocDL.TabIndex = 1;
            // 
            // Lab02_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(795, 989);
            this.Controls.Add(this.Ghi);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.DocDL);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab02_Bai05";
            this.Text = "Lab02_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Ghi;
        private System.Windows.Forms.TextBox DocDL;
    }
}
namespace LAB_01
{
    partial class Lab01_Bai3_1
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
            this.DocSo = new System.Windows.Forms.TextBox();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.Doc = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(172, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỌC SỐ NGUYÊN (NÂNG CAO)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(36, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(36, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả:";
            // 
            // DocSo
            // 
            this.DocSo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSo.Location = new System.Drawing.Point(168, 162);
            this.DocSo.Name = "DocSo";
            this.DocSo.Size = new System.Drawing.Size(725, 34);
            this.DocSo.TabIndex = 2;
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.Color.LightCyan;
            this.KetQua.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.Location = new System.Drawing.Point(168, 231);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(725, 34);
            this.KetQua.TabIndex = 2;
            // 
            // Doc
            // 
            this.Doc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Doc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.Navy;
            this.Doc.Location = new System.Drawing.Point(121, 329);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(112, 39);
            this.Doc.TabIndex = 3;
            this.Doc.Text = "ĐỌC";
            this.Doc.UseVisualStyleBackColor = false;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Xoa.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.Navy;
            this.Xoa.Location = new System.Drawing.Point(313, 329);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(112, 39);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "XÓA";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Thoat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.Color.Navy;
            this.Thoat.Location = new System.Drawing.Point(521, 329);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(140, 39);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "THOÁT";
            this.Thoat.UseVisualStyleBackColor = false;
            // 
            // Lab01_Bai3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(905, 437);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.DocSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai3_1";
            this.Text = "Lab01_Bai3_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocSo;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
    }
}
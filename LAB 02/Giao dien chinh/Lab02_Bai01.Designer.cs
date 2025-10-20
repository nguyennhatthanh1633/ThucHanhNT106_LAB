namespace Giao_dien_chinh
{
    partial class Lab02_Bai01
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
            this.NoiDung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Doc
            // 
            this.Doc.BackColor = System.Drawing.Color.MistyRose;
            this.Doc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doc.ForeColor = System.Drawing.Color.DarkRed;
            this.Doc.Location = new System.Drawing.Point(41, 148);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(144, 42);
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
            this.Ghi.Location = new System.Drawing.Point(41, 241);
            this.Ghi.Name = "Ghi";
            this.Ghi.Size = new System.Drawing.Size(144, 42);
            this.Ghi.TabIndex = 0;
            this.Ghi.Text = "GHI FILE";
            this.Ghi.UseVisualStyleBackColor = false;
            this.Ghi.Click += new System.EventHandler(this.Ghi_Click);
            // 
            // NoiDung
            // 
            this.NoiDung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDung.Location = new System.Drawing.Point(218, 33);
            this.NoiDung.Multiline = true;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(549, 383);
            this.NoiDung.TabIndex = 1;
            // 
            // Lab02_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.NoiDung);
            this.Controls.Add(this.Ghi);
            this.Controls.Add(this.Doc);
            this.Name = "Lab02_Bai01";
            this.Text = "Lab02_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Ghi;
        private System.Windows.Forms.TextBox NoiDung;
    }
}
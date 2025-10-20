namespace Giao_dien_chinh
{
    partial class Lab02_Bai07
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
            this.TreeDirectory = new System.Windows.Forms.TreeView();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.FilePictureContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureContent)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeDirectory
            // 
            this.TreeDirectory.Location = new System.Drawing.Point(12, 12);
            this.TreeDirectory.Name = "TreeDirectory";
            this.TreeDirectory.Size = new System.Drawing.Size(314, 714);
            this.TreeDirectory.TabIndex = 0;
            this.TreeDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDirectory_NodeMouseClick);
            // 
            // txtFileContent
            // 
            this.txtFileContent.BackColor = System.Drawing.SystemColors.Control;
            this.txtFileContent.Location = new System.Drawing.Point(353, 12);
            this.txtFileContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ReadOnly = true;
            this.txtFileContent.Size = new System.Drawing.Size(717, 714);
            this.txtFileContent.TabIndex = 4;
            this.txtFileContent.Text = "";
            this.txtFileContent.Visible = false;
            // 
            // FilePictureContent
            // 
            this.FilePictureContent.Location = new System.Drawing.Point(353, 13);
            this.FilePictureContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilePictureContent.Name = "FilePictureContent";
            this.FilePictureContent.Size = new System.Drawing.Size(716, 713);
            this.FilePictureContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilePictureContent.TabIndex = 2;
            this.FilePictureContent.TabStop = false;
            this.FilePictureContent.Visible = false;
            // 
            // Lab02_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 737);
            this.Controls.Add(this.FilePictureContent);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.TreeDirectory);
            this.Name = "Lab02_Bai07";
            this.Text = "Lab02_Bai07";
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeDirectory;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.PictureBox FilePictureContent;
    }
}
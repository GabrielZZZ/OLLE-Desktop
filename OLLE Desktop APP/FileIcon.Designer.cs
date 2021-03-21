namespace OLLE_Desktop_APP
{
    partial class FileIcon
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fileImage = new System.Windows.Forms.PictureBox();
            this.fileName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileImage
            // 
            this.fileImage.Location = new System.Drawing.Point(41, 38);
            this.fileImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileImage.Name = "fileImage";
            this.fileImage.Size = new System.Drawing.Size(119, 114);
            this.fileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileImage.TabIndex = 0;
            this.fileImage.TabStop = false;
            // 
            // fileName
            // 
            this.fileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(0, 0);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileName.MaximumSize = new System.Drawing.Size(0, 30);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(200, 30);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "aaaaaaaaaaaaaaa";
            this.fileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileName.Click += new System.EventHandler(this.FileName_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 2;
            // 
            // FileIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fileImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(190, 190);
            this.Name = "FileIcon";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.FileIcon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fileImage;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Panel panel1;
    }
}

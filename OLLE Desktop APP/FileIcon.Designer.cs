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
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // fileImage
            // 
            this.fileImage.Location = new System.Drawing.Point(47, 37);
            this.fileImage.Name = "fileImage";
            this.fileImage.Size = new System.Drawing.Size(223, 182);
            this.fileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fileImage.TabIndex = 0;
            this.fileImage.TabStop = false;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(42, 247);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(77, 27);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "label1";
            // 
            // FileIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileImage);
            this.Name = "FileIcon";
            this.Size = new System.Drawing.Size(325, 300);
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fileImage;
        private System.Windows.Forms.Label fileName;
    }
}

namespace OLLE_Desktop_APP
{
    partial class Topic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topic));
            this.topic_title = new System.Windows.Forms.Label();
            this.topic_details = new System.Windows.Forms.Label();
            this.author_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(93, 10);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(50, 22);
            this.topic_title.TabIndex = 0;
            this.topic_title.Text = "Title";
            // 
            // topic_details
            // 
            this.topic_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details.ForeColor = System.Drawing.SystemColors.GrayText;
            this.topic_details.Location = new System.Drawing.Point(93, 46);
            this.topic_details.Name = "topic_details";
            this.topic_details.Size = new System.Drawing.Size(745, 55);
            this.topic_details.TabIndex = 1;
            this.topic_details.Text = "Topic Details";
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(15, 24);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(62, 59);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 2;
            this.author_image.TabStop = false;
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_details);
            this.Controls.Add(this.topic_title);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Topic";
            this.Size = new System.Drawing.Size(856, 116);
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_title;
        private System.Windows.Forms.Label topic_details;
        private System.Windows.Forms.PictureBox author_image;
    }
}

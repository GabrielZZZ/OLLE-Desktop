namespace OLLE_Desktop_APP
{
    partial class Reply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reply));
            this.topic_date1 = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.Label();
            this.author_image = new System.Windows.Forms.PictureBox();
            this.topic_details = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_date1
            // 
            this.topic_date1.AutoSize = true;
            this.topic_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date1.Location = new System.Drawing.Point(24, 225);
            this.topic_date1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_date1.Name = "topic_date1";
            this.topic_date1.Size = new System.Drawing.Size(75, 32);
            this.topic_date1.TabIndex = 26;
            this.topic_date1.Text = "Date";
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(23, 157);
            this.author_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(122, 44);
            this.author_name.TabIndex = 25;
            this.author_name.Text = "Name";
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(28, 23);
            this.author_image.Margin = new System.Windows.Forms.Padding(6);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(124, 118);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 24;
            this.author_image.TabStop = false;
            // 
            // topic_details
            // 
            this.topic_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details.ForeColor = System.Drawing.SystemColors.GrayText;
            this.topic_details.Location = new System.Drawing.Point(186, 23);
            this.topic_details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_details.Name = "topic_details";
            this.topic_details.Size = new System.Drawing.Size(1175, 234);
            this.topic_details.TabIndex = 27;
            this.topic_details.Text = "Topic Details";
            // 
            // Reply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topic_details);
            this.Controls.Add(this.topic_date1);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Name = "Reply";
            this.Size = new System.Drawing.Size(1388, 300);
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_date1;
        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.PictureBox author_image;
        private System.Windows.Forms.Label topic_details;
    }
}

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
            this.topic_date = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.Label();
            this.author_image = new System.Windows.Forms.PictureBox();
            this.topic_title = new System.Windows.Forms.Label();
            this.topic_date1 = new System.Windows.Forms.Label();
            this.view_details = new System.Windows.Forms.Button();
            this.author_name1 = new System.Windows.Forms.Label();
            this.author_image1 = new System.Windows.Forms.PictureBox();
            this.topic_details = new System.Windows.Forms.Label();
            this.topic_title1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_image1)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_date
            // 
            this.topic_date.AutoSize = true;
            this.topic_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date.Location = new System.Drawing.Point(82, -106);
            this.topic_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_date.Name = "topic_date";
            this.topic_date.Size = new System.Drawing.Size(66, 28);
            this.topic_date.TabIndex = 17;
            this.topic_date.Text = "Date";
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(88, -174);
            this.author_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(129, 44);
            this.author_name.TabIndex = 15;
            this.author_name.Text = "Name";
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(90, -308);
            this.author_image.Margin = new System.Windows.Forms.Padding(6);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(124, 118);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 14;
            this.author_image.TabStop = false;
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(246, -312);
            this.topic_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(100, 44);
            this.topic_title.TabIndex = 13;
            this.topic_title.Text = "Title";
            // 
            // topic_date1
            // 
            this.topic_date1.AutoSize = true;
            this.topic_date1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date1.Location = new System.Drawing.Point(20, 252);
            this.topic_date1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_date1.Name = "topic_date1";
            this.topic_date1.Size = new System.Drawing.Size(80, 32);
            this.topic_date1.TabIndex = 23;
            this.topic_date1.Text = "Date";
            // 
            // view_details
            // 
            this.view_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_details.Location = new System.Drawing.Point(1458, 296);
            this.view_details.Margin = new System.Windows.Forms.Padding(6);
            this.view_details.Name = "view_details";
            this.view_details.Size = new System.Drawing.Size(150, 46);
            this.view_details.TabIndex = 22;
            this.view_details.Text = "Details";
            this.view_details.UseVisualStyleBackColor = true;
            this.view_details.Click += new System.EventHandler(this.view_details_Click_1);
            // 
            // author_name1
            // 
            this.author_name1.AutoSize = true;
            this.author_name1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name1.Location = new System.Drawing.Point(19, 184);
            this.author_name1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.author_name1.Name = "author_name1";
            this.author_name1.Size = new System.Drawing.Size(129, 44);
            this.author_name1.TabIndex = 21;
            this.author_name1.Text = "Name";
            // 
            // author_image1
            // 
            this.author_image1.Image = ((System.Drawing.Image)(resources.GetObject("author_image1.Image")));
            this.author_image1.Location = new System.Drawing.Point(24, 50);
            this.author_image1.Margin = new System.Windows.Forms.Padding(6);
            this.author_image1.Name = "author_image1";
            this.author_image1.Size = new System.Drawing.Size(124, 118);
            this.author_image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image1.TabIndex = 20;
            this.author_image1.TabStop = false;
            // 
            // topic_details
            // 
            this.topic_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details.ForeColor = System.Drawing.SystemColors.GrayText;
            this.topic_details.Location = new System.Drawing.Point(180, 118);
            this.topic_details.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_details.Name = "topic_details";
            this.topic_details.Size = new System.Drawing.Size(1490, 110);
            this.topic_details.TabIndex = 19;
            this.topic_details.Text = "Topic Details";
            // 
            // topic_title1
            // 
            this.topic_title1.AutoSize = true;
            this.topic_title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title1.Location = new System.Drawing.Point(180, 46);
            this.topic_title1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_title1.Name = "topic_title1";
            this.topic_title1.Size = new System.Drawing.Size(100, 44);
            this.topic_title1.TabIndex = 18;
            this.topic_title1.Text = "Title";
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.topic_date1);
            this.Controls.Add(this.view_details);
            this.Controls.Add(this.author_name1);
            this.Controls.Add(this.author_image1);
            this.Controls.Add(this.topic_details);
            this.Controls.Add(this.topic_title1);
            this.Controls.Add(this.topic_date);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_title);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Topic";
            this.Size = new System.Drawing.Size(1682, 354);
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_date;
        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.PictureBox author_image;
        private System.Windows.Forms.Label topic_title;
        private System.Windows.Forms.Label topic_date1;
        private System.Windows.Forms.Button view_details;
        private System.Windows.Forms.Label author_name1;
        private System.Windows.Forms.PictureBox author_image1;
        private System.Windows.Forms.Label topic_details;
        private System.Windows.Forms.Label topic_title1;
    }
}

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
            this.label1 = new System.Windows.Forms.Label();
            this.view_details = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topic_details = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_date
            // 
            this.topic_date.AutoSize = true;
            this.topic_date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date.Location = new System.Drawing.Point(41, -53);
            this.topic_date.Name = "topic_date";
            this.topic_date.Size = new System.Drawing.Size(34, 14);
            this.topic_date.TabIndex = 17;
            this.topic_date.Text = "Date";
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(44, -87);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(63, 22);
            this.author_name.TabIndex = 15;
            this.author_name.Text = "Name";
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(45, -154);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(62, 59);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 14;
            this.author_image.TabStop = false;
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(123, -156);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(50, 22);
            this.topic_title.TabIndex = 13;
            this.topic_title.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date";
            // 
            // view_details
            // 
            this.view_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_details.Location = new System.Drawing.Point(729, 148);
            this.view_details.Name = "view_details";
            this.view_details.Size = new System.Drawing.Size(75, 23);
            this.view_details.TabIndex = 22;
            this.view_details.Text = "Details";
            this.view_details.UseVisualStyleBackColor = true;
            this.view_details.Click += new System.EventHandler(this.view_details_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // topic_details
            // 
            this.topic_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details.ForeColor = System.Drawing.SystemColors.GrayText;
            this.topic_details.Location = new System.Drawing.Point(90, 59);
            this.topic_details.Name = "topic_details";
            this.topic_details.Size = new System.Drawing.Size(745, 55);
            this.topic_details.TabIndex = 19;
            this.topic_details.Text = "Topic Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Title";
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view_details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topic_details);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topic_date);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_title);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Topic";
            this.Size = new System.Drawing.Size(856, 179);
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_date;
        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.PictureBox author_image;
        private System.Windows.Forms.Label topic_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topic_details;
        private System.Windows.Forms.Label label3;
    }
}

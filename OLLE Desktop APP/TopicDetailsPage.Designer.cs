namespace OLLE_Desktop_APP
{
    partial class TopicDetailsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicDetailsPage));
            this.topic_date = new System.Windows.Forms.Label();
            this.topic_details1 = new System.Windows.Forms.RichTextBox();
            this.author_name = new System.Windows.Forms.Label();
            this.topic_title = new System.Windows.Forms.Label();
            this.fileLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.download_button = new System.Windows.Forms.Button();
            this.author_image = new System.Windows.Forms.PictureBox();
            this.replyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.reply_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_date
            // 
            this.topic_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topic_date.AutoSize = true;
            this.topic_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date.Location = new System.Drawing.Point(17, 139);
            this.topic_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topic_date.MaximumSize = new System.Drawing.Size(85, 0);
            this.topic_date.Name = "topic_date";
            this.topic_date.Size = new System.Drawing.Size(33, 15);
            this.topic_date.TabIndex = 17;
            this.topic_date.Text = "Date";
            // 
            // topic_details1
            // 
            this.topic_details1.AutoWordSelection = true;
            this.topic_details1.BackColor = System.Drawing.Color.White;
            this.topic_details1.Cursor = System.Windows.Forms.Cursors.Default;
            this.topic_details1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details1.Location = new System.Drawing.Point(132, 62);
            this.topic_details1.Margin = new System.Windows.Forms.Padding(4);
            this.topic_details1.Name = "topic_details1";
            this.topic_details1.ReadOnly = true;
            this.topic_details1.Size = new System.Drawing.Size(927, 486);
            this.topic_details1.TabIndex = 16;
            this.topic_details1.Text = "Topic Details";
            this.topic_details1.TextChanged += new System.EventHandler(this.topic_details1_TextChanged);
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(21, 100);
            this.author_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(78, 29);
            this.author_name.TabIndex = 15;
            this.author_name.Text = "Name";
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topic_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(132, 16);
            this.topic_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(63, 31);
            this.topic_title.TabIndex = 13;
            this.topic_title.Text = "Title";
            // 
            // fileLayoutPanel
            // 
            this.fileLayoutPanel.AutoScroll = true;
            this.fileLayoutPanel.BackColor = System.Drawing.Color.White;
            this.fileLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileLayoutPanel.Location = new System.Drawing.Point(132, 588);
            this.fileLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.Size = new System.Drawing.Size(767, 124);
            this.fileLayoutPanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(951, 662);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "download";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // download_button
            // 
            this.download_button.BackColor = System.Drawing.Color.White;
            this.download_button.BackgroundImage = global::OLLE_Desktop_APP.Properties.Resources.download;
            this.download_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.download_button.Location = new System.Drawing.Point(951, 598);
            this.download_button.Margin = new System.Windows.Forms.Padding(2);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(63, 58);
            this.download_button.TabIndex = 19;
            this.download_button.UseVisualStyleBackColor = false;
            this.download_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(23, 16);
            this.author_image.Margin = new System.Windows.Forms.Padding(4);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(83, 74);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 14;
            this.author_image.TabStop = false;
            // 
            // replyPanel
            // 
            this.replyPanel.AutoScroll = true;
            this.replyPanel.Location = new System.Drawing.Point(132, 780);
            this.replyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.replyPanel.Name = "replyPanel";
            this.replyPanel.Size = new System.Drawing.Size(925, 175);
            this.replyPanel.TabIndex = 21;
            this.replyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.replyPanel_Paint);
            // 
            // reply_button
            // 
            this.reply_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reply_button.Location = new System.Drawing.Point(951, 739);
            this.reply_button.Name = "reply_button";
            this.reply_button.Size = new System.Drawing.Size(87, 36);
            this.reply_button.TabIndex = 22;
            this.reply_button.Text = "Reply";
            this.reply_button.UseVisualStyleBackColor = true;
            this.reply_button.Click += new System.EventHandler(this.reply_button_Click);
            // 
            // TopicDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 966);
            this.Controls.Add(this.reply_button);
            this.Controls.Add(this.replyPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.fileLayoutPanel);
            this.Controls.Add(this.topic_date);
            this.Controls.Add(this.topic_details1);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TopicDetailsPage";
            this.Text = "TopicDetails";
            this.Load += new System.EventHandler(this.TopicDetailsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topic_date;
        private System.Windows.Forms.RichTextBox topic_details1;
        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.PictureBox author_image;
        private System.Windows.Forms.Label topic_title;
        public System.Windows.Forms.FlowLayoutPanel fileLayoutPanel;
        public System.Windows.Forms.Button download_button;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel replyPanel;
        private System.Windows.Forms.Button reply_button;
    }
}
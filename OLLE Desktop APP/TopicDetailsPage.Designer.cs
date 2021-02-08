﻿namespace OLLE_Desktop_APP
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
            this.button1 = new System.Windows.Forms.Button();
            this.author_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.author_image)).BeginInit();
            this.SuspendLayout();
            // 
            // topic_date
            // 
            this.topic_date.AutoSize = true;
            this.topic_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_date.Location = new System.Drawing.Point(26, 228);
            this.topic_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_date.Name = "topic_date";
            this.topic_date.Size = new System.Drawing.Size(63, 29);
            this.topic_date.TabIndex = 17;
            this.topic_date.Text = "Date";
            // 
            // topic_details1
            // 
            this.topic_details1.AutoWordSelection = true;
            this.topic_details1.BackColor = System.Drawing.Color.White;
            this.topic_details1.Cursor = System.Windows.Forms.Cursors.Default;
            this.topic_details1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_details1.Location = new System.Drawing.Point(197, 325);
            this.topic_details1.Margin = new System.Windows.Forms.Padding(6);
            this.topic_details1.Name = "topic_details1";
            this.topic_details1.ReadOnly = true;
            this.topic_details1.Size = new System.Drawing.Size(1388, 776);
            this.topic_details1.TabIndex = 16;
            this.topic_details1.Text = "Topic Details";
            this.topic_details1.TextChanged += new System.EventHandler(this.topic_details1_TextChanged);
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(32, 160);
            this.author_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(122, 44);
            this.author_name.TabIndex = 15;
            this.author_name.Text = "Name";
            // 
            // topic_title
            // 
            this.topic_title.AutoSize = true;
            this.topic_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topic_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_title.Location = new System.Drawing.Point(198, 26);
            this.topic_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topic_title.Name = "topic_title";
            this.topic_title.Size = new System.Drawing.Size(95, 46);
            this.topic_title.TabIndex = 13;
            this.topic_title.Text = "Title";
            // 
            // fileLayoutPanel
            // 
            this.fileLayoutPanel.AutoScroll = true;
            this.fileLayoutPanel.BackColor = System.Drawing.Color.White;
            this.fileLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileLayoutPanel.Location = new System.Drawing.Point(198, 95);
            this.fileLayoutPanel.Name = "fileLayoutPanel";
            this.fileLayoutPanel.Size = new System.Drawing.Size(1148, 196);
            this.fileLayoutPanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1427, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "download";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::OLLE_Desktop_APP.Properties.Resources.download;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1427, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 93);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // author_image
            // 
            this.author_image.Image = ((System.Drawing.Image)(resources.GetObject("author_image.Image")));
            this.author_image.Location = new System.Drawing.Point(34, 26);
            this.author_image.Margin = new System.Windows.Forms.Padding(6);
            this.author_image.Name = "author_image";
            this.author_image.Size = new System.Drawing.Size(124, 118);
            this.author_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.author_image.TabIndex = 14;
            this.author_image.TabStop = false;
            // 
            // TopicDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 1429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileLayoutPanel);
            this.Controls.Add(this.topic_date);
            this.Controls.Add(this.topic_details1);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.author_image);
            this.Controls.Add(this.topic_title);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TopicDetailsPage";
            this.Text = "TopicDetails";
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
        private System.Windows.Forms.FlowLayoutPanel fileLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
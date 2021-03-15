﻿namespace OLLE_Desktop_APP
{
    partial class Forum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forum));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_button = new System.Windows.Forms.Button();
            this.NAAenable = new System.Windows.Forms.CheckBox();
            this.newTopic = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "OLLE Forum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.NAAenable);
            this.panel1.Controls.Add(this.newTopic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 92);
            this.panel1.TabIndex = 2;
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_button.ForeColor = System.Drawing.Color.Black;
            this.refresh_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh_button.Location = new System.Drawing.Point(923, 56);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(36, 28);
            this.refresh_button.TabIndex = 4;
            this.refresh_button.Text = "↻";
            this.refresh_button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // NAAenable
            // 
            this.NAAenable.AutoSize = true;
            this.NAAenable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAAenable.ForeColor = System.Drawing.Color.White;
            this.NAAenable.Location = new System.Drawing.Point(848, 58);
            this.NAAenable.Margin = new System.Windows.Forms.Padding(2);
            this.NAAenable.Name = "NAAenable";
            this.NAAenable.Size = new System.Drawing.Size(59, 22);
            this.NAAenable.TabIndex = 2;
            this.NAAenable.Text = "NAA";
            this.NAAenable.UseVisualStyleBackColor = true;
            this.NAAenable.CheckedChanged += new System.EventHandler(this.NAAenable_CheckedChanged);
            // 
            // newTopic
            // 
            this.newTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTopic.Location = new System.Drawing.Point(975, 56);
            this.newTopic.Margin = new System.Windows.Forms.Padding(2);
            this.newTopic.Name = "newTopic";
            this.newTopic.Size = new System.Drawing.Size(135, 31);
            this.newTopic.TabIndex = 1;
            this.newTopic.Text = "New Topic";
            this.newTopic.UseVisualStyleBackColor = true;
            this.newTopic.Click += new System.EventHandler(this.newTopic_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 92);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1124, 619);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 711);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Forum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forum";
            this.Load += new System.EventHandler(this.Forum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button newTopic;
        private System.Windows.Forms.CheckBox NAAenable;
        private System.Windows.Forms.Button refresh_button;
    }
}
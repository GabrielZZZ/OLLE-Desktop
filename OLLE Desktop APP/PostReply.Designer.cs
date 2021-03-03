namespace OLLE_Desktop_APP
{
    partial class PostReply
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
            this.reply_content = new System.Windows.Forms.RichTextBox();
            this.post_reply_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reply_content
            // 
            this.reply_content.Location = new System.Drawing.Point(26, 38);
            this.reply_content.Name = "reply_content";
            this.reply_content.Size = new System.Drawing.Size(743, 310);
            this.reply_content.TabIndex = 0;
            this.reply_content.Text = "";
            // 
            // post_reply_button
            // 
            this.post_reply_button.AutoSize = true;
            this.post_reply_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_reply_button.Location = new System.Drawing.Point(669, 389);
            this.post_reply_button.Name = "post_reply_button";
            this.post_reply_button.Size = new System.Drawing.Size(94, 28);
            this.post_reply_button.TabIndex = 1;
            this.post_reply_button.Text = "Post Reply";
            this.post_reply_button.UseVisualStyleBackColor = true;
            this.post_reply_button.Click += new System.EventHandler(this.post_reply_button_Click);
            // 
            // PostReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.post_reply_button);
            this.Controls.Add(this.reply_content);
            this.Name = "PostReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostReply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reply_content;
        private System.Windows.Forms.Button post_reply_button;
    }
}
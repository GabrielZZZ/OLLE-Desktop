namespace OLLE_Desktop_APP
{
    partial class newTopic
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.bold = new System.Windows.Forms.Button();
            this.italic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.submitTopic = new System.Windows.Forms.Button();
            this.uploadFile = new System.Windows.Forms.Button();
            this.selectFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.underline_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(34, 152);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(1608, 35);
            this.titleBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contents";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contentBox
            // 
            this.contentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentBox.Location = new System.Drawing.Point(34, 364);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(1608, 694);
            this.contentBox.TabIndex = 3;
            this.contentBox.Text = "";
            this.contentBox.TextChanged += new System.EventHandler(this.contentBox_TextChanged);
            // 
            // bold
            // 
            this.bold.BackColor = System.Drawing.Color.White;
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(34, 308);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(59, 43);
            this.bold.TabIndex = 4;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = false;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.BackColor = System.Drawing.Color.White;
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(102, 307);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(59, 43);
            this.italic.TabIndex = 5;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = false;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 1118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 61);
            this.label3.TabIndex = 6;
            this.label3.Text = "Upload";
            // 
            // submitTopic
            // 
            this.submitTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTopic.Location = new System.Drawing.Point(1501, 34);
            this.submitTopic.Name = "submitTopic";
            this.submitTopic.Size = new System.Drawing.Size(141, 50);
            this.submitTopic.TabIndex = 7;
            this.submitTopic.Text = "Submit!";
            this.submitTopic.UseVisualStyleBackColor = true;
            this.submitTopic.Click += new System.EventHandler(this.submitTopic_Click);
            // 
            // uploadFile
            // 
            this.uploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFile.Location = new System.Drawing.Point(34, 1249);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(285, 117);
            this.uploadFile.TabIndex = 8;
            this.uploadFile.Text = "Upload File";
            this.uploadFile.UseVisualStyleBackColor = true;
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // selectFilePanel
            // 
            this.selectFilePanel.AutoScroll = true;
            this.selectFilePanel.AutoSize = true;
            this.selectFilePanel.BackColor = System.Drawing.Color.White;
            this.selectFilePanel.Location = new System.Drawing.Point(400, 1177);
            this.selectFilePanel.Name = "selectFilePanel";
            this.selectFilePanel.Size = new System.Drawing.Size(1242, 317);
            this.selectFilePanel.TabIndex = 9;
            // 
            // underline_button
            // 
            this.underline_button.BackColor = System.Drawing.Color.White;
            this.underline_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_button.Location = new System.Drawing.Point(178, 307);
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(59, 43);
            this.underline_button.TabIndex = 10;
            this.underline_button.Text = "U";
            this.underline_button.UseVisualStyleBackColor = false;
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // newTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1686, 1529);
            this.Controls.Add(this.underline_button);
            this.Controls.Add(this.selectFilePanel);
            this.Controls.Add(this.uploadFile);
            this.Controls.Add(this.submitTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Name = "newTopic";
            this.Text = "newTopic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitTopic;
        private System.Windows.Forms.Button uploadFile;
        private System.Windows.Forms.FlowLayoutPanel selectFilePanel;
        private System.Windows.Forms.Button underline_button;
    }
}
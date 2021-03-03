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
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(23, 95);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(1073, 24);
            this.titleBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contents";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contentBox
            // 
            this.contentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentBox.Location = new System.Drawing.Point(23, 228);
            this.contentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(1073, 435);
            this.contentBox.TabIndex = 3;
            this.contentBox.Text = "";
            this.contentBox.TextChanged += new System.EventHandler(this.contentBox_TextChanged);
            // 
            // bold
            // 
            this.bold.BackColor = System.Drawing.Color.White;
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(23, 192);
            this.bold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(39, 27);
            this.bold.TabIndex = 4;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = false;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.BackColor = System.Drawing.Color.White;
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(68, 192);
            this.italic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(39, 27);
            this.italic.TabIndex = 5;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = false;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 699);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Upload";
            // 
            // submitTopic
            // 
            this.submitTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTopic.Location = new System.Drawing.Point(1001, 21);
            this.submitTopic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitTopic.Name = "submitTopic";
            this.submitTopic.Size = new System.Drawing.Size(94, 31);
            this.submitTopic.TabIndex = 7;
            this.submitTopic.Text = "Submit!";
            this.submitTopic.UseVisualStyleBackColor = true;
            this.submitTopic.Click += new System.EventHandler(this.submitTopic_Click);
            // 
            // uploadFile
            // 
            this.uploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFile.Location = new System.Drawing.Point(23, 781);
            this.uploadFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(190, 73);
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
            this.selectFilePanel.Location = new System.Drawing.Point(267, 736);
            this.selectFilePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectFilePanel.Name = "selectFilePanel";
            this.selectFilePanel.Size = new System.Drawing.Size(828, 198);
            this.selectFilePanel.TabIndex = 9;
            // 
            // underline_button
            // 
            this.underline_button.BackColor = System.Drawing.Color.White;
            this.underline_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_button.Location = new System.Drawing.Point(119, 192);
            this.underline_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(39, 27);
            this.underline_button.TabIndex = 10;
            this.underline_button.Text = "U";
            this.underline_button.UseVisualStyleBackColor = false;
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // newTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1124, 884);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
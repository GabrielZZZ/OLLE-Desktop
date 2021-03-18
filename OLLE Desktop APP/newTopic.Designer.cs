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
            this.week_label = new System.Windows.Forms.Label();
            this.week_select = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(17, 124);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(806, 21);
            this.titleBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contents";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contentBox
            // 
            this.contentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentBox.Location = new System.Drawing.Point(17, 222);
            this.contentBox.Margin = new System.Windows.Forms.Padding(2);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(806, 378);
            this.contentBox.TabIndex = 3;
            this.contentBox.Text = "";
            this.contentBox.TextChanged += new System.EventHandler(this.contentBox_TextChanged);
            // 
            // bold
            // 
            this.bold.BackColor = System.Drawing.Color.White;
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(17, 190);
            this.bold.Margin = new System.Windows.Forms.Padding(2);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(29, 23);
            this.bold.TabIndex = 4;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = false;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.BackColor = System.Drawing.Color.White;
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(51, 190);
            this.italic.Margin = new System.Windows.Forms.Padding(2);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(29, 23);
            this.italic.TabIndex = 5;
            this.italic.Text = "I";
            this.italic.UseVisualStyleBackColor = false;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 606);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Upload";
            // 
            // submitTopic
            // 
            this.submitTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTopic.Location = new System.Drawing.Point(751, 18);
            this.submitTopic.Margin = new System.Windows.Forms.Padding(2);
            this.submitTopic.Name = "submitTopic";
            this.submitTopic.Size = new System.Drawing.Size(70, 27);
            this.submitTopic.TabIndex = 7;
            this.submitTopic.Text = "Submit!";
            this.submitTopic.UseVisualStyleBackColor = true;
            this.submitTopic.Click += new System.EventHandler(this.submitTopic_Click);
            // 
            // uploadFile
            // 
            this.uploadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadFile.Location = new System.Drawing.Point(17, 677);
            this.uploadFile.Margin = new System.Windows.Forms.Padding(2);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(142, 63);
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
            this.selectFilePanel.Location = new System.Drawing.Point(200, 638);
            this.selectFilePanel.Margin = new System.Windows.Forms.Padding(2);
            this.selectFilePanel.Name = "selectFilePanel";
            this.selectFilePanel.Size = new System.Drawing.Size(621, 172);
            this.selectFilePanel.TabIndex = 9;
            // 
            // underline_button
            // 
            this.underline_button.BackColor = System.Drawing.Color.White;
            this.underline_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_button.Location = new System.Drawing.Point(89, 190);
            this.underline_button.Margin = new System.Windows.Forms.Padding(2);
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(29, 23);
            this.underline_button.TabIndex = 10;
            this.underline_button.Text = "U";
            this.underline_button.UseVisualStyleBackColor = false;
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // week_label
            // 
            this.week_label.AutoSize = true;
            this.week_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week_label.Location = new System.Drawing.Point(11, 36);
            this.week_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.week_label.Name = "week_label";
            this.week_label.Size = new System.Drawing.Size(83, 31);
            this.week_label.TabIndex = 11;
            this.week_label.Text = "Week";
            // 
            // week_select
            // 
            this.week_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.week_select.FormattingEnabled = true;
            this.week_select.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.week_select.Location = new System.Drawing.Point(113, 46);
            this.week_select.Name = "week_select";
            this.week_select.Size = new System.Drawing.Size(46, 21);
            this.week_select.TabIndex = 14;
            // 
            // newTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(843, 766);
            this.Controls.Add(this.week_select);
            this.Controls.Add(this.week_label);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "newTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newTopic";
            this.Load += new System.EventHandler(this.NewTopic_Load);
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
        private System.Windows.Forms.Label week_label;
        private System.Windows.Forms.ComboBox week_select;
    }
}
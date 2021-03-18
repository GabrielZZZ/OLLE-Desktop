namespace OLLE_Desktop_APP
{
    partial class MainPageItem
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
            this.weekNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPageTitle = new System.Windows.Forms.Label();
            this.detailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weekNum
            // 
            this.weekNum.AutoSize = true;
            this.weekNum.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekNum.Location = new System.Drawing.Point(64, 20);
            this.weekNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekNum.Name = "weekNum";
            this.weekNum.Size = new System.Drawing.Size(21, 22);
            this.weekNum.TabIndex = 0;
            this.weekNum.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Week";
            // 
            // mainPageTitle
            // 
            this.mainPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainPageTitle.AutoSize = true;
            this.mainPageTitle.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPageTitle.Location = new System.Drawing.Point(356, 20);
            this.mainPageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainPageTitle.Name = "mainPageTitle";
            this.mainPageTitle.Size = new System.Drawing.Size(152, 22);
            this.mainPageTitle.TabIndex = 2;
            this.mainPageTitle.Text = "Main Page Title";
            this.mainPageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // detailButton
            // 
            this.detailButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailButton.Location = new System.Drawing.Point(768, 35);
            this.detailButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(62, 23);
            this.detailButton.TabIndex = 3;
            this.detailButton.Text = "Details";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // MainPageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.mainPageTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekNum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPageItem";
            this.Size = new System.Drawing.Size(841, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weekNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainPageTitle;
        private System.Windows.Forms.Button detailButton;
    }
}

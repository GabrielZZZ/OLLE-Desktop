namespace OLLE_Desktop_APP
{
    partial class CalendarEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.event_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remaining_time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.end_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // event_name
            // 
            this.event_name.AutoSize = true;
            this.event_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name.Location = new System.Drawing.Point(162, 27);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(173, 28);
            this.event_name.TabIndex = 1;
            this.event_name.Text = "Event Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remaining Time";
            // 
            // remaining_time
            // 
            this.remaining_time.AutoSize = true;
            this.remaining_time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining_time.Location = new System.Drawing.Point(164, 171);
            this.remaining_time.Name = "remaining_time";
            this.remaining_time.Size = new System.Drawing.Size(43, 17);
            this.remaining_time.TabIndex = 3;
            this.remaining_time.Text = "Time";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_time.Location = new System.Drawing.Point(164, 97);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(43, 17);
            this.start_time.TabIndex = 5;
            this.start_time.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start Time";
            // 
            // end_time
            // 
            this.end_time.AutoSize = true;
            this.end_time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time.Location = new System.Drawing.Point(164, 132);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(43, 17);
            this.end_time.TabIndex = 7;
            this.end_time.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Time";
            // 
            // CalendarEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remaining_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.event_name);
            this.Controls.Add(this.label1);
            this.Name = "CalendarEvent";
            this.Size = new System.Drawing.Size(590, 221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label event_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label remaining_time;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label end_time;
        private System.Windows.Forms.Label label6;
    }
}

namespace OLLE_Desktop_APP
{
    partial class CalendarCreate
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
            this.startTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.title_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.publish_button = new System.Windows.Forms.Button();
            this.startTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // startTimePicker_date
            // 
            this.startTimePicker_date.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker_date.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.startTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTimePicker_date.Location = new System.Drawing.Point(162, 165);
            this.startTimePicker_date.Name = "startTimePicker_date";
            this.startTimePicker_date.Size = new System.Drawing.Size(198, 25);
            this.startTimePicker_date.TabIndex = 0;
            this.startTimePicker_date.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Time";
            // 
            // endTimePicker_date
            // 
            this.endTimePicker_date.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.endTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endTimePicker_date.Location = new System.Drawing.Point(162, 211);
            this.endTimePicker_date.Name = "endTimePicker_date";
            this.endTimePicker_date.Size = new System.Drawing.Size(198, 25);
            this.endTimePicker_date.TabIndex = 5;
            // 
            // title_box
            // 
            this.title_box.Location = new System.Drawing.Point(162, 62);
            this.title_box.Margin = new System.Windows.Forms.Padding(4);
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(132, 25);
            this.title_box.TabIndex = 6;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(162, 110);
            this.description_box.Margin = new System.Windows.Forms.Padding(4);
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(132, 25);
            this.description_box.TabIndex = 7;
            // 
            // publish_button
            // 
            this.publish_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publish_button.Location = new System.Drawing.Point(668, 393);
            this.publish_button.Name = "publish_button";
            this.publish_button.Size = new System.Drawing.Size(100, 32);
            this.publish_button.TabIndex = 8;
            this.publish_button.Text = "Publish";
            this.publish_button.UseVisualStyleBackColor = true;
            this.publish_button.Click += new System.EventHandler(this.publish_button_Click);
            // 
            // startTimePicker_time
            // 
            this.startTimePicker_time.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.startTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker_time.Location = new System.Drawing.Point(380, 165);
            this.startTimePicker_time.Name = "startTimePicker_time";
            this.startTimePicker_time.ShowUpDown = true;
            this.startTimePicker_time.Size = new System.Drawing.Size(198, 25);
            this.startTimePicker_time.TabIndex = 9;
            // 
            // endTimePicker_time
            // 
            this.endTimePicker_time.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.endTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker_time.Location = new System.Drawing.Point(380, 211);
            this.endTimePicker_time.Name = "endTimePicker_time";
            this.endTimePicker_time.ShowUpDown = true;
            this.endTimePicker_time.Size = new System.Drawing.Size(198, 25);
            this.endTimePicker_time.TabIndex = 10;
            // 
            // CalendarCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endTimePicker_time);
            this.Controls.Add(this.startTimePicker_time);
            this.Controls.Add(this.publish_button);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.endTimePicker_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTimePicker_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalendarCreate";
            this.Text = "CalendarCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startTimePicker_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTimePicker_date;
        private System.Windows.Forms.TextBox title_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Button publish_button;
        private System.Windows.Forms.DateTimePicker startTimePicker_time;
        private System.Windows.Forms.DateTimePicker endTimePicker_time;
    }
}
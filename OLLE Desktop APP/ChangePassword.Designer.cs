namespace OLLE_Desktop_APP
{
    partial class ChangePassword
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
            this.password1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(142, 72);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(182, 21);
            this.password1.TabIndex = 13;
            this.password1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(142, 118);
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(182, 21);
            this.password2.TabIndex = 16;
            this.password2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type Again";
            // 
            // password0
            // 
            this.password0.Location = new System.Drawing.Point(142, 27);
            this.password0.Name = "password0";
            this.password0.PasswordChar = '*';
            this.password0.Size = new System.Drawing.Size(182, 21);
            this.password0.TabIndex = 18;
            this.password0.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Old Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 273);
            this.Controls.Add(this.password0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "ChangeInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password0;
        private System.Windows.Forms.Label label3;
    }
}
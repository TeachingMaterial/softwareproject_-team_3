namespace OnlineUniversity
{
    partial class Form1
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
            this.loggin_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loggin_button
            // 
            this.loggin_button.Location = new System.Drawing.Point(458, 266);
            this.loggin_button.Name = "loggin_button";
            this.loggin_button.Size = new System.Drawing.Size(146, 48);
            this.loggin_button.TabIndex = 0;
            this.loggin_button.Text = "Login";
            this.loggin_button.UseVisualStyleBackColor = true;
            this.loggin_button.Click += new System.EventHandler(this.logginbutton_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(329, 137);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(70, 16);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(329, 205);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(67, 16);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(458, 137);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(146, 22);
            this.textBox_User.TabIndex = 3;
            this.textBox_User.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(458, 205);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(146, 22);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.loggin_button);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loggin_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_password;
    }
}


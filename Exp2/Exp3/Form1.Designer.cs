namespace Exp3
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
            this.header = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(234, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(80, 31);
            this.header.TabIndex = 0;
            this.header.Text = "Login";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(96, 102);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(104, 25);
            this.username.TabIndex = 1;
            this.username.Text = "user name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(96, 147);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(96, 25);
            this.password.TabIndex = 2;
            this.password.Text = "password";
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(228, 106);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(135, 20);
            this.t_username.TabIndex = 3;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(228, 152);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(135, 20);
            this.t_password.TabIndex = 4;
            this.t_password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(287, 194);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.login);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Button login;
    }
}


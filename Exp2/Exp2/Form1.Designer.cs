namespace Exp2
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
            this.l_qualification = new System.Windows.Forms.GroupBox();
            this.s_one_error = new System.Windows.Forms.Label();
            this.r_faculty = new System.Windows.Forms.RadioButton();
            this.r_student = new System.Windows.Forms.RadioButton();
            this.r_admin = new System.Windows.Forms.RadioButton();
            this.close = new System.Windows.Forms.Button();
            this.lu = new System.Windows.Forms.Label();
            this.lp = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.TextBox();
            this.l_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.e_username = new System.Windows.Forms.Label();
            this.e_password = new System.Windows.Forms.Label();
            this.cb_login = new System.Windows.Forms.ComboBox();
            this.l_qualification.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_qualification
            // 
            this.l_qualification.Controls.Add(this.s_one_error);
            this.l_qualification.Controls.Add(this.r_faculty);
            this.l_qualification.Controls.Add(this.r_student);
            this.l_qualification.Controls.Add(this.r_admin);
            this.l_qualification.Location = new System.Drawing.Point(100, 62);
            this.l_qualification.Name = "l_qualification";
            this.l_qualification.Size = new System.Drawing.Size(351, 89);
            this.l_qualification.TabIndex = 0;
            this.l_qualification.TabStop = false;
            this.l_qualification.Text = "Select one";
            // 
            // s_one_error
            // 
            this.s_one_error.AutoSize = true;
            this.s_one_error.Location = new System.Drawing.Point(31, 65);
            this.s_one_error.Name = "s_one_error";
            this.s_one_error.Size = new System.Drawing.Size(0, 13);
            this.s_one_error.TabIndex = 6;
            // 
            // r_faculty
            // 
            this.r_faculty.AutoSize = true;
            this.r_faculty.Location = new System.Drawing.Point(243, 41);
            this.r_faculty.Name = "r_faculty";
            this.r_faculty.Size = new System.Drawing.Size(59, 17);
            this.r_faculty.TabIndex = 5;
            this.r_faculty.TabStop = true;
            this.r_faculty.Text = "Faculty";
            this.r_faculty.UseVisualStyleBackColor = true;
            // 
            // r_student
            // 
            this.r_student.AutoSize = true;
            this.r_student.Location = new System.Drawing.Point(137, 41);
            this.r_student.Name = "r_student";
            this.r_student.Size = new System.Drawing.Size(62, 17);
            this.r_student.TabIndex = 4;
            this.r_student.TabStop = true;
            this.r_student.Text = "Student";
            this.r_student.UseVisualStyleBackColor = true;
            // 
            // r_admin
            // 
            this.r_admin.AutoSize = true;
            this.r_admin.Location = new System.Drawing.Point(31, 41);
            this.r_admin.Name = "r_admin";
            this.r_admin.Size = new System.Drawing.Size(54, 17);
            this.r_admin.TabIndex = 3;
            this.r_admin.TabStop = true;
            this.r_admin.Text = "Admin";
            this.r_admin.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.close.Location = new System.Drawing.Point(517, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 26);
            this.close.TabIndex = 8;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lu
            // 
            this.lu.AutoSize = true;
            this.lu.Location = new System.Drawing.Point(97, 166);
            this.lu.Name = "lu";
            this.lu.Size = new System.Drawing.Size(56, 13);
            this.lu.TabIndex = 1;
            this.lu.Text = "user name";
            // 
            // lp
            // 
            this.lp.AutoSize = true;
            this.lp.Location = new System.Drawing.Point(99, 204);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(53, 13);
            this.lp.TabIndex = 2;
            this.lp.Text = "Password";
            // 
            // l_username
            // 
            this.l_username.Location = new System.Drawing.Point(185, 166);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(122, 20);
            this.l_username.TabIndex = 3;
            // 
            // l_password
            // 
            this.l_password.Location = new System.Drawing.Point(185, 197);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(122, 20);
            this.l_password.TabIndex = 4;
            this.l_password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // e_username
            // 
            this.e_username.AutoSize = true;
            this.e_username.ForeColor = System.Drawing.Color.DarkRed;
            this.e_username.Location = new System.Drawing.Point(314, 172);
            this.e_username.Name = "e_username";
            this.e_username.Size = new System.Drawing.Size(0, 13);
            this.e_username.TabIndex = 6;
            // 
            // e_password
            // 
            this.e_password.AutoSize = true;
            this.e_password.ForeColor = System.Drawing.Color.DarkRed;
            this.e_password.Location = new System.Drawing.Point(314, 203);
            this.e_password.Name = "e_password";
            this.e_password.Size = new System.Drawing.Size(0, 13);
            this.e_password.TabIndex = 7;
            // 
            // cb_login
            // 
            this.cb_login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_login.FormattingEnabled = true;
            this.cb_login.Items.AddRange(new object[] {
            "cse",
            "ece",
            "eee"});
            this.cb_login.Location = new System.Drawing.Point(100, 241);
            this.cb_login.Name = "cb_login";
            this.cb_login.Size = new System.Drawing.Size(121, 21);
            this.cb_login.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(554, 312);
            this.Controls.Add(this.cb_login);
            this.Controls.Add(this.close);
            this.Controls.Add(this.e_password);
            this.Controls.Add(this.e_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.lp);
            this.Controls.Add(this.lu);
            this.Controls.Add(this.l_qualification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.l_qualification.ResumeLayout(false);
            this.l_qualification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox l_qualification;
        private System.Windows.Forms.Label s_one_error;
        private System.Windows.Forms.RadioButton r_faculty;
        private System.Windows.Forms.RadioButton r_student;
        private System.Windows.Forms.RadioButton r_admin;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label lu;
        private System.Windows.Forms.Label lp;
        private System.Windows.Forms.TextBox l_username;
        private System.Windows.Forms.TextBox l_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label e_username;
        private System.Windows.Forms.Label e_password;
        private System.Windows.Forms.ComboBox cb_login;
    }
}


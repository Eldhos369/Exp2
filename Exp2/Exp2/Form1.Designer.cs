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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.TextBox();
            this.l_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.e_username = new System.Windows.Forms.Label();
            this.e_password = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_qualification.SuspendLayout();
            this.GB.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
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
            // GB
            // 
            this.GB.Controls.Add(this.exit);
            this.GB.Controls.Add(this.sum);
            this.GB.Controls.Add(this.mul);
            this.GB.Controls.Add(this.sub);
            this.GB.Controls.Add(this.add);
            this.GB.Controls.Add(this.y);
            this.GB.Controls.Add(this.x);
            this.GB.Controls.Add(this.label4);
            this.GB.Controls.Add(this.label3);
            this.GB.Location = new System.Drawing.Point(372, 157);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(155, 143);
            this.GB.TabIndex = 9;
            this.GB.TabStop = false;
            this.GB.Text = "groupBox1";
            this.GB.Visible = false;
            this.GB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(7, 114);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 23);
            this.exit.TabIndex = 25;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.UseWaitCursor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(84, 104);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(43, 13);
            this.sum.TabIndex = 24;
            this.sum.Text = "bhjvjvgj";
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(114, 74);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(24, 23);
            this.mul.TabIndex = 23;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.UseWaitCursor = true;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(84, 74);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(24, 23);
            this.sub.TabIndex = 22;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.UseWaitCursor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(54, 74);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(24, 23);
            this.add.TabIndex = 21;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.UseWaitCursor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(43, 48);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(65, 20);
            this.y.TabIndex = 20;
            this.y.UseWaitCursor = true;
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(43, 19);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(65, 20);
            this.x.TabIndex = 19;
            this.x.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Y";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "x";
            this.label3.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(554, 312);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.close);
            this.Controls.Add(this.e_password);
            this.Controls.Add(this.e_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_qualification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.l_qualification.ResumeLayout(false);
            this.l_qualification.PerformLayout();
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox l_qualification;
        private System.Windows.Forms.Label s_one_error;
        private System.Windows.Forms.RadioButton r_faculty;
        private System.Windows.Forms.RadioButton r_student;
        private System.Windows.Forms.RadioButton r_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox l_username;
        private System.Windows.Forms.TextBox l_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label e_username;
        private System.Windows.Forms.Label e_password;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
    }
}


namespace Exp2
{
    partial class login
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
            this.login_lb = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.GroupBox();
            this.exit_log = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.y = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_lb
            // 
            this.login_lb.AutoSize = true;
            this.login_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lb.Location = new System.Drawing.Point(219, 9);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(115, 29);
            this.login_lb.TabIndex = 0;
            this.login_lb.Text = "Welcome";
            // 
            // GB
            // 
            this.GB.Controls.Add(this.exit_log);
            this.GB.Controls.Add(this.sum);
            this.GB.Controls.Add(this.mul);
            this.GB.Controls.Add(this.sub);
            this.GB.Controls.Add(this.add);
            this.GB.Controls.Add(this.y);
            this.GB.Controls.Add(this.x);
            this.GB.Controls.Add(this.label4);
            this.GB.Controls.Add(this.label3);
            this.GB.Location = new System.Drawing.Point(185, 67);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(155, 143);
            this.GB.TabIndex = 10;
            this.GB.TabStop = false;
            this.GB.Text = "groupBox1";
            // 
            // exit_log
            // 
            this.exit_log.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.exit_log.Location = new System.Drawing.Point(48, 120);
            this.exit_log.Name = "exit_log";
            this.exit_log.Size = new System.Drawing.Size(60, 23);
            this.exit_log.TabIndex = 25;
            this.exit_log.Text = "LogOut";
            this.exit_log.UseVisualStyleBackColor = true;
            this.exit_log.UseWaitCursor = true;
            this.exit_log.Click += new System.EventHandler(this.exit_log_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(69, 103);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(13, 13);
            this.sum.TabIndex = 24;
            this.sum.Text = "0";
            // 
            // mul
            // 
            this.mul.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mul.Location = new System.Drawing.Point(94, 74);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(24, 23);
            this.mul.TabIndex = 23;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.UseWaitCursor = true;
            // 
            // sub
            // 
            this.sub.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.sub.Location = new System.Drawing.Point(64, 74);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(24, 23);
            this.sub.TabIndex = 22;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.UseWaitCursor = true;
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.add.Location = new System.Drawing.Point(34, 74);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(24, 23);
            this.add.TabIndex = 21;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.UseWaitCursor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // y
            // 
            this.y.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.y.Location = new System.Drawing.Point(43, 48);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(65, 20);
            this.y.TabIndex = 20;
            this.y.UseWaitCursor = true;
            // 
            // x
            // 
            this.x.Cursor = System.Windows.Forms.Cursors.WaitCursor;
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
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 273);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.login_lb);
            this.Name = "login";
            this.Text = "login";
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_lb;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Button exit_log;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
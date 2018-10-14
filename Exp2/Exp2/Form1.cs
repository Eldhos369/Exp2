using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp2
{
    public partial class Form1 : Form
    {
        public static int log=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r_admin.Checked==true)
            {
                if (l_username.Text == "" || l_password.Text == "")
                {
                    e_username.Text = "invalid user name";
                }
                else if (l_username.Text=="admin")
                {
                    e_username.Text=null;
                    if (l_password.Text=="")
                    {
                        e_password.Text = "invalid password";
                    }
                    else if (l_password.Text == "admin")
                    {
                        MessageBox.Show("Login succes"+l_username.Text);
                        GB.Visible = true;
                        x.Text = null;
                        y.Text = null;
                        l_username.Clear();
                        l_password.Clear();
                    }
                    else
                    {
                        e_password.Text = "password is not matching";
                    }
                }
                else
                {

                    e_username.Text = "invalid username";

                }
            }
            else if (r_faculty.Checked == true)
            {
                if (l_username.Text == null || l_password.Text == null)
                {
                    e_username.Text = "invalid user name";
                }
                else if (l_username.Text == "faculty")
                {
                    e_username.Text=null;
                    if (l_password.Text == "")
                    {
                        e_password.Text = "invalid password";
                    }
                    else if (l_password.Text == "faculty")
                    {
                        MessageBox.Show("Login succes" + l_username.Text);
                        l_username.Clear();
                        l_password.Clear();
                        x.Text = null;
                        y.Text = null;
                        GB.Visible = true;

                    }
                    else
                    {
                        e_password.Text = "password is not matching";
                    }
                }
                else
                {

                    e_username.Text = "invalid username";

                }
            }
            else if (r_student.Checked == true)
            {
                if (l_username.Text == "" || l_password.Text == "")
                {
                    e_username.Text = "invalid user name";
                }
                else if (l_username.Text == "student")
                {
                    e_username.Text=null;
                    if (l_password.Text == "")
                    {
                        e_password.Text = "invalid password";
                    }
                    else if (l_password.Text == "student")
                    {
                        MessageBox.Show("Login succes" + l_username.Text);
                        l_username.Clear();
                        x.Text = null;
                        y.Text = null;
                        GB.Visible = true;
                        l_password.Clear();
                    }
                    else
                    {
                        e_password.Text = "password is not matching";
                    }
                }
                else
                {
                    
                        e_username.Text = "invalid username";
                    
                }

            }
            else
            {
                
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(x.Text);
            int b = Convert.ToInt16(y.Text);
            int s = a + b;

            sum.Text = a + " + " + b + "=" + s;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(x.Text);
            int b = Convert.ToInt16(y.Text);
            int s = a - b;

            sum.Text = a + " - " + b + "=" + s;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(x.Text);
            int b = Convert.ToInt16(y.Text);
            int s = a * b;

            sum.Text = a + " * " + b + "=" + s;

        }

        private void x_TextChanged(object sender, EventArgs e)
        {

        }

        private void y_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if(log==1)
            {
                Visible = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            GB.Visible = false;
        }

        private void add_Click_1(object sender, EventArgs e)
        {

        }
    }
}

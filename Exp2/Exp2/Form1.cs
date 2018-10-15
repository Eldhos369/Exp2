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
            cb_login.SelectedIndex = 0;

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
                        lu.Visible = false;
                        lp.Visible = false;
                        login log = new login(l_username.Text);
                        log.Show();
                        l_password.Visible = false;
                        l_username.Visible = false;
                        button1.Visible = false;

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
                        lu.Visible = false;
                        lp.Visible = false;
                        login log = new login(l_username.Text);
                        log.Show();
                        l_password.Visible = false;
                        l_username.Visible = false;
                        button1.Visible = false;
                   

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

                        lu.Visible = false;
                        lp.Visible = false;
                        l_password.Visible = false;
                        l_username.Visible = false;
                        login log = new login(l_username.Text);
                        Close();
                        log.Show();
                        button1.Visible = false;
                        
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


        
    }
}

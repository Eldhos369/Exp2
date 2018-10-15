using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(t_password.Text=="admin" && t_username.Text=="admin")
            {
                MessageBox.Show("Login succes "+t_username.Text);
                loginF f = new loginF();
                f.Show();
               
                
            }
        }
    }
}

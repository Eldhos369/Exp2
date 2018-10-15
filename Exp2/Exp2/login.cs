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
    public partial class login : Form
    {
        public login(string username)
        {
            InitializeComponent();
            x.Text = null;
            y.Text = null;
            GB.Visible = true;
            GB.Text = username;
            login_lb.Text = username;
        }

        private void exit_log_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
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
    }
}

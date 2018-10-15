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
    public partial class loginF : Form
    {
        public static int done;
        public static int x;
        public static int y;
        public static int sum;
        public static int rec;

        public loginF()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            y = 1;
            result.Text = one.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            y = 2;
            result.Text = two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            y = 3;
            result.Text = three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            y = 4;
            result.Text = four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            y = 5;
            result.Text = five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            y = 6;
            result.Text = six.Text;
        }

        private void ce_Click(object sender, EventArgs e)
        {
            result.Clear();
        }

        private void e_Click(object sender, EventArgs e)
        {
            switch(done)
            {
                case 1:
                    {
                        sum = x + y;
                        result.Text =Convert.ToString(sum);
                        x = sum;
                        break;
                    }
                case 2:
                    {
                        sum = x - y;
                        result.Text = Convert.ToString(sum);
                        x = sum;
                        break;
                    }
                case 3:
                    {
                        sum = x * y;
                        result.Text = Convert.ToString(sum);
                        x = sum;
                        break;
                    }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            x = int.Parse(result.Text);
             done = 1;
            result.Text = x+add.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = int.Parse(result.Text);
            done = 2;
            result.Text = x+sub.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = int.Parse(result.Text);
            done = 3;
            result.Text = x + mul.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sev_Click(object sender, EventArgs e)
        {
            y = 7;
            result.Text = sev.Text;
        }

        private void eig_Click(object sender, EventArgs e)
        {
            y = 8;
            result.Text = eig.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            y =9;
            result.Text = nine.Text;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            y = 0;
            result.Text = zero.Text;
        }
    }
}

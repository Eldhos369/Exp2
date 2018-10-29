﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionName = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string selectCommand = "SELECT * FROM dbo.[Table]";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand,connectionName);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView2.DataSource = bs;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace studyy
{
    public partial class Form2 : Form
    {
        public System.Data.SqlClient.SqlConnection Con { get; set; }
        public Form2(System.Data.SqlClient.SqlConnection con)
        {
            InitializeComponent();
            System.Data.SqlClient.SqlConnection connection = con;
            Con = con;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zapros_Click(object sender, EventArgs e)
        {
            Con.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select student, subject, dbo.main.period, mark from dbo.main inner join dbo.student on (dbo.main.student = dbo.student.id) inner join dbo.subject on (dbo.main.subject = dbo.subject.id)";
            cmd.Connection = Con;
            bindingSource1.DataSource = GetData(cmd);
            dataGridView1.DataSource = bindingSource1;
            Con.Close();

        }

        private static DataTable GetData(System.Data.SqlClient.SqlCommand sqlCommand)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

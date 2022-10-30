using System;
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
            if (studentName.Text == "")
            {
                cmd.CommandText = @"select id, (select FIO from student where student.id=main.student) as Students, (select subj from subject where subject.id=main.subject) as ""Предмет"", period as ""Семестр"", mark as ""Оценка"" from main";
            } else if (studentName.Text != "")
            {
                cmd.CommandText = $@"select  id, Students, Subject, Period, Mark from (select id, (select FIO from student where student.id=main.student) as Students, (select subj from subject where subject.id=main.subject) as Subject, period as Period, mark as Mark from main) as Query where Students like '%{studentName.Text}%'";
            }
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

        private void studentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

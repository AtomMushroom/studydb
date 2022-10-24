using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from dbo.main";
            cmd.Connection = Con;
            textBox2.Text = Convert.ToString(cmd.ExecuteNonQuery());
            tableLayout.Cell
        }
    }
}

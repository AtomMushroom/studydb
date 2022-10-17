using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Data.SqlClient.SqlConnection con;
        }
        System.Data.SqlClient.SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=.\db;
                          AttachDbFilename=db\studydb.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True";
            con.Open();
            MessageBox.Show("Connection opened");
            con.Close();
            MessageBox.Show("Connection closed");
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kurwa = new Form2();
            kurwa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

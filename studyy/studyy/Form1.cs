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
        }
        System.Data.SqlClient.SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            string dir = Environment.CurrentDirectory;
            con.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dir}\db\studydb.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(con);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(con);
            form3.Show();
        }
    }
}

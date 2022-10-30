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
    public partial class Form3 : Form
    {
        public System.Data.SqlClient.SqlConnection Con { get; set; }
        public Form3(System.Data.SqlClient.SqlConnection con)
        {
            System.Data.SqlClient.SqlConnection connection = con;
            Con = con;
            InitializeComponent();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Con.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Con;
            cmd.CommandText = $"insert into student(FIO) VALUES (N'{textBoxFIO.Text}')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $@"insert into main(student,period,subject,mark) VALUES ((SELECT IDENT_CURRENT('student')), {textBoxPeriod.Text}, (select top 1 id from subject where subject.subj like '{comboBoxSubject.Text}%') , {textBoxMark.Text})";
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}

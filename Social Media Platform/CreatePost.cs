using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Social_Media_Platform
{
    public partial class CreatePost : Form
    {
        public CreatePost()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Social Media Platform\Social Media Platform\Database1.mdf;Integrated Security=True");








        



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Post values('" + textBox1.Text + "','" + richTextBox1.Text +   "')";
            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Posted Successfully");




        }




        public void Display_Data()
        {
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = CommandType.Text;
            scmd.CommandText = "select * from Post";
            scmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }











        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePost_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete  from Post where User_IdentityNo = '" + textBox1.Text + "' ";

            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Post Deleted");

        }
    }
}

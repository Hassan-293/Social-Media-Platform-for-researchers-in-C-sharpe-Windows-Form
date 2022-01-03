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
    public partial class Contributions : Form
    {
        public Contributions()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Social Media Platform\Social Media Platform\Database1.mdf;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
         

           conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Contributions values ('" + textBox1.Text + "','" + textBox2.Text + "','" + txtanalysis.Text +  "')";
            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show("Posted Successfully");






        }



        public void Display_Data()
        {
            conn.Open();
            SqlCommand scmd = conn.CreateCommand();
            scmd.CommandType = CommandType.Text;
            scmd.CommandText = "select * from Contributions";
            scmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }















        private void Contributions_Load(object sender, EventArgs e)
        {
            Display_Data();
        }
    }
}

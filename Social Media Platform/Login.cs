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
    public partial class Login : Form
    {


        static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Social Media Platform\Social Media Platform\Database1.mdf;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connection);
        //static SqlCommand scmd;


        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        bool Authentication() {
            if (string.IsNullOrWhiteSpace(Username.Text) || string.IsNullOrWhiteSpace(Password.Text))
                return false;

            else
                return true;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Main_Menu p = new Main_Menu();
            p.ShowDialog();


        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();

                    SqlDataReader dr;




            if (Password.Text != string.Empty || Username.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from UserRegisteration where Username='" + Username.Text + "' and Password='" + Password.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                     Main_Menu main_Menu= new Main_Menu();
                    main_Menu.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}

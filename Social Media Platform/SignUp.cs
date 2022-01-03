using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Social_Media_Platform
{
    public partial class SignUp : Form

        
    {   


        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Social Media Platform\Social Media Platform\Database1.mdf;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();
        }


       
        private void First_Click(object sender, EventArgs e)
        {
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (Username.Text == "" || Password.Text == "")
                MessageBox.Show("Please not leave any field empty");
            else if (Password.Text != Confirm_Password.Text)
                MessageBox.Show("Password not matches");
            


            else

            { 
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {

                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", First_name.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", last_name.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", Conatct.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", Address.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", Password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registeration is Successful");

                    Clear();




                }
        }

        void Clear() {
            First_name.Text = last_name.Text = Conatct.Text = Address.Text = Username.Text = Password.Text = " ";
        }


            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            Login f2 = new Login(); //this is the change, code for redirect  
            f2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

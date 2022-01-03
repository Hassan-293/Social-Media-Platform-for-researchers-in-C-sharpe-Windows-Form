using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Media_Platform
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        Login login = new Login();



        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void on1ConsultancyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void profilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contributionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contributions contributions =new  Contributions();

            contributions.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do want to exit the application?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
                login.ShowDialog();

            }

            else

            { 
            
            }
        }
    }
}

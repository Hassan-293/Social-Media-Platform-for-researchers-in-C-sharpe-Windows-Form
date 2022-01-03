using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Media_Platform
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void consultancy_Click(object sender, EventArgs e)
        {
            Consultancy consultancy = new Consultancy();
            consultancy.ShowDialog();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            CreatePost createPost = new CreatePost();
            createPost.ShowDialog();
        }
    }
}

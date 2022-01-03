
namespace Social_Media_Platform
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Post = new System.Windows.Forms.Button();
            this.consultancy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 491);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Post
            // 
            this.Post.BackColor = System.Drawing.Color.BlueViolet;
            this.Post.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Post.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Post.Location = new System.Drawing.Point(0, 0);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(239, 249);
            this.Post.TabIndex = 1;
            this.Post.Text = "Create a New Post    +";
            this.Post.UseVisualStyleBackColor = false;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // consultancy
            // 
            this.consultancy.BackColor = System.Drawing.Color.Blue;
            this.consultancy.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consultancy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.consultancy.Location = new System.Drawing.Point(686, 242);
            this.consultancy.Name = "consultancy";
            this.consultancy.Size = new System.Drawing.Size(239, 249);
            this.consultancy.TabIndex = 2;
            this.consultancy.Text = "1 VS 1 Consultancy";
            this.consultancy.UseVisualStyleBackColor = false;
            this.consultancy.Click += new System.EventHandler(this.consultancy_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(919, 491);
            this.Controls.Add(this.consultancy);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.splitter1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Button consultancy;
    }
}
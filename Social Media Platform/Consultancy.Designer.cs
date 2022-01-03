
namespace Social_Media_Platform
{
    partial class Consultancy
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
            this.Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msgbox = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(131, 54);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(226, 27);
            this.Phone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PhoneNumber :";
            // 
            // msgbox
            // 
            this.msgbox.Location = new System.Drawing.Point(131, 109);
            this.msgbox.Multiline = true;
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(550, 233);
            this.msgbox.TabIndex = 2;
            this.msgbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(414, 57);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(267, 27);
            this.port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port :";
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.LimeGreen;
            this.Send.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Send.ForeColor = System.Drawing.Color.Honeydew;
            this.Send.Location = new System.Drawing.Point(552, 366);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(129, 45);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.port);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone);
            this.Name = "Consultancy";
            this.Text = "Consultancy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgbox;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send;
    }
}
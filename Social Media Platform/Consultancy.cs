using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Social_Media_Platform
{
    public partial class Consultancy : Form
    {
        public Consultancy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort sp = new SerialPort();
                sp.PortName = port.Text;
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);

                sp.WriteLine("AT+CMGF=1"+Environment.NewLine);
                Thread.Sleep(100);

                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS\"" + Phone.Text + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(msgbox.Text + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);

                Thread.Sleep(100);
                var response = sp.ReadExisting();

                if (response.Contains("Error"))
                    MessageBox.Show("Send Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Message Send !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sp.Close();









            }

       

            catch (Exception ex) {


                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

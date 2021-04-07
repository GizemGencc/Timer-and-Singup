using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_6
{
    public partial class Form1 : Form
    {
        public string fullname { get; set; }
        public string emailAdress { get; set; }
        public string message { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fullname = null;
            this.emailAdress = null;
            this.message = null;

            timer1.Start();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.fullname))
                    throw new Exception("Please Sign Up First");
                if (string.IsNullOrEmpty(this.emailAdress))
                    throw new Exception("Please Sign up First");

                if (string.IsNullOrEmpty(richTextBox1.Text.Trim()))
                    throw new Exception("Please Enter Message To Send");

                this.message = richTextBox1.Text.Trim();
                MessageBox.Show("Your Message Is Sent");
                richTextBox1.Text = "";
                timer2.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void sign_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1_fullname.Text.Trim()))
                    throw new Exception("Please Your Full Name");

                if (string.IsNullOrEmpty(textBox2_emailadress.Text.Trim()))
                    throw new Exception("Please Your E-mail Adress");

                this.fullname = textBox1_fullname.Text.Trim();
                this.emailAdress = textBox2_emailadress.Text.Trim();

                MessageBox.Show("Successfull");
                textBox1_fullname.Text = " ";
                textBox2_emailadress.Text = " ";
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_getlastmessage_Click(object sender, EventArgs e)
        {
            label_lastMessage.Text=$"Your Name:{ this.fullname}\n" + 
            $"Your e mail: {this.emailAdress}\n"+
            $"Message: {this.message}";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3_time.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // label_lastMessage.Text = $"Your Name:{ this.fullname}\n" +
            //$"Your e mail: {this.emailAdress}\n" +
            // $"Message: {this.message}";
            btn_getlastmessage_Click(sender, e);
            timer2.Stop();
        }
    }
}

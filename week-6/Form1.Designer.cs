
namespace week_6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1_info = new System.Windows.Forms.GroupBox();
            this.sign_signup = new System.Windows.Forms.Button();
            this.textBox2_emailadress = new System.Windows.Forms.TextBox();
            this.textBox1_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2_message = new System.Windows.Forms.GroupBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_lastMessage = new System.Windows.Forms.Label();
            this.btn_getlastmessage = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3_time = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1_info.SuspendLayout();
            this.groupBox2_message.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_info
            // 
            this.groupBox1_info.BackColor = System.Drawing.Color.Silver;
            this.groupBox1_info.Controls.Add(this.sign_signup);
            this.groupBox1_info.Controls.Add(this.textBox2_emailadress);
            this.groupBox1_info.Controls.Add(this.textBox1_fullname);
            this.groupBox1_info.Controls.Add(this.label2);
            this.groupBox1_info.Controls.Add(this.label1);
            this.groupBox1_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1_info.Location = new System.Drawing.Point(13, 13);
            this.groupBox1_info.Name = "groupBox1_info";
            this.groupBox1_info.Size = new System.Drawing.Size(245, 119);
            this.groupBox1_info.TabIndex = 0;
            this.groupBox1_info.TabStop = false;
            this.groupBox1_info.Text = "Personal İnfo";
            // 
            // sign_signup
            // 
            this.sign_signup.BackColor = System.Drawing.Color.LightCoral;
            this.sign_signup.Location = new System.Drawing.Point(161, 90);
            this.sign_signup.Name = "sign_signup";
            this.sign_signup.Size = new System.Drawing.Size(75, 23);
            this.sign_signup.TabIndex = 4;
            this.sign_signup.Text = "Sign Up";
            this.sign_signup.UseVisualStyleBackColor = false;
            this.sign_signup.Click += new System.EventHandler(this.sign_signup_Click);
            // 
            // textBox2_emailadress
            // 
            this.textBox2_emailadress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2_emailadress.Location = new System.Drawing.Point(95, 50);
            this.textBox2_emailadress.Name = "textBox2_emailadress";
            this.textBox2_emailadress.Size = new System.Drawing.Size(141, 20);
            this.textBox2_emailadress.TabIndex = 3;
            // 
            // textBox1_fullname
            // 
            this.textBox1_fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1_fullname.Location = new System.Drawing.Point(95, 24);
            this.textBox1_fullname.Name = "textBox1_fullname";
            this.textBox1_fullname.Size = new System.Drawing.Size(141, 20);
            this.textBox1_fullname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail Adress";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // groupBox2_message
            // 
            this.groupBox2_message.BackColor = System.Drawing.Color.Silver;
            this.groupBox2_message.Controls.Add(this.btn_send);
            this.groupBox2_message.Controls.Add(this.richTextBox1);
            this.groupBox2_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2_message.Location = new System.Drawing.Point(13, 154);
            this.groupBox2_message.Name = "groupBox2_message";
            this.groupBox2_message.Size = new System.Drawing.Size(245, 138);
            this.groupBox2_message.TabIndex = 1;
            this.groupBox2_message.TabStop = false;
            this.groupBox2_message.Text = "Message";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.LightCoral;
            this.btn_send.Location = new System.Drawing.Point(161, 109);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 83);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label_lastMessage
            // 
            this.label_lastMessage.BackColor = System.Drawing.Color.Silver;
            this.label_lastMessage.Location = new System.Drawing.Point(264, 63);
            this.label_lastMessage.Name = "label_lastMessage";
            this.label_lastMessage.Size = new System.Drawing.Size(206, 229);
            this.label_lastMessage.TabIndex = 2;
            // 
            // btn_getlastmessage
            // 
            this.btn_getlastmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_getlastmessage.Location = new System.Drawing.Point(264, 13);
            this.btn_getlastmessage.Name = "btn_getlastmessage";
            this.btn_getlastmessage.Size = new System.Drawing.Size(206, 44);
            this.btn_getlastmessage.TabIndex = 3;
            this.btn_getlastmessage.Text = "Get last Message";
            this.btn_getlastmessage.UseVisualStyleBackColor = false;
            this.btn_getlastmessage.Click += new System.EventHandler(this.btn_getlastmessage_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3_time
            // 
            this.label3_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3_time.Location = new System.Drawing.Point(13, 295);
            this.label3_time.Name = "label3_time";
            this.label3_time.Size = new System.Drawing.Size(110, 19);
            this.label3_time.TabIndex = 4;
            this.label3_time.Text = "label3";
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 331);
            this.Controls.Add(this.label3_time);
            this.Controls.Add(this.btn_getlastmessage);
            this.Controls.Add(this.label_lastMessage);
            this.Controls.Add(this.groupBox2_message);
            this.Controls.Add(this.groupBox1_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_info.ResumeLayout(false);
            this.groupBox1_info.PerformLayout();
            this.groupBox2_message.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_info;
        private System.Windows.Forms.Button sign_signup;
        private System.Windows.Forms.TextBox textBox2_emailadress;
        private System.Windows.Forms.TextBox textBox1_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_lastMessage;
        private System.Windows.Forms.Button btn_getlastmessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3_time;
        private System.Windows.Forms.Timer timer2;
    }
}


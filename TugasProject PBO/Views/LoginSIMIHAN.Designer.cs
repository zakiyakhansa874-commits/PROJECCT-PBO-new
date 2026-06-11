using System.Runtime.CompilerServices;

namespace TugasProject_PBO.Views
{
    partial class LoginSIMIHAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSIMIHAN));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-422, -100);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1160, 755);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(512, -1);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 571);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Petani" });
            comboBox1.Location = new Point(40, 385);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(303, 33);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Choose Role";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(229, 435);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 435);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 25);
            label5.TabIndex = 6;
            label5.Text = "Don't have an account ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 5;
            label4.Text = "<- Back";
            label4.Click += label4_Click;
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Location = new Point(40, 332);
            tbPassword.Margin = new Padding(4, 4, 4, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter password";
            tbPassword.Size = new Size(303, 31);
            tbPassword.TabIndex = 4;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(404, 46);
            label3.TabIndex = 3;
            label3.Text = "Manajemen Terintegrasi";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(315, 46);
            label2.TabIndex = 2;
            label2.Text = "Kesegaran Alami, ";
            label2.Click += label2_Click;
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.Gray;
            tbEmail.Location = new Point(40, 281);
            tbEmail.Margin = new Padding(4, 4, 4, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter email";
            tbEmail.Size = new Size(303, 31);
            tbEmail.TabIndex = 1;
            tbEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 29);
            label1.TabIndex = 0;
            label1.Text = "Login to";
            // 
            // LoginSIMIHAN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 569);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginSIMIHAN";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
    }
}
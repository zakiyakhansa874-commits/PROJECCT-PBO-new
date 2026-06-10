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
            pictureBox1.Location = new Point(-338, -80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(928, 604);
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
            panel1.Location = new Point(410, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 457);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Petani" });
            comboBox1.Location = new Point(32, 308);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 28);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Choose Role";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(183, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 348);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 6;
            label5.Text = "Don't have an account ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 35);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "<- Back";
            label4.Click += label4_Click;
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Location = new Point(32, 266);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter password";
            tbPassword.Size = new Size(243, 27);
            tbPassword.TabIndex = 4;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 173);
            label3.Name = "label3";
            label3.Size = new Size(341, 39);
            label3.TabIndex = 3;
            label3.Text = "Manajemen Terintegrasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 132);
            label2.Name = "label2";
            label2.Size = new Size(267, 39);
            label2.TabIndex = 2;
            label2.Text = "Kesegaran Alami, ";
            label2.Click += label2_Click;
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.Gray;
            tbEmail.Location = new Point(32, 225);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter email";
            tbEmail.Size = new Size(243, 27);
            tbEmail.TabIndex = 1;
            tbEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 107);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Login to";
            // 
            // LoginSIMIHAN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 455);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
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
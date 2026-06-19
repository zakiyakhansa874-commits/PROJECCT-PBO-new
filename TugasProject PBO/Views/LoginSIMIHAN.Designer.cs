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
            btnLogin = new Button();
            panelLogin = new Panel();
            L_Role = new Label();
            L_Password = new Label();
            label4 = new Label();
            cbRole = new ComboBox();
            tbPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-247, -187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1474, 862);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkKhaki;
            btnLogin.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(43, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(244, 29);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.LightGoldenrodYellow;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(L_Role);
            panelLogin.Controls.Add(L_Password);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(cbRole);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(tbPassword);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(tbEmail);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(695, 38);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(492, 483);
            panelLogin.TabIndex = 1;
            panelLogin.Paint += panel1_Paint;
            // 
            // L_Role
            // 
            L_Role.AutoSize = true;
            L_Role.Location = new Point(45, 318);
            L_Role.Name = "L_Role";
            L_Role.Size = new Size(39, 20);
            L_Role.TabIndex = 12;
            L_Role.Text = "Role";
            // 
            // L_Password
            // 
            L_Password.AutoSize = true;
            L_Password.Location = new Point(43, 262);
            L_Password.Name = "L_Password";
            L_Password.Size = new Size(70, 20);
            L_Password.TabIndex = 11;
            L_Password.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 205);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.ForeColor = Color.Gray;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Petani" });
            cbRole.Location = new Point(45, 342);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(243, 28);
            cbRole.TabIndex = 8;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Gray;
            tbPassword.Location = new Point(44, 285);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Enter password";
            tbPassword.Size = new Size(243, 27);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            tbPassword.KeyPress += tbPassword_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 152);
            label3.Name = "label3";
            label3.Size = new Size(320, 26);
            label3.TabIndex = 3;
            label3.Text = "Panen Terpantau, Stok Terkelola.";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(190, 46);
            label2.TabIndex = 2;
            label2.Text = "SIMIHAN";
            label2.Click += label2_Click;
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.Gray;
            tbEmail.Location = new Point(44, 228);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Enter username";
            tbEmail.Size = new Size(243, 27);
            tbEmail.TabIndex = 1;
            tbEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Login to";
            label1.Click += label1_Click;
            // 
            // LoginSIMIHAN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 561);
            Controls.Add(panelLogin);
            Controls.Add(pictureBox1);
            Name = "LoginSIMIHAN";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private PictureBox pictureBox1;
        private Panel panelLogin;
        private Button btnLogin;
        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private ComboBox cbRole;
        private Label L_Role;
        private Label L_Password;
        private Label label4;
    }
}
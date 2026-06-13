using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasProject_PBO.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TugasProject_PBO.Helpers;
using Npgsql;

namespace TugasProject_PBO.Views
{
    public partial class LoginSIMIHAN : Form
    {
        public LoginSIMIHAN()
        {
            InitializeComponent();
            // Ensure the form opens centered and Enter triggers login
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnLogin;
            this.KeyPreview = true;

            // Wire lifecycle events
            this.Load += LoginSIMIHAN_Load;
            this.Shown += LoginSIMIHAN_Load2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Draw a header band with gradient and title to style the login panel
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle headerRect = new Rectangle(0, 0, panel1.Width, 80);
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                           headerRect, Color.DarkOliveGreen, Color.SeaGreen, 90f))
                {
                    g.FillRectangle(brush, headerRect);
                }

                using (var titleFont = new Font("Calibri", 14f, FontStyle.Bold))
                using (var titleBrush = new SolidBrush(Color.White))
                using (var sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString("SIMIHAN", titleFont, titleBrush, new Rectangle(12, 0, panel1.Width - 24, 80), sf);
                }
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Show a short slogan/info when the label is clicked
            MessageBox.Show("Kesegaran Alami, selalu terjaga dalam setiap panen.", "SIMIHAN", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Confirm navigation/back action. If this is the startup form, closing it will exit the app.
            var result = MessageBox.Show(
                "Kembali ke halaman sebelumnya? Aplikasi akan menutup jika ini merupakan halaman utama.",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Validate email as user types
            string email = tbEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                tbEmail.ForeColor = Color.Gray;
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    tbEmail.ForeColor = addr.Address == email ? Color.Black : Color.Red;
                }
                catch
                {
                    tbEmail.ForeColor = Color.Red;
                }
            }
            UpdateLoginButtonState();
        }
        private void LoginSIMIHAN_Load(object sender, EventArgs e)
        {
            tbEmail.PlaceholderText = "Enter email";
            tbPassword.PlaceholderText = "Enter password";
            // Initialize email color and disable login until inputs are provided
            tbEmail.ForeColor = Color.Gray;
            btnLogin.Enabled = true;
        }
        private void LoginSIMIHAN_Load2(object sender, EventArgs e)
        {
            // Populate items only once. Use a prompt item at index 0.
            if (cbRole.Items.Count == 0)
            {
                cbRole.Items.Add(" Select Role"); 
                cbRole.Items.Add("Admin");
                cbRole.Items.Add("Petani");
            }
        }

        private void UpdateLoginButtonState()
        {
            bool hasPassword = !string.IsNullOrWhiteSpace(tbPassword.Text);
            // require a selection other than the prompt at index 0
            bool hasRole = cbRole.SelectedIndex > 0;

            // Validate email format
            bool emailValid = false;
            string email = tbEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    emailValid = addr.Address == email;
                }
                catch { emailValid = false; }
            }

            // Visual cue for email validity
            tbEmail.ForeColor = string.IsNullOrEmpty(email) ? Color.Gray : (emailValid ? Color.Black : Color.Black);

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login berhasil");

            string username = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();

            MessageBox.Show(
                        "Username = " + username +
                        "\nPassword = " + password +
                        "\nRole = " + role
                                );

            // Basic client-side validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbRole.SelectedIndex <= 0 || string.IsNullOrEmpty(role) || role.StartsWith("--"))
            {
                MessageBox.Show("Pilih role terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT *
                 FROM ""User""
                 WHERE username = @username
                 AND password = @password
                 AND role = @role"; ;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Use parameter names that match the SQL query
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessionHelper.SetSession(
                                    Convert.ToInt32(reader["id_user"]),
                                    reader["username"].ToString(),
                                    reader["username"].ToString(),
                                    reader["role"].ToString()
                                );

                                // Open dashboard modelessly and close login when dashboard closes
                                var dashboard = new TugasProject_PBO.Views.Admin.DashboardAdmin();
                                dashboard.FormClosed += (s, ev) => this.Close();
                                this.Hide();
                                dashboard.Show();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Username, password, atau role salah!", "Login Gagal",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error koneksi database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Menu Sign Up belum dibuat.");
        }
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter ditekan!");

                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Show more details about the application when subtitle is clicked
            MessageBox.Show("SIMIHAN - Sistem Informasi Manajemen Hasil Panen dan Inventori.", "Tentang SIMIHAN", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
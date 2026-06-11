using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginSIMIHAN_Load(object sender, EventArgs e)
        {
            tbEmail.PlaceholderText = "Enter email";
            tbPassword.PlaceholderText = "Enter password";
        }
        private void LoginSIMIHAN_Load2(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Petani");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string role = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Pilih role terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT * FROM \"User\" WHERE username=@username AND password=@password AND role=@role";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        SessionHelper.SetSession(
                            Convert.ToInt32(reader["id_user"]),
                            reader["username"].ToString(),
                            reader["username"].ToString(),
                            reader["role"].ToString()
                        );

                        reader.Close();

                        if (role == "Admin")
                        {
                            TugasProject_PBO.Views.Admin.DashboardAdmin dashboard =
                                new TugasProject_PBO.Views.Admin.DashboardAdmin();
                            dashboard.Show();
                            this.Hide();
                        }
                        else if (role == "Petani")
                        {
                            MessageBox.Show("Akses ditolak! Petani tidak diizinkan masuk.",
                                "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username, password, atau role salah!", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error koneksi database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

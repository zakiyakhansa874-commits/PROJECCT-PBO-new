using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class InputStokMasuk4 : Form
    {
        public InputStokMasuk4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
INSERT INTO ""Stok_Masuk""
(id_petani, id_gudang, jumlah, tanggal, kualitas, catatan)
VALUES
(@id_petani, @id_gudang, @jumlah, @tanggal, @kualitas, @catatan)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@id_petani",
                            Convert.ToInt32(tbPetani4.Text));

                        cmd.Parameters.AddWithValue("@id_gudang",
                            Convert.ToInt32(tbGudang4.Text));

                        cmd.Parameters.AddWithValue("@jumlah",
                            Convert.ToDecimal(tbJumlah4.Text));

                        cmd.Parameters.AddWithValue("@tanggal",
                            DateTime.Parse(tbTanggal4.Text));

                        cmd.Parameters.AddWithValue("@catatan",
                            tbCatatan4.Text);
                        cmd.Parameters.AddWithValue("@kualitas",
                            tbKualitas4.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data stok masuk berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void InputStokMasuk_Load(object sender, EventArgs e) { }

        private void btBatal4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
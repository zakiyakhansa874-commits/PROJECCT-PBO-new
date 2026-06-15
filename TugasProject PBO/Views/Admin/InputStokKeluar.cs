using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Models;

namespace TugasProject_PBO.Views.Admin
{
    public partial class InputStokKeluar5 : Form
    {
        public InputStokKeluar5()
        {
            InitializeComponent();

            LoadGudang();
            LoadAdmin();
            LoadKualitas();
        }
        private void LoadGudang()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
            SELECT id_gudang, nama_gudang
            FROM ""Gudang""
            ORDER BY id_gudang";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbGudang5.DataSource = dt;
                        cbGudang5.DisplayMember = "nama_gudang";
                        cbGudang5.ValueMember = "id_gudang";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAdmin()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
            SELECT a.id_admin, u.nama
            FROM ""Admin"" a
            INNER JOIN ""User"" u
            ON a.id_user = u.id_user
            ORDER BY u.nama";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbAdmin5.DataSource = dt;
                        cbAdmin5.DisplayMember = "nama";
                        cbAdmin5.ValueMember = "id_admin";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadKualitas()
        {
            cbKualitas5.Items.Clear();

            cbKualitas5.Items.Add("A");
            cbKualitas5.Items.Add("B");
            cbKualitas5.Items.Add("C");

            cbKualitas5.SelectedIndex = 0;
        }

        private void L_Petani9_Click(object sender, EventArgs e)
        {
            // logika klik label/link Petani
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // logika perubahan textBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // logika perubahan textBox2
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // logika perubahan textBox3
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // logika perubahan textBox6
        }

        private void btSimpan5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbJumlah5.Text))
            {
                MessageBox.Show(
                    "Jumlah harus diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int idGudang =
                    Convert.ToInt32(cbGudang5.SelectedValue);

                decimal jumlah;

                if (!decimal.TryParse(tbJumlah5.Text, out jumlah))
                {
                    MessageBox.Show(
                        "Jumlah harus berupa angka!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
            INSERT INTO ""Stok_Keluar""
            (
                id_gudang,
                jumlah,
                tanggal,
                tujuan,
                keterangan
            )
            VALUES
            (
                @id_gudang,
                @jumlah,
                @tanggal,
                @tujuan,
                @keterangan
            )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_gudang",
                            idGudang);

                        cmd.Parameters.AddWithValue(
                            "@jumlah",
                            jumlah);

                        cmd.Parameters.AddWithValue(
                            "@tanggal",
                            dtpTanggal5.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@tujuan",
                            cbAdmin5.Text);

                        cmd.Parameters.AddWithValue(
                            "@keterangan",
                            tbCatatan5.Text);

                        int hasil = cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            "Baris tersimpan = " + hasil);
                    }
                }

                MessageBox.Show(
                    "Data stok keluar berhasil disimpan!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InputStokKeluar_Load(object sender, EventArgs e)
        {
            // bisa kosong dulu
        }

        private void LTanggal5_Click(object sender, EventArgs e)
        {

        }

        private void LGudang_Click(object sender, EventArgs e)
        {

        }

        private void cbAdmin5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

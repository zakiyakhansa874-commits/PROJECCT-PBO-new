using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;
using System.Globalization;

namespace TugasProject_PBO.Views.Admin
{
    public partial class InputStokMasuk4 : Form
    {
        public InputStokMasuk4()
        {
            InitializeComponent();

            LoadGudang();
            LoadPetani();
            LoadKualitas();
        }
        private void LoadGudang()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
            SELECT id_gudang,nama_gudang
            FROM ""Gudang""
            ORDER BY id_gudang";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbGudang4.DataSource = dt;
                        cbGudang4.DisplayMember = "nama_gudang";
                        cbGudang4.ValueMember = "id_gudang";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadPetani()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
            SELECT p.id_petani, u.nama
            FROM ""Petani"" p
            INNER JOIN ""User"" u
            ON p.id_user = u.id_user
            ORDER BY u.nama";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbPetani4.DataSource = dt;
                        cbPetani4.DisplayMember = "nama";
                        cbPetani4.ValueMember = "id_petani";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data petani:\n" + ex.Message);
            }
        }
        private void LoadKualitas()
        {
            cbKualitas4.Items.Clear();

            cbKualitas4.Items.Add("A");
            cbKualitas4.Items.Add("B");
            cbKualitas4.Items.Add("C");

            cbKualitas4.SelectedIndex = 0;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        // PERBAIKAN: Tombol Simpan
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPetani4.Text) ||
                string.IsNullOrWhiteSpace(cbGudang4.Text) ||
                string.IsNullOrWhiteSpace(tbJumlah4.Text) ||
                string.IsNullOrWhiteSpace(dtpTanggal4.Text))
            {
                MessageBox.Show(
                    "Semua kolom data wajib diisi (kecuali catatan)!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // Cari ID Petani
                    int idPetani =
    Convert.ToInt32(cbPetani4.SelectedValue);

                    // Cari ID Gudang
                    int idGudang =
                    Convert.ToInt32(cbGudang4.SelectedValue);

                    // Parse jumlah
                    decimal jumlah;

                    if (!decimal.TryParse(
                            tbJumlah4.Text.Trim(),
                            NumberStyles.Number,
                            CultureInfo.InvariantCulture,
                            out jumlah))
                    {
                        if (!decimal.TryParse(
                                tbJumlah4.Text.Trim(),
                                out jumlah))
                        {
                            MessageBox.Show(
                                "Jumlah harus berupa angka!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            return;
                        }
                    }

                    // Parse tanggal
                    DateTime tanggal;

                    if (!DateTime.TryParse(
                            dtpTanggal4.Text.Trim(),
                            out tanggal))
                    {
                        MessageBox.Show(
                            "Format tanggal salah!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    string query = @"
            INSERT INTO ""Stok_Masuk""
            (
                id_petani,
                id_gudang,
                jumlah,
                tanggal,
                kualitas,
                catatan
            )
            VALUES
            (
                @id_petani,
                @id_gudang,
                @jumlah,
                @tanggal,
                @kualitas,
                @catatan
            )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);

                        cmd.Parameters.AddWithValue(
                            "@kualitas",
                            string.IsNullOrWhiteSpace(cbKualitas4.Text)
                            ? (object)DBNull.Value
                            : cbKualitas4.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@catatan",
                            string.IsNullOrWhiteSpace(tbCatatan4.Text)
                            ? (object)DBNull.Value
                            : tbCatatan4.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data stok masuk berhasil disimpan!",
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

        private void InputStokMasuk_Load(object sender, EventArgs e) { }

        // PERBAIKAN: Tombol Batal
        private void btBatal4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Set ke Cancel agar tidak memicu refresh data di form induk
            this.Close();
        }

        private void tbTanggal4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGudang4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPetani4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
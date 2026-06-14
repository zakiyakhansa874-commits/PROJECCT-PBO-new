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
            // 1. Validasi Input Dasar (Mencegah input kosong)
            if (string.IsNullOrWhiteSpace(tbPetani4.Text) ||
                string.IsNullOrWhiteSpace(tbGudang4.Text) ||
                string.IsNullOrWhiteSpace(tbJumlah4.Text) ||
                string.IsNullOrWhiteSpace(tbTanggal4.Text))
            {
                MessageBox.Show("Semua kolom data wajib diisi (kecuali catatan)!", "Peringatan", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    // Resolve petani id (accept either numeric id or nama petani)
                    int idPetani;
                    if (!int.TryParse(tbPetani4.Text.Trim(), out idPetani))
                    {
                        string qPetani = @"SELECT p.id_petani FROM ""Petani"" p INNER JOIN ""User"" u ON p.id_user = u.id_user WHERE u.nama = @nama LIMIT 1";
                        using (var lookup = new NpgsqlCommand(qPetani, conn))
                        {
                            lookup.Parameters.AddWithValue("@nama", tbPetani4.Text.Trim());
                            var res = lookup.ExecuteScalar();
                            if (res == null)
                            {
                                MessageBox.Show("Petani tidak ditemukan. Masukkan ID petani atau nama petani yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            idPetani = Convert.ToInt32(res);
                        }
                    }

                    // Resolve gudang id (accept either numeric id or nama gudang)
                    int idGudang;
                    if (!int.TryParse(tbGudang4.Text.Trim(), out idGudang))
                    {
                        string qGudang = @"SELECT id_gudang FROM ""Gudang"" WHERE nama_gudang = @nama LIMIT 1";
                        using (var lookup = new NpgsqlCommand(qGudang, conn))
                        {
                            lookup.Parameters.AddWithValue("@nama", tbGudang4.Text.Trim());
                            var res = lookup.ExecuteScalar();
                            if (res == null)
                            {
                                MessageBox.Show("Gudang tidak ditemukan. Masukkan ID gudang atau nama gudang yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            idGudang = Convert.ToInt32(res);
                        }
                    }

                    // Parse jumlah (accept comma or dot decimals)
                    string jumlahText = tbJumlah4.Text.Trim();
                    decimal jumlah;
                    if (!decimal.TryParse(jumlahText, NumberStyles.Number, CultureInfo.InvariantCulture, out jumlah))
                    {
                        // try current culture as fallback (handles commas)
                        if (!decimal.TryParse(jumlahText, NumberStyles.Number, CultureInfo.CurrentCulture, out jumlah))
                        {
                            MessageBox.Show("Format jumlah salah. Masukkan angka valid untuk jumlah (kg), gunakan titik atau koma sebagai desimal jika perlu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Parse tanggal supporting multiple common formats
                    string tanggalText = tbTanggal4.Text.Trim();
                    DateTime tanggal;
                    string[] formats = new[] { "yyyy-MM-dd", "dd-MM-yyyy", "dd/MM/yyyy", "MM/dd/yyyy", "yyyy/MM/dd" };
                    if (!DateTime.TryParseExact(tanggalText, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal))
                    {
                        // fallback to liberal parse
                        if (!DateTime.TryParse(tanggalText, CultureInfo.CurrentCulture, DateTimeStyles.None, out tanggal))
                        {
                            MessageBox.Show("Format tanggal salah. Gunakan salah satu format: yyyy-MM-dd, dd-MM-yyyy atau dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = @"
                                    INSERT INTO ""Stok_Masuk""
                                    (id_petani, id_gudang, jumlah, tanggal, kualitas, catatan)
                                    VALUES
                                    (@id_petani, @id_gudang, @jumlah, @tanggal, @kualitas, @catatan)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@kualitas", string.IsNullOrWhiteSpace(tbKualitas4.Text) ? (object)DBNull.Value : tbKualitas4.Text.Trim());
                        cmd.Parameters.AddWithValue("@catatan", string.IsNullOrWhiteSpace(tbCatatan4.Text) ? (object)DBNull.Value : tbCatatan4.Text.Trim());

                        int affected = cmd.ExecuteNonQuery();
                        if (affected <= 0)
                        {
                            MessageBox.Show("Gagal menyimpan data ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // 2. Tampilkan pesan sukses yang informatif
                MessageBox.Show("Data stok masuk berhasil disimpan!", "Sukses", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

                // 3. KUNCI UTAMA: Set DialogResult ke OK agar form pemanggil tahu data sukses disimpan
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format inputan salah! Pastikan ID berupa angka, jumlah berupa desimal, dan tanggal berformat YYYY-MM-DD.", "Kesalahan Validasi", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan ke database:\n" + ex.Message, "Error Database", 
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
    }
}
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
    public partial class KelolaGudang : Form
    {
        // Variabel lokal untuk menyimpan ID gudang yang dipilih dari DataGridView
        private int selectedGudangId = 0;

        public KelolaGudang()
        {
            InitializeComponent();
            // Mendaftarkan event Load secara programmatif agar data langsung muncul saat form dibuka
            this.Load += KelolaGudang_Load;
        }

        private void KelolaGudang_Load(object sender, EventArgs e)
        {
            try
            {
                // Menampilkan informasi session admin di sidebar jika komponennya tersedia
                // L_UsernameAdmin.Text = Helpers.SessionHelper.Nama;

                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data awal gudang: " + ex.Message, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mengambil data dari tabel "Gudang" database PostgreSQL dan memasukkannya ke DataGridView
        /// </summary>
        private void LoadDataGudangAll()
        {
            // 1. Bersihkan baris lama di DataGridView sebelum memuat data baru
            DGV_KelolaGudang3.Rows.Clear();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // Pastikan koneksi terbuka dengan aman
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    // Menggunakan LEFT JOIN agar gudang yang masih kosong (0 kg) tetap muncul di tabel
                    string sql = @"SELECT 
                                    g.id_gudang, 
                                    g.nama_gudang, 
                                    g.lokasi, 
                                    g.kapasitas_maksimal,
                                    COALESCE(SUM(sm.jumlah), 0) AS stok_saat_ini
                                   FROM ""Gudang"" g
                                   LEFT JOIN ""Stok_Masuk"" sm ON g.id_gudang = sm.id_gudang
                                   GROUP BY g.id_gudang, g.nama_gudang, g.lokasi, g.kapasitas_maksimal
                                   ORDER BY g.id_gudang ASC";


                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["id_gudang"].ToString();
                            string namaGudang = reader["nama_gudang"]?.ToString() ?? "-";
                            string lokasi = reader["lokasi"]?.ToString() ?? "-";

                            // BARIS COPIAN YANG SALAH DAN TERSELIP DI SINI SUDAH DIHAPUS 👍

                            // Format angka desimal/berat agar rapi saat tampil
                            double kapasitas = reader["kapasitas_maksimal"] != DBNull.Value ? Convert.ToDouble(reader["kapasitas_maksimal"]) : 0;
                            double stokSaatIni = reader["stok_saat_ini"] != DBNull.Value ? Convert.ToDouble(reader["stok_saat_ini"]) : 0;

                            // 2. Hitung persentase keterisian kapasitas gudang
                            string terisi;
                            if (kapasitas <= 0)
                            {
                                terisi = "0%";
                            }
                            else
                            {
                                double percent = (stokSaatIni / kapasitas) * 100.0;
                                terisi = Math.Round(percent, 2).ToString() + "%";
                            }

                            DGV_KelolaGudang3.Rows.Add(
                                id,
                                namaGudang,
                                lokasi,
                                kapasitas.ToString() + " kg",
                                stokSaatIni.ToString() + " kg",
                                terisi
                            );
                        }
                    }
                }
            }
            catch (NpgsqlException npgEx)
            {
                MessageBox.Show("Terjadi masalah konfigurasi query database:\n" + npgEx.Message,
                                "Error PostgreSQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data halaman kelola gudang: " + ex.Message,
                                "Error Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_KelolaGudang3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Menangkap ID Gudang ketika salah satu baris di dalam grid diklik oleh Admin
            if (e.RowIndex >= 0)
            {
                var row = DGV_KelolaGudang3.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    selectedGudangId = Convert.ToInt32(row.Cells[0].Value);
                }
            }
        }

        // ==========================================
        // TOMBOL OPERASI CRUD (MASTER GUDANG)
        // ==========================================

        private void btTambah3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formTambah = new InputEditGudang())
                {
                    formTambah.ShowDialog();
                }
                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form tambah gudang: " + ex.Message, "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btEdit3_Click(object sender, EventArgs e)
        {
            if (selectedGudangId == 0)
            {
                MessageBox.Show("Silakan pilih salah satu gudang di dalam tabel terlebih dahulu!", "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var formEdit = new InputEditGudang())
                {
                    formEdit.ShowDialog();
                }
                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form edit gudang: " + ex.Message, "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btHapus3_Click(object sender, EventArgs e)
        {
            if (selectedGudangId == 0)
            {
                MessageBox.Show("Silakan pilih data gudang yang ingin dihapus!", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data gudang ini beserta semua riwayat stok masuknya?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Helpers.DatabaseHelper.GetConnection())
                    {
                        // PENGAMAN: Pastikan koneksi dibuka dulu sebelum eksekusi perintah SQL!
                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        // Hapus data Stok_Masuk yang terkait dengan gudang terlebih dahulu (Mencegah error Foreign Key Cascade Restrict)
                        string deleteStokMasuk = @"DELETE FROM ""Stok_Masuk"" WHERE id_gudang = @id";
                        using (var cmd1 = new NpgsqlCommand(deleteStokMasuk, conn))
                        {
                            cmd1.Parameters.AddWithValue("@id", selectedGudangId);
                            cmd1.ExecuteNonQuery();
                        }

                        // Hapus data utama di tabel gudang
                        string deleteGudang = @"DELETE FROM ""Gudang"" WHERE id_gudang = @id";
                        using (var cmd2 = new NpgsqlCommand(deleteGudang, conn))
                        {
                            cmd2.Parameters.AddWithValue("@id", selectedGudangId);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data gudang berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    selectedGudangId = 0;
                    LoadDataGudangAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // SCRIPT NAVIGASI SIDEBAR MENU (KIRI)
        // ==========================================

        private void btDashboard3_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaHasilPanen3_Click(object sender, EventArgs e)
        {
            KelolaDataHasilPanen hasilPanen = new KelolaDataHasilPanen();
            hasilPanen.Show();
            this.Hide();
        }

        private void btKelolaGudang3_Click(object sender, EventArgs e)
        {
            LoadDataGudangAll();
        }

        private void btStokMasuk3_Click(object sender, EventArgs e)
        {
            KelolaStokMasuk stokMasuk = new KelolaStokMasuk();
            stokMasuk.Show();
            this.Hide();
        }

        private void btStokKeluar3_Click(object sender, EventArgs e)
        {
            KelolaStokKeluar stokKeluar = new KelolaStokKeluar();
            stokKeluar.Show();
            this.Hide();
        }

        private void btMonitoringStok3_Click(object sender, EventArgs e)
        {
            MonitoringStok monitoring = new MonitoringStok();
            monitoring.Show();
            this.Hide();
        }

        private void btLaporanInventori3_Click(object sender, EventArgs e)
        {
            LaporanInventori laporan = new LaporanInventori();
            laporan.Show();
            this.Hide();
        }

        private void btLogout3_Click(object sender, EventArgs e)
        {
            using (KonfirmasiLogout frm = new KonfirmasiLogout())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    Helpers.SessionHelper.ClearSession();
                    LoginSIMIHAN login = new LoginSIMIHAN();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void G_KelolaGudang_Click(object sender, EventArgs e) { }
        private void BC_MenuBar_Paint3(object sender, PaintEventArgs e) { }
        private void J_KelolaGudang3_Click(object sender, EventArgs e) { }
        private void BC_Page3_Paint(object sender, PaintEventArgs e) { }
    }
}
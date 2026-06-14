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
            // Membersihkan baris lama di DataGridView sebelum diisi ulang
            DGV_KelolaGudang3.Rows.Clear();

            try
            {
                using (var conn = Helpers.DatabaseHelper.GetConnection())
                {
                    // Query mengambil data gudang. Menggunakan tanda petik ganda jika nama tabel Anda "Gudang" (Capital)
                    // Ditambahkan subquery opsional untuk menghitung total stok riil saat ini dari tabel stok/inventori jika ada
                    string sql = @"SELECT 
                                    id_gudang, 
                                    nama_gudang, 
                                    lokasi, 
                                    kapasitas 
                                   FROM ""Gudang"" 
                                   ORDER BY id_gudang ASC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nama = reader.IsDBNull(1) ? "-" : reader.GetString(1);
                            string lokasi = reader.IsDBNull(2) ? "-" : reader.GetString(2);
                            int kapasitas = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);

                            // Sementara stok saat ini diset 0 atau bisa Anda formulasikan dari tabel detail stok masuk-keluar
                            int stokSaatIni = 0;

                            // Menambahkan data ke baris grid sesuai susunan kolom desainer Anda:
                            // [ID] [Nama Gudang] [Lokasi] [Kapasitas (kg)] [Stok Saat Ini (kg)]
                            DGV_KelolaGudang3.Rows.Add(id, nama, lokasi, kapasitas.ToString() + " kg", stokSaatIni.ToString() + " kg");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data gudang: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Berdasarkan Solution Explorer Anda, terdapat Form bernama InputEditGudang
                using (var formTambah = new InputEditGudang())
                {
                    formTambah.ShowDialog();
                }
                // Refresh data setelah form input ditutup
                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form tambah gudang: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEdit3_Click(object sender, EventArgs e)
        {
            if (selectedGudangId == 0)
            {
                MessageBox.Show("Silakan pilih salah satu gudang di dalam tabel terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Membuka form edit dengan mengirimkan ID gudang yang dipilih (Konsep OOP Overloading/Constructor)
                using (var formEdit = new InputEditGudang())
                {
                    // Anda bisa mempassing selectedGudangId ke form tersebut jika constructor-nya sudah disiapkan
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
                MessageBox.Show(
                    "Silakan pilih data gudang yang ingin dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data gudang ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Helpers.DatabaseHelper.GetConnection())
                    {
                        // Hapus data Stok_Masuk yang terkait dengan gudang
                        string deleteStokMasuk =
                            @"DELETE FROM ""Stok_Masuk""
                      WHERE id_gudang = @id";

                        using (var cmd1 = new NpgsqlCommand(deleteStokMasuk, conn))
                        {
                            cmd1.Parameters.AddWithValue("@id", selectedGudangId);
                            cmd1.ExecuteNonQuery();
                        }

                        // Hapus data gudang
                        string deleteGudang =
                            @"DELETE FROM ""Gudang""
                      WHERE id_gudang = @id";

                        using (var cmd2 = new NpgsqlCommand(deleteGudang, conn))
                        {
                            cmd2.Parameters.AddWithValue("@id", selectedGudangId);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show(
                        "Data gudang berhasil dihapus!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    selectedGudangId = 0;
                    LoadDataGudangAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal menghapus data: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
            // Tetap di halaman ini, cukup segarkan data
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

        // Event handler bawaan desainer yang kosong (dibiarkan agar tidak merusak file designer)
        private void G_KelolaGudang_Click(object sender, EventArgs e) { }
        private void BC_MenuBar_Paint3(object sender, PaintEventArgs e) { }
        private void J_KelolaGudang3_Click(object sender, EventArgs e) { }

        private void BC_Page3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
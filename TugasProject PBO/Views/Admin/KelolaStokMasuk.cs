using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Wajib ditambahkan untuk akses PostgreSQL
using TugasProject_PBO.Helpers; // Menghubungkan ke Helper Database Anda

namespace TugasProject_PBO.Views.Admin
{
    public partial class KelolaStokMasuk : Form
    {
        public KelolaStokMasuk()
        {
            InitializeComponent();

            // Memanggil fungsi load data pertama kali saat form ini dibuka
            LoadDataStokMasukAll();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void G_KelolaStokMasuk_Click(object sender, EventArgs e) { }
        private void BC_MenuBar_Paint2(object sender, PaintEventArgs e) { }
        private void BC_Page4_Paint(object sender, PaintEventArgs e) { }

        /// <summary>
        /// METHOD UTAMA: Mengambil data dari tabel "Stok_Masuk" di PostgreSQL
        /// </summary>
        private void LoadDataStokMasukAll()
        {
            // Bersihkan baris lama di DataGridView sebelum memuat yang baru
            DGV_KelolaStokMasuk4.Rows.Clear();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // Ensure connection is open (DatabaseHelper may return a closed connection)
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    // PERBAIKAN: Melakukan JOIN tambahan ke tabel "User" (u) untuk mengambil kolom nama asli petani
                    string sql = @"SELECT 
                            sm.id_stokmasuk, 
                            sm.tanggal, 
                            g.nama_gudang, 
                            u.nama AS nama_petani, 
                            sm.jumlah,
                            sm.kualitas,
                            sm.catatan
                           FROM ""Stok_Masuk"" sm
                           INNER JOIN ""Gudang"" g ON sm.id_gudang = g.id_gudang
                           INNER JOIN ""Petani"" p ON sm.id_petani = p.id_petani
                           INNER JOIN ""User"" u ON p.id_user = u.id_user
                           ORDER BY sm.id_stokmasuk DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["id_stokmasuk"].ToString();

                            string tanggal = reader["tanggal"] != DBNull.Value
                                ? Convert.ToDateTime(reader["tanggal"]).ToString("dd-MM-yyyy")
                                : "-";

                            string namaGudang = reader["nama_gudang"]?.ToString() ?? "-";
                            string namaPetani = reader["nama_petani"]?.ToString() ?? "-";
                            string jumlah = reader["jumlah"]?.ToString() ?? "0";
                            string kualitas = reader["kualitas"]?.ToString() ?? "-";
                            string catatan = reader["catatan"]?.ToString() ?? "-";

                            // Masukkan ke dalam baris DataGridView Anda (ID, Tanggal, Gudang, Petani, Jumlah, Kualitas, Catatan)
                            DGV_KelolaStokMasuk4.Rows.Add(id, tanggal, namaGudang, namaPetani, jumlah + " kg", kualitas, catatan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok masuk: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// EVENT TOMBOL TAMBAH DATA
        /// </summary>
        private void btTambah4_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka form inputan secara dialog pop-up modal
                using (InputStokMasuk4 formInput = new InputStokMasuk4())
                {
                    // Jika user menekan tombol simpan dan berhasil (DialogResult.OK)
                    if (formInput.ShowDialog() == DialogResult.OK)
                    {
                        // Otomatis refresh muat data terbaru tanpa perlu buka-tutup form kelola
                        LoadDataStokMasukAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman tambah data: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// EVENT TOMBOL HAPUS DATA (Bonus Implementasi Fitur Hapus)
        /// </summary>
        private void btHapus4_Click(object sender, EventArgs e)
        {
            // Memastikan user sudah memilih baris data di DataGridView sebelum menghapus
            if (DGV_KelolaStokMasuk4.CurrentRow == null || DGV_KelolaStokMasuk4.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Silakan pilih baris data di tabel yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mengambil ID stok masuk dari kolom pertama (indeks 0) baris yang dipilih
            string idTerpilih = DGV_KelolaStokMasuk4.CurrentRow.Cells[0].Value.ToString();

            // Konfirmasi ulang ke user agar aman tidak sengaja terhapus
            DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus data transaksi dengan ID {idTerpilih}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();
                        // Gunakan nama kolom yang konsisten dengan SELECT (id_stokmasuk)
                        string queryHapus = @"DELETE FROM ""Stok_Masuk"" WHERE id_stokmasuk = @id";
                        using (var cmd = new NpgsqlCommand(queryHapus, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idTerpilih));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStokMasukAll(); // Refresh tabel setelah penghapusan
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data dari database: " + ex.Message, "Error Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DGV_KelolaStokMasuk4_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>
        /// NAVIGASI KE DASHBOARD UTAMA
        /// </summary>
        private void btDashboard4_Click(object sender, EventArgs e)
        {
            // Buka DashboardAdmin
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();

            // Tutup Form KelolaStokMasuk yang sekarang biar tidak menumpuk di memori
            this.Close();
        }

        /// <summary>
        /// NAVIGASI KE KELOLA HASIL PANEN
        /// </summary>
        private void btKelolaHasilPanen4_Click(object sender, EventArgs e)
        {
            // Sesuaikan dengan nama kelas form hasil panen Anda (misal: KelolaDataHasilPanen)
            KelolaDataHasilPanen hasilPanen = new KelolaDataHasilPanen();
            hasilPanen.Show();
            this.Close();
        }

        /// <summary>
        /// NAVIGASI KE KELOLA GUDANG
        /// </summary>
        private void btKelolaGudang4_Click(object sender, EventArgs e)
        {
            KelolaGudang gudang = new KelolaGudang();
            gudang.Show();
            this.Close();
        }

        /// <summary>
        /// TOMBOL STOK MASUK (Halaman ini sendiri)
        /// </summary>
        private void btStokMasuk4_Click(object sender, EventArgs e)
        {
            // Karena user sudah berada di halaman Stok Masuk, cukup refresh datanya saja
            LoadDataStokMasukAll();
        }

        /// <summary>
        /// NAVIGASI KE STOK KELUAR
        /// </summary>
        private void btStokKeluar4_Click(object sender, EventArgs e)
        {
            // Pastikan nama Form KelolaStokKeluar Anda sudah sesuai di Solution Explorer
            KelolaStokKeluar stokKeluar = new KelolaStokKeluar();
            stokKeluar.Show();
            this.Close();
        }

        /// <summary>
        /// NAVIGASI KE MONITORING STOK
        /// </summary>
        private void btMonitoringStok4_Click(object sender, EventArgs e)
        {
            MonitoringStok monitoring = new MonitoringStok();
            monitoring.Show();
            this.Close();
        }

        /// <summary>
        /// NAVIGASI KE LAPORAN INVENTORI
        /// </summary>
        private void btLaporanInventori4_Click(object sender, EventArgs e)
        {
            LaporanInventori laporan = new LaporanInventori();
            laporan.Show();
            this.Close();
        }
    }
}
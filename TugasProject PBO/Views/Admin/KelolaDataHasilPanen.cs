using System;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Views.Petani; 

namespace TugasProject_PBO.Views.Admin
{
    public partial class KelolaDataHasilPanen : Form
    {
        // Variabel untuk menyimpan ID data yang dipilih dari DataGridView
        private int selectedId = 0;

        public KelolaDataHasilPanen()
        {
            InitializeComponent();
            // ensure load handler is registered so initialization code is executed
            this.Load += KelolaDataHasilPanen_Load;
        }

        private void KelolaDataHasilPanen_Load(object sender, EventArgs e)
        {
            try
            {
                // Menampilkan nama session admin jika ada label username dan role di sidebar
                // L_UsernameAdmin.Text = Helpers.SessionHelper.Nama;

                LoadDataPanenAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data awal: " + ex.Message, "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Memuat seluruh data hasil panen dari database ke DataGridView
        /// </summary>
        private void LoadDataPanenAll()
        {
            // Use designer DataGridView control name DGV_datahasilpanen2
            DGV_datahasilpanen2.Rows.Clear();

            try
            {
                using (var conn = Helpers.DatabaseHelper.GetConnection())
                {
                    // Query mengambil seluruh data hasil panen untuk Admin
                    const string sql = @"SELECT
                        id_hasilpanen,
                        berat_kotor,
                        berat_bersih,
                        kualitas,
                        catatan,
                        tanggal_panen,
                        id_petani,
                        komoditas
                        FROM hasil_panen
                        ORDER BY id_hasil_panen DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            decimal beratKotor = reader.IsDBNull(1) ? 0M : reader.GetDecimal(1);
                            decimal beratBersih = reader.IsDBNull(2) ? 0M : reader.GetDecimal(2);
                            string kualitas = reader.IsDBNull(3) ? "-" : reader.GetString(3);
                            string catatan = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            string tanggal = reader.IsDBNull(5) ? string.Empty : reader.GetDateTime(5).ToString("yyyy-MM-dd");
                            string petani = reader.IsDBNull(6) ? string.Empty : reader.GetInt32(6).ToString();
                            string komoditas = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);

                            // Memasukkan data ke baris gridview sesuai urutan kolom di Designer
                            DGV_datahasilpanen2.Rows.Add(id, beratKotor.ToString("F2"), beratBersih.ToString("F2"), kualitas, catatan, tanggal, petani, komoditas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Menangkap ID saat baris grid diklik agar bisa di-Edit atau di-Hapus
            if (e.RowIndex >= 0)
            {
                var row = DGV_datahasilpanen2.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    selectedId = Convert.ToInt32(row.Cells[0].Value);
                }
            }
        }

        // ==========================================
        // TOMBOL AKSI UTAMA (CRUD)
        // ==========================================

        private void bt_tambah2_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka form tambah input secara Dialog Modal
                using (var formTambah = new BCInputHasilPanen())
                {
                    // Jika di form input mengeklik simpan dan berhasil (DialogResult.OK)
                    if (formTambah.ShowDialog() == DialogResult.OK)
                    {
                        LoadDataPanenAll(); // Otomatis refresh DataGridView utama
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form tambah: " + ex.Message, "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void bt_edit2_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Silakan pilih data pada tabel terlebih dahulu untuk diubah!", "Informasi", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Integrasikan dengan form edit Anda di sini membawa `selectedId`
            MessageBox.Show($"Fitur edit untuk ID: {selectedId} siap dikembangkan.", "Edit Data", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);

            // Contoh implementasi form edit:
            // using (var formEdit = new FormEditHasilPanen(selectedId)) { ... }
        }

        private void bt_hapus2_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Silakan pilih baris data yang ingin dihapus terlebih dahulu!", "Peringatan", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
                return;
            }

            var konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus data hasil panen dengan ID {selectedId}?", "Konfirmasi Hapus", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (var conn = Helpers.DatabaseHelper.GetConnection())
                    {
                        string sql = @"DELETE FROM ""Hasil_Panen"" WHERE id_hasilpanen = @id";
                        using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data berhasil dihapus!", "Sukses", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                    selectedId = 0; // reset selection
                    LoadDataPanenAll(); // Refresh tabel
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // NAVIGASI SIDEBAR MENU (Kiri)
        // ==========================================

        private void btDashboard2_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaHasilPanen2_Click(object sender, EventArgs e)
        {
            // Menolak aksi karena Anda sudah berada di halaman ini
            LoadDataPanenAll();
        }

        private void btKelolaGudang2_Click(object sender, EventArgs e)
        {
            // Pindah ke form kelola gudang jika sudah ada
            // KelolaGudang frm = new KelolaGudang();
            // frm.Show();
            // this.Hide();
        }

        private void btStokMasuk2_Click(object sender, EventArgs e)
        {
            // Navigasi ke form stok masuk
        }

        private void btStokKeluar2_Click(object sender, EventArgs e)
        {
            // Navigasi ke form stok keluar
        }

        private void btMonitoringStok2_Click(object sender, EventArgs e)
        {
            // Navigasi ke form monitoring stok
        }

        private void btLaporanInventori2_Click(object sender, EventArgs e)
        {
            // Navigasi ke form laporan inventori
        }

        private void btLogout2_Click(object sender, EventArgs e)
        {
            using (KonfirmasiLogout frm = new KonfirmasiLogout())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
      
                    LoginSIMIHAN login = new LoginSIMIHAN();
                    login.Show();
                    this.Hide();
                }
            }
        }

        // Event handler opsional bawaan designer (kosong) - reference parameters to avoid unused-parameter warnings
        private void label1_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void BC_MenuBar_Paint(object sender, PaintEventArgs e) { _ = sender; _ = e; }
        private void G_KelolaDataHasilPanen_Click(object sender, EventArgs e) { _ = sender; _ = e; }
    }
}
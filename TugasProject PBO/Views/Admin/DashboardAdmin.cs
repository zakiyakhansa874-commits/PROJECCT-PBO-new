using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO.Views.Admin
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            this.Load += DashboardAdmin_Load;
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            // Header labels
            L_TotalGedung.Text = "Total Gudang: 3";
            L_Username.Text = "Username: admin";
            L_Role.Text = "Role: Administrator";

            // Informasi stok & hasil panen
            L_StokSaatIni.Text = "Stok Saat Ini: 5420 kg";
            L_TotalHasilPanen.Text = "Total Hasil Panen: 1306 kg";
            SJ_KapasitasGudang.Text = "Gudang Utama A – 3200/5000 kg (64%)";

            // Progress bar kapasitas gudang
            try
            {
                KG_progressBar.Maximum = 5000;
                KG_progressBar.Value = 2000;
            }
            catch { }

            // Judul tabel hasil panen terbaru
            T_HPT.Text = "Hasil Panen Terbaru";

            // Isi data grid hasil panen terbaru
            HPT_dataGridView1.Rows.Clear();
            HPT_dataGridView1.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "Pak Budi", "Jagung", "120", "A");
            HPT_dataGridView1.Rows.Add(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), "Bu Siti", "Padi", "860", "B");
            HPT_dataGridView1.Rows.Add(DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"), "Pak Agus", "Kedelai", "326", "A");
        }

        // Labels
        private void L_TotalGedung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Gudang: 3");
        }
        private void L_Username_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username Admin aktif");
        }
        private void L_Role_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Role: Administrator");
        }
        private void L_StokSaatIni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stok Saat Ini: 5420 kg");
        }
        private void L_TotalHasilPanen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Hasil Panen: 1306 kg");
        }
        private void L_KapasitasGudang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gudang Utama A – 3200/5000 kg (64%)");
        }

        // Judul
        private void J_DashboardAdmin_Click(object sender, EventArgs e) => MessageBox.Show("Anda sedang berada di Dashboard Admin");

        // Gambar
        private void G_Profil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profil Admin ditampilkan");
        }

        // Buttons
        private void btDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Dashboard dibuka");
        }
        private void btDataHasilPanen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Data Hasil Panen dibuka");
        }
        private void btKelolaGudang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Kelola Gudang dibuka");
            try
            {
                var form = new KelolaGudang();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka Kelola Gudang: " + ex.Message, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void btStokMasuk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Stok Masuk dibuka");
        }
        private void btStokKeluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Stok Keluar dibuka");
        }
        private void btMonitoringStok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Monitoring Stok dibuka");
        }
        private void btLaporanInventori_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Laporan Inventori dibuka");
        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            using (FormKonfirmasiKeluar frm = new FormKonfirmasiKeluar())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    LoginSIMIHAN login = new LoginSIMIHAN();
                    login.Show();
                    this.Hide();
                }
            }
        }

        // Background
        private void BC_DashboardAdmin_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightGray;
            MessageBox.Show("Background Dashboard diubah menjadi abu-abu");
        }

        private void BC_MenuBar_Paint(object sender, PaintEventArgs e)
        {
            // Hanya menu bar yang diwarnai hijau tua
            e.Graphics.FillRectangle(System.Drawing.Brushes.DarkGreen, new Rectangle(0, 0, this.Width, 50));
        }

        // Angka
        private void T_HPT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Hasil Panen Terbaru: 1306 kg");
        }
        private void L_StokSaatIni_Click_1(object sender, EventArgs e)
        {
            // Show quick stock info
            MessageBox.Show(A_StokSaatIni.Text, "Stok Saat Ini",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void A_StokSaatIni_Click(object sender, EventArgs e)
        {
            // Same as clicking the label — show detailed stok info
            MessageBox.Show($"Detail Stok: {A_StokSaatIni.Text}", "Stok Detail", 
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void G_HasilPanen_Click(object sender, EventArgs e)
        {
            // Open the Data Hasil Panen view or show info
            MessageBox.Show("Membuka daftar Hasil Panen...", "Hasil Panen", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void L_TotalHasilPanen_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"{L_TotalHasilPanen.Text}", "Total Hasil Panen", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void A_TotalHasilPanen_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Angka Hasil Panen: {A_TotalHasilPanen.Text}", "Hasil Panen", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void G_Gudang_Click(object sender, EventArgs e)
        {
            // Open KelolaGudang form if available
            try
            {
                var form = new KelolaGudang();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka Kelola Gudang: " + ex.Message, "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }

        private void A_TotalGedung_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{A_TotalGedung.Text} gudang terdaftar.", "Total Gudang",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void SJ_KapasitasGudang_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{SJ_KapasitasGudang.Text}", "Kapasitas Gudang",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void L_TeksPendukungSJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Info: {L_TeksPendukungSJ.Text}", "Informasi Gudang", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void KG_progressBar_Click(object sender, EventArgs e)
        {
            // Show percentage based on progress bar
            try
            {
                int max = KG_progressBar.Maximum;
                int val = KG_progressBar.Value;
                int percent = max > 0 ? (int)Math.Round(val * 100.0 / max) : 0;
                MessageBox.Show($"Kapasitas saat ini: {val}/{max} kg ({percent}%)", "Kapasitas Gudang", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }
            catch { }
        }

        private void T_HPT_Click_1(object sender, EventArgs e)
        {
            // Same action as the other HPT click handler
            MessageBox.Show("Total Hasil Panen Terbaru: 1306 kg");
        }

        private void HPT_dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Show details for the clicked row
            if (e.RowIndex < 0) return;

            try
            {
                var row = HPT_dataGridView1.Rows[e.RowIndex];
                string tanggal = row.Cells[0].Value?.ToString() ?? "-";
                string petani = row.Cells[1].Value?.ToString() ?? "-";
                string komoditas = row.Cells[2].Value?.ToString() ?? "-";
                string berat = row.Cells[3].Value?.ToString() ?? "-";
                string kualitas = row.Cells[4].Value?.ToString() ?? "-";

                MessageBox.Show($"Tanggal: {tanggal}\nPetani: {petani}\nKomoditas: {komoditas}\nBerat Bersih: {berat} kg\nKualitas: {kualitas}", "Detail Hasil Panen", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendapatkan data baris: " + ex.Message, "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }
    }
}
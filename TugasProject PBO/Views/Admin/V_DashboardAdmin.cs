using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Models;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_DashboardAdmin : Form
    {
        private DashboardController _controller = new DashboardController();

        public V_DashboardAdmin()
        {
            InitializeComponent();
            this.Load += DashboardAdmin_Load;
        }

        private void LoadDashboardAdmin()
        {
            LoadDashboardAdmin();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SessionHelper.Nama))
                {
                    L_Username1.Text = SessionHelper.Nama;
                    L_Role1.Text = SessionHelper.Role ?? "Admin";
                }

                var ringkasan = _controller.GetRingkasan();

                L_TotalGedung.Text = ringkasan.TotalGudang;
                L_Username1.Text = ringkasan.Username;
                L_Role1.Text = ringkasan.Role;
                L_StokSaatIni.Text = ringkasan.StokSaatIni;
                L_TotalHasilPanen.Text = ringkasan.TotalHasilPanen;
                SJ_KapasitasGudang.Text = ringkasan.KapasitasGudang;

                KG_progressBar1.Maximum = ringkasan.GudangAMax;
                KG_progressBar1.Value = Math.Min(ringkasan.GudangAValue, ringkasan.GudangAMax);

                KG_progressBar2.Maximum = ringkasan.GudangBMax;
                KG_progressBar2.Value = Math.Min(ringkasan.GudangBValue, ringkasan.GudangBMax);

                KG_progressBar3.Maximum = ringkasan.GudangCMax;
                KG_progressBar3.Value = Math.Min(ringkasan.GudangCValue, ringkasan.GudangCMax);

                T_HPT.Text = "Hasil Panen Terbaru";

                HPT_dataGridView1.Rows.Clear();
                DataTable dtHasilPanen = _controller.GetHasilPanenTerbaruDashboard();
                foreach (DataRow row in dtHasilPanen.Rows)
                {
                    string tanggal = "-";
                    if (row["tanggal_panen"] != DBNull.Value)
                    {
                        var nilaiTanggal = row["tanggal_panen"];
                        tanggal = nilaiTanggal is DateOnly dateOnly
                            ? dateOnly.ToString("yyyy-MM-dd")
                            : Convert.ToDateTime(nilaiTanggal).ToString("yyyy-MM-dd");
                    }

                    string petani = row["nama_petani"]?.ToString() ?? "-";
                    string komoditas = row["komoditas"]?.ToString() ?? "-";
                    string beratBersih = row["berat_bersih"] != DBNull.Value ? row["berat_bersih"].ToString() : "0";
                    string kualitas = row["kualitas"]?.ToString() ?? "-";

                    HPT_dataGridView1.Rows.Add(tanggal, petani, komoditas, beratBersih, kualitas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Labels
        private void L_TotalGedung_Click(object sender, EventArgs e) => MessageBox.Show("Total Gudang: ");
        private void L_Username_Click(object sender, EventArgs e) => MessageBox.Show("Username Admin aktif");
        private void L_Role_Click(object sender, EventArgs e) => MessageBox.Show("Role: Administrator");
        private void L_StokSaatIni_Click(object sender, EventArgs e) => MessageBox.Show("Stok Saat Ini:  ");
        private void L_TotalHasilPanen_Click(object sender, EventArgs e) => MessageBox.Show("Total Hasil Panen: ");
        private void L_KapasitasGudang_Click(object sender, EventArgs e) => MessageBox.Show("Gudang Utama A – 3200/5000 kg (64%)");

        // Judul
        private void J_DashboardAdmin_Click(object sender, EventArgs e) => MessageBox.Show("Anda sedang berada di Dashboard Admin");

        // Gambar
        private void G_Profil_Click(object sender, EventArgs e) => MessageBox.Show("Profil Admin ditampilkan");

        // Buttons
        private void btDashboard_Click(object sender, EventArgs e) => MessageBox.Show("Menu Dashboard dibuka");

        private void btDataHasilPanen_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new V_KelolaDataHasilPanen();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka Kelola Data Hasil Panen: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKelolaGudang_Click(object sender, EventArgs e)
        {
            V_KelolaGudang form = new V_KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_Click(object sender, EventArgs e)
        {
            V_KelolaStokKeluar form = new V_KelolaStokKeluar();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_Click(object sender, EventArgs e) => MessageBox.Show("Menu Stok Keluar dibuka");

        private void btMonitoringStok_Click(object sender, EventArgs e)
        {
            V_MonitoringStok form = new V_MonitoringStok();
            form.Show();
            this.Hide();
        }

        private void btLaporanInventori_Click(object sender, EventArgs e)
        {
            V_LaporanInventori form = new V_LaporanInventori();
            form.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
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

        // Background
        private void BC_DashboardAdmin_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightGray;
            MessageBox.Show("Background Dashboard diubah menjadi abu-abu");
        }

        private void BC_MenuBar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(System.Drawing.Brushes.DarkGreen, new Rectangle(0, 0, this.Width, 50));
        }

        private void T_HPT_Click(object sender, EventArgs e) => MessageBox.Show("Total Hasil Panen Terbaru: 1306 kg");

        private void L_StokSaatIni_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(A_StokSaatIni.Text, "Stok Saat Ini", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void A_StokSaatIni_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Detail Stok: {A_StokSaatIni.Text}", "Stok Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void G_HasilPanen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Membuka daftar Hasil Panen...", "Hasil Panen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void L_TotalHasilPanen_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"{L_TotalHasilPanen.Text}", "Total Hasil Panen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void A_TotalHasilPanen_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Angka Hasil Panen: {A_TotalHasilPanen.Text}", "Hasil Panen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void G_Gudang_Click(object sender, EventArgs e)
        {
            V_KelolaGudang form = new V_KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void A_TotalGedung_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{A_TotalGedung.Text} gudang terdaftar.", "Total Gudang", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SJ_KapasitasGudang_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{SJ_KapasitasGudang.Text}", "Kapasitas Gudang", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void L_TeksPendukungSJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Info: {L_TeksPendukungSJ.Text}", "Informasi Gudang", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KG_progressBar_Click(object sender, EventArgs e)
        {
            try
            {
                int max = KG_progressBar1.Maximum;
                int val = KG_progressBar1.Value;
                int percent = max > 0 ? (int)Math.Round(val * 100.0 / max) : 0;
                MessageBox.Show($"Kapasitas saat ini: {val}/{max} kg ({percent}%)", "Kapasitas Gudang",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void T_HPT_Click_1(object sender, EventArgs e) => MessageBox.Show("Total Hasil Panen Terbaru: 1306 kg");

        private void HPT_dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = HPT_dataGridView1.Rows[e.RowIndex];
                string tanggal = row.Cells[0].Value?.ToString() ?? "-";
                string petani = row.Cells[1].Value?.ToString() ?? "-";
                string komoditas = row.Cells[2].Value?.ToString() ?? "-";
                string berat = row.Cells[3].Value?.ToString() ?? "-";
                string kualitas = row.Cells[4].Value?.ToString() ?? "-";

                MessageBox.Show($"Tanggal: {tanggal}\nPetani: {petani}\nKomoditas: {komoditas}\nBerat Bersih: {berat} kg\nKualitas: {kualitas}",
                "Detail Hasil Panen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendapatkan data baris: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BC_Page1_Paint(object sender, PaintEventArgs e) { }

        private void KG_progressBar_Clickk(object sender, EventArgs e)
        {
            try
            {
                int max = KG_progressBar3.Maximum;
                int val = KG_progressBar3.Value;
                int percent = max > 0 ? (int)Math.Round(val * 100.0 / max) : 0;
                MessageBox.Show($"Kapasitas saat ini: {val}/{max} kg ({percent}%)", "Kapasitas Gudang",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void KG_progressBar_Clickkk(object sender, EventArgs e)
        {
            try
            {
                int max = KG_progressBar2.Maximum;
                int val = KG_progressBar2.Value;
                int percent = max > 0 ? (int)Math.Round(val * 100.0 / max) : 0;
                MessageBox.Show($"Kapasitas saat ini: {val}/{max} kg ({percent}%)", "Kapasitas Gudang",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}
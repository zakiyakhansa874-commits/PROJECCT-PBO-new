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
            // Initialize header labels
            try
            {
                L_TotalGedung.Text = "Total Gudang: 3";
            }
            catch { }

            try
            {
                L_Username.Text = "Username: admin";
            }
            catch { }

            try
            {
                L_Role.Text = "Role: Administrator";
            }
            catch { }

            // Initialize recent harvest label (if present)
            try
            {
                T_HPT.Text = "Hasil Panen Terbaru";
            }
            catch { }

            // Populate sample rows into the HPT data grid (designer defines columns: Tanggal, Petani, Komoditas, Berat Bersih (kg), Kualitas)
            try
            {
                HPT_dataGridView1.Rows.Clear();
                HPT_dataGridView1.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd"), "Pak Budi", "Jagung", "120", "A");
                HPT_dataGridView1.Rows.Add(DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), "Bu Siti", "Padi", "860", "B");
                HPT_dataGridView1.Rows.Add(DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"), "Pak Agus", "Kedelai", "326", "A");
            }
            catch { }
        }

        // Ini LABELS (L) Bossku
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

        // Ini JUDUL (J) Bossku
        private void J_DashboardAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda sedang berada di Dashboard Admin");
        }

        // Ini GAMBAR (G) Bossku
        private void G_Profil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profil Admin ditampilkan");
        }

        // Ini BUTTONS (bt) Bossku
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
            using (FrmKonfirmasiKeluar frm =
           new FrmKonfirmasiKeluar("Pak Hendra"))
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    LoginSIMIHAN login = new LoginSIMIHAN();
                    login.Show();

                    this.Hide();
                }
            }
        }

        // Ini BACKGROUND (BC) Bossku
        private void BC_DashboardAdmin_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightGray;
            MessageBox.Show("Background Dashboard diubah menjadi abu-abu");
        }

        private void BC_MenuBar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(System.Drawing.Brushes.DarkGreen, this.ClientRectangle);
        }

        // Ini ANGKA (A) Bossku
        private void T_HPT_Clik(object sender, EventArgs e)
        {
            MessageBox.Show("Total Hasil Panen Terbaru: 1306 kg");
        }

        private void HPT_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
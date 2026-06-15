using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO.Views.Admin
{
    public partial class MonitoringStok : Form
    {
        public MonitoringStok()
        {
            InitializeComponent();
        }
        private void BC_MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void G_KelolaDataHasilPanen_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btDashboard_6_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaGudang_6_Click(object sender, EventArgs e)
        {
            KelolaGudang form = new KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_6_Click(object sender, EventArgs e)
        {
            KelolaStokMasuk form = new KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_6_Click(object sender, EventArgs e)
        {
            KelolaStokKeluar form = new KelolaStokKeluar();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok_6_Click(object sender, EventArgs e)
        {
            MonitoringStok form = new MonitoringStok();
            form.Show();
            this.Hide();
        }

        private void btLaporanInventori_6_Click(object sender, EventArgs e)
        {
            LaporanInventori form = new LaporanInventori();
            form.Show();
            this.Hide();
        }

        private void btLogout_6_Click(object sender, EventArgs e)
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

        private void BC__Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Show percentage based on progress bar
            try
            {
                int max = RSProgressbar.Maximum;
                int val = RSProgressbar.Value;
                int percent = max > 0 ? (int)Math.Round(val * 100.0 / max) : 0;
                MessageBox.Show($"Kapasitas saat ini: {val}/{max} kg ({percent}%)", "Kapasitas Gudang",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch { }
        }
    }
}

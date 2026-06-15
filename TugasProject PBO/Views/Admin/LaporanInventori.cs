using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO.Views.Admin
{
    public partial class LaporanInventori : Form
    {
        public LaporanInventori()
        {
            InitializeComponent();
        }

        private void G_DashboardAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
        private void J_DashboardAdmin_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btKelolaHasilPanen_1_Click(object sender, EventArgs e)
        {

        }

        private void btDashboard_7_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaGudang_7_Click(object sender, EventArgs e)
        {
            KelolaGudang form = new KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_7_Click(object sender, EventArgs e)
        {
            KelolaStokMasuk form = new KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_7_Click(object sender, EventArgs e)
        {
            KelolaStokKeluar form = new KelolaStokKeluar();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok_7_Click(object sender, EventArgs e)
        {
            MonitoringStok form = new MonitoringStok();
            form.Show();
            this.Hide();
        }

        private void btLaporanInventori_7_Click(object sender, EventArgs e)
        {
            LaporanInventori form = new LaporanInventori();
            form.Show();
            this.Hide();
        }

        private void btLogout_7_Click(object sender, EventArgs e)
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
    }
}

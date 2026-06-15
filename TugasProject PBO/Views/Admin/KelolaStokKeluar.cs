using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO.Views.Admin
{
    public partial class KelolaStokKeluar : Form
    {
        public KelolaStokKeluar()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void G_KelolaStokKeluar_Click(object sender, EventArgs e)
        {

        }
        private void BC_MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDashboard5_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboard = new DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaGudang5_Click(object sender, EventArgs e)
        {
            KelolaGudang form = new KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk5_Click(object sender, EventArgs e)
        {
            KelolaStokMasuk form = new KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok5_Click(object sender, EventArgs e)
        {
            MonitoringStok form = new MonitoringStok();
            form.Show();
            this.Hide();
        }

        private void btLogout5_Click(object sender, EventArgs e)
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

        private void BC_Page5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

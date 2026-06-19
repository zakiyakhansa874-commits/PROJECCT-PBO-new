using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_MonitoringStok : Form   
    {
        public V_MonitoringStok()
        {
            InitializeComponent();
            Load += MonitoringStok_Load;  
        }

        private MonitoringController _controller = new MonitoringController();
        private void MonitoringStok_Load(object sender, EventArgs e)
        {
            L_Username6.Text = SessionHelper.Nama;
            L_Role6.Text = SessionHelper.Role;
            LoadRiwayatStok();
            LoadMasukTerakhir();
            LoadKeluarTerakhir();
        }

        private void LoadRiwayatStok()
        {
            DGV_RiwayatStok.DataSource = _controller.GetRiwayatStok();
            DGV_RiwayatStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadMasukTerakhir()
        {
            DGV_MasukTerakhir.DataSource = _controller.GetMasukTerakhir();
            DGV_MasukTerakhir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadKeluarTerakhir()
        {
            DGV_KeluarTerakhir6.DataSource = _controller.GetKeluarTerakhir();
            DGV_KeluarTerakhir6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btDashboard_6_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin form = new V_DashboardAdmin();
            form.Show();
            this.Hide();
        }

        private void btKelolaGudang_6_Click(object sender, EventArgs e)
        {
            V_KelolaGudang form = new V_KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_6_Click(object sender, EventArgs e)
        {
            V_KelolaStokMasuk form = new V_KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_6_Click(object sender, EventArgs e)
        {
            V_KelolaStokKeluar form = new V_KelolaStokKeluar();
            form.Show();
            this.Hide();
        }
        private void btMonitoringStok_6_Click(object sender, EventArgs e)
        {

        }
        private void btLaporanInventori_6_Click(object sender, EventArgs e)
        {
            V_LaporanInventori form = new V_LaporanInventori();
            form.Show();
            this.Hide();
        }
        private void btLogout_6_Click(object sender, EventArgs e)
        {
            LoginSIMIHAN login = new LoginSIMIHAN();
            login.Show();
            this.Hide();
        }
        private void BC__Paint(object sender, PaintEventArgs e)
        {

        }
        private void BC_penel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DGV_RiwayatMutasiStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void J_MonitoringStok6_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Controllers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_LaporanInventori : Form
    {
        private LaporanController _controller = new LaporanController();

        public V_LaporanInventori()
        {
            InitializeComponent();
            Load += LaporanInventori_Load;
        }

        private void LaporanInventori_Load(object sender, EventArgs e)
        {
            L_Username7.Text = SessionHelper.Nama;
            L_Role7.Text = SessionHelper.Role;
            LoadHasilPanen();
            LoadStokMasuk();
            LoadStokKeluar();

            dtpDari7.ValueChanged += FilterChanged;
            dtpSampai7.ValueChanged += FilterChanged;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            LoadHasilPanen();
            LoadStokMasuk();
            LoadStokKeluar();
        }

        private void LoadHasilPanen()
        {
            try
            {
                DGV_RHP7.Columns.Clear();
                DGV_RHP7.DataSource = _controller.GetHasilPanen(dtpDari7.Value.Date, dtpSampai7.Value.Date);
                DGV_RHP7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadStokMasuk()
        {
            try
            {
                DGV_RSM7.Columns.Clear();
                DGV_RSM7.DataSource = _controller.GetStokMasuk(dtpDari7.Value.Date, dtpSampai7.Value.Date);
                DGV_RSM7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadStokKeluar()
        {
            try
            {
                DGV_RHK7.Columns.Clear();
                DGV_RHK7.DataSource = _controller.GetStokKeluar(dtpDari7.Value.Date, dtpSampai7.Value.Date);
                DGV_RHK7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BC_MenuBar7_Paint(object sender, PaintEventArgs e) { }

        private void btDashboard_7_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin form = new V_DashboardAdmin();
            form.Show();
            this.Hide();
        }

        private void btKelolaGudang_7_Click(object sender, EventArgs e)
        {
            V_KelolaGudang form = new V_KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_7_Click(object sender, EventArgs e)
        {
            V_KelolaStokMasuk form = new V_KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_7_Click(object sender, EventArgs e)
        {
            V_KelolaStokKeluar form = new V_KelolaStokKeluar();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok_7_Click(object sender, EventArgs e)
        {
            V_MonitoringStok form = new V_MonitoringStok();
            form.Show();
            this.Hide();
        }

        private void btLaporanInventori_7_Click(object sender, EventArgs e) { }

        private void btLogout_7_Click(object sender, EventArgs e)
        {
            LoginSIMIHAN login = new LoginSIMIHAN();
            login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void G_DashboardAdmin_Click(object sender, EventArgs e) { }
        private void J_DashboardAdmin_Click(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
    }
}
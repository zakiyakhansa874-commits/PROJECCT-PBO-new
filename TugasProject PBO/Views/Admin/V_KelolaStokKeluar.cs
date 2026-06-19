using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_KelolaStokKeluar : Form
    {
        private StokKeluarController _controller = new StokKeluarController();

        public V_KelolaStokKeluar()
        {
            InitializeComponent();
            Load += LoadDataStokKeluar;
            DGV_KelolaStokKeluar5.AutoGenerateColumns = true;
            LoadDataStokKeluar();
        }

        // Overload tanpa parameter — CUKUP SATU
        private void LoadDataStokKeluar()
        {
            LoadDataStokKeluar(this, EventArgs.Empty);
        }

        private void LoadDataStokKeluar(object sender, EventArgs e)
        {
            L_Username5.Text = SessionHelper.Nama;
            L_Role5.Text = SessionHelper.Role;

            try
            {
                DataTable dt = _controller.GetAllStokKeluar();
                DGV_KelolaStokKeluar5.Columns.Clear();
                DGV_KelolaStokKeluar5.AutoGenerateColumns = true;
                DGV_KelolaStokKeluar5.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void G_KelolaStokKeluar_Click(object sender, EventArgs e) { }
        private void BC_MenuBar_Paint(object sender, PaintEventArgs e) { }
        private void BC_Page5_Paint(object sender, PaintEventArgs e) { }
        private void J_KelolaStokKeluar5_Click(object sender, EventArgs e) { }
        private void DGV_KelolaStokKeluar5_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btTambah5_Click(object sender, EventArgs e)
        {
            using (InputStokKeluar5 frm = new InputStokKeluar5())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadDataStokKeluar();
            }
        }

        private void btHapus5_Click(object sender, EventArgs e)
        {
            if (DGV_KelolaStokKeluar5.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.No) return;

            try
            {
                int idStokKeluar = Convert.ToInt32(
                    DGV_KelolaStokKeluar5.CurrentRow.Cells["id_stokkeluar"].Value);

                _controller.HapusStokKeluar(idStokKeluar);

                MessageBox.Show("Data berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataStokKeluar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ← navigasi sudah difix nama class-nya
        private void btDashboard5_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin dashboard = new V_DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaGudang5_Click(object sender, EventArgs e)
        {
            V_KelolaGudang form = new V_KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk5_Click(object sender, EventArgs e)
        {
            V_KelolaStokMasuk form = new V_KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok5_Click(object sender, EventArgs e)
        {
            V_MonitoringStok form = new V_MonitoringStok();
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
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_KelolaGudang : Form
    {
        private GudangController _controller = new GudangController();
        private int selectedGudangId = 0;

        public V_KelolaGudang()
        {
            InitializeComponent();
            this.Load += KelolaGudang_Load;
        }

        private void KelolaGudang_Load(object sender, EventArgs e)
        {
            L_Username.Text = SessionHelper.Nama;
            L_Role.Text = SessionHelper.Role;

            try
            {
                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data awal gudang: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGudangAll()
        {
            DGV_KelolaGudang3.Rows.Clear();
            try
            {
                DataTable dt = _controller.GetAllGudang();
                foreach (DataRow row in dt.Rows)
                {
                    double kapasitas = row["kapasitas_maksimal"] != DBNull.Value ? Convert.ToDouble(row["kapasitas_maksimal"]) : 0;
                    double stokSaatIni = row["stok_saat_ini"] != DBNull.Value ? Convert.ToDouble(row["stok_saat_ini"]) : 0;

                    string terisi = kapasitas <= 0 ? "0%" :
                        Math.Round((stokSaatIni / kapasitas) * 100.0, 2).ToString() + "%";

                    DGV_KelolaGudang3.Rows.Add(
                        row["id_gudang"].ToString(),
                        row["nama_gudang"]?.ToString() ?? "-",
                        row["lokasi"]?.ToString() ?? "-",
                        kapasitas.ToString() + " kg",
                        stokSaatIni.ToString() + " kg",
                        terisi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_KelolaGudang3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = DGV_KelolaGudang3.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                    selectedGudangId = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void btTambah3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formTambah = new V_InputEditGudang())
                    formTambah.ShowDialog();
                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form tambah gudang: " + ex.Message, "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btEdit3_Click(object sender, EventArgs e)
        {
            if (selectedGudangId == 0)
            {
                MessageBox.Show("Silakan pilih salah satu gudang di dalam tabel terlebih dahulu!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var formEdit = new V_InputEditGudang())
                    formEdit.ShowDialog();
                LoadDataGudangAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form edit gudang: " + ex.Message, "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btHapus3_Click(object sender, EventArgs e)
        {
            if (selectedGudangId == 0)
            {
                MessageBox.Show("Silakan pilih data gudang yang ingin dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data gudang ini beserta semua riwayat stok masuknya?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusGudang(selectedGudangId);
                    MessageBox.Show("Data gudang berhasil dihapus!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedGudangId = 0;
                    LoadDataGudangAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btDashboard3_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin dashboard = new V_DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaHasilPanen3_Click(object sender, EventArgs e)
        {
            V_KelolaDataHasilPanen hasilPanen = new V_KelolaDataHasilPanen();
            hasilPanen.Show();
            this.Hide();
        }

        private void btKelolaGudang3_Click(object sender, EventArgs e) { LoadDataGudangAll(); }

        private void btStokMasuk3_Click(object sender, EventArgs e)
        {
            V_KelolaStokMasuk stokMasuk = new V_KelolaStokMasuk();
            stokMasuk.Show();
            this.Hide();
        }

        private void btStokKeluar3_Click(object sender, EventArgs e)
        {
            V_KelolaStokKeluar stokKeluar = new V_KelolaStokKeluar();
            stokKeluar.Show();
            this.Hide();
        }

        private void btMonitoringStok3_Click(object sender, EventArgs e)
        {
            V_MonitoringStok monitoring = new V_MonitoringStok();
            monitoring.Show();
            this.Hide();
        }

        private void btLaporanInventori3_Click(object sender, EventArgs e)
        {
            V_LaporanInventori laporan = new V_LaporanInventori();
            laporan.Show();
            this.Hide();
        }

        private void btLogout3_Click(object sender, EventArgs e)
        {
            using (KonfirmasiLogout frm = new KonfirmasiLogout())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    SessionHelper.ClearSession();
                    LoginSIMIHAN login = new LoginSIMIHAN();
                    login.Show();
                    this.Hide();
                }
            }
        }

        private void G_KelolaGudang_Click(object sender, EventArgs e) { }
        private void BC_MenuBar_Paint3(object sender, PaintEventArgs e) { }
        private void J_KelolaGudang3_Click(object sender, EventArgs e) { }
        private void BC_Page3_Paint(object sender, PaintEventArgs e) { }
    }
}
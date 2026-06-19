using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_KelolaStokMasuk : Form
    {
        private StokMasukController _controller = new StokMasukController();

        public V_KelolaStokMasuk()
        {
            InitializeComponent();
            LoadDataStokMasukAll();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void G_KelolaStokMasuk_Click(object sender, EventArgs e) { }
        private void BC_MenuBar_Paint2(object sender, PaintEventArgs e) { }
        private void BC_Page4_Paint(object sender, PaintEventArgs e) { }

        private void LoadDataStokMasukAll()
        {
            L_Username4.Text = SessionHelper.Nama;
            L_Role4.Text = SessionHelper.Role;
            DGV_KelolaStokMasuk4.Rows.Clear();
            try
            {
                DataTable dt = _controller.GetAllStokMasuk();
                foreach (DataRow row in dt.Rows)
                {
                    string tanggal = "-";
                    if (row["tanggal"] != DBNull.Value)
                    {
                        var nilaiTanggal = row["tanggal"];
                        if (nilaiTanggal is DateOnly dateOnly)
                            tanggal = dateOnly.ToString("dd-MM-yyyy");
                        else
                            tanggal = Convert.ToDateTime(nilaiTanggal).ToString("dd-MM-yyyy");
                    }

                    DGV_KelolaStokMasuk4.Rows.Add(
                        row["id_stokmasuk"].ToString(),
                        tanggal,
                        row["nama_gudang"]?.ToString() ?? "-",
                        row["nama_petani"]?.ToString() ?? "-",
                        row["jumlah"]?.ToString() + " kg" ?? "0",
                        row["kualitas"]?.ToString() ?? "-",
                        row["catatan"]?.ToString() ?? "-");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTambah4_Click(object sender, EventArgs e)
        {
            try
            {
                using (InputStokMasuk4 formInput = new InputStokMasuk4())
                {
                    if (formInput.ShowDialog() == DialogResult.OK)
                        LoadDataStokMasukAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman tambah data: " + ex.Message, "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btHapus4_Click(object sender, EventArgs e)
        {
            if (DGV_KelolaStokMasuk4.CurrentRow == null || DGV_KelolaStokMasuk4.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Silakan pilih baris data di tabel yang ingin dihapus terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idTerpilih = DGV_KelolaStokMasuk4.CurrentRow.Cells[0].Value.ToString();

            DialogResult konfirmasi = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus data transaksi dengan ID {idTerpilih}?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusStokMasuk(Convert.ToInt32(idTerpilih));
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStokMasukAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DGV_KelolaStokMasuk4_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btDashboard4_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin dashboard = new V_DashboardAdmin();
            dashboard.Show();
            this.Close();
        }

        private void btKelolaHasilPanen4_Click(object sender, EventArgs e)
        {
            V_KelolaDataHasilPanen hasilPanen = new V_KelolaDataHasilPanen();
            hasilPanen.Show();
            this.Close();
        }

        private void btKelolaGudang4_Click(object sender, EventArgs e)
        {
            V_KelolaGudang gudang = new V_KelolaGudang();
            gudang.Show();
            this.Close();
        }

        private void btStokMasuk4_Click(object sender, EventArgs e) { LoadDataStokMasukAll(); }

        private void btStokKeluar4_Click(object sender, EventArgs e)
        {
            V_KelolaStokKeluar stokKeluar = new V_KelolaStokKeluar();
            stokKeluar.Show();
            this.Close();
        }

        private void btMonitoringStok4_Click(object sender, EventArgs e)
        {
            V_MonitoringStok monitoring = new V_MonitoringStok();
            monitoring.Show();
            this.Close();
        }

        private void btLaporanInventori4_Click(object sender, EventArgs e)
        {
            V_LaporanInventori laporan = new V_LaporanInventori();
            laporan.Show();
            this.Close();
        }

        private void btLogout4_Click(object sender, EventArgs e)
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
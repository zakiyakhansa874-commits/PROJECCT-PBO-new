using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_KelolaDataHasilPanen : Form
    {
        private HasilPanenController _controller = new HasilPanenController();
        private int selectedId = 0;

        public V_KelolaDataHasilPanen()
        {
            InitializeComponent();
            this.Load += KelolaDataHasilPanen_Load;
        }

        private void KelolaDataHasilPanen_Load(object sender, EventArgs e)
        {
            L_Username2.Text = SessionHelper.Nama;
            L_Role2.Text = SessionHelper.Role;

            try
            {
                LoadDataPanenAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data awal: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataPanenAll()
        {
            DGV_datahasilpanen2.Rows.Clear();
            try
            {
                DataTable dt = _controller.GetAllHasilPanen();
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["id_hasilpanen"]);
                    decimal beratKotor = row.IsNull("berat_kotor") ? 0M : Convert.ToDecimal(row["berat_kotor"]);
                    decimal beratBersih = row.IsNull("berat_bersih") ? 0M : Convert.ToDecimal(row["berat_bersih"]);
                    string kualitas = row.IsNull("kualitas") ? "-" : row["kualitas"].ToString();
                    string catatan = row.IsNull("catatan") ? "" : row["catatan"].ToString();
                    string tanggal = "";
                    if (!row.IsNull("tanggal_panen"))
                    {
                        var nilaiTanggal = row["tanggal_panen"];
                        if (nilaiTanggal is DateOnly dateOnly)
                            tanggal = dateOnly.ToString("yyyy-MM-dd");
                        else
                            tanggal = Convert.ToDateTime(nilaiTanggal).ToString("yyyy-MM-dd");
                    }
                    string komoditas = row.IsNull("komoditas") ? "" : row["komoditas"].ToString();
                    string petani = row.IsNull("id_petani") ? "" : row["id_petani"].ToString();

                    DGV_datahasilpanen2.Rows.Add(id, beratKotor.ToString("F2"), beratBersih.ToString("F2"),
                        kualitas, catatan, tanggal, petani, komoditas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR DATABASE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_datahasilpanen2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(
                    DGV_datahasilpanen2.Rows[e.RowIndex].Cells[0].Value
                );
            }
        }

        private void bt_tambah2_Click(object sender, EventArgs e)
        {
            using (V_InputHasilPanenPetani frm = new V_InputHasilPanenPetani())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataPanenAll();
                }
            }
        }

        private void bt_edit2_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Silakan pilih data pada tabel terlebih dahulu untuk diubah!", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Fitur edit untuk ID: {selectedId} siap dikembangkan.", "Edit Data",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_hapus2_Click(object sender, EventArgs e)
        {
            if (DGV_datahasilpanen2.CurrentRow == null)
            {
                MessageBox.Show(
                    "Silakan pilih data yang ingin dihapus terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(
                DGV_datahasilpanen2.CurrentRow.Cells[0].Value);

            DialogResult konfirmasi = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus data hasil panen dengan ID {id}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    _controller.HapusHasilPanen(id);

                    MessageBox.Show(
                        "Data berhasil dihapus!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDataPanenAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btDashboard2_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin dashboard = new V_DashboardAdmin();
            dashboard.Show();
            this.Hide();
        }

        private void btKelolaHasilPanen2_Click(object sender, EventArgs e) { LoadDataPanenAll(); }

        private void btKelolaGudang2_Click(object sender, EventArgs e)
        {
            V_KelolaGudang form = new V_KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk2_Click(object sender, EventArgs e)
        {
            V_KelolaStokMasuk form = new V_KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar2_Click(object sender, EventArgs e)
        {
            V_KelolaStokMasuk form = new V_KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok2_Click(object sender, EventArgs e)
        {
            V_MonitoringStok form = new V_MonitoringStok();
            form.Show();
            this.Hide();
        }

        private void btLaporanInventori2_Click(object sender, EventArgs e) { }

        private void btLogout2_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void BC_MenuBar_Paint(object sender, PaintEventArgs e) { _ = sender; _ = e; }
        private void G_KelolaDataHasilPanen_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void J_KelolaDataHasilPanen2_Click(object sender, EventArgs e) { _ = sender; }

        private void DGV_datahasilpanen2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
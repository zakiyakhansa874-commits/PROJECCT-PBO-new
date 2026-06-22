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

        private void LoadDataPanenAll() // DGV kelola hasil panen ADMIN
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

                    DGV_datahasilpanen2.Rows.Add(id, petani, tanggal, komoditas, kualitas, beratKotor.ToString("F2"), beratBersih.ToString("F2"),
                        catatan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR DATABASE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_datahasilpanen2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = DGV_datahasilpanen2.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells[0].Value);
            int idPetani = Convert.ToInt32(row.Cells[1].Value);
            DateTime tanggal = DateTime.Parse(row.Cells[2].Value.ToString());
            string komoditas = row.Cells[3].Value?.ToString() ?? "";
            string kualitas = row.Cells[4].Value?.ToString() ?? "";
            decimal beratKotor = decimal.Parse(row.Cells[5].Value.ToString());
            decimal beratBersih = decimal.Parse(row.Cells[6].Value.ToString());
            string catatan = row.Cells[7].Value?.ToString() ?? "";

            using (V_InputHasilPanenPetani frm = new V_InputHasilPanenPetani())
            {
                frm.LoadDataEdit(id, idPetani, tanggal, komoditas, beratKotor, beratBersih, kualitas, catatan);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataPanenAll();
                }
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
            try
            {
                foreach (DataGridViewRow row in DGV_datahasilpanen2.Rows)
                {
                    if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == selectedId)
                    {
                        decimal beratKotor = decimal.Parse(row.Cells[1].Value.ToString());
                        decimal beratBersih = decimal.Parse(row.Cells[2].Value.ToString());
                        string kualitas = row.Cells[3].Value?.ToString() ?? "";
                        string catatan = row.Cells[4].Value?.ToString() ?? "";
                        DateTime tanggal = DateTime.Parse(row.Cells[5].Value.ToString());
                        int idPetani = Convert.ToInt32(row.Cells[6].Value);
                        string komoditas = row.Cells[7].Value?.ToString() ?? "";

                        using (V_InputHasilPanenPetani frm = new V_InputHasilPanenPetani())
                        {
                            frm.LoadDataEdit(selectedId, idPetani, tanggal, komoditas, beratKotor, beratBersih, kualitas, catatan);

                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                LoadDataPanenAll();
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DEBUG ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
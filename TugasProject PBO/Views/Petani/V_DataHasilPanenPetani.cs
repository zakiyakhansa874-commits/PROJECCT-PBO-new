using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Views.Admin;

namespace TugasProject_PBO.Views.Petani
{
    public partial class V_DataHasilPanenPetani : Form
    {
        private readonly HasilPanenController _controller = new HasilPanenController();

        public V_DataHasilPanenPetani()
        {
            InitializeComponent();
            this.Load += DataHasilPanenPetani_Load;
        }

        private void DataHasilPanenPetani_Load(object sender, EventArgs e)
        {
            L_Username8.Text = SessionHelper.Username;
            L_Petani8.Text = SessionHelper.Role;

            try
            {
                if (!string.IsNullOrEmpty(SessionHelper.Nama))
                {
                    L_Username8.Text = SessionHelper.Nama;
                    L_Petani8.Text = SessionHelper.Role ?? "Petani";
                }
                LoadHasilPanen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHasilPanen()
        {
            DGV_InputHasilPanen8.Rows.Clear();
            try
            {
                DataTable dt = _controller.GetHasilPanenByPetani(SessionHelper.IdUser);

                decimal totalBeratBersih = 0m;
                int totalEntri = 0;

                foreach (DataRow row in dt.Rows)
                {
                    var nilaiTanggal = row["tanggal_panen"];
                    string tanggal = "-";
                    if (nilaiTanggal != DBNull.Value)
                    {
                        if (nilaiTanggal is DateOnly dateOnly)
                            tanggal = dateOnly.ToString("yyyy-MM-dd");
                        else
                            tanggal = Convert.ToDateTime(nilaiTanggal).ToString("yyyy-MM-dd");
                    }

                    string komoditas = row.IsNull("komoditas") ? "-" : row["komoditas"].ToString();
                    decimal beratKotor = row.IsNull("berat_kotor") ? 0m : Convert.ToDecimal(row["berat_kotor"]);
                    decimal beratBersih = row.IsNull("berat_bersih") ? 0m : Convert.ToDecimal(row["berat_bersih"]);
                    string kualitas = row.IsNull("kualitas") ? "-" : row["kualitas"].ToString();
                    string catatan = row.IsNull("catatan") ? "" : row["catatan"].ToString();

                    DGV_InputHasilPanen8.Rows.Add(tanggal, komoditas,
                        beratKotor.ToString("F2"), beratBersih.ToString("F2"), kualitas, catatan);

                    totalBeratBersih += beratBersih;
                    totalEntri++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKelolaHasilPanen_1_Click(object sender, EventArgs e)
        {
            MonitoringStokGudang frm = new MonitoringStokGudang();
            frm.Show();
            this.Hide();
        }

        private void btInputBaru_Click(object sender, EventArgs e)
        {
            // Open input form modally and refresh the list after it closes so new entries appear on the dashboard
            using var frm = new V_InputHasilPanenPetani();
            try
            {
                var result = frm.ShowDialog();
                // Refresh regardless of DialogResult to ensure latest data shown
                LoadHasilPanen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form input: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_InputHasilPanen8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var row = DGV_InputHasilPanen8.Rows[e.RowIndex];
                string tanggal = row.Cells[0].Value?.ToString() ?? "-";
                string komoditas = row.Cells[1].Value?.ToString() ?? "-";
                string beratKotor = row.Cells[2].Value?.ToString() ?? "-";
                string beratBersih = row.Cells[3].Value?.ToString() ?? "-";
                string kualitas = row.Cells[4].Value?.ToString() ?? "-";
                string catatan = row.Cells[5].Value?.ToString() ?? "-";

                MessageBox.Show(
                    $"Tanggal: {tanggal}\nKomoditas: {komoditas}\nBerat Kotor: {beratKotor} kg\nBerat Bersih: {beratBersih} kg\nKualitas: {kualitas}\nCatatan: {catatan}",
                    "Detail Entri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan detail: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDashboard_8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogout_8_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionHelper.ClearSession();

                LoginSIMIHAN login = new LoginSIMIHAN();
                login.Show();

                this.Close();
            }
        }

        private void btInputBaru8_Click_1(object sender, EventArgs e)
        {
            // Another entry point for opening the input form. Always refresh after close.
            using var frm = new V_InputHasilPanenPetani();
            try
            {
                var result = frm.ShowDialog();
                LoadHasilPanen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form input: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void J_InputHasilPanenPetani8_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void A_StokSaatIni_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void label2_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void label5_Click(object sender, EventArgs e) { _ = sender; _ = e; }

        private void P_TotalEntri_Paint(object sender, PaintEventArgs e)
        {
            // Intentionally left blank (designer event). No action required.
            _ = sender; _ = e;
        }
        // There are two possible CellContentClick handlers generated by the designer.
        // Keep a single implementation above (DGV_InputHasilPanen8_CellContentClick) and ignore extra wiring.
        private void DGV_InputHasilPanen8_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Forward to the main handler so designer wiring to this method still works.
            DGV_InputHasilPanen8_CellContentClick(sender, e);
        }
    }
}
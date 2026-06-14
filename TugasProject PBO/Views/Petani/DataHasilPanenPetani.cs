using System;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Views.Admin;
namespace TugasProject_PBO.Views.Petani
{
    public partial class DataHasilPanenPetani : Form
    {
        public DataHasilPanenPetani()
        {
            InitializeComponent();
            this.Load += DataHasilPanenPetani_Load;
        }


        private void DataHasilPanenPetani_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SessionHelper.Nama))
                {
                    L_Username8.Text = SessionHelper.Nama;
                    L_Role8.Text = SessionHelper.Role ?? "Petani";
                }

                LoadHasilPanen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHasilPanen()
        {
            DGV_InputHasilPanen8.Rows.Clear();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    const string sql = @"SELECT
                        tanggal_panen,
                        komoditas,
                        berat_kotor,
                        berat_bersih,
                        kualitas,
                        catatan
                        FROM hasil_panen
                        WHERE id_petani = @id_petani
                        ORDER BY tanggal_panen DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", SessionHelper.IdUser);

                        using (var reader = cmd.ExecuteReader())
                        {
                            decimal totalBeratBersih = 0m;
                            int totalEntri = 0;

                            while (reader.Read())
                            {
                                var tanggal = reader.IsDBNull(0) ? "-" : reader.GetDateTime(0).ToString("yyyy-MM-dd");
                                var komoditas = reader.IsDBNull(1) ? "-" : reader.GetString(1);
                                var beratKotor = reader.IsDBNull(2) ? 0m : reader.GetDecimal(2);
                                var beratBersih = reader.IsDBNull(3) ? 0m : reader.GetDecimal(3);
                                var kualitas = reader.IsDBNull(4) ? "-" : reader.GetString(4);
                                var catatan = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);

                                DGV_InputHasilPanen8.Rows.Add(tanggal, komoditas, beratKotor.ToString("F2"), beratBersih.ToString("F2"), kualitas, catatan);

                                totalBeratBersih += beratBersih;
                                totalEntri++;
                            }

                            A_StokSaatIni.Text = totalEntri.ToString();
                            label2.Text = totalBeratBersih.ToString("F2") + " kg";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat hasil panen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKelolaHasilPanen_1_Click(object sender, EventArgs e)
        {
            KelolaDataHasilPanen frm = new KelolaDataHasilPanen();
            frm.Show();
            this.Hide();
        }

        private void btInputBaru8_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new BCInputHasilPanen())
                {
                    form.ShowDialog();
                }

                LoadHasilPanen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // PERBAIKAN: Duplikasi metode DGV_InputHasilPanen8_CellContentClick dihapus & disatukan ke sini
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

                MessageBox.Show($"Tanggal: {tanggal}\nKomoditas: {komoditas}\nBerat Kotor: {beratKotor} kg\nBerat Bersih: {beratBersih} kg\nKualitas: {kualitas}\nCatatan: {catatan}", "Detail Entri",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan detail: " + ex.Message, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        // PERBAIKAN: Duplikasi metode btDashboard_8_Click dihapus & disatukan ke sini
        private void btDashboard_8_Click(object sender, EventArgs e)
        {
            // Buka form input baru
            btInputBaru8_Click(sender, e);
        }

        // PERBAIKAN: Duplikasi metode btLogout_8_Click dihapus & disatukan ke sini
        private void btLogout_8_Click(object sender, EventArgs e)
        {
            using (KonfirmasiLogout frm = new KonfirmasiLogout())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    SessionHelper.ClearSession();
                    var login = new LoginSIMIHAN();
                    login.Show();
                    this.Hide();
                }
            }
        }

        // Designer wires btLogout_8.Click to this method; forward to primary logout logic.
        private void btLogout_8_Click_1(object sender, EventArgs e)
        {
            btLogout_8_Click(sender, e);
        }

        // Metode kosong opsional (referensi parameter agar analyzer tidak memunculkan peringatan)
        private void J_InputHasilPanenPetani8_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void A_StokSaatIni_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void label2_Click(object sender, EventArgs e) { _ = sender; _ = e; }
        private void label5_Click(object sender, EventArgs e) { _ = sender; _ = e; }

    }
}
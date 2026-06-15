using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class KelolaStokKeluar : Form
    {
        public KelolaStokKeluar()
        {
            InitializeComponent();


            DGV_KelolaStokKeluar5.AutoGenerateColumns = true;

            LoadDataStokKeluar();
        }

        private void LoadDataStokKeluar()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sk.id_stokkeluar,
                    g.nama_gudang,
                    sk.jumlah,
                    sk.tanggal,
                    sk.tujuan,
                    sk.keterangan
                FROM ""Stok_Keluar"" sk
                JOIN ""Gudang"" g
                    ON sk.id_gudang = g.id_gudang
                ORDER BY sk.id_stokkeluar";

                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        DGV_KelolaStokKeluar5.Columns.Clear();
                        DGV_KelolaStokKeluar5.AutoGenerateColumns = true;
                        DGV_KelolaStokKeluar5.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data:\n" + ex.Message);
            }
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

        private void J_KelolaStokKeluar5_Click(object sender, EventArgs e)
        {

        }

        private void btTambah5_Click(object sender, EventArgs e)
        {
            using (InputStokKeluar5 frm = new InputStokKeluar5())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataStokKeluar();
                }
            }
        }

        private void btHapus5_Click(object sender, EventArgs e)
        {
            if (DGV_KelolaStokKeluar5.CurrentRow == null)
            {
                MessageBox.Show(
                    "Pilih data yang akan dihapus!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.No)
                return;

            try
            {
                int idStokKeluar = Convert.ToInt32(
                    DGV_KelolaStokKeluar5.CurrentRow.Cells["id_stokkeluar"].Value);

                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                DELETE FROM ""Stok_Keluar""
                WHERE id_stokkeluar = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idStokKeluar);

                        int hasil = cmd.ExecuteNonQuery();

                        if (hasil > 0)
                        {
                            MessageBox.Show(
                                "Data berhasil dihapus!",
                                "Sukses",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadDataStokKeluar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DGV_KelolaStokKeluar5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class MonitoringStok : Form
    {
        public MonitoringStok()
        {
            InitializeComponent();
            Load += MonitoringStok_Load;
        }


        private void MonitoringStok_Load(object sender, EventArgs e)
        {
            LoadRiwayatStok();
            LoadMasukTerakhir();
            LoadKeluarTerakhir();
        }

        private void LoadRiwayatStok()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    g.nama_gudang AS ""Nama Gudang"",
                    g.lokasi AS ""Lokasi"",
                    COALESCE(
                        (SELECT SUM(sm.jumlah)
                         FROM ""Stok_Masuk"" sm
                         WHERE sm.id_gudang = g.id_gudang),0)
                    -
                    COALESCE(
                        (SELECT SUM(sk.jumlah)
                         FROM ""Stok_Keluar"" sk
                         WHERE sk.id_gudang = g.id_gudang),0)
                    AS ""Stok (kg)"",
                    g.kapasitas_maksimal AS ""Kapasitas (kg)"",
                    CASE
                        WHEN (
                            COALESCE(
                                (SELECT SUM(sm.jumlah)
                                 FROM ""Stok_Masuk"" sm
                                 WHERE sm.id_gudang = g.id_gudang),0)
                            -
                            COALESCE(
                                (SELECT SUM(sk.jumlah)
                                 FROM ""Stok_Keluar"" sk
                                 WHERE sk.id_gudang = g.id_gudang),0)
                        ) >= g.kapasitas_maksimal
                        THEN 'Penuh'
                        ELSE 'Tersedia'
                    END AS ""Status"",
                    ROUND(
                        (
                            (
                                COALESCE(
                                    (SELECT SUM(sm.jumlah)
                                     FROM ""Stok_Masuk"" sm
                                     WHERE sm.id_gudang = g.id_gudang),0)
                                -
                                COALESCE(
                                    (SELECT SUM(sk.jumlah)
                                     FROM ""Stok_Keluar"" sk
                                     WHERE sk.id_gudang = g.id_gudang),0)
                            )
                            / g.kapasitas_maksimal
                        ) * 100,2
                    ) || '%' AS ""Terisi""
                FROM ""Gudang"" g
                ORDER BY g.id_gudang";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV_RiwayatStok.DataSource = dt;
                    DGV_RiwayatStok.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data riwayat stok!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadMasukTerakhir()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sm.tanggal AS ""Tanggal"",
                    g.nama_gudang AS ""Gudang""
                FROM ""Stok_Masuk"" sm
                JOIN ""Gudang"" g
                    ON sm.id_gudang = g.id_gudang
                ORDER BY sm.tanggal DESC
                LIMIT 10";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV_MasukTerakhir.DataSource = dt;
                    DGV_MasukTerakhir.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data stok masuk!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadKeluarTerakhir()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    tanggal AS ""Tanggal"",
                    keterangan AS ""Keterangan""
                FROM ""Stok_Keluar""
                ORDER BY tanggal DESC
                LIMIT 10";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV_KeluarTerakhir6.DataSource = dt;
                    DGV_KeluarTerakhir6.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data stok keluar!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btDashboard_6_Click(object sender, EventArgs e)
        {
            DashboardAdmin form = new DashboardAdmin();
            form.Show();
            this.Hide();
        }

        private void btKelolaGudang_6_Click(object sender, EventArgs e)
        {
            KelolaGudang form = new KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_6_Click(object sender, EventArgs e)
        {
            KelolaStokMasuk form = new KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_6_Click(object sender, EventArgs e)
        {
            KelolaStokKeluar form = new KelolaStokKeluar();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok_6_Click(object sender, EventArgs e)
        {
        }

        private void btLaporanInventori_6_Click(object sender, EventArgs e)
        {
            LaporanInventori form = new LaporanInventori();
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

        private void DGV_RiwayatMutasiStok_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void J_MonitoringStok6_Click(object sender, EventArgs e)
        {

        }
    }


}
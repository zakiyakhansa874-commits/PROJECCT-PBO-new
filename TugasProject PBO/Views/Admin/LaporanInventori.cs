using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class LaporanInventori : Form
    {
        public LaporanInventori()
        {
            InitializeComponent();
            Load += LaporanInventori_Load;
        }

        private void LaporanInventori_Load(object sender, EventArgs e)
        {
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
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    hp.tanggal_panen AS ""Tanggal"",
                    u.nama AS ""Petani"",
                    hp.komoditas AS ""Komoditas"",
                    hp.berat_bersih AS ""Berat Bersih (kg)"",
                    hp.kualitas AS ""Kualitas""
                FROM hasil_panen hp
                JOIN ""Petani"" p ON hp.id_petani = p.id_petani
                JOIN ""User"" u ON p.id_user = u.id_user
                WHERE hp.tanggal_panen BETWEEN @dari AND @sampai
                ORDER BY hp.tanggal_panen DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dari", dtpDari7.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@sampai", dtpSampai7.Value.Date);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV_RHP7.Columns.Clear();
                    DGV_RHP7.DataSource = dt;
                    DGV_RHP7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStokMasuk()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sm.tanggal AS ""Tanggal"",
                    g.nama_gudang AS ""Gudang"",
                    u.nama AS ""Petani"",
                    sm.jumlah AS ""Jumlah (kg)"",
                    sm.kualitas AS ""Kualitas""
                FROM ""Stok_Masuk"" sm
                JOIN ""Gudang"" g ON sm.id_gudang = g.id_gudang
                JOIN ""Petani"" p ON sm.id_petani = p.id_petani
                JOIN ""User"" u ON p.id_user = u.id_user
                WHERE sm.tanggal BETWEEN @dari AND @sampai
                ORDER BY sm.tanggal DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dari", dtpDari7.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@sampai", dtpSampai7.Value.Date);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV_RSM7.Columns.Clear();
                    DGV_RSM7.DataSource = dt;
                    DGV_RSM7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStokKeluar()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sk.tanggal AS ""Tanggal"",
                    g.nama_gudang AS ""Gudang"",
                    sk.keterangan AS ""Keterangan"",
                    sk.jumlah AS ""Jumlah (kg)""
                FROM ""Stok_Keluar"" sk
                JOIN ""Gudang"" g ON sk.id_gudang = g.id_gudang
                WHERE sk.tanggal BETWEEN @dari AND @sampai
                ORDER BY sk.tanggal DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dari", dtpDari7.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@sampai", dtpSampai7.Value.Date);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGV_RHK7.Columns.Clear();
                    DGV_RHK7.DataSource = dt;
                    DGV_RHK7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BC_MenuBar7_Paint(object sender, PaintEventArgs e) { }

        private void btDashboard_7_Click(object sender, EventArgs e)
        {
            DashboardAdmin form = new DashboardAdmin();
            form.Show();
            this.Hide();
        }

        private void btKelolaGudang_7_Click(object sender, EventArgs e)
        {
            KelolaGudang form = new KelolaGudang();
            form.Show();
            this.Hide();
        }

        private void btStokMasuk_7_Click(object sender, EventArgs e)
        {
            KelolaStokMasuk form = new KelolaStokMasuk();
            form.Show();
            this.Hide();
        }

        private void btStokKeluar_7_Click(object sender, EventArgs e)
        {
            KelolaStokKeluar form = new KelolaStokKeluar();
            form.Show();
            this.Hide();
        }

        private void btMonitoringStok_7_Click(object sender, EventArgs e)
        {
            MonitoringStok form = new MonitoringStok();
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
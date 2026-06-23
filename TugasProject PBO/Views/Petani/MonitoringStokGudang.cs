
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Views.Admin;

namespace TugasProject_PBO.Views.Petani
{
    public partial class MonitoringStokGudang : Form
    {
        private MonitoringController _controller = new MonitoringController();

        public MonitoringStokGudang()
        {
            InitializeComponent();
            this.Load += MonitoringStokGudang_Load;
        }

      
        private void MonitoringStokGudang_Load(object sender, EventArgs e)
        {

            try
            {
                // Tampilkan info session
                if (!string.IsNullOrEmpty(SessionHelper.Nama))
                {
                    L_Username9.Text = SessionHelper.Nama;
                    L_Petani9.Text = SessionHelper.Role ?? "Petani";
                }

                LoadStatusGudang();
                LoadRingkasan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadStatusGudang()
        {
            try
            {
                DataTable dt = _controller.GetStatusGudang();

                ProgressBar[] bars = {
                PB_MonitoringStok9,
                PB_MonitoringStok2_9,
                progressBar3_9
                };

                Label[] labelInfo = {
                A_BawahBlokA9,
                label4,
                label1
                };

                for (int i = 0; i < dt.Rows.Count && i < bars.Length; i++)
                {
                    DataRow row = dt.Rows[i];

                    int kapasitas = Convert.ToInt32(row["kapasitas_maksimal"]);
                    int stok = Convert.ToInt32(row["stok_saat_ini"]);
                    int persen = kapasitas > 0
                        ? (int)Math.Round(stok * 100.0 / kapasitas)
                        : 0;
                    persen = Math.Min(persen, 100);

                    labelInfo[i].Text = $"{stok}/{kapasitas} kg ({persen}%)";
                    bars[i].Maximum = 100;
                    bars[i].Value = persen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat status gudang: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRingkasan()
        {
            try
            {
                var (jumlahGudang, totalStok, totalKapasitas) = _controller.GetRingkasanGudang();

                A_JumlahGudang9.Text = jumlahGudang.ToString();
                A_TotalStok9.Text = totalStok.ToString("F0");
                A_TotalKapasitas9.Text = totalKapasitas.ToString("F0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BC_MenuBar_Paint(object sender, PaintEventArgs e) { }
        private void G_KelolaDataHasilPanen_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void J_DashboardAdmin_Click(object sender, EventArgs e) { }
        private void L_Role9_Click(object sender, EventArgs e) { }

        private void btDashboard_9_Click(object sender, EventArgs e)
        {
            V_DataHasilPanenPetani frm = new V_DataHasilPanenPetani();
            frm.Show();
            this.Hide();
        }

        private void btKelolaHasilPanen_9_Click(object sender, EventArgs e)
        {
            KonfirmasiLogout frm = new KonfirmasiLogout();
            frm.Show();
            this.Hide();
        }
        private void btLogout_9_Click(object sender, EventArgs e)
        {
            using (KonfirmasiLogout frm = new KonfirmasiLogout())
            {
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    SessionHelper.ClearSession();

                    LoginSIMIHAN login = new LoginSIMIHAN();
                    login.Show();

                    this.Close();
                }
            }
        }

        private void MonitoringStokGudang_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogout_9_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hapus session login
                SessionHelper.ClearSession();

                // Tampilkan form login
                LoginSIMIHAN login = new LoginSIMIHAN();
                login.Show();

                // Tutup form saat ini
                this.Hide();
            }
        }

        private void P_JumlahGudang9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_JumlahGudang9_Click(object sender, EventArgs e)
        {

        }
    }
}
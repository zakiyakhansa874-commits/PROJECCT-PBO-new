using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace TugasProject_PBO.Views.Admin
{
    public partial class KelolaHasilPanen : Form
    {
        private string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=ProjectPBO_SIMIHAN;" +
            "Username=postgres;" +
            "Password=elmitra14";

        public KelolaHasilPanen()
        {
            InitializeComponent();
        }

        private void KelolaHasilPanen_Load(object sender, EventArgs e)
        {
            LoadPetani();
            LoadKomoditas();
            LoadKualitas();
        }

        private void LoadPetani()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT id_petani, nama_petani FROM petani";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbPetani.DataSource = dt;
                    cbPetani.DisplayMember = "nama_petani";
                    cbPetani.ValueMember = "id_petani";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadKomoditas()
        {
            cbKomoditas.Items.Clear();

            cbKomoditas.Items.Add("Padi");
            cbKomoditas.Items.Add("Jagung");
            cbKomoditas.Items.Add("Kedelai");
            cbKomoditas.Items.Add("Cabai");
        }

        private void LoadKualitas()
        {
            cbKualitas.Items.Clear();

            cbKualitas.Items.Add("A");
            cbKualitas.Items.Add("B");
            cbKualitas.Items.Add("C");
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPetani.Text == "" ||
                    cbKomoditas.Text == "" ||
                    txtBeratKotor.Text == "" ||
                    txtBeratBersih.Text == "")
                {
                    MessageBox.Show("Lengkapi data terlebih dahulu!");
                    return;
                }

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    INSERT INTO hasil_panen
                    (
                        id_petani,
                        tanggal_panen,
                        komoditas,
                        berat_kotor,
                        berat_bersih,
                        kualitas,
                        catatan
                    )
                    VALUES
                    (
                        @id_petani,
                        @tanggal,
                        @komoditas,
                        @berat_kotor,
                        @berat_bersih,
                        @kualitas,
                        @catatan
                    )";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani",
                            Convert.ToInt32(cbPetani.SelectedValue));

                        cmd.Parameters.AddWithValue("@tanggal",
                            dtpTanggal.Value.Date);

                        cmd.Parameters.AddWithValue("@komoditas",
                            cbKomoditas.Text);

                        cmd.Parameters.AddWithValue("@berat_kotor",
                            Convert.ToDecimal(txtBeratKotor.Text));

                        cmd.Parameters.AddWithValue("@berat_bersih",
                            Convert.ToDecimal(txtBeratBersih.Text));

                        cmd.Parameters.AddWithValue("@kualitas",
                            cbKualitas.Text);

                        cmd.Parameters.AddWithValue("@catatan",
                            txtCatatan.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data hasil panen berhasil disimpan.");

                    BersihkanForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data : " + ex.Message);
            }
        }

        private void BersihkanForm()
        {
            cbPetani.SelectedIndex = -1;
            cbKomoditas.SelectedIndex = -1;
            cbKualitas.SelectedIndex = -1;

            txtBeratKotor.Clear();
            txtBeratBersih.Clear();
            txtCatatan.Clear();

            dtpTanggal.Value = DateTime.Now;
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void txtCatatan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
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

        private int idHasilPanen = 0;

        public KelolaHasilPanen()
        {
            InitializeComponent();
        }

        private void KelolaHasilPanen_Load(object sender, EventArgs e)
        {
            LoadPetani();
            LoadKomoditas();
            LoadKualitas();

            dtpTanggal.Value = DateTime.Now;
        }

        #region LOAD DATA

        private void LoadPetani()
        {
            try
            {
                using (NpgsqlConnection conn =
                    new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "SELECT id_petani, nama_petani FROM petani ORDER BY nama_petani";

                    DataTable dt = new DataTable();

                    NpgsqlDataAdapter da =
                        new NpgsqlDataAdapter(sql, conn);

                    da.Fill(dt);

                    cbPetani.DataSource = dt;
                    cbPetani.DisplayMember = "nama_petani";
                    cbPetani.ValueMember = "id_petani";
                    cbPetani.SelectedIndex = -1;
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
            cbKomoditas.Items.Add("Bawang");
        }

        private void LoadKualitas()
        {
            cbKualitas.Items.Clear();

            cbKualitas.Items.Add("A");
            cbKualitas.Items.Add("B");
            cbKualitas.Items.Add("C");
        }

        #endregion

        #region VALIDASI

        private bool ValidasiInput()
        {
            if (cbPetani.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih petani terlebih dahulu.");
                cbPetani.Focus();
                return false;
            }

            if (cbKomoditas.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih komoditas.");
                cbKomoditas.Focus();
                return false;
            }

            decimal beratKotor;
            decimal beratBersih;

            if (!decimal.TryParse(txtBeratKotor.Text, out beratKotor))
            {
                MessageBox.Show("Berat kotor harus angka.");
                txtBeratKotor.Focus();
                return false;
            }

            if (!decimal.TryParse(txtBeratBersih.Text, out beratBersih))
            {
                MessageBox.Show("Berat bersih harus angka.");
                txtBeratBersih.Focus();
                return false;
            }

            if (cbKualitas.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih kualitas.");
                cbKualitas.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region SIMPAN

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;
            try
            {
                using (NpgsqlConnection conn =
                    new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query =
                    @"INSERT INTO hasil_panen
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
                        @tanggal_panen,
                        @komoditas,
                        @berat_kotor,
                        @berat_bersih,
                        @kualitas,
                        @catatan
                    )";

                    using (NpgsqlCommand cmd =
                        new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id_petani",
                            Convert.ToInt32(cbPetani.SelectedValue));

                        cmd.Parameters.AddWithValue(
                            "@tanggal_panen",
                            dtpTanggal.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@komoditas",
                            cbKomoditas.Text);

                        cmd.Parameters.AddWithValue(
                            "@berat_kotor",
                            Convert.ToDecimal(txtBeratKotor.Text));

                        cmd.Parameters.AddWithValue(
                            "@berat_bersih",
                            Convert.ToDecimal(txtBeratBersih.Text));

                        cmd.Parameters.AddWithValue(
                            "@kualitas",
                            cbKualitas.Text);

                        cmd.Parameters.AddWithValue(
                            "@catatan",
                            txtCatatan.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Data hasil panen berhasil disimpan.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    BersihkanForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data : " + ex.Message);
            }
        }

        #endregion

        #region UPDATE

        public void LoadDataEdit(
            int id,
            int idPetani,
            DateTime tanggal,
            string komoditas,
            decimal beratKotor,
            decimal beratBersih,
            string kualitas,
            string catatan)
        {
            idHasilPanen = id;

            cbPetani.SelectedValue = idPetani;
            dtpTanggal.Value = tanggal;
            cbKomoditas.Text = komoditas;
            txtBeratKotor.Text = beratKotor.ToString();
            txtBeratBersih.Text = beratBersih.ToString();
            cbKualitas.Text = kualitas;
            txtCatatan.Text = catatan;

            btSimpan.Text = "Update";
        }

        private void UpdateData()
        {
            try
            {
                using (NpgsqlConnection conn =
                    new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                    @"UPDATE hasil_panen
                    SET
                        id_petani=@id_petani,
                        tanggal_panen=@tanggal,
                        komoditas=@komoditas,
                        berat_kotor=@berat_kotor,
                        berat_bersih=@berat_bersih,
                        kualitas=@kualitas,
                        catatan=@catatan
                    WHERE id_hasil_panen=@id";

                    using (NpgsqlCommand cmd =
                        new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idHasilPanen);
                        cmd.Parameters.AddWithValue("@id_petani",
                            Convert.ToInt32(cbPetani.SelectedValue));
                        cmd.Parameters.AddWithValue("@tanggal",
                            dtpTanggal.Value);
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
                }

                MessageBox.Show("Data berhasil diupdate.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region RESET

        private void BersihkanForm()
        {
            cbPetani.SelectedIndex = -1;
            cbKomoditas.SelectedIndex = -1;
            cbKualitas.SelectedIndex = -1;

            txtBeratKotor.Clear();
            txtBeratBersih.Clear();
            txtCatatan.Clear();

            dtpTanggal.Value = DateTime.Now;

            idHasilPanen = 0;

            btSimpan.Text = "Simpan";
        }

        #endregion

        #region BUTTON BATAL

        private void btBatal_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Yakin ingin membatalkan?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BersihkanForm();
            }
        }

        #endregion

        #region VALIDASI ANGKA

        private void txtBeratKotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtBeratBersih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
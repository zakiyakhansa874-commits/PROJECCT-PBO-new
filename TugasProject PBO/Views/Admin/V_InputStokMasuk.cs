using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class InputStokMasuk4 : Form
    {
        private StokMasukController _controller = new StokMasukController();

        public InputStokMasuk4()
        {
            InitializeComponent();
            LoadGudang();
            LoadPetani();
            LoadKualitas();
        }

        private void LoadGudang()
        {
            try
            {
                DataTable dt = _controller.GetAllGudang();
                cbGudang4.DataSource = dt;
                cbGudang4.DisplayMember = "nama_gudang";
                cbGudang4.ValueMember = "id_gudang";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadPetani()
        {
            try
            {
                DataTable dt = _controller.GetAllPetani();
                cbPetani4.DataSource = dt;
                cbPetani4.DisplayMember = "nama";
                cbPetani4.ValueMember = "id_petani";
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat data petani:\n" + ex.Message); }
        }

        private void LoadKualitas()
        {
            cbKualitas4.Items.Clear();
            cbKualitas4.Items.Add("Premium");
            cbKualitas4.Items.Add("Standart");
            cbKualitas4.Items.Add("Rendah");
            cbKualitas4.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPetani4.Text) ||
                string.IsNullOrWhiteSpace(cbGudang4.Text) ||
                string.IsNullOrWhiteSpace(tbJumlah4.Text) ||
                string.IsNullOrWhiteSpace(dtpTanggal4.Text))
            {
                MessageBox.Show("Semua kolom data wajib diisi (kecuali catatan)!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idPetani = Convert.ToInt32(cbPetani4.SelectedValue);
                int idGudang = Convert.ToInt32(cbGudang4.SelectedValue);

                decimal jumlah;
                if (!decimal.TryParse(tbJumlah4.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out jumlah))
                {
                    if (!decimal.TryParse(tbJumlah4.Text.Trim(), out jumlah))
                    {
                        MessageBox.Show("Jumlah harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DateTime tanggal;
                if (!DateTime.TryParse(dtpTanggal4.Text.Trim(), out tanggal))
                {
                    MessageBox.Show("Format tanggal salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _controller.TambahStokMasuk(idPetani, idGudang, jumlah, tanggal, cbKualitas4.Text, tbCatatan4.Text);

                MessageBox.Show("Data stok masuk berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputStokMasuk_Load(object sender, EventArgs e) { }

        private void btBatal4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbTanggal4_TextChanged(object sender, EventArgs e) { }
        private void cbGudang4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbPetani4_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class InputStokKeluar5 : Form
    {
        private StokKeluarController _controller = new StokKeluarController();

        public InputStokKeluar5()
        {
            InitializeComponent();
            LoadGudang();
            LoadAdmin();
            LoadKualitas();
        }

        private void LoadGudang()
        {
            try
            {
                DataTable dt = _controller.GetAllGudang();
                cbGudang5.DataSource = dt;
                cbGudang5.DisplayMember = "nama_gudang";
                cbGudang5.ValueMember = "id_gudang";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadAdmin()
        {
            try
            {
                DataTable dt = _controller.GetAllAdmin();
                cbAdmin5.DataSource = dt;
                cbAdmin5.DisplayMember = "nama";
                cbAdmin5.ValueMember = "id_admin";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadKualitas()
        {
            cbKualitas5.Items.Clear();
            cbKualitas5.Items.Add("Premium");
            cbKualitas5.Items.Add("Standart");
            cbKualitas5.Items.Add("Rendah");
            cbKualitas5.SelectedIndex = 0;
        }

        private void L_Petani9_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }

        private void btSimpan5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbJumlah5.Text))
            {
                MessageBox.Show("Jumlah harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idGudang = Convert.ToInt32(cbGudang5.SelectedValue);

                decimal jumlah;
                if (!decimal.TryParse(tbJumlah5.Text, out jumlah))
                {
                    MessageBox.Show("Jumlah harus berupa angka!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _controller.TambahStokKeluar(
                    idGudang,
                    jumlah,
                    dtpTanggal5.Value.Date,
                    cbAdmin5.Text,
                    tbCatatan5.Text);

                MessageBox.Show("Data stok keluar berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputStokKeluar_Load(object sender, EventArgs e) { }
        private void LTanggal5_Click(object sender, EventArgs e) { }
        private void LGudang_Click(object sender, EventArgs e) { }
        private void cbAdmin5_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
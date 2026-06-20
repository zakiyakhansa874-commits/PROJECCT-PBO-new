using System;
using System.Data;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_InputHasilPanenPetani : Form
    {
        private HasilPanenController _controller = new HasilPanenController();
        private int idHasilPanen = 0;

        public V_InputHasilPanenPetani()
        {
            InitializeComponent();
        }

        private void KelolaHasilPanen_Load(object sender, EventArgs e)
        {
            LoadPetani();
            LoadKomoditas();
            LoadKualitas();
            dtpTanggal.Value = DateTime.Now;

            if (idHasilPanen == 0)
            {
                this.Text = "Tambah Hasil Panen";
                btSimpan.Text = "Simpan";
            }
        }

        private void LoadPetani()
        {
            try
            {
                DataTable dt = _controller.GetAllPetani();
                cbPetani.DataSource = dt;
                cbPetani.DisplayMember = "nama";
                cbPetani.ValueMember = "id_petani";
                cbPetani.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void LoadDataEdit(int id, int idPetani, DateTime tanggal, string komoditas,
        decimal beratKotor, decimal beratBersih, string kualitas, string catatan)
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
            this.Text = "Edit Hasil Panen"; 
        }
        
        private void LoadKomoditas()
        {
            cbKomoditas.Items.Clear();
            cbKomoditas.Items.Add("Teh Hijau");
            cbKomoditas.Items.Add("Teh Hitam");
            cbKomoditas.Items.Add("Teh Oolong");
            cbKomoditas.Items.Add("Teh Putih");
        }

        private void LoadKualitas()
        {
            cbKualitas.Items.Clear();
            cbKualitas.Items.Add("Premium");
            cbKualitas.Items.Add("Standart");
            cbKualitas.Items.Add("Rendah");
        }

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
            if (!decimal.TryParse(txtBeratKotor.Text, out _))
            {
                MessageBox.Show("Berat kotor harus angka.");
                txtBeratKotor.Focus();
                return false;
            }
            if (!decimal.TryParse(txtBeratBersih.Text, out _))
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

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            try
            {
                if (idHasilPanen == 0)
                {
                    // Tambah Data
                    _controller.TambahHasilPanen(
                        Convert.ToInt32(cbPetani.SelectedValue),
                        dtpTanggal.Value.Date,
                        cbKomoditas.Text,
                        Convert.ToDecimal(txtBeratKotor.Text),
                        Convert.ToDecimal(txtBeratBersih.Text),
                        cbKualitas.Text,
                        txtCatatan.Text);

                    MessageBox.Show("Data hasil panen berhasil disimpan.");
                }
                else
                {
                    // Update Data
                    UpdateData();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                _controller.UpdateHasilPanen(
                    idHasilPanen,
                    Convert.ToInt32(cbPetani.SelectedValue),
                    dtpTanggal.Value,
                    cbKomoditas.Text,
                    Convert.ToDecimal(txtBeratKotor.Text),
                    Convert.ToDecimal(txtBeratBersih.Text),
                    cbKualitas.Text,
                    txtCatatan.Text);

                MessageBox.Show("Data berhasil diupdate.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            idHasilPanen = 0;
            btSimpan.Text = "Simpan";
        }

        private void btBatal_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin membatalkan?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BersihkanForm();
            }
        }

        private void txtBeratKotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtBeratBersih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void LPetani_Click(object sender, EventArgs e)
        {

        }

        private void txtBeratKotor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
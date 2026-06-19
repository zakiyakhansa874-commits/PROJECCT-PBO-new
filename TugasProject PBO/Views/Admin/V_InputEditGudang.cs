using System;
using System.Windows.Forms;
using System.Drawing;
using TugasProject_PBO.Controllers;

namespace TugasProject_PBO.Views.Admin
{
    public partial class V_InputEditGudang : Form
    {
        private GudangController _controller = new GudangController();

        public V_InputEditGudang()
        {
            InitializeComponent();
        }

        private void KelolaGudang_Load(object sender, EventArgs e)
        {
            txtNamaGudang.Text = "Gudang A";
            txtLokasi.Text = "Jl. Raya Sumbersari No. 12";
            txtKapasitas.Text = "5000";
            txtStokSaatIni.Text = "1200";

            lblStatus.Text = "Form Edit Gudang siap digunakan.";
            lblStatus.ForeColor = Color.Blue;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaGudang.Text) ||
                    string.IsNullOrWhiteSpace(txtLokasi.Text) ||
                    string.IsNullOrWhiteSpace(txtKapasitas.Text))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _controller.TambahGudang(
                    txtNamaGudang.Text,
                    txtLokasi.Text,
                    Convert.ToDecimal(txtKapasitas.Text));

                MessageBox.Show("Data gudang berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            BersihkanForm();
        }

        private void BersihkanForm()
        {
            txtNamaGudang.Clear();
            txtLokasi.Clear();
            txtKapasitas.Clear();
            txtStokSaatIni.Clear();
            txtNamaGudang.Focus();
        }

        private void LNamaGudang_Click(object sender, EventArgs e)
        {
            string namaGudang = txtNamaGudang.Text;
            if (string.IsNullOrWhiteSpace(namaGudang))
                MessageBox.Show("Nama Gudang belum diisi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"Nama Gudang: {namaGudang}", "Informasi Gudang", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNamaGudang_TextChanged(object sender, EventArgs e)
        {
            string namaGudang = txtNamaGudang.Text;
            if (string.IsNullOrWhiteSpace(namaGudang))
            {
                lblStatus.Text = "Nama Gudang tidak boleh kosong.";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = $"Nama Gudang: {namaGudang}";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void LLokasi_Click(object sender, EventArgs e)
        {
            string lokasi = txtLokasi.Text;
            if (string.IsNullOrWhiteSpace(lokasi))
                MessageBox.Show("Lokasi belum diisi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"Lokasi: {lokasi}", "Informasi Gudang", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtLokasi_TextChanged(object sender, EventArgs e)
        {
            string lokasi = txtLokasi.Text;
            if (string.IsNullOrWhiteSpace(lokasi))
            {
                lblStatus.Text = "Lokasi gudang tidak boleh kosong.";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = $"Lokasi Gudang: {lokasi}";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void LKapasitas_Click(object sender, EventArgs e)
        {
            string kapasitas = txtKapasitas.Text;
            if (string.IsNullOrWhiteSpace(kapasitas))
                MessageBox.Show("Kapasitas belum diisi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (decimal.TryParse(kapasitas, out var value))
                MessageBox.Show($"Kapasitas Maksimal: {value} kg", "Informasi Kapasitas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kapasitas harus berupa angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtKapasitas_TextChanged(object sender, EventArgs e)
        {
            string kapasitas = txtKapasitas.Text;
            if (string.IsNullOrWhiteSpace(kapasitas))
            {
                lblStatus.Text = "Kapasitas tidak boleh kosong.";
                lblStatus.ForeColor = Color.Red;
            }
            else if (!decimal.TryParse(kapasitas, out var value))
            {
                lblStatus.Text = "Kapasitas harus berupa angka.";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = $"Kapasitas Maksimal: {value} kg";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void LStokSaatIni_Click(object sender, EventArgs e)
        {
            string stok = txtStokSaatIni.Text;
            if (string.IsNullOrWhiteSpace(stok))
                MessageBox.Show("Stok belum diisi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (decimal.TryParse(stok, out var value))
                MessageBox.Show($"Stok Saat Ini: {value} kg", "Informasi Stok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Stok harus berupa angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtStokSaatIni_TextChanged(object sender, EventArgs e)
        {
            string stok = txtStokSaatIni.Text;
            if (string.IsNullOrWhiteSpace(stok))
            {
                lblStatus.Text = "Stok tidak boleh kosong.";
                lblStatus.ForeColor = Color.Red;
            }
            else if (!decimal.TryParse(stok, out var value))
            {
                lblStatus.Text = "Stok harus berupa angka.";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = $"Stok Saat Ini: {value} kg";
                lblStatus.ForeColor = Color.Green;
            }
        }
    }
}
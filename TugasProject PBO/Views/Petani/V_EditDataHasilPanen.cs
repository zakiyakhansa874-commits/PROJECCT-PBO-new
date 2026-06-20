using System;
using System.Drawing;
using System.Windows.Forms;
using TugasProject_PBO.Controllers;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Views.Petani
{
    public partial class BCInputHasilPanen : Form
    {
        private HasilPanenController _controller = new HasilPanenController();

        public BCInputHasilPanen()
        {
            InitializeComponent();
        }

        private void InputDataHasilPanen_Load(object sender, EventArgs e)
        {
            LNamaPetani.Text = SessionHelper.Nama;
            dtpTanggalPanen.Value = DateTime.Now;

            if (cbKomoditas.Items.Count == 0)
                cbKomoditas.Items.AddRange(new object[] { "Teh Hijau", "Teh Hitam", "Teh Oolong", "Teh Putih" });

            if (cbKualitas.Items.Count == 0)
                cbKualitas.Items.AddRange(new object[] { "Premium", "Standart", "Rendah" });

            if (cbKomoditas.Items.Count > 0 && string.IsNullOrEmpty(cbKomoditas.Text))
                cbKomoditas.SelectedIndex = 0;
            if (cbKualitas.Items.Count > 0 && cbKualitas.SelectedIndex < 0)
                cbKualitas.SelectedIndex = 0;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            int idPetani = _controller.GetIdPetaniByUserId(SessionHelper.IdUser);

            if (idPetani == 0)
            {
                MessageBox.Show("Data petani tidak ditemukan untuk user ini!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btBatal_Click(object sender, EventArgs e) 
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LBeratKotor_TextChanged(object sender, EventArgs e) { }

        private void LPetani_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Petani: {LPetani.Text}", "Petani", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LNamaPetani_Click(object sender, EventArgs e) 
        {
            LNamaPetani.Text = SessionHelper.Nama;
        }

        private void LTanggalPanen_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tanggal Panen: {dtpTanggalPanen.Value:dd/MM/yyyy}", "Tanggal Panen",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpTanggalPanen_ValueChanged(object sender, EventArgs e)
        {
            try { LTanggalPanen.Text = $"Tanggal Panen: {dtpTanggalPanen.Value:dd/MM/yyyy}"; }
            catch { }
        }

        private void Lkomoditas_Click(object sender, EventArgs e) { cbKomoditas.Focus(); }

        private void cbKomoditas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBeratKotor != null) txtBeratKotor.Clear();
            if (txtBeratBersih != null) txtBeratBersih.Clear();
            if (txtBeratKotor != null) txtBeratKotor.Focus();
        }

        private void LBeratKotor_Click(object sender, EventArgs e) { if (txtBeratKotor != null) txtBeratKotor.Focus(); }

        private void txtBeratKotor_TextChanged(object sender, EventArgs e)
        {
            if (txtBeratKotor == null || txtBeratBersih == null) return;
            string raw = txtBeratKotor.Text.Trim();
            if (double.TryParse(raw, out double beratKotor) && beratKotor >= 0)
            {
                txtBeratBersih.Text = (beratKotor * 0.95).ToString("F2");
                txtBeratBersih.ForeColor = Color.Black;
            }
            else
            {
                txtBeratBersih.Text = string.Empty;
                txtBeratBersih.ForeColor = string.IsNullOrEmpty(raw) ? Color.Gray : Color.Red;
            }
        }

        private void LBeratBersih_Click(object sender, EventArgs e) { if (txtBeratBersih != null) txtBeratBersih.Focus(); }
        private void txtBeratBersih_TextChanged(object sender, EventArgs e) { }
        private void LKualitas_Click(object sender, EventArgs e) { if (cbKualitas != null) cbKualitas.Focus(); }
        private void cbKualitas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LCatatan_Click(object sender, EventArgs e) { if (txtCatatan != null) txtCatatan.Focus(); }
        private void txtCatatan_TextChanged(object sender, EventArgs e) { }
    }
}
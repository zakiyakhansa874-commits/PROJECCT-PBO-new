using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO.Views.Petani
{
    public partial class BCInputHasilPanen : Form
    {
        public BCInputHasilPanen()
        {
            InitializeComponent();
            // InitializeComponent already wires the Load event in designer; avoid double subscription
        }

        private void InputDataHasilPanen_Load(object sender, EventArgs e)
        {
            // Set default Petani dan Tanggal Panen
            LNamaPetani.Text = "Pak Hendra";
            dtpTanggalPanen.Value = DateTime.Now;
            // Populate komoditas and kualitas options
            if (cbKomoditas.Items.Count == 0)
            {
                cbKomoditas.Items.AddRange(new object[] { "Jagung", "Padi", "Kedelai", "Kacang Tanah", "Kacang Hijau" });
            }

            if (cbKualitas.Items.Count == 0)
            {
                cbKualitas.Items.AddRange(new object[] { "A", "B", "C" });
            }

            // Select first items by default (if present)
            if (cbKomoditas.Items.Count > 0 && string.IsNullOrEmpty(cbKomoditas.Text)) cbKomoditas.SelectedIndex = 0;
            if (cbKualitas.Items.Count > 0 && cbKualitas.SelectedIndex < 0) cbKualitas.SelectedIndex = 0;
        }

        private void LBeratKotor_TextChanged(object sender, EventArgs e)
        {
            // kept for compatibility; actual weight change handled in txtBeratKotor_TextChanged
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            // Ambil data dari form
            string petani = LPetani.Text;
            DateTime tanggal = dtpTanggalPanen.Value;
            string komoditas = cbKomoditas.Text;
            string kualitas = cbKualitas.SelectedItem?.ToString() ?? "";
            string catatan = txtCatatan.Text;

            string pesan = $"Data Panen:\n" +
                           $"- Petani: {petani}\n" +
                           $"- Tanggal: {tanggal:dd/MM/yyyy}\n" +
                           $"- Komoditas: {komoditas}\n" +
                           $"- Berat Kotor: {txtBeratKotor.Text} kg\n" +
                           $"- Berat Bersih: {txtBeratBersih.Text} kg\n" +
                           $"- Kualitas: {kualitas}\n" +
                           $"- Catatan: {catatan}";

            MessageBox.Show(pesan, "Data Disimpan", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);

            // Tambahkan logika simpan ke database di sini
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LPetani_Click(object sender, EventArgs e)
        {
            // Show the current farmer name when label is clicked
            MessageBox.Show($"Petani: {LPetani.Text}", "Petani", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void LNamaPetani_Click(object sender, EventArgs e)
        {
            // Mirror click behavior of the main petani label
            LPetani_Click(sender, e);
        }

        private void LTanggalPanen_Click(object sender, EventArgs e)
        {
            // Show the selected harvest date
            MessageBox.Show($"Tanggal Panen: {dtpTanggalPanen.Value:dd/MM/yyyy}", "Tanggal Panen", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void dtpTanggalPanen_ValueChanged(object sender, EventArgs e)
        {
            // Update a display string to keep the UI informative
            try
            {
                LTanggalPanen.Text = $"Tanggal Panen: {dtpTanggalPanen.Value:dd/MM/yyyy}";
            }
            catch
            {
                // Ignore if label not available at runtime
            }
        }

        private void Lkomoditas_Click(object sender, EventArgs e)
        {
            // Set focus to komoditas selection
            cbKomoditas.Focus();
        }

        private void cbKomoditas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When komoditas changes, reset weights and focus input
            if (txtBeratKotor != null) txtBeratKotor.Clear();
            if (txtBeratBersih != null) txtBeratBersih.Clear();
            if (txtBeratKotor != null) txtBeratKotor.Focus();
        }

        private void LBeratKotor_Click(object sender, EventArgs e)
        {
            if (txtBeratKotor != null) txtBeratKotor.Focus();
        }

        private void txtBeratKotor_TextChanged(object sender, EventArgs e)
        {
            // Calculate berat bersih automatically (example: minus 5% losses)
            if (txtBeratKotor == null || txtBeratBersih == null) return;

            string raw = txtBeratKotor.Text.Trim();
            if (double.TryParse(raw, out double beratKotor) && beratKotor >= 0)
            {
                double beratBersih = beratKotor * 0.95; // 5% deduction
                txtBeratBersih.Text = beratBersih.ToString("F2");
                txtBeratBersih.ForeColor = Color.Black;
            }
            else
            {
                txtBeratBersih.Text = string.Empty;
                if (!string.IsNullOrEmpty(raw))
                    txtBeratBersih.ForeColor = Color.Red;
                else
                    txtBeratBersih.ForeColor = Color.Gray;
            }
        }

        private void LBeratBersih_Click(object sender, EventArgs e)
        {
            if (txtBeratBersih != null) txtBeratBersih.Focus();
        }

        private void txtBeratBersih_TextChanged(object sender, EventArgs e)
        {
            // No extra handling required; this field is readonly/updated from berat kotor
        }

        private void LKualitas_Click(object sender, EventArgs e)
        {
            if (cbKualitas != null) cbKualitas.Focus();
        }

        private void cbKualitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optionally react to quality changes; currently no-op
        }

        private void LCatatan_Click(object sender, EventArgs e)
        {
            if (txtCatatan != null) txtCatatan.Focus();
        }

        private void txtCatatan_TextChanged(object sender, EventArgs e)
        {
            // Could implement character count or validation here
        }
    }
}

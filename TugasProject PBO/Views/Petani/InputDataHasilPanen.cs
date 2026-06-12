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
            this.Load += InputDataHasilPanen_Load;
        }

        private void InputDataHasilPanen_Load(object sender, EventArgs e)
        {
            // Set default Petani dan Tanggal Panen
            LPetani.Text = "Pak Hendra";
            dtpTanggalPanen.Value = DateTime.Now;
        }

        private void LBeratKotor_TextChanged(object sender, EventArgs e)
        {
            // Hitung otomatis Berat Bersih (misalnya dikurangi 5% dari berat kotor)
            if (double.TryParse(LBeratKotor.Text, out double beratKotor))
            {
                double beratBersih = beratKotor * 0.95;
                LBeratBersih.Text = beratBersih.ToString("F2");
            }
            else
            {
                LBeratBersih.Text = "";
            }
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

            MessageBox.Show(pesan, "Data Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Tambahkan logika simpan ke database di sini
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

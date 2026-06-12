using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasProject_PBO
{
    public partial class FormKonfirmasiKeluar : Form
    {
        public FormKonfirmasiKeluar()
        {
            InitializeComponent();
            this.Load += FormKonfirmasiKeluar_Load;
        }

        private void FormKonfirmasiKeluar_Load(object sender, EventArgs e)
        {
            // Set teks konfirmasi sesuai kebutuhan
            btKeluar.Text = "Yakin ingin keluar?\n" +
                                 "Anda akan keluar dari sesi sebagai Pak Hendra.\n" +
                                 "Semua perubahan yang belum tersimpan akan hilang.";
        }

        private void btKeluar_Click(object sender, EventArgs e)
        {
            // Jika user menekan "Ya, Keluar"
            DialogResult result = MessageBox.Show(
                "Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Tutup seluruh aplikasi
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            // Jika user menekan "Batal", cukup tutup form konfirmasi
            this.Close();
        }

        // Label klik opsional
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini adalah form konfirmasi keluar.");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Pastikan semua data sudah tersimpan sebelum keluar.");
        }
    }
}

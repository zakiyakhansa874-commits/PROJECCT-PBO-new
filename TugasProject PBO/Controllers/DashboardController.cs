using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Controllers
{
    internal class DashboardController
    {
            // Menyimpan referensi ke form Dashboard (View) jika dibutuhkan
            // private DashboardForm _view;

        public DashboardController()
        {
                // Constructor kosong atau inisialisasi awal
        }

            /// <summary>
            /// Mengambil total atau ringkasan data untuk ditampilkan di Dashboard
            /// </summary>
        public int GetTotalStokMasuk()
        {
                // Contoh logika untuk mengambil data (nanti dihubungkan ke Database)
             int totalStok = 0;
             return totalStok;
        }

        public int GetTotalHasilPanen()
        {
                // Contoh fungsi ringkasan data lainnya
             int totalPanen = 0;
             return totalPanen;
        }

            /// <summary>
            /// Logika untuk menangani fungsi logout dari dashboard
            /// </summary>
        public void Logout()
        {
                // Contoh logika logout: tutup form dashboard, buka kembali form login
                // FormLogin login = new FormLogin();
                // login.Show();
        }
    }
 }
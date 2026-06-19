using System;
using System.Data;
using Npgsql;
using TugasProject_PBO.Helpers;
using TugasProject_PBO.Models;

namespace TugasProject_PBO.Controllers
{
    public class DashboardController
    {
        public RingkasanDashboard GetRingkasan()
        {
            RingkasanDashboard ringkasan = new RingkasanDashboard()
            {
                TotalGudang = "Total Gudang: ",
                Username =  SessionHelper.Nama,
                Role = SessionHelper.Role,
                StokSaatIni = "Stok Saat Ini: ",
                TotalHasilPanen = "Total Hasil Panen: ",
                KapasitasGudang = "Gudang Utama A – 3200/5000 kg (64%)"
                
            };

            try
            {
                DataTable dtGudang = GetDataGudang();

                if (dtGudang != null && dtGudang.Rows.Count > 0)
                {
                    ringkasan.GudangAMax = Convert.ToInt32(dtGudang.Rows[0]["kapasitas_maksimal"]);
                    ringkasan.GudangAValue = Convert.ToInt32(dtGudang.Rows[0]["stok_saat_ini"]);
                }

                if (dtGudang != null && dtGudang.Rows.Count > 1)
                {
                    ringkasan.GudangBMax = Convert.ToInt32(dtGudang.Rows[1]["kapasitas_maksimal"]);
                    ringkasan.GudangBValue = Convert.ToInt32(dtGudang.Rows[1]["stok_saat_ini"]);
                }

                if (dtGudang != null && dtGudang.Rows.Count > 2)
                {
                    ringkasan.GudangCMax = Convert.ToInt32(dtGudang.Rows[2]["kapasitas_maksimal"]);
                    ringkasan.GudangCValue = Convert.ToInt32(dtGudang.Rows[2]["stok_saat_ini"]);
                }
            }
            catch
            {
                ringkasan.GudangAMax = 100; ringkasan.GudangAValue = 0;
                ringkasan.GudangBMax = 100; ringkasan.GudangBValue = 0;
                ringkasan.GudangCMax = 100; ringkasan.GudangCValue = 0;
            }

            return ringkasan;
        }

        public DataTable GetDataGudang()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    g.id_gudang,
                    g.nama_gudang,
                    g.kapasitas_maksimal,
                    COALESCE(SUM(sm.jumlah), 0) -
                    COALESCE(
                        (SELECT SUM(sk.jumlah)
                         FROM ""Stok_Keluar"" sk
                         WHERE sk.id_gudang = g.id_gudang), 0
                    ) AS stok_saat_ini
                FROM ""Gudang"" g
                LEFT JOIN ""Stok_Masuk"" sm ON g.id_gudang = sm.id_gudang
                GROUP BY g.id_gudang, g.nama_gudang, g.kapasitas_maksimal";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data gudang: " + ex.Message);
            }
        }

        public DataTable GetHasilPanenTerbaru()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string queryHasilPanen = @"SELECT * FROM ""Hasil_Panen"" ORDER BY tanggal DESC LIMIT 5";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(queryHasilPanen, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data hasil panen: " + ex.Message);
            }
        }
    }
}
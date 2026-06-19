using System;
using System.Data;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Controllers
{
    public class MonitoringController
    {

        //  Monitoring Admin

        public DataTable GetRiwayatStok()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    g.nama_gudang AS ""Nama Gudang"",
                    g.lokasi AS ""Lokasi"",
                    COALESCE(
                        (SELECT SUM(sm.jumlah)
                         FROM ""Stok_Masuk"" sm
                         WHERE sm.id_gudang = g.id_gudang),0)
                    -
                    COALESCE(
                        (SELECT SUM(sk.jumlah)
                         FROM ""Stok_Keluar"" sk
                         WHERE sk.id_gudang = g.id_gudang),0)
                    AS ""Stok (kg)"",
                    g.kapasitas_maksimal AS ""Kapasitas (kg)"",
                    CASE
                        WHEN (
                            COALESCE(
                                (SELECT SUM(sm.jumlah)
                                 FROM ""Stok_Masuk"" sm
                                 WHERE sm.id_gudang = g.id_gudang),0)
                            -
                            COALESCE(
                                (SELECT SUM(sk.jumlah)
                                 FROM ""Stok_Keluar"" sk
                                 WHERE sk.id_gudang = g.id_gudang),0)
                        ) >= g.kapasitas_maksimal
                        THEN 'Penuh'
                        ELSE 'Tersedia'
                    END AS ""Status"",
                    ROUND(
                        (
                            (
                                COALESCE(
                                    (SELECT SUM(sm.jumlah)
                                     FROM ""Stok_Masuk"" sm
                                     WHERE sm.id_gudang = g.id_gudang),0)
                                -
                                COALESCE(
                                    (SELECT SUM(sk.jumlah)
                                     FROM ""Stok_Keluar"" sk
                                     WHERE sk.id_gudang = g.id_gudang),0)
                            )
                            / g.kapasitas_maksimal
                        ) * 100,2
                    ) || '%' AS ""Terisi""
                FROM ""Gudang"" g
                ORDER BY g.id_gudang";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data riwayat stok!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable GetMasukTerakhir()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sm.tanggal AS ""Tanggal"",
                    g.nama_gudang AS ""Gudang""
                FROM ""Stok_Masuk"" sm
                JOIN ""Gudang"" g
                    ON sm.id_gudang = g.id_gudang
                ORDER BY sm.tanggal DESC
                LIMIT 10";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data stok masuk!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable GetKeluarTerakhir()
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    tanggal AS ""Tanggal"",
                    keterangan AS ""Keterangan""
                FROM ""Stok_Keluar""
                ORDER BY tanggal DESC
                LIMIT 10";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data stok keluar!\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        // Monitoring Petani

        public DataTable GetStatusGudang()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    g.id_gudang,
                    g.nama_gudang,
                    g.lokasi,
                    g.kapasitas_maksimal,
                    COALESCE(SUM(sm.jumlah), 0) - 
                    COALESCE((SELECT SUM(sk.jumlah) FROM ""Stok_Keluar"" sk WHERE sk.id_gudang = g.id_gudang), 0)
                    AS stok_saat_ini
                FROM ""Gudang"" g
                LEFT JOIN ""Stok_Masuk"" sm ON g.id_gudang = sm.id_gudang
                GROUP BY g.id_gudang, g.nama_gudang, g.lokasi, g.kapasitas_maksimal
                ORDER BY g.id_gudang";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat status gudang: " + ex.Message);
            }
        }

        public (int jumlahGudang, decimal totalStok, decimal totalKapasitas) GetRingkasanGudang()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    COUNT(g.id_gudang) AS jumlah_gudang,
                    COALESCE(SUM(sm.jumlah), 0) AS total_stok,
                    SUM(g.kapasitas_maksimal) AS total_kapasitas
                FROM ""Gudang"" g
                LEFT JOIN ""Stok_Masuk"" sm ON g.id_gudang = sm.id_gudang";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                Convert.ToInt32(reader["jumlah_gudang"]),
                                Convert.ToDecimal(reader["total_stok"]),
                                Convert.ToDecimal(reader["total_kapasitas"])
                            );
                        }
                    }
                }
                return (0, 0, 0);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat ringkasan: " + ex.Message);
            }
        }
    }
}
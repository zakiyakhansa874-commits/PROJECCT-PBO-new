using System;
using System.Data;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Controllers
{
    public class LaporanController
    {
        public DataTable GetHasilPanen(DateTime dari, DateTime sampai)
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    hp.tanggal_panen AS ""Tanggal"",
                    u.nama AS ""Petani"",
                    hp.komoditas AS ""Komoditas"",
                    hp.berat_bersih AS ""Berat Bersih (kg)"",
                    hp.kualitas AS ""Kualitas""
                FROM hasil_panen hp
                JOIN ""Petani"" p ON hp.id_petani = p.id_petani
                JOIN ""User"" u ON p.id_user = u.id_user
                WHERE hp.tanggal_panen BETWEEN @dari AND @sampai
                ORDER BY hp.tanggal_panen DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dari", dari);
                    da.SelectCommand.Parameters.AddWithValue("@sampai", sampai);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetStokMasuk(DateTime dari, DateTime sampai)
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sm.tanggal AS ""Tanggal"",
                    g.nama_gudang AS ""Gudang"",
                    u.nama AS ""Petani"",
                    sm.jumlah AS ""Jumlah (kg)"",
                    sm.kualitas AS ""Kualitas""
                FROM ""Stok_Masuk"" sm
                JOIN ""Gudang"" g ON sm.id_gudang = g.id_gudang
                JOIN ""Petani"" p ON sm.id_petani = p.id_petani
                JOIN ""User"" u ON p.id_user = u.id_user
                WHERE sm.tanggal BETWEEN @dari AND @sampai
                ORDER BY sm.tanggal DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dari", dari);
                    da.SelectCommand.Parameters.AddWithValue("@sampai", sampai);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetStokKeluar(DateTime dari, DateTime sampai)
        {
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sk.tanggal AS ""Tanggal"",
                    g.nama_gudang AS ""Gudang"",
                    sk.keterangan AS ""Keterangan"",
                    sk.jumlah AS ""Jumlah (kg)""
                FROM ""Stok_Keluar"" sk
                JOIN ""Gudang"" g ON sk.id_gudang = g.id_gudang
                WHERE sk.tanggal BETWEEN @dari AND @sampai
                ORDER BY sk.tanggal DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dari", dari);
                    da.SelectCommand.Parameters.AddWithValue("@sampai", sampai);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
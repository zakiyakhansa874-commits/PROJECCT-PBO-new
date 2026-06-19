using System;
using System.Data;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Controllers
{
    public class StokKeluarController
    {
        public DataTable GetAllStokKeluar()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT
                    sk.id_stokkeluar,
                    g.nama_gudang,
                    sk.jumlah,
                    sk.tanggal,
                    sk.tujuan,
                    sk.keterangan
                FROM ""Stok_Keluar"" sk
                JOIN ""Gudang"" g ON sk.id_gudang = g.id_gudang
                ORDER BY sk.id_stokkeluar";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data:\n" + ex.Message);
            }
        }

        public DataTable GetAllGudang()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT id_gudang, nama_gudang FROM ""Gudang"" ORDER BY id_gudang";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
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

        public DataTable GetAllAdmin()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT a.id_admin, u.nama
                FROM ""Admin"" a
                INNER JOIN ""User"" u ON a.id_user = u.id_user
                ORDER BY u.nama";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
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

        public void TambahStokKeluar(int idGudang, decimal jumlah, DateTime tanggal, string tujuan, string keterangan)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                INSERT INTO ""Stok_Keluar""
                (id_gudang, jumlah, tanggal, tujuan, keterangan)
                VALUES (@id_gudang, @jumlah, @tanggal, @tujuan, @keterangan)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@tujuan", tujuan);
                        cmd.Parameters.AddWithValue("@keterangan", keterangan);

                        int hasil = cmd.ExecuteNonQuery();
                        MessageBox.Show("Baris tersimpan = " + hasil);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan data:\n" + ex.Message);
            }
        }

        public void HapusStokKeluar(int idStokKeluar)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"DELETE FROM ""Stok_Keluar"" WHERE id_stokkeluar = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idStokKeluar);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data:\n" + ex.Message);
            }
        }
    }
}
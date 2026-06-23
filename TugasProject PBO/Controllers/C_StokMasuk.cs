using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Controllers
{
    public class StokMasukController
    {
        public DataTable GetAllStokMasuk()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string sql = @"SELECT 
                            sm.id_stokmasuk, 
                            sm.tanggal, 
                            g.nama_gudang, 
                            u.nama AS nama_petani, 
                            sm.jumlah,
                            sm.kualitas,
                            sm.catatan
                           FROM ""Stok_Masuk"" sm
                           INNER JOIN ""Gudang"" g ON sm.id_gudang = g.id_gudang
                           INNER JOIN ""Petani"" p ON sm.id_petani = p.id_petani
                           INNER JOIN ""User"" u ON p.id_user = u.id_user
                           ORDER BY sm.id_stokmasuk DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data stok masuk: " + ex.Message);
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

        public DataTable GetAllPetani()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT p.id_petani, u.nama
                                     FROM ""Petani"" p
                                     INNER JOIN ""User"" u ON p.id_user = u.id_user
                                     ORDER BY u.nama";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data petani:\n" + ex.Message);
            }
        }

        public void TambahStokMasuk(int idPetani, int idGudang, decimal jumlah, DateTime tanggal, string kualitas, string catatan)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // Simpan ke tabel Stok_Masuk
                    string query = @"
            INSERT INTO ""Stok_Masuk""
            (id_petani, id_gudang, jumlah, tanggal, kualitas, catatan)
            VALUES
            (@id_petani, @id_gudang, @jumlah, @tanggal, @kualitas, @catatan)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@kualitas",
                            string.IsNullOrWhiteSpace(kualitas)
                            ? (object)DBNull.Value
                            : kualitas.Trim());

                        cmd.Parameters.AddWithValue("@catatan",
                            string.IsNullOrWhiteSpace(catatan)
                            ? (object)DBNull.Value
                            : catatan.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    // Tambah stok gudang
                    string updateGudang = @"
                        UPDATE ""Gudang""
                        SET stok_saat_ini = stok_saat_ini + @jumlah
                        WHERE id_gudang = @id_gudang";

                    using (var cmdUpdate = new NpgsqlCommand(updateGudang, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@jumlah", jumlah);
                        cmdUpdate.Parameters.AddWithValue("@id_gudang", idGudang);

                        int rows = cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show(
                            "Stok gudang berhasil diperbarui.\nRows = " + rows);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan data:\n" + ex.Message);
            }
        }

        public void HapusStokMasuk(int idStokMasuk)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string queryHapus = @"DELETE FROM ""Stok_Masuk"" WHERE id_stokmasuk = @id";
                    using (var cmd = new NpgsqlCommand(queryHapus, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idStokMasuk);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data dari database: " + ex.Message);
            }
        }
    }
}
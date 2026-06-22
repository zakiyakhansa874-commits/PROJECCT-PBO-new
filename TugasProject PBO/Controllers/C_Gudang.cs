using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Controllers
{
    public class GudangController
    {
        public DataTable GetAllGudang()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string sql = @"SELECT 
                            id_gudang, 
                            nama_gudang, 
                            lokasi, 
                            kapasitas_maksimal,
                            stok_saat_ini
                           FROM ""Gudang""
                           ORDER BY id_gudang ASC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (NpgsqlException npgEx)
            {
                throw new Exception("Terjadi masalah konfigurasi query database:\n" + npgEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat data halaman kelola gudang: " + ex.Message);
            }
        }
        
        public DataRow GetGudangById(int idGudang)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT id_gudang, nama_gudang, lokasi, kapasitas_maksimal 
                              FROM ""Gudang"" WHERE id_gudang = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idGudang);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data gudang: " + ex.Message);
            }
        }

        public void UpdateGudang(int idGudang, string nama, string lokasi, decimal kapasitas, decimal stok_saat_ini)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"UPDATE ""Gudang""
                              SET nama_gudang = @nama, lokasi = @lokasi, kapasitas_maksimal = @kapasitas, stok_saat_ini = @stok_saat_ini
                              WHERE id_gudang = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idGudang);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@lokasi", lokasi);
                        cmd.Parameters.AddWithValue("@kapasitas", kapasitas);
                        cmd.Parameters.AddWithValue("@stok_saat_ini", stok_saat_ini);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengupdate data gudang: " + ex.Message);
            }
        }

        public void TambahGudang(string nama, string lokasi, decimal kapasitas, decimal stok_saat_ini)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO ""Gudang""
                        (nama_gudang, lokasi, kapasitas_maksimal, stok_saat_ini)
                        VALUES (@nama, @lokasi, @kapasitas, @stok_saat_ini)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@lokasi", lokasi);
                        cmd.Parameters.AddWithValue("@kapasitas", kapasitas);
                        cmd.Parameters.AddWithValue("@stok_saat_ini", stok_saat_ini);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void HapusGudang(int idGudang)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string deleteStokMasuk = @"DELETE FROM ""Stok_Masuk"" WHERE id_gudang = @id";
                    using (var cmd1 = new NpgsqlCommand(deleteStokMasuk, conn))
                    {
                        cmd1.Parameters.AddWithValue("@id", idGudang);
                        cmd1.ExecuteNonQuery();
                    }

                    string deleteGudang = @"DELETE FROM ""Gudang"" WHERE id_gudang = @id";
                    using (var cmd2 = new NpgsqlCommand(deleteGudang, conn))
                    {
                        cmd2.Parameters.AddWithValue("@id", idGudang);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data: " + ex.Message);
            }
        }
    }
}
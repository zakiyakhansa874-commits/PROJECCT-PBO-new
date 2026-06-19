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
                                    g.id_gudang, 
                                    g.nama_gudang, 
                                    g.lokasi, 
                                    g.kapasitas_maksimal,
                                    COALESCE(SUM(sm.jumlah), 0) AS stok_saat_ini
                                   FROM ""Gudang"" g
                                   LEFT JOIN ""Stok_Masuk"" sm ON g.id_gudang = sm.id_gudang
                                   GROUP BY g.id_gudang, g.nama_gudang, g.lokasi, g.kapasitas_maksimal
                                   ORDER BY g.id_gudang ASC";

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

        public void TambahGudang(string nama, string lokasi, decimal kapasitas)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                        INSERT INTO ""Gudang""
                        (nama_gudang, lokasi, kapasitas_maksimal)
                        VALUES (@nama, @lokasi, @kapasitas)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@lokasi", lokasi);
                        cmd.Parameters.AddWithValue("@kapasitas", kapasitas);
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
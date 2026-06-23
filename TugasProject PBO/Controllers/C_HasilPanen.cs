using System;
using System.Data;
using Npgsql;
using TugasProject_PBO.Helpers;

namespace TugasProject_PBO.Controllers
{
    public class HasilPanenController
    {
        public DataTable GetAllHasilPanen()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    const string sql = @"
                    SELECT
                        id_hasilpanen,
                        berat_kotor,
                        berat_bersih,
                        kualitas,
                        catatan,
                        tanggal_panen,
                        id_petani,
                        komoditas
                    FROM hasil_panen
                    ORDER BY id_hasilpanen DESC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public DataTable GetAllPetani()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                    SELECT p.id_petani, u.nama
                    FROM ""Petani"" p
                    INNER JOIN ""User"" u ON p.id_user = u.id_user
                    ORDER BY u.nama";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
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

        public void TambahHasilPanen(int idPetani, DateTime tanggalPanen, string komoditas,
        decimal beratKotor, decimal beratBersih, string kualitas, string catatan)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // conn.Open(); ← HAPUS BARIS INI
                    string query = @"INSERT INTO hasil_panen
                    (id_petani, tanggal_panen, komoditas, berat_kotor, berat_bersih, kualitas, catatan)
                    VALUES (@id_petani, @tanggal_panen, @komoditas, @berat_kotor, @berat_bersih, @kualitas, @catatan)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@tanggal_panen", tanggalPanen);
                        cmd.Parameters.AddWithValue("@komoditas", komoditas);
                        cmd.Parameters.AddWithValue("@berat_kotor", beratKotor);
                        cmd.Parameters.AddWithValue("@berat_bersih", beratBersih);
                        cmd.Parameters.AddWithValue("@kualitas", kualitas);
                        cmd.Parameters.AddWithValue("@catatan", catatan);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan data : " + ex.Message);
            }
        }

        public void TambahHasilPanenDanSinkronStokMasuk( int idPetani, DateTime tanggal, string komoditas,
            decimal beratKotor, decimal beratBersih, string kualitas, string catatan, int idGudang)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // Insert ke hasil_panen
                    string queryPanen = @"
                        INSERT INTO hasil_panen 
                        (id_petani, tanggal_panen, komoditas, berat_kotor, berat_bersih, kualitas, catatan)
                        VALUES (@id_petani, @tanggal, @komoditas, @berat_kotor, @berat_bersih, @kualitas, @catatan)";

                    using (var cmd = new NpgsqlCommand(queryPanen, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@komoditas", komoditas);
                        cmd.Parameters.AddWithValue("@berat_kotor", beratKotor);
                        cmd.Parameters.AddWithValue("@berat_bersih", beratBersih);
                        cmd.Parameters.AddWithValue("@kualitas", kualitas);
                        cmd.Parameters.AddWithValue("@catatan",
                            string.IsNullOrWhiteSpace(catatan) ? (object)DBNull.Value : catatan);
                        cmd.ExecuteNonQuery();
                    }
                    // Auto-sync ke Stok_Masuk
                    string queryStok = @"
                        INSERT INTO ""Stok_Masuk""
                        (id_petani, id_gudang, jumlah, tanggal, kualitas, catatan)
                        VALUES (@id_petani, @id_gudang, @jumlah, @tanggal, @kualitas, @catatan)";

                    using (var cmd = new NpgsqlCommand(queryStok, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@id_gudang", idGudang);
                        cmd.Parameters.AddWithValue("@jumlah", beratBersih);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@kualitas", kualitas);
                        cmd.Parameters.AddWithValue("@catatan",
                            $"Auto-sync dari hasil panen: {komoditas}");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan data: " + ex.Message);
            }
        }

        public void UpdateHasilPanen(int id, int idPetani, DateTime tanggal, string komoditas,
            decimal beratKotor, decimal beratBersih, string kualitas, string catatan)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    string sql = @"UPDATE hasil_panen
                    SET id_petani=@id_petani, tanggal_panen=@tanggal, komoditas=@komoditas,
                        berat_kotor=@berat_kotor, berat_bersih=@berat_bersih, kualitas=@kualitas, catatan=@catatan
                    WHERE id_hasilpanen=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@komoditas", komoditas);
                        cmd.Parameters.AddWithValue("@berat_kotor", beratKotor);
                        cmd.Parameters.AddWithValue("@berat_bersih", beratBersih);
                        cmd.Parameters.AddWithValue("@kualitas", kualitas);
                        cmd.Parameters.AddWithValue("@catatan", catatan);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void HapusHasilPanen(int id)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"DELETE FROM ""hasil_panen"" WHERE id_hasilpanen = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus data: " + ex.Message);
            }
        }

        // PUNYA PETANI

        public int GetIdPetaniByUserId(int idUser)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT id_petani FROM ""Petani"" WHERE id_user = @id_user";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_user", idUser);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mendapatkan ID petani: " + ex.Message);
            }
        }
        public DataTable GetHasilPanenByPetani(int idPetani)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    const string sql = @"
                    SELECT
                      hp.id_hasilpanen,
                      hp.tanggal_panen,
                      u.nama AS nama_petani,
                      hp.komoditas,
                      hp.berat_kotor,
                      hp.berat_bersih,
                      hp.kualitas,
                      hp.catatan
                    FROM hasil_panen hp
                    JOIN ""Petani"" p ON hp.id_petani = p.id_petani
                    JOIN ""User"" u ON p.id_user = u.id_user
                    WHERE hp.id_petani = @id_petani
                    ORDER BY hp.tanggal_panen DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", idPetani);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat hasil panen: " + ex.Message);
            }
        }

        public void TambahHasilPanenPetani(string petani, DateTime tanggal, string komoditas,
          double beratKotor, double beratBersih, string kualitas, string catatan)
        {
            // Method ini untuk BCInputHasilPanen yang belum connect DB
            // Saat ini hanya tampilkan pesan, bisa dikembangkan
            string pesan = $"Data Panen:\n" +
                           $"- Petani: {petani}\n" +
                           $"- Tanggal: {tanggal:dd/MM/yyyy}\n" +
                           $"- Komoditas: {komoditas}\n" +
                           $"- Berat Kotor: {beratKotor} kg\n" +
                           $"- Berat Bersih: {beratBersih} kg\n" +
                           $"- Kualitas: {kualitas}\n" +
                           $"- Catatan: {catatan}";

            MessageBox.Show(pesan, "Data Disimpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool HapusData(int idPanen)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    // SOLUSI: Cek status koneksi terlebih dahulu sebelum di-Open
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    else if (conn.State == System.Data.ConnectionState.Broken)
                    {
                        conn.Close();
                        conn.Open();
                    }

                    MessageBox.Show("ID diterima Controller = " + idPanen);

                    string query = @"DELETE FROM hasil_panen WHERE id_hasilpanen = @id";

                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPanen);

                        int affectedRows = cmd.ExecuteNonQuery();

                        MessageBox.Show("Rows affected = " + affectedRows);

                        return affectedRows > 0;
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERROR DATABASE:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
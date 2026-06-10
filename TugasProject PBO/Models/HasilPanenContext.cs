// Models/HasilPanenContext.cs
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TugasProject_PBO.Helpers;

//namespace inventory_panen_mvc.Models
//{
//    public class HasilPanenContext
//    {
//        public List<HasilPanen> GetAll()
//        {
//            List<HasilPanen> list = new List<HasilPanen>();
//            string query = "SELECT * FROM hasil_panen";
//            DataTable dt = DatabaseHelper.ExecuteQuery(query);

//            foreach (DataRow row in dt.Rows)
//            {
//                list.Add(new HasilPanen
//                {
//                    Id = Convert.ToInt32(row["id"]),
//                    NamaKomoditas = row["nama_komoditas"].ToString(),
//                    Berat = Convert.ToDouble(row["berat"]),
//                    TanggalPanen = Convert.ToDateTime(row["tanggal_panen"]),
//                    Kualitas = row["kualitas"].ToString()
//                });
//            }
//            return list;
//        }

//        public bool Insert(HasilPanen panen)
//        {
//            string query = "INSERT INTO hasil_panen (nama_komoditas, berat, tanggal_panen, kualitas) VALUES (@nama, @berat, @tgl, @kualitas)";
//            SqlParameter[] p = {
//                new SqlParameter("@nama", panen.NamaKomoditas),
//                new SqlParameter("@berat", panen.Berat),
//                new SqlParameter("@tgl", panen.TanggalPanen),
//                new SqlParameter("@kualitas", panen.Kualitas)
//            };
//            return DatabaseHelper.ExecuteNonQuery(query, p) > 0;
//        }
//    }
//}
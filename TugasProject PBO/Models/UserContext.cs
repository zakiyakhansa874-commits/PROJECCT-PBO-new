// Models/UserContext.cs
using System;
using System.Data;
using System.Data.SqlClient;
using TugasProject_PBO.Helpers;

//namespace inventory_panen_mvc.Models
//{
//    public class UserContext
//    {
//        public User Login(string email, string password)
//        {
//            string query = "SELECT * FROM users WHERE email = @email AND password = @password";
//            SqlParameter[] p = {
//                new SqlParameter("@email", email),
//                new SqlParameter("@password", password) // Idealnya di-hash
//            };

//            DataTable dt = DatabaseHelper.ExecuteQuery(query, p);
//            if (dt.Rows.Count > 0)
//            {
//                DataRow row = dt.Rows[0];
//                return new User
//                {
//                    Id = Convert.ToInt32(row["id"]),
//                    Username = row["username"].ToString(),
//                    Email = row["email"].ToString(),
//                    Role = row["role"].ToString()
//                };
//            }
//            return null;
//        }
//    }
//}
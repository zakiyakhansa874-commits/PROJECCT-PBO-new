using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Helpers
{
    public class DatabaseHelper
    {
        private static string connectionString =
            "Host=localhost;" +
            "Port=5433;" +
            "Database=ProjectPBO_SIMIHAN;" +
            "Username=postgres;" +
            "Password=galang13;";

        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}

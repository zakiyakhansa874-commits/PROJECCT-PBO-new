using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_panen_mvc.Models
{
    public abstract class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }
        public string Role { get; set; }

        public abstract List<string> GetMenu();  
    }
    public class Admin : User
    {
        public override List<string> GetMenu()
        {
            return new List<string>
            {
                "Dashboard",
                "Kelola Data Hasil Panen",
                "Kelola Gudang",
                "Kelola Stok Masuk",
                "Kelola Stok Keluar",
                "Monitoring Stok",
                "Laporan Inventori"
            };
        }
    }
    public class Petani : User
    {
        public override List<string> GetMenu()
        {
            return new List<string>
            {
               "Input Hasil Panen",
               "Monitoring Stok"
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

// Models/User.cs
namespace inventory_panen_mvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin / Petani / Customer
    }
}

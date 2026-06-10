// Models/HasilPanen.cs
using System;

namespace inventory_panen_mvc.Models
{
    public class HasilPanen
    {
        public int Id { get; set; }
        public string NamaKomoditas { get; set; } // Misal: Teh Hijau, Kopi Arabika
        public double Berat { get; set; } // dalam Kg
        public DateTime TanggalPanen { get; set; }
        public string Kualitas { get; set; } // Premium, Medium, Rendah
    }
}
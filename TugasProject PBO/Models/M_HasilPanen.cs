// Models/HasilPanen.cs
using System;

namespace TugasProject_PBO.Models
{
    public class HasilPanen
    {
        public int IdHasilPanen { get; set; }
        public decimal BeratKotor { get; set; }
        public decimal BeratBersih { get; set; }
        public string Kualitas { get; set; }
        public string Catatan { get; set; }
        public string TanggalPanen { get; set; }
        public string IdPetani { get; set; }
        public string Komoditas { get; set; }
    }
}
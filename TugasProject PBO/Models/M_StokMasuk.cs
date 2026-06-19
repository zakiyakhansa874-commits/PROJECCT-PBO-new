using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Models
{
    public class StokMasuk
    {
        public int IdStokMasuk { get; set; }
        public string Tanggal { get; set; }
        public string NamaGudang { get; set; }
        public string NamaPetani { get; set; }
        public string Jumlah { get; set; }
        public string Kualitas { get; set; }
        public string Catatan { get; set; }
    }
}
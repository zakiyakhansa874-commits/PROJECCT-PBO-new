using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Models
{
    public class StokKeluar
    {
        public int IdStokKeluar { get; set; }
        public string NamaGudang { get; set; }
        public decimal Jumlah { get; set; }
        public string Tanggal { get; set; }
        public string Tujuan { get; set; }
        public string Keterangan { get; set; }
    }
}
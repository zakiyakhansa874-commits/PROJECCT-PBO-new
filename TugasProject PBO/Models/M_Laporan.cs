using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Models
{
    public class LaporanHasilPanen
    {
        public string Tanggal { get; set; }
        public string Petani { get; set; }
        public string Komoditas { get; set; }
        public decimal BeratBersih { get; set; }
        public string Kualitas { get; set; }
    }
    public class LaporanStokMasuk
    {
        public string Tanggal { get; set; }
        public string Gudang { get; set; }
        public string Petani { get; set; }
        public decimal Jumlah { get; set; }
        public string Kualitas { get; set; }
    }
    public class LaporanStokKeluar
    {
        public string Tanggal { get; set; }
        public string Gudang { get; set; }
        public string Keterangan { get; set; }
        public decimal Jumlah { get; set; }
    }
}

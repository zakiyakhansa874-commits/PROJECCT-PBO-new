 using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Models
{
    internal class M_Monitoring
    {
        public class RiwayatStok
        {
            public string NamaGudang { get; set; }
            public string Lokasi { get; set; }
            public decimal Stok { get; set; }
            public decimal KapasitasMaksimal { get; set; }
            public string Status { get; set; }
            public string Terisi { get; set; }
        }
        // Admin
        public class StokMasukTerakhir
        {
            public DateTime Tanggal { get; set; }
            public string Gudang { get; set; }
        }
        public class StokKeluarTerakhir
        {
            public DateTime Tanggal { get; set; }
            public string Keterangan { get; set; }
        }
        // Customer
        public class StatusGudang
        {
            public int IdGudang { get; set; }
            public string NamaGudang { get; set; }
            public string Lokasi { get; set; }
            public decimal KapasitasMaksimal { get; set; }
            public decimal StokSaatIni { get; set; }
            public double Persentase { get; set; }
        }
        public class RingkasanGudang
        {
            public int JumlahGudang { get; set; }
            public decimal TotalStok { get; set; }
            public decimal TotalKapasitas { get; set; }
        }
    }
}

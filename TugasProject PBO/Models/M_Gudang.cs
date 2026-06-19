using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Models
{
    public class Gudang
    {
        public int IdGudang { get; set; }
        public string NamaGudang { get; set; }
        public string Lokasi { get; set; }
        public decimal KapasitasMaksimal { get; set; }
        public decimal StokSaatIni { get; set; }
        public string Terisi { get; set; }
    }
}
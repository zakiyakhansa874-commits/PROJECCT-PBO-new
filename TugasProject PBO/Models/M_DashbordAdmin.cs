using System;
using System.Collections.Generic;
using System.Text;

namespace TugasProject_PBO.Models
{
    public class RingkasanDashboard
    {
        public string TotalGudang { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string StokSaatIni { get; set; }
        public string TotalHasilPanen { get; set; }
        public string KapasitasGudang { get; set; }
        public int GudangAMax { get; set; }
        public int GudangAValue { get; set; }
        public int GudangBMax { get; set; }
        public int GudangBValue { get; set; }
        public int GudangCMax { get; set; }
        public int GudangCValue { get; set; }

    }
}

// ENKAPSULASI harus menerapkan private 
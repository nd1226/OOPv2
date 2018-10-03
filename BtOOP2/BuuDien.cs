using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    public class BuuDien
    {
        public string MaBuuDien { get; set; }
        public string TenBuuDien { get; set; }
        public string DiaChi { get; set; }

        public BuuDien() { }
        public BuuDien(string maBuuDien, string tenBuuDien, string diaChi)
        {
            MaBuuDien = maBuuDien;
            TenBuuDien = tenBuuDien;
            DiaChi = diaChi;
        }
    }
}

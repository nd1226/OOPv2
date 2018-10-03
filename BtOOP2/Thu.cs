using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    public enum LT
    {
        Thuong,
        Nhanh
    }
    public class Thu : BuuPham, IBuuPham
    {
        public LT LoaiThu { get; set; }

        public override int Price()
        {
            return LoaiThu.Equals(LT.Thuong) ? 500 : 2000;
        }

        public override string ToString()
        {
            return LoaiThu.Equals(LT.Thuong) ? "Thuong`: " + this.Price() : "Nhanh: " + this.Price();
        }
    }
}

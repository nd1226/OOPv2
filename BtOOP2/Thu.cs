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
    public class Thu : BuuPham
    {
        private int countThu = 0;
        public LT LoaiThu { get; set; }
        public Thu() { countThu++; }

        public Thu(string maBuuPham,
            string tenBuuPham,
            string nguoiNhan,
            LT loaiThu)
            : base(maBuuPham, tenBuuPham, nguoiNhan)
        {
            countThu++;
            LoaiThu = loaiThu;
        }

        public override void Print()
        {
            base.Print();
            if (LoaiThu == LT.Thuong)
            {
                Console.WriteLine("Loai thu : Thu thuong");
            }
            else
                Console.WriteLine("Loai thu : Thu chuyen phat nhanh");
        }

        public override int Count()
        {
            return countThu;
        }

        public override double Sum()
        {
            int sum = 0;
            if (LoaiThu == LT.Thuong)
            {
                sum = 2000;
            }
            else
                sum = 500;
            return sum;
        }
    }
}

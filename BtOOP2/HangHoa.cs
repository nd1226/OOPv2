using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    class HangHoa : BuuPham
    {
        private int countHangHoa = 0;
        public float KhoiLuong { get; set; }

        public HangHoa() { countHangHoa++; }

        public HangHoa(string maBuuPham,
            string tenBuuPham,
            string nguoiNhan,
            float khoiLuong)
            :base(maBuuPham,tenBuuPham,nguoiNhan)
        {
            countHangHoa++;
            KhoiLuong = khoiLuong;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Khoi Luong :" + KhoiLuong);
        }
        public override int Count()
        {
            return countHangHoa;
        }
        public override double Sum()
        {
            return KhoiLuong * 1000;
        }
    }
}

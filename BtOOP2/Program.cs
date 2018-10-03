using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BuuPham> lst = new List<BuuPham>() {
                new Thu(){ LoaiThu = LT.Nhanh, MaBuuPham = "thu1", TenBuuPham = "thu1", NguoiNhan = "Nhan"},
                new HangHoa(){ KhoiLuong = 10, TenBuuPham = "heroin", MaBuuPham = "heroin10kg", NguoiNhan = "Bao Nguyen"},
                new Thu(){ LoaiThu = LT.Thuong, MaBuuPham = "thu thuong", TenBuuPham = "thuthuong", NguoiNhan = "QC"}
            };

            BuuDien bd = new BuuDien()
            {
                DiaChi = "abc 123",
                MaBuuDien = "abc 321",
                TenBuuDien = "buu dien",
                LstBuuPham = lst
            };


            bd.ShowPrice();
            bd.ShowAll();
            Console.WriteLine("So luong hang hoa: " + bd.CountProducts());
            Console.WriteLine("So luong thu: " + bd.CountLetters());
        }
    }
}

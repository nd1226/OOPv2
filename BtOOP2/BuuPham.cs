using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    public abstract class BuuPham
    {
            public static int count;
            public string MaBuuPham { get; set; }
            public string TenBuuPham { get; set; }
            public string NguoiNhan { get; set; }

            /// <summary>
            /// Constructor
            /// </summary>
            public BuuPham() { count++; }
            public BuuPham(string maBuuPham, string tenBuuPham, string nguoiNhan)
            {
                count++;
                MaBuuPham = maBuuPham;
                TenBuuPham = tenBuuPham;
                NguoiNhan = nguoiNhan;
            }
            public virtual void Print()
            {
                Console.WriteLine("Ma Buu Pham :" + MaBuuPham);
                Console.WriteLine("Ten Buu Pham :" + TenBuuPham);
                Console.WriteLine("Nguoi Nhan :" + NguoiNhan);
            }
            public abstract int Count();
            public abstract double Sum();
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    public abstract class BuuPham : IBuuPham
    {
        public string MaBuuPham { get; set; }
        public string TenBuuPham { get; set; }
        public string NguoiNhan { get; set; }

        public virtual int Price()
        {
            return 0;
        }

        public virtual void Show()
        {
            Console.WriteLine(ToString());
        }
    }
}

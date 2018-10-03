using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    class HangHoa : BuuPham, IBuuPham
    {
        public float KhoiLuong { get; set; }


        public override int Price()
        {
            return Convert.ToInt16(1000 * KhoiLuong);
        }

        public override string ToString()
        {
            return "Hang Hoa :" +this.Price();
        }

    }
}

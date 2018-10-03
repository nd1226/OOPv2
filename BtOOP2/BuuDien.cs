using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP2
{
    public class BuuDien : IBuuDien
    {
        public string MaBuuDien { get; set; }
        public string TenBuuDien { get; set; }
        public string DiaChi { get; set; }
        public List<BuuPham> LstBuuPham { get; set; }


        public BuuDien()
        {
            LstBuuPham = new List<BuuPham>();
        }

        public void ShowPrice()
        {
            Console.WriteLine("Total price: {0}", SumPrice());
        }

        public int SumPrice()
        {
            if (LstBuuPham == null || LstBuuPham.Count == 0) return 0;
            return LstBuuPham.Sum(i => i.Price());
        }

        public void ShowAll()
        {
            if (LstBuuPham == null || LstBuuPham.Count == 0) return;
            foreach (var item in LstBuuPham)
            {
                item.Show();
            }
        }

        public int CountProducts()
        {
            return LstBuuPham == null ? 0 : LstBuuPham.Count(x => typeof(HangHoa).Equals(x.GetType()));
        }

        public int CountLetters()
        {
            return LstBuuPham == null ? 0 : LstBuuPham.Count(x => typeof(Thu).Equals(x.GetType()));
            //if (LstBuuPham == null) return 0;
            //int count = 0;
            //foreach (var item in LstBuuPham)
            //{
            //    if (item.GetType() == typeof(Thu)) count++;
            //}
            //return count;
        }
    }
}

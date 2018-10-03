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
            BuuPham buuPham = new HangHoa("BP01", "Buu Pham A", "Doan Van Nhan", 3);
            Console.WriteLine(buuPham.Sum());
        }
    }
}

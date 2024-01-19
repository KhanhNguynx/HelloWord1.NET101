using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CungThu nhanVat1 = new CungThu();
            nhanVat1.DiemTanCong = 1000;
            nhanVat1.DiemPhongThu = 500;
            nhanVat1.HP = 3000 ;
            nhanVat1.TocDo = 2;

            CungThu nhanVat2 = new CungThu( 1000, 500, 3000, 2) ;

            nhanVat1.Kynang1();

            = Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConOng
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int soLuong = 10;
            do
            {
                Console.WriteLine("1. Tao dan ong");
                Console.WriteLine("2. Tan cong");
                Console.WriteLine("3. In danh sach");
                Console.WriteLine("0. Thoat");
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        game.KhoiTaoDanOng(soLuong);
                        break;
                    case 2:
                        game.TanCongDanOng();
                        break;
                    case 3:
                        game.InDanhSach();
                        break;
                    default:
                        break;
                }
                if (luaChon == 0)
                {
                    return;
                }
            } while (true);
        }
    }
}

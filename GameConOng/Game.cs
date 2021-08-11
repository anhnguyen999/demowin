using GameConOng.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConOng
{
    class Game
    {
        List<ConOng> danhSach = new List<ConOng>();

        public void KhoiTaoDanOng(int soLuong)
        {
            //ConOng conOng;
            for (int i = 0; i < soLuong; i++)
            {
                //conOng = new OngChua();
                danhSach.Add(new OngChua());
                danhSach.Add(new OngTho());
                danhSach.Add(new OngDuc());
                //conOng = new OngTho();
            }
        }
        public void TanCongDanOng()
        {
            Random rnd = new Random();
            foreach (ConOng conOng in danhSach)
            {
                //int soMauTanCong = rnd.Next(81);
                conOng.TanCong(rnd.Next(81));
            }
        }

        public void InDanhSach()
        {
            //var newList = people.OrderBy(x => x.Name).ToList();
            danhSach = danhSach.OrderBy(s => s.GetType().ToString()).ToList();
            foreach (ConOng conOng in danhSach)
            {
                Console.WriteLine("{0} - {1} - {2}", conOng.GetType().ToString(), conOng.soMau, conOng.GetTrangThai());
            }
            Console.ReadLine();
        }
    }
}

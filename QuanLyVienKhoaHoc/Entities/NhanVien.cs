using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhanVien
    {
        //--base--
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string BangCap { get; set; }
        //--base--

        public virtual void Nhap()
        {
            Console.Write("Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nam Sinh: ");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Bang Cap: ");
            BangCap = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\tHọ Tên: {0}", HoTen);
            Console.WriteLine("\tNam Sinh: {0}", NamSinh.ToShortDateString());
            Console.WriteLine("\tBang Cap: {0}", BangCap);
        }
    }
}

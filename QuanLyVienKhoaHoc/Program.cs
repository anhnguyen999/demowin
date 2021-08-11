using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PhongThiNghiem phongThiNghiem = new PhongThiNghiem();
            phongThiNghiem.Nhap();
            phongThiNghiem.Xuat();
            phongThiNghiem.InTongLuongTungLoaiDoiTuong();
            Console.ReadLine();
        }
    }
}

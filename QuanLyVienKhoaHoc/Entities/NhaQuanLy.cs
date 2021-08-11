using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Entities
{
    class NhaQuanLy : NhanVien
    {
        public float BacLuong { get; set; }
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }

        public double Luong {
            get
            {
                return BacLuong * SoNgayCong;
            }
        }

        public override void Nhap()
        {
            //nhập nhân viên trước
            base.Nhap();
            //nhập các thuộc tính còn lại của nhà quản lý
            Console.Write("Bac Luong: ");
            BacLuong = float.Parse(Console.ReadLine());
            Console.Write("Chuc Vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("So Ngay Cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\tBac Luong: {0}", BacLuong);
            Console.WriteLine("\tChuc Vu: {0}", ChucVu);
            Console.WriteLine("\tSo Ngay Cong: {0}", SoNgayCong);
        }
    }
}

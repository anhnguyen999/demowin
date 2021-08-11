using QuanLyVienKhoaHoc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc
{
    class PhongThiNghiem
    {
        public List<NhanVien> NhanViens;
        public NhanVien nhanVien;
        //ham khởi tạo, được tạo ra khi tạo đối tượng phòng thí nghiệm
        public PhongThiNghiem()
        {
            NhanViens = new List<NhanVien>();
        }

        public void Nhap()
        {
            do
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("\t1. Nhập nhà khoa học");
                Console.WriteLine("\t2. Nhập nhà quản lý");
                Console.WriteLine("\t3. Nhập nhân viên PTN");
                Console.WriteLine("\t0. END");
                Console.WriteLine("---MENU---");
                int luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        //nhap nha khoa hoc
                        nhanVien = new NhaKhoaHoc();
                        nhanVien.Nhap();
                        break;
                    case 2:
                        //nhap nha quan ly
                        nhanVien = new NhaQuanLy();
                        nhanVien.Nhap();
                        break;
                    case 3:
                        //nhan vien phong thi nghiem
                        nhanVien = new NhanVienPTN();
                        nhanVien.Nhap();
                        break;
                    default:
                        return;
                }
                //Thêm vào danh sach
                NhanViens.Add(nhanVien);
            } while (true);
        }

        public void Xuat()
        {
            //vòng lặp
            foreach (NhanVien nhanVien in NhanViens)
            {
                Console.WriteLine("--------------");
                nhanVien.Xuat();
            }
        }

        public void InTongLuongTungLoaiDoiTuong()
        {
            //in tong luong cho nha khoa hoc
            double luongNhaKhoaHoc = 0, luongNhaQuanLy = 0, luongNhanVienPTN = 0;
            foreach (NhaKhoaHoc item in NhanViens.OfType<NhaKhoaHoc>())
            {
                luongNhaKhoaHoc += item.Luong;
            }
            //in tong luong cho nha quan ly
            foreach (NhaQuanLy item in NhanViens.OfType<NhaQuanLy>())
            {
                luongNhaQuanLy += item.Luong;
            }
            //in tong luong cho nhan vien phong thi nghiem
            foreach (NhanVienPTN item in NhanViens.OfType<NhanVienPTN>())
            {
                luongNhanVienPTN += item.LuongTrongThang;
            }
            Console.WriteLine("Tong Luong Nha Khoa Hoc = {0}, Tong Luong Nha Quan Ly = {1}, Tong Luong Nhan vien PTN = {2}", luongNhaKhoaHoc, luongNhaQuanLy, luongNhanVienPTN);
        }

        //xuat danh sách nhân viên PTN có mức lương >=15.000.000
        public void XuatDanhSachNVPTN(double mucLuong) {
            List<NhanVienPTN> list = NhanViens.OfType<NhanVienPTN>().Where(p => p.LuongTrongThang >= mucLuong && p.NamSinh.Year == 2000).ToList();
            foreach (var item in list)
            {
                item.Xuat();
            }
        }

    }
}

using System;

namespace TH01
{
    class NhanVien
    {
        public string HoTen;
        public double Luong;
        public int SoNgayNghi;

        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap luong: ");
            Luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay nghi: ");
            SoNgayNghi = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return Luong - SoNgayNghi * 100000;
        }

        public void Xuat()
        {
            Console.WriteLine("----- THONG TIN NHAN VIEN -----");
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Luong ban dau: " + Luong);
            Console.WriteLine("So ngay nghi: " + SoNgayNghi);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
    }

    class Bai14
    {
        public static void Chay()
        {
            NhanVien nv = new NhanVien();

            nv.Nhap();
            nv.Xuat();
        }
    }
}
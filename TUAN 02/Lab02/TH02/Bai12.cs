using System;

namespace TH02
{
    class NhanVien
    {
        private string hoTen;
        private double luong;
        private int soNgayVang;

        public NhanVien()
        {
            hoTen = "";
            luong = 0;
            soNgayVang = 0;
        }

        public NhanVien(string hoTen, double luong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.luong = luong;
            this.soNgayVang = soNgayVang;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            luong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            soNgayVang = int.Parse(Console.ReadLine());
        }

        public double TinhLuong()
        {
            return luong - soNgayVang * 100000;
        }

        public void Output()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Muc luong: " + luong);
            Console.WriteLine("So ngay vang: " + soNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
    }

    class Bai12
    {
        public static void Chay()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            NhanVien[] ds = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("===== NHAN VIEN " + (i + 1) + " =====");

                ds[i] = new NhanVien();
                ds[i].Input();
            }

            double tongLuong = 0;

            Console.WriteLine();
            Console.WriteLine("===== DANH SACH NHAN VIEN =====");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                ds[i].Output();

                tongLuong += ds[i].TinhLuong();
            }

            Console.WriteLine();
            Console.WriteLine("Tong luong phong ban: " + tongLuong);
        }
    }
}
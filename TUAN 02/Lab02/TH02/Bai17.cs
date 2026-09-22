using System;

namespace TH02
{
    // Lớp cha
    class NhanVienCongTy
    {
        protected string maNV;
        protected string hoTen;

        public NhanVienCongTy()
        {
            maNV = "";
            hoTen = "";
        }

        public NhanVienCongTy(string maNV, string hoTen)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
        }

        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
        }

        public virtual double TinhLuong()
        {
            return 0;
        }

        public virtual void Output()
        {
            Console.WriteLine("Ma NV: " + maNV);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }


    // Nhân viên kinh doanh
    class NhanVienKinhDoanh : NhanVienCongTy
    {
        private double luongCoBan;
        private int soHopDong;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap luong co ban: ");
            luongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Nhap so hop dong: ");
            soHopDong = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            return luongCoBan + soHopDong * 500000;
        }
    }


    // Nhân viên sản xuất
    class NhanVienSanXuat : NhanVienCongTy
    {
        private int soSanPham;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap so san pham: ");
            soSanPham = int.Parse(Console.ReadLine());
        }

        public override double TinhLuong()
        {
            double luong = soSanPham * 1000;

            if (soSanPham > 3000)
                luong = luong * 1.05;

            return luong;
        }
    }


    class Bai17
    {
        public static void Chay()
        {
            Console.Write("Nhap so nhan vien: ");
            int n = int.Parse(Console.ReadLine());

            NhanVienCongTy[] ds = new NhanVienCongTy[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("===== NHAN VIEN " + (i + 1) + " =====");

                Console.WriteLine("1. Nhan vien kinh doanh");
                Console.WriteLine("2. Nhan vien san xuat");
                Console.Write("Chon loai nhan vien: ");

                int loai = int.Parse(Console.ReadLine());

                if (loai == 1)
                    ds[i] = new NhanVienKinhDoanh();
                else
                    ds[i] = new NhanVienSanXuat();

                ds[i].Input();
            }

            Console.WriteLine();
            Console.WriteLine("===== DANH SACH NHAN VIEN =====");

            double tongLuong = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan vien " + (i + 1));

                ds[i].Output();

                tongLuong += ds[i].TinhLuong();
            }

            Console.WriteLine();
            Console.WriteLine("Tong luong cong ty: " + tongLuong);
        }
    }
}
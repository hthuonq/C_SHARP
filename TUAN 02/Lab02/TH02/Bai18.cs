using System;

namespace TH02
{
    // Lớp cha
    class ThiSinh
    {
        protected string sbd;
        protected string hoTen;
        protected double bai1;
        protected double bai2;
        protected double bai3;

        public ThiSinh()
        {
            sbd = "";
            hoTen = "";
            bai1 = 0;
            bai2 = 0;
            bai3 = 0;
        }

        public virtual void Input()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap diem bai 1: ");
            bai1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 2: ");
            bai2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem bai 3: ");
            bai3 = double.Parse(Console.ReadLine());
        }

        public virtual double TinhTong()
        {
            return bai1 + bai2 + bai3;
        }

        public virtual void Output()
        {
            Console.WriteLine("So bao danh: " + sbd);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Bai 1: " + bai1);
            Console.WriteLine("Bai 2: " + bai2);
            Console.WriteLine("Bai 3: " + bai3);
            Console.WriteLine("Tong diem: " + TinhTong());
        }
    }


    // Thí sinh Chuyên
    class ThiSinhChuyen : ThiSinh
    {
        private double tiengAnh;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem Tieng Anh: ");
            tiengAnh = double.Parse(Console.ReadLine());
        }

        public override double TinhTong()
        {
            double tong = bai1 + bai2 + bai3 + tiengAnh;

            if (tiengAnh >= 7 && tiengAnh <= 8)
                tong += 1;
            else if (tiengAnh >= 9 && tiengAnh <= 10)
                tong += 2;

            return tong;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Tieng Anh: " + tiengAnh);
        }
    }


    // Thí sinh Siêu cúp
    class ThiSinhSieuCup : ThiSinh
    {
        private double coSoDuLieu;

        public override void Input()
        {
            base.Input();

            Console.Write("Nhap diem Co so du lieu: ");
            coSoDuLieu = double.Parse(Console.ReadLine());
        }

        public override double TinhTong()
        {
            return bai1 + bai2 + bai3 + coSoDuLieu;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Co so du lieu: " + coSoDuLieu);
        }
    }


    class Bai18
    {
        public static void Chay()
        {
            Console.Write("Nhap so luong thi sinh: ");
            int n = int.Parse(Console.ReadLine());

            ThiSinh[] ds = new ThiSinh[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("===== THI SINH " + (i + 1) + " =====");

                Console.WriteLine("1. Thi sinh Chuyen");
                Console.WriteLine("2. Thi sinh Sieu cup");
                Console.Write("Chon loai thi sinh: ");

                int loai = int.Parse(Console.ReadLine());

                if (loai == 1)
                    ds[i] = new ThiSinhChuyen();
                else
                    ds[i] = new ThiSinhSieuCup();

                ds[i].Input();
            }

            Console.WriteLine();
            Console.WriteLine("===== KET QUA =====");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("----- Thi sinh " + (i + 1) + " -----");

                ds[i].Output();
            }
        }
    }
}
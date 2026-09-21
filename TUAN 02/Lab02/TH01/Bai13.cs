using System;

namespace TH01
{
    class SinhVien
    {
        public string MaSV;
        public string HoTen;
        public string DiaChi;
        public int NamSinh;

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("----- THONG TIN SINH VIEN -----");
            Console.WriteLine("Ma sinh vien: " + MaSV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Nam sinh: " + NamSinh);
        }
    }

    class Bai13
    {
        public static void Chay()
        {
            SinhVien sv = new SinhVien();

            sv.Nhap();
            sv.Xuat();
        }
    }
}
using System;

namespace TH02
{
    class Bai01
    {
        public static void Chay()
        {
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            int tuoi = DateTime.Now.Year - namSinh;

            Console.WriteLine("----- THONG TIN SINH VIEN -----");
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Tuoi: " + tuoi);
        }
    }
}
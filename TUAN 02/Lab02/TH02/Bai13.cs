using System;

namespace TH02
{
    class SinhVien
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien(string hoTen, double diem)
        {
            HoTen = hoTen;
            Diem = diem;
        }

        public override string ToString()
        {
            return HoTen + " - " + Diem;
        }
    }

    class Bai13
    {
        public static void Chay()
        {
            SinhVien[] ds =
            {
                new SinhVien("An", 7.5),
                new SinhVien("Binh", 9.0),
                new SinhVien("Cuong", 6.5),
                new SinhVien("Dung", 8.0)
            };

            Console.WriteLine("===== DANH SACH BAN DAU =====");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);

            Array.Sort(ds, (a, b) => a.Diem.CompareTo(b.Diem));

            Console.WriteLine();
            Console.WriteLine("===== SAU KHI SAP XEP DIEM TANG DAN =====");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);
        }
    }
}
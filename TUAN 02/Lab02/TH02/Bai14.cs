using System;

namespace TH02
{
    interface ISoSanh
    {
        int SoSanh(object obj);
    }

    class SinhVien2 : ISoSanh
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien2(string hoTen, double diem)
        {
            HoTen = hoTen;
            Diem = diem;
        }

        public int SoSanh(object obj)
        {
            SinhVien2 sv = (SinhVien2)obj;

            if (Diem > sv.Diem)
                return 1;

            if (Diem < sv.Diem)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return HoTen + " - " + Diem;
        }
    }

    class SapXep
    {
        public static void Sort(object[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    ISoSanh x = (ISoSanh)a[i];

                    if (x.SoSanh(a[j]) > 0)
                    {
                        object temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }

    class Bai14
    {
        public static void Chay()
        {
            object[] ds =
            {
                new SinhVien2("An", 7.5),
                new SinhVien2("Binh", 9.0),
                new SinhVien2("Cuong", 6.5),
                new SinhVien2("Dung", 8.0)
            };

            Console.WriteLine("===== DANH SACH BAN DAU =====");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);

            SapXep.Sort(ds);

            Console.WriteLine();
            Console.WriteLine("===== SAU KHI SAP XEP =====");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);
        }
    }
}
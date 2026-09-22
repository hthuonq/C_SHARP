using System;

namespace TH02
{
    class SinhVien3
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien3(string hoTen, double diem)
        {
            HoTen = hoTen;
            Diem = diem;
        }

        public override string ToString()
        {
            return HoTen + " - " + Diem;
        }
    }

    delegate int SoSanhDoiTuong(object a, object b);

    class SapXepDelegate
    {
        public static void Sort(object[] a, SoSanhDoiTuong hamSoSanh)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (hamSoSanh(a[i], a[j]) > 0)
                    {
                        object temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }

    class Bai15
    {
        static int SoSanhTheoDiem(object a, object b)
        {
            SinhVien3 sv1 = (SinhVien3)a;
            SinhVien3 sv2 = (SinhVien3)b;

            if (sv1.Diem > sv2.Diem)
                return 1;

            if (sv1.Diem < sv2.Diem)
                return -1;

            return 0;
        }

        public static void Chay()
        {
            object[] ds =
            {
                new SinhVien3("An", 7.5),
                new SinhVien3("Binh", 9.0),
                new SinhVien3("Cuong", 6.5),
                new SinhVien3("Dung", 8.0)
            };

            Console.WriteLine("===== DANH SACH BAN DAU =====");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);

            SapXepDelegate.Sort(ds, SoSanhTheoDiem);

            Console.WriteLine();
            Console.WriteLine("===== SAU KHI SAP XEP =====");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine(ds[i]);
        }
    }
}
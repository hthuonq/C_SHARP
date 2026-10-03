using System;
using System.Linq;

namespace BaiThucHanhLINQ
{
    class bai5_2
    {
        public static void xuly()
        {
            var dsMon = DuLieu.DS_Mon();

            var cauA = dsMon.Count();
            Console.WriteLine("Cau a:");
            Console.WriteLine($"Tong so mon: {cauA}");

            var cauB = dsMon.Count(m => m.TenMon.StartsWith("Lập trình"));
            Console.WriteLine("Cau b:");
            Console.WriteLine($"So mon bat dau bang 'Lap trinh': {cauB}");

            var cauC = dsMon.Where(m => m.He == "KTV").Sum(m => m.SoTiet);
            Console.WriteLine("Cau c:");
            Console.WriteLine($"Tong so tiet he KTV: {cauC}");

            var cauD = from m in dsMon
                       group m by m.He into nhom
                       select new { He = nhom.Key, TongSoMon = nhom.Count() };
            Console.WriteLine("Cau d:");
            foreach (var x in cauD)
                Console.WriteLine($"He: {x.He} - Tong so mon: {x.TongSoMon}");

            var cauE = from m in dsMon
                       group m by m.SoTiet into nhom
                       orderby nhom.Key descending
                       select new { SoTiet = nhom.Key, TongSoMon = nhom.Count() };
            Console.WriteLine("Cau e:");
            foreach (var x in cauE)
                Console.WriteLine($"So tiet: {x.SoTiet} - Tong so mon: {x.TongSoMon}");

            var soTietCaoNhat = dsMon.Max(m => m.SoTiet);
            var cauF = dsMon.Where(m => m.SoTiet == soTietCaoNhat);
            Console.WriteLine("Cau f:");
            foreach (var m in cauF)
                Console.WriteLine($"{m.MaMon} - {m.TenMon} - {m.SoTiet} tiet");

            var cauG = from m in dsMon
                       group m by m.He into nhom
                       select new
                       {
                           He = nhom.Key,
                           TongSoMon = nhom.Count(),
                           TongSoTiet = nhom.Sum(x => x.SoTiet),
                           SoTietCaoNhat = nhom.Max(x => x.SoTiet),
                           SoTietThapNhat = nhom.Min(x => x.SoTiet)
                       };
            Console.WriteLine("Cau g:");
            foreach (var x in cauG)
                Console.WriteLine($"He: {x.He} - Tong mon: {x.TongSoMon} - Tong tiet: {x.TongSoTiet} - Cao nhat: {x.SoTietCaoNhat} - Thap nhat: {x.SoTietThapNhat}");

            var cauH = from m in dsMon
                       group m by m.He into nhom
                       select nhom;
            Console.WriteLine("Cau h:");
            foreach (var nhom in cauH)
            {
                Console.WriteLine($"He: {nhom.Key}");
                foreach (var m in nhom)
                    Console.WriteLine($"  - {m.MaMon} - {m.TenMon}");
            }

            var cauI = from m in dsMon
                       group m by m.SoTiet into nhom
                       orderby nhom.Key ascending
                       select nhom;
            Console.WriteLine("Cau i:");
            foreach (var nhom in cauI)
            {
                Console.WriteLine($"So tiet: {nhom.Key}");
                foreach (var m in nhom)
                    Console.WriteLine($"  - {m.MaMon} - {m.TenMon}");
            }

            var cauJ = from m in dsMon
                       where m.He == "KTV"
                       group m by m.MaMon.Split('_')[0] into nhom
                       orderby nhom.Key
                       select nhom;
            Console.WriteLine("Cau j:");
            foreach (var nhom in cauJ)
            {
                Console.WriteLine($"Hoc phan: {nhom.Key}");
                foreach (var m in nhom.OrderBy(x => x.MaMon))
                    Console.WriteLine($"  - {m.MaMon} - {m.TenMon}");
            }

            var cauK = from m in dsMon
                       where m.SoTiet > 40
                       group m by m.He into nhom
                       select nhom;
            Console.WriteLine("Cau k:");
            foreach (var nhom in cauK)
            {
                Console.WriteLine($"He: {nhom.Key}");
                foreach (var m in nhom.OrderBy(x => x.MaMon))
                    Console.WriteLine($"  - {m.MaMon} - {m.TenMon} - {m.SoTiet} tiet");
            }
        }
    }
}
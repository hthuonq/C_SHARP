using System;
using System.Linq;

namespace BaiThucHanhLINQ
{
    class bai5_1
    {
        public static void xuly()
        {
            var dsMon = DuLieu.DS_Mon();

            var cauA = from m in dsMon
                       where m.TenMon.StartsWith("Lập trình")
                       select m.TenMon;

            Console.WriteLine("Cau a:");
            foreach (var ten in cauA)
                Console.WriteLine($"- {ten}");

            var cauB = from m in dsMon
                       where m.He == "CD"
                       orderby m.SoTiet descending, m.MaMon ascending
                       select m;

            Console.WriteLine("Cau b:");
            foreach (var m in cauB)
                Console.WriteLine($"{m.MaMon} - {m.TenMon} - {m.SoTiet} tiet");

            var cauC = from m in dsMon
                       where m.TenMon.ToLower().Contains("web")
                       select new { m.TenMon, m.He };

            Console.WriteLine("Cau c:");
            foreach (var m in cauC)
                Console.WriteLine($"{m.TenMon} - He: {m.He}");

            var cauD = from m in dsMon
                       where m.He == "KTV"
                       orderby m.MaMon ascending
                       select m;

            Console.WriteLine("Cau d:");
            foreach (var m in cauD)
                Console.WriteLine($"{m.MaMon} - {m.TenMon}");
        }
    }
}
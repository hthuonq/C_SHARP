using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ
{
    class bai3_2
    {
        public static void xuly()
        {
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
                "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
                "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

            int doDaiMin = monAn.Min(m => m.Length);
            int doDaiMax = monAn.Max(m => m.Length);

            var cauA_NganNhat = from m in monAn
                                where m.Length == doDaiMin
                                select m;

            var cauA_DaiNhat = from m in monAn
                               where m.Length == doDaiMax
                               select m;

            Console.WriteLine("Cau a - Ngan nhat:");
            foreach (var m in cauA_NganNhat)
                Console.WriteLine($"- {m}");

            Console.WriteLine("Cau a - Dai nhat:");
            foreach (var m in cauA_DaiNhat)
                Console.WriteLine($"- {m}");

            var cauB = from m in monAn
                       group m by m.Split(' ')[0] into nhom
                       select nhom;

            Console.WriteLine("Cau b:");
            foreach (var nhom in cauB)
            {
                Console.WriteLine($"Nhom: {nhom.Key}");
                foreach (var m in nhom)
                    Console.WriteLine($"  - {m}");
            }

            var cauC = monAn.Count(m => m.Split(' ')[0] == "Bánh");

            Console.WriteLine("Cau c:");
            Console.WriteLine($"So mon bat dau bang 'Banh': {cauC}");
        }
    }
}
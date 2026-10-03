using System;
using System.Collections.Generic;
using System.Text;

namespace BaiThucHanhLINQ
{
    class bai3_1
    {
        public static void xuly()
        {
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
            var cauA = from so in mangSo
                       group so by so % 2 == 0 into nhom
                       select new { Nhom = nhom.Key ? "Chan" : "Le", SoLuong = nhom.Count() };

            Console.WriteLine("Cau a:");
            foreach (var result in cauA)
            {
                Console.WriteLine($"Nhom {result.Nhom}: {result.SoLuong} phần tử");
            }
            var cauB = new
            {
                Tong = mangSo.Sum(),
                LonNhat = mangSo.Max(),
                NhoNhat = mangSo.Min()
            };
            Console.WriteLine("Cau b:");
            Console.WriteLine($"Tong: {cauB.Tong}");
            Console.WriteLine($"Lon nhat: {cauB.LonNhat}");
            Console.WriteLine($"Nho nhat: {cauB.NhoNhat}");

        }
    }
}
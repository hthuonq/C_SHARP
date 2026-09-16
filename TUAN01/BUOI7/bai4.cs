using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI7
{
    class bai4
    {
        static bool namnhuan(int nam)
        {
            if (nam % 400 == 0) return true;
            if (nam % 100 == 0) return false;
            if (nam % 4 == 0) return true;
            return false;
        }
        static int songaytrongthang(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (namnhuan(nam)) return 29;
                    else return 28;
                default: return 0;
            }
        }
        public static void chay()
        {
            int ngay, thang, nam;
            int ngaytruoc, thangtruoc, namtruoc;
            Console.Write("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang= int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam=int.Parse(Console.ReadLine());

            if (ngay == 1)
            {
                if (thang == 1) {
                    ngaytruoc = 31;
                    thangtruoc = 12;
                    namtruoc = nam - 1;
                }
                else
                {
                    thangtruoc = thang - 1;
                    namtruoc = nam;
                    ngaytruoc = songaytrongthang(thangtruoc, namtruoc);
                }
            }
            else
            {
                ngaytruoc = ngay - 1;
                thangtruoc = thang;
                namtruoc = nam;
            }
            Console.WriteLine("Ngay truoc ngay {0}/{1}/{2} la ngay {3}/{4}/{5}", ngay, thang, nam, ngaytruoc, thangtruoc, namtruoc);
        }
    }
}
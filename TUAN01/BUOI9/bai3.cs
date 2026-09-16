using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI9
{
    class bai3
    {
        public static void chay()
        {
            int n;
            double[] a;
            int soduong = 0, soam = 0, sokhong = 0;
            Console.Write("nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            a= new double[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("phan tu 0: ", i);
                a[i] = double.Parse(Console.ReadLine());
            }
            for(int i=0; i<n; i++)
            {
                if (a[i] > 0) soduong++;
                else if (a[i] < 0) soam++;
                else sokhong++;
            }
             Console.WriteLine("day so co {0} so duong, {1} so am, {2} so khong",soduong,soam,sokhong);

        }

    }
}

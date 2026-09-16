using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI9
{
    class bai4
    {
        public static void chay()
        {
            int n;
            double[] a;
            double x;

            int dau = -1;
            int cuoi = -1;
            int solan = 0;

            Console.Write("nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            a = new double[n];

            for(int i=0; i<n; i++)
            {
                Console.Write("phan tu {0}: ", i);
                a[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("nhap gia tri x can tim: ");
            x = double.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                if (a[i] == x)
                {
                    solan++;
                    if(dau==-1)
                    {
                        dau = i;
                    }
                    else
                    {
                        cuoi = i;
                    }
                }
                
            }
            if (solan == 0)
            {
                Console.WriteLine("gia tri {0} khong ton tai trong day so", x);
            }
            else
            {
                Console.WriteLine("gia tri {0} xuat hien {1} lan ", x, solan);
                Console.WriteLine("vi tri gia tri {0} xuat hien dau tien tai {1}", x, dau);
                Console.WriteLine("vi tri gia tri {0} xuat hien cuoi cung tai {1} ", x, cuoi);
            }

        }
    }
}

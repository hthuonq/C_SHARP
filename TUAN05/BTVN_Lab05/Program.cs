using System;
using System.Windows.Forms;
using BTVN_Lab05.Forms;

namespace BTVN_Lab05
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Chạy Form Main tổng hợp toàn bộ bài tập
            Application.Run(new FrmMain());
        }
    }
}
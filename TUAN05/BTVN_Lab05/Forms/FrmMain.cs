using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTVN_Lab05.Forms
{
    public partial class FrmMain : Form
    {
        private MenuStrip menuStripMain;

        public FrmMain()
        {
            KhoiTaoGiaoDien();
        }

        private void KhoiTaoGiaoDien()
        {
            this.Text = "BTVN Tuan 05 - Tong Hop Bai Tap WinForms";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true; // Cho phép mở các Form con bên trong Form Main

            // Khởi tạo MenuStrip
            menuStripMain = new MenuStrip();

            // --- Menu 1: Lab 05c ---
            ToolStripMenuItem menuLab05c = new ToolStripMenuItem("Lab 05c (Adv Control)");
            ToolStripMenuItem itemTuDien = new ToolStripMenuItem("Bài 1: Từ điển Anh - Việt", null, (s, e) => MoFormCon(new FrmTuDien()));
            ToolStripMenuItem itemListBox = new ToolStripMenuItem("Bài 2: Thao tác ListBox", null, (s, e) => MoFormCon(new FrmListBoxNumbers()));
            ToolStripMenuItem itemDanhBa = new ToolStripMenuItem("Bài 3: Danh bạ TreeView A-Z", null, (s, e) => MoFormCon(new FrmDanhBaTreeView()));
            
            menuLab05c.DropDownItems.Add(itemTuDien);
            menuLab05c.DropDownItems.Add(itemListBox);
            menuLab05c.DropDownItems.Add(itemDanhBa);

            // --- Menu 2: Lab 05d ---
            ToolStripMenuItem menuLab05d = new ToolStripMenuItem("Lab 05d (Timer & CSDL)");
            ToolStripMenuItem itemDemNguoc = new ToolStripMenuItem("Bài 1: Đồng hồ đếm ngược", null, (s, e) => MoFormCon(new FrmDemNguoc()));
            ToolStripMenuItem itemQuanLyLop = new ToolStripMenuItem("Bài tập CSDL: Quản lý Lớp", null, (s, e) => MoFormCon(new FrmQuanLyLop()));

            menuLab05d.DropDownItems.Add(itemDemNguoc);
            menuLab05d.DropDownItems.Add(itemQuanLyLop);

            // --- Menu 3: Hệ thống / Thoát ---
            ToolStripMenuItem menuHeThong = new ToolStripMenuItem("Hệ thống");
            ToolStripMenuItem itemThoat = new ToolStripMenuItem("Thoát", null, (s, e) => {
                if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            });
            menuHeThong.DropDownItems.Add(itemThoat);

            // Đưa các menu vào MenuStrip chính
            menuStripMain.Items.Add(menuLab05c);
            menuStripMain.Items.Add(menuLab05d);
            menuStripMain.Items.Add(menuHeThong);

            this.MainMenuStrip = menuStripMain;
            this.Controls.Add(menuStripMain);
        }

        /// <summary>
        /// Hàm hỗ trợ mở Form con theo dạng MDI hoặc Modal
        /// </summary>
        private void MoFormCon(Form formCon)
        {
            formCon.MdiParent = this;
            formCon.Show();
        }
    }
}
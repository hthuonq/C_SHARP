using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BTVN_Lab05.Forms
{
    public partial class FrmTuDien : Form
    {
        // Lớp cấu trúc lưu trữ dữ liệu Từ vựng - Nghĩa
        public class WordItem
        {
            public string Word { get; set; } = string.Empty;
            public string Meaning { get; set; } = string.Empty;

            public override string ToString()
            {
                return Word;
            }
        }

        // Danh sách từ vựng dữ liệu mẫu
        private List<WordItem> listAnhViet = new List<WordItem>();
        private List<WordItem> listVietAnh = new List<WordItem>();

        public FrmTuDien()
        {
            // Bỏ InitializeComponent(); vì khởi tạo giao diện hoàn toàn bằng code bên dưới
            KhoiTaoDuLieu();
            KhoiTaoGiaoDien();
        }

        /// <summary>
        /// Khởi tạo dữ liệu từ điển ban đầu
        /// </summary>
        private void KhoiTaoDuLieu()
        {
            // Dữ liệu Anh - Việt
            listAnhViet.Add(new WordItem { Word = "cat", Meaning = "Mèo, con mèo" });
            listAnhViet.Add(new WordItem { Word = "dog", Meaning = "Chó, con chó" });
            listAnhViet.Add(new WordItem { Word = "frog", Meaning = "Con ếch" });
            listAnhViet.Add(new WordItem { Word = "hat", Meaning = "Cái nón, cái mũ" });
            listAnhViet.Add(new WordItem { Word = "head", Meaning = "Cái đầu" });
            listAnhViet.Add(new WordItem { Word = "loan", Meaning = "Khoản vay, sự cho vay" });
            listAnhViet.Add(new WordItem { Word = "mouse", Meaning = "Con chuột" });
            listAnhViet.Add(new WordItem { Word = "sheep", Meaning = "Con cừu" });
            listAnhViet.Add(new WordItem { Word = "snake", Meaning = "Con rắn" });
            listAnhViet.Add(new WordItem { Word = "student", Meaning = "Sinh viên, học sinh" });
            listAnhViet.Add(new WordItem { Word = "teacher", Meaning = "Giáo viên, thầy cô giáo" });
            listAnhViet.Add(new WordItem { Word = "worker", Meaning = "Công nhân, người lao động" });

            // Dữ liệu Việt - Anh
            listVietAnh.Add(new WordItem { Word = "chó", Meaning = "dog" });
            listVietAnh.Add(new WordItem { Word = "công nhân", Meaning = "worker" });
            listVietAnh.Add(new WordItem { Word = "giáo viên", Meaning = "teacher" });
            listVietAnh.Add(new WordItem { Word = "học sinh", Meaning = "student, pupil" });
            listVietAnh.Add(new WordItem { Word = "mèo", Meaning = "cat" });
            listVietAnh.Add(new WordItem { Word = "sinh viên", Meaning = "student" });
        }

        /// <summary>
        /// Khởi tạo các Control và thiết lập giao diện bằng Code
        /// </summary>
        private void KhoiTaoGiaoDien()
        {
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.Size = new System.Drawing.Size(550, 420);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. TabControl chứa 2 Tab Anh - Việt và Việt - Anh
            TabControl tabTuDien = new TabControl { Dock = DockStyle.Top, Height = 310 };
            TabPage tabAV = new TabPage("ANH - VIỆT");
            TabPage tabVA = new TabPage("VIỆT - ANH");

            // Thiết lập nội dung cho Tab Anh - Việt
            TaoGiaoDienTab(tabAV, listAnhViet, "Tiếng Anh", "Tiếng Việt");
            // Thiết lập nội dung cho Tab Việt - Anh
            TaoGiaoDienTab(tabVA, listVietAnh, "Tiếng Việt", "Tiếng Anh");

            tabTuDien.TabPages.Add(tabAV);
            tabTuDien.TabPages.Add(tabVA);

            // 2. Button Thoát
            Button btnThoat = new Button
            {
                Text = "Thoát",
                Size = new System.Drawing.Size(90, 30),
                Location = new System.Drawing.Point(420, 325)
            };
            btnThoat.Click += (s, e) => {
                if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            };

            this.Controls.Add(tabTuDien);
            this.Controls.Add(btnThoat);
        }

        /// <summary>
        /// Tạo bố cục và gắn sự kiện cho từng Tab Từ điển
        /// </summary>
        private void TaoGiaoDienTab(TabPage tab, List<WordItem> dataList, string labelLeftText, string labelRightText)
        {
            Label lblSearch = new Label { Text = labelLeftText, Location = new System.Drawing.Point(20, 15), AutoSize = true };
            TextBox txtSearch = new TextBox { Location = new System.Drawing.Point(20, 35), Width = 200 };
            ListBox lstWords = new ListBox { Location = new System.Drawing.Point(20, 65), Size = new System.Drawing.Size(200, 180) };

            Label lblMeaning = new Label { Text = labelRightText, Location = new System.Drawing.Point(240, 15), AutoSize = true };
            RichTextBox txtMeaning = new RichTextBox { Location = new System.Drawing.Point(240, 35), Size = new System.Drawing.Size(260, 210), ReadOnly = true };

            // Hiển thị danh sách từ ban đầu
            lstWords.DataSource = dataList.ToList();

            // Xử lý sự kiện Tìm kiếm gần đúng khi gõ chữ vào TextBox
            txtSearch.TextChanged += (s, e) =>
            {
                string keyword = txtSearch.Text.Trim().ToLower();
                var filtered = dataList.Where(w => w.Word.ToLower().StartsWith(keyword)).ToList();
                lstWords.DataSource = filtered;

                if (filtered.Count > 0)
                {
                    lstWords.SelectedIndex = 0;
                }
            };

            // Sự kiện nhấn phím Enter trên ô Tìm kiếm
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && lstWords.SelectedItem != null)
                {
                    WordItem selected = (WordItem)lstWords.SelectedItem;
                    txtMeaning.Text = selected.Meaning;
                    e.SuppressKeyPress = true;
                }
            };

            // Sự kiện Double Click hoặc Chọn từ trên ListBox để hiển thị nghĩa
            lstWords.DoubleClick += (s, e) =>
            {
                if (lstWords.SelectedItem != null)
                {
                    WordItem selected = (WordItem)lstWords.SelectedItem;
                    txtMeaning.Text = selected.Meaning;
                }
            };

            lstWords.SelectedIndexChanged += (s, e) =>
            {
                if (lstWords.SelectedItem != null)
                {
                    WordItem selected = (WordItem)lstWords.SelectedItem;
                    txtMeaning.Text = selected.Meaning;
                }
            };

            tab.Controls.Add(lblSearch);
            tab.Controls.Add(txtSearch);
            tab.Controls.Add(lstWords);
            tab.Controls.Add(lblMeaning);
            tab.Controls.Add(txtMeaning);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BTVN_Lab05.Forms
{
    public partial class FrmListBoxNumbers : Form
    {
        private ListBox lstNumbers;
        private TextBox txtInput;
        private Button btnNhap;

        public FrmListBoxNumbers()
        {
            KhoiTaoGiaoDien();
        }

        private void KhoiTaoGiaoDien()
        {
            this.Text = "Xử lý ListBox";
            this.Size = new Size(520, 430);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Header Title
            Label lblTitle = new Label
            {
                Text = "LISTBOX",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.OrangeRed,
                AutoSize = true,
                Location = new Point(200, 10)
            };

            // GroupBox Nhập và Danh sách
            GroupBox grpListBox = new GroupBox
            {
                Text = "ListBox",
                Location = new Point(15, 45),
                Size = new Size(220, 300)
            };

            txtInput = new TextBox { Location = new Point(15, 25), Width = 190 };
            btnNhap = new Button { Text = "Nhập", Location = new Point(15, 55), Width = 190, Height = 30 };

            lstNumbers = new ListBox
            {
                Location = new Point(15, 95),
                Size = new Size(190, 190),
                SelectionMode = SelectionMode.MultiExtended // Cho phép chọn nhiều dòng
            };

            // Nạp dữ liệu mẫu ban đầu
            int[] defaultData = { 30, 21, 35, 43, 1, 3, 20, 9, 4, 80 };
            foreach (int num in defaultData)
            {
                lstNumbers.Items.Add(num);
            }

            grpListBox.Controls.Add(txtInput);
            grpListBox.Controls.Add(btnNhap);
            grpListBox.Controls.Add(lstNumbers);

            // GroupBox Xử lý ListBox
            GroupBox grpXuLy = new GroupBox
            {
                Text = "Xử lý ListBox",
                Location = new Point(250, 45),
                Size = new Size(240, 300)
            };

            Button btnTong = new Button { Text = "Tổng các phần tử trong List", Location = new Point(15, 25), Size = new Size(210, 30) };
            Button btnXoaDauCuoi = new Button { Text = "Xóa Phần tử đầu và cuối", Location = new Point(15, 60), Size = new Size(210, 30) };
            Button btnXoaChon = new Button { Text = "Xóa Phần tử đang chọn", Location = new Point(15, 95), Size = new Size(210, 30) };
            Button btnTang2 = new Button { Text = "Tăng mỗi phần tử lên 2", Location = new Point(15, 130), Size = new Size(210, 30) };
            Button btnBinhPhuong = new Button { Text = "Thay bằng bình phương", Location = new Point(15, 165), Size = new Size(210, 30) };
            Button btnChonChan = new Button { Text = "Chọn số chẵn", Location = new Point(15, 200), Size = new Size(210, 30) };
            Button btnChonLe = new Button { Text = "Chọn số lẻ", Location = new Point(15, 235), Size = new Size(210, 30) };

            grpXuLy.Controls.Add(btnTong);
            grpXuLy.Controls.Add(btnXoaDauCuoi);
            grpXuLy.Controls.Add(btnXoaChon);
            grpXuLy.Controls.Add(btnTang2);
            grpXuLy.Controls.Add(btnBinhPhuong);
            grpXuLy.Controls.Add(btnChonChan);
            grpXuLy.Controls.Add(btnChonLe);

            // Button KẾT THÚC
            Button btnKetThuc = new Button
            {
                Text = "KẾT THÚC",
                Location = new Point(15, 350),
                Size = new Size(475, 35),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // --- GẮN CÁC SỰ KIỆN XỬ LÝ ---

            // 1. Thêm số vào ListBox
            btnNhap.Click += (s, e) =>
            {
                if (int.TryParse(txtInput.Text.Trim(), out int val))
                {
                    lstNumbers.Items.Add(val);
                    txtInput.Clear();
                    txtInput.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số tự nhiên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // 2. Tính tổng các phần tử
            btnTong.Click += (s, e) =>
            {
                int sum = 0;
                foreach (var item in lstNumbers.Items)
                {
                    sum += Convert.ToInt32(item);
                }
                MessageBox.Show($"Tổng các phần tử trong ListBox là: {sum}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // 3. Xóa phần tử đầu và cuối
            btnXoaDauCuoi.Click += (s, e) =>
            {
                if (lstNumbers.Items.Count == 0) return;

                if (lstNumbers.Items.Count == 1)
                {
                    lstNumbers.Items.RemoveAt(0);
                }
                else
                {
                    lstNumbers.Items.RemoveAt(lstNumbers.Items.Count - 1); // Xóa cuối trước để không sai index
                    lstNumbers.Items.RemoveAt(0);                          // Xóa đầu
                }
            };

            // 4. Xóa phần tử đang chọn
            btnXoaChon.Click += (s, e) =>
            {
                while (lstNumbers.SelectedItems.Count > 0)
                {
                    lstNumbers.Items.Remove(lstNumbers.SelectedItems[0]);
                }
            };

            // 5. Tăng mỗi phần tử lên 2
            btnTang2.Click += (s, e) =>
            {
                for (int i = 0; i < lstNumbers.Items.Count; i++)
                {
                    int val = Convert.ToInt32(lstNumbers.Items[i]);
                    lstNumbers.Items[i] = val + 2;
                }
            };

            // 6. Thay bằng bình phương
            btnBinhPhuong.Click += (s, e) =>
            {
                for (int i = 0; i < lstNumbers.Items.Count; i++)
                {
                    int val = Convert.ToInt32(lstNumbers.Items[i]);
                    lstNumbers.Items[i] = val * val;
                }
            };

            // 7. Chọn các số chẵn
            btnChonChan.Click += (s, e) =>
            {
                lstNumbers.ClearSelected();
                for (int i = 0; i < lstNumbers.Items.Count; i++)
                {
                    int val = Convert.ToInt32(lstNumbers.Items[i]);
                    if (val % 2 == 0)
                    {
                        lstNumbers.SetSelected(i, true);
                    }
                }
            };

            // 8. Chọn các số lẻ
            btnChonLe.Click += (s, e) =>
            {
                lstNumbers.ClearSelected();
                for (int i = 0; i < lstNumbers.Items.Count; i++)
                {
                    int val = Convert.ToInt32(lstNumbers.Items[i]);
                    if (val % 2 != 0)
                    {
                        lstNumbers.SetSelected(i, true);
                    }
                }
            };

            // 9. Kết thúc
            btnKetThuc.Click += (s, e) => this.Close();

            // Thêm các controls vào Form
            this.Controls.Add(lblTitle);
            this.Controls.Add(grpListBox);
            this.Controls.Add(grpXuLy);
            this.Controls.Add(btnKetThuc);
        }
    }
}
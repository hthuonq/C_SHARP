using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTVN_Lab05.Forms
{
    public partial class FrmDanhBaTreeView : Form
    {
        private TreeView trvDanhBa;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnExit;

        public FrmDanhBaTreeView()
        {
            KhoiTaoGiaoDien();
            KhoiTaoDanhSachAZ();
        }

        /// <summary>
        /// Khởi tạo giao diện các Control
        /// </summary>
        private void KhoiTaoGiaoDien()
        {
            this.Text = "Quan Ly Danh Ba";
            this.Size = new Size(500, 380);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. TreeView bên trái chứa cây chữ cái A - Z
            trvDanhBa = new TreeView
            {
                Location = new Point(12, 12),
                Size = new Size(180, 310)
            };

            // 2. GroupBox chứa các ô nhập liệu bên phải
            GroupBox grpInput = new GroupBox
            {
                Location = new Point(205, 12),
                Size = new Size(265, 230)
            };

            Label lblFirstName = new Label { Text = "First Name", Location = new Point(15, 30), AutoSize = true };
            txtFirstName = new TextBox { Location = new Point(95, 27), Width = 150 };

            Label lblLastName = new Label { Text = "Last Name", Location = new Point(15, 70), AutoSize = true };
            txtLastName = new TextBox { Location = new Point(95, 67), Width = 150 };

            btnAdd = new Button
            {
                Text = "Add",
                Location = new Point(150, 110),
                Size = new Size(95, 30)
            };

            grpInput.Controls.Add(lblFirstName);
            grpInput.Controls.Add(txtFirstName);
            grpInput.Controls.Add(lblLastName);
            grpInput.Controls.Add(txtLastName);
            grpInput.Controls.Add(btnAdd);

            // 3. Button Exit
            btnExit = new Button
            {
                Text = "Exit",
                Location = new Point(355, 290),
                Size = new Size(115, 32)
            };

            // --- GẮN SỰ KIỆN ---
            btnAdd.Click += BtnAdd_Click;
            btnExit.Click += (s, e) => this.Close();

            // Đưa các Control vào Form
            this.Controls.Add(trvDanhBa);
            this.Controls.Add(grpInput);
            this.Controls.Add(btnExit);
        }

        /// <summary>
        /// Tạo các Node gốc từ A đến Z trên TreeView
        /// </summary>
        private void KhoiTaoDanhSachAZ()
        {
            trvDanhBa.Nodes.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                trvDanhBa.Nodes.Add(c.ToString());
            }
        }

        /// <summary>
        /// Xử lý thêm liên hệ vào đúng Node ký tự đầu tiên của First Name
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Vui lòng nhập First Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            // Lấy chữ cái đầu tiên của First Name và chuyển thành chữ hoa
            char firstChar = char.ToUpper(firstName[0]);

            // Định dạng chuỗi hiển thị: "First Name, Last Name" (hoặc chỉ First Name nếu Last Name rỗng)
            string contactInfo = string.IsNullOrEmpty(lastName) ? firstName : $"{firstName}, {lastName}";

            // Tìm Node ký tự tương ứng
            TreeNode targetNode = null;
            foreach (TreeNode node in trvDanhBa.Nodes)
            {
                if (node.Text == firstChar.ToString())
                {
                    targetNode = node;
                    break;
                }
            }

            if (targetNode != null)
            {
                // Thêm liên hệ vào Node tìm được
                TreeNode newNode = targetNode.Nodes.Add(contactInfo);
                targetNode.Expand(); // Mở rộng nhánh để nhìn thấy người vừa thêm
                trvDanhBa.SelectedNode = newNode; // Highlight dòng vừa thêm

                // Xóa trắng ô nhập liệu
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
            else
            {
                MessageBox.Show("Tên không bắt đầu bằng chữ cái từ A-Z hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
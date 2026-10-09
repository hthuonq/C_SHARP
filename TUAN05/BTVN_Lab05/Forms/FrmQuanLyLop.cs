using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace BTVN_Lab05.Forms
{
    public partial class FrmQuanLyLop : Form
    {
        private TextBox txtMaKhoa;
        private TextBox txtMaLop;
        private TextBox txtTenLop;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;

        // Tên file CSDL SQLite tự động tạo tại thư mục chạy
        private string connectionString = "Data Source=QLSinhVien.db";

        public FrmQuanLyLop()
        {
            KhoiTaoGiaoDien();
            KhoiTaoDatabase(); // Tự động tạo CSDL & bảng nếu chưa có
        }

        /// <summary>
        /// Khởi tạo file CSDL SQLite và bảng Lop tự động
        /// </summary>
        private void KhoiTaoDatabase()
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"
                        CREATE TABLE IF NOT EXISTS Lop (
                            MaKhoa TEXT NOT NULL,
                            MaLop TEXT PRIMARY KEY NOT NULL,
                            TenLop TEXT NOT NULL
                        );";
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhoiTaoGiaoDien()
        {
            this.Text = "frmLop";
            this.Size = new Size(380, 260);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblMaKhoa = new Label { Text = "Mã khoa", Location = new Point(30, 25), AutoSize = true };
            txtMaKhoa = new TextBox { Location = new Point(120, 22), Width = 200 };

            Label lblMaLop = new Label { Text = "Mã lớp", Location = new Point(30, 65), AutoSize = true };
            txtMaLop = new TextBox { Location = new Point(120, 62), Width = 200 };

            Label lblTenLop = new Label { Text = "Tên lớp", Location = new Point(30, 105), AutoSize = true };
            txtTenLop = new TextBox { Location = new Point(120, 102), Width = 200 };

            btnThem = new Button { Text = "Thêm", Location = new Point(30, 155), Size = new Size(80, 32) };
            btnXoa = new Button { Text = "Xóa", Location = new Point(140, 155), Size = new Size(80, 32) };
            btnSua = new Button { Text = "Sửa", Location = new Point(250, 155), Size = new Size(80, 32) };

            btnThem.Click += BtnThem_Click;
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;

            this.Controls.Add(lblMaKhoa);
            this.Controls.Add(txtMaKhoa);
            this.Controls.Add(lblMaLop);
            this.Controls.Add(txtMaLop);
            this.Controls.Add(lblTenLop);
            this.Controls.Add(txtTenLop);
            this.Controls.Add(btnThem);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnSua);
        }

        // 1. Chức năng Thêm Lớp
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Mã khoa, Mã lớp, Tên lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES (@MaKhoa, @MaLop, @TenLop)";
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Chức năng Xóa Lớp
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "DELETE FROM Lop WHERE MaLop = @MaLop";
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy Mã lớp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Chức năng Sửa Lớp
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) && string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Mã khoa hoặc Tên lớp phải có ít nhất 1 trường có dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE Lop SET MaKhoa = COALESCE(NULLIF(@MaKhoa, ''), MaKhoa), TenLop = COALESCE(NULLIF(@TenLop, ''), TenLop) WHERE MaLop = @MaLop";
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy Mã lớp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Focus();
        }
    }
}
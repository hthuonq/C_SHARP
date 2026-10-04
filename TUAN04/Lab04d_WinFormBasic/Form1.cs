namespace Lab04d_WinFormBasic;

public partial class Form1 : Form
{
    // Khai báo các Control nhập liệu
    private TextBox txtHoTen = new TextBox();
    private TextBox txtDiaChi = new TextBox();
    private TextBox txtSoNgayO = new TextBox();
    
    // Loại phòng
    private RadioButton rdoPhongDon = new RadioButton();
    private RadioButton rdoPhongDoi = new RadioButton();
    private RadioButton rdoPhongBa = new RadioButton();

    // Tiện nghi
    private CheckBox chkTivi = new CheckBox();
    private CheckBox chkInternet = new CheckBox();
    private CheckBox chkMayNuocNong = new CheckBox();

    // Dịch vụ
    private CheckBox chkKaraoke = new CheckBox();
    private CheckBox chkAnSang = new CheckBox();

    // Kết quả & Thống kê
    private Label lblThanhTien = new Label();
    private Label lblSoLuotNguoi = new Label();
    private Label lblTongSoTien = new Label();

    // Các nút chức năng
    private Button btnThanhToan = new Button();
    private Button btnNhapMoi = new Button();
    private Button btnTongKet = new Button();
    private Button btnThoat = new Button();

    // Biến lưu tổng kết
    private int tongSoLuotKhach = 0;
    private double tongTienThuDuoc = 0;

    public Form1()
    {
        InitializeComponentCustom();
    }

    private void InitializeComponentCustom()
    {
        this.Text = "Khách Sạn Thanh Thanh - Trả Phòng";
        this.Size = new Size(580, 520);
        this.StartPosition = FormStartPosition.CenterScreen;

        Label lblTitle = new Label 
        { 
            Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG", 
            Font = new Font("Arial", 13, FontStyle.Bold), 
            ForeColor = Color.Red, 
            Location = new Point(100, 10), 
            AutoSize = true 
        };

        // Thông tin khách hàng
        Label lblName = new Label { Text = "Họ và tên:", Location = new Point(20, 50), AutoSize = true };
        txtHoTen.Location = new Point(100, 47); txtHoTen.Size = new Size(200, 23);

        Label lblAddress = new Label { Text = "Địa chỉ:", Location = new Point(20, 85), AutoSize = true };
        txtDiaChi.Location = new Point(100, 82); txtDiaChi.Size = new Size(200, 23);

        Label lblDays = new Label { Text = "Số ngày ở:", Location = new Point(20, 120), AutoSize = true };
        txtSoNgayO.Location = new Point(100, 117); txtSoNgayO.Size = new Size(200, 23);

        // GroupBox Loại phòng
        GroupBox gbLoaiPhong = new GroupBox { Text = "Loại phòng", Location = new Point(20, 155), Size = new Size(160, 110) };
        rdoPhongDon.Text = "Phòng đơn"; rdoPhongDon.Location = new Point(10, 20); rdoPhongDon.Checked = true;
        rdoPhongDoi.Text = "Phòng đôi"; rdoPhongDoi.Location = new Point(10, 48);
        rdoPhongBa.Text = "Phòng ba"; rdoPhongBa.Location = new Point(10, 76);
        gbLoaiPhong.Controls.AddRange(new Control[] { rdoPhongDon, rdoPhongDoi, rdoPhongBa });

        // GroupBox Tiện nghi
        GroupBox gbTienNghi = new GroupBox { Text = "Tiện nghi", Location = new Point(190, 155), Size = new Size(160, 110) };
        chkTivi.Text = "Tivi"; chkTivi.Location = new Point(10, 20);
        chkInternet.Text = "Internet"; chkInternet.Location = new Point(10, 48);
        chkMayNuocNong.Text = "Máy nước nóng"; chkMayNuocNong.Location = new Point(10, 76);
        gbTienNghi.Controls.AddRange(new Control[] { chkTivi, chkInternet, chkMayNuocNong });

        // GroupBox Dịch vụ
        GroupBox gbDichVu = new GroupBox { Text = "Dịch vụ", Location = new Point(360, 155), Size = new Size(170, 110) };
        chkKaraoke.Text = "Karaoke"; chkKaraoke.Location = new Point(10, 20);
        chkAnSang.Text = "Ăn sáng"; chkAnSang.Location = new Point(10, 48);
        gbDichVu.Controls.AddRange(new Control[] { chkKaraoke, chkAnSang });

        // Thành tiền
        Label lblTTText = new Label { Text = "Thành tiền:", Location = new Point(20, 280), Font = new Font("Arial", 10, FontStyle.Bold), AutoSize = true };
        lblThanhTien.Text = "0 VND"; lblThanhTien.Location = new Point(110, 280); lblThanhTien.Font = new Font("Arial", 10, FontStyle.Bold); lblThanhTien.ForeColor = Color.Blue; lblThanhTien.AutoSize = true;

        // GroupBox Thông tin tổng kết
        GroupBox gbTongKet = new GroupBox { Text = "Thông tin tổng kết", Location = new Point(20, 315), Size = new Size(510, 80) };
        Label lblSLText = new Label { Text = "Số lượt người:", Location = new Point(20, 30), AutoSize = true };
        lblSoLuotNguoi.Text = "0"; lblSoLuotNguoi.Location = new Point(120, 30); lblSoLuotNguoi.AutoSize = true;

        Label lblSTText = new Label { Text = "Tổng số tiền:", Location = new Point(250, 30), AutoSize = true };
        lblTongSoTien.Text = "0 VND"; lblTongSoTien.Location = new Point(340, 30); lblTongSoTien.AutoSize = true;
        gbTongKet.Controls.AddRange(new Control[] { lblSLText, lblSoLuotNguoi, lblSTText, lblTongSoTien });

        // Nút bấm
        btnThanhToan.Text = "Thanh toán"; btnThanhToan.Location = new Point(40, 415); btnThanhToan.Size = new Size(100, 35); btnThanhToan.Enabled = false;
        btnNhapMoi.Text = "Nhập mới"; btnNhapMoi.Location = new Point(160, 415); btnNhapMoi.Size = new Size(100, 35); btnNhapMoi.Enabled = false;
        btnTongKet.Text = "Tổng Kết"; btnTongKet.Location = new Point(280, 415); btnTongKet.Size = new Size(100, 35); btnTongKet.Enabled = false;
        btnThoat.Text = "Thoát"; btnThoat.Location = new Point(400, 415); btnThoat.Size = new Size(100, 35);

        // Đăng ký sự kiện
        txtHoTen.TextChanged += KiemTraInput;
        txtSoNgayO.TextChanged += KiemTraInput;

        btnThanhToan.Click += BtnThanhToan_Click;
        btnNhapMoi.Click += BtnNhapMoi_Click;
        btnTongKet.Click += BtnTongKet_Click;
        btnThoat.Click += (s, e) => this.Close();
        this.FormClosing += Form1_FormClosing;

        this.Controls.AddRange(new Control[] { 
            lblTitle, lblName, txtHoTen, lblAddress, txtDiaChi, lblDays, txtSoNgayO, 
            gbLoaiPhong, gbTienNghi, gbDichVu, lblTTText, lblThanhTien, gbTongKet,
            btnThanhToan, btnNhapMoi, btnTongKet, btnThoat 
        });
    }

    private void KiemTraInput(object? sender, EventArgs e)
    {
        btnThanhToan.Enabled = !string.IsNullOrWhiteSpace(txtHoTen.Text) && 
                               int.TryParse(txtSoNgayO.Text, out int n) && n > 0;
    }

    private void BtnThanhToan_Click(object? sender, EventArgs e)
    {
        int soNgay = int.Parse(txtSoNgayO.Text);
        double giaPhong = 0;

        if (rdoPhongDon.Checked) giaPhong = 300000;
        else if (rdoPhongDoi.Checked) giaPhong = 350000;
        else if (rdoPhongBa.Checked) giaPhong = 400000;

        int tienNghiCount = 0;
        if (chkTivi.Checked) tienNghiCount++;
        if (chkInternet.Checked) tienNghiCount++;
        if (chkMayNuocNong.Checked) tienNghiCount++;

        double giaTienNghi = tienNghiCount * 10000;

        double giaDichVu = 0;
        if (chkKaraoke.Checked) giaDichVu += 50000;
        if (chkAnSang.Checked) giaDichVu += 15000 * soNgay;

        double tongTienKhach = (giaPhong + giaTienNghi) * soNgay + giaDichVu;
        lblThanhTien.Text = $"{tongTienKhach:N0} VND";

        // Cập nhật biến tích lũy
        tongSoLuotKhach++;
        tongTienThuDuoc += tongTienKhach;

        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;
    }

    private void BtnNhapMoi_Click(object? sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtDiaChi.Clear();
        txtSoNgayO.Clear();
        rdoPhongDon.Checked = true;
        chkTivi.Checked = false; chkInternet.Checked = false; chkMayNuocNong.Checked = false;
        chkKaraoke.Checked = false; chkAnSang.Checked = false;
        lblThanhTien.Text = "0 VND";
        btnNhapMoi.Enabled = false;
        btnThanhToan.Enabled = false;
        txtHoTen.Focus();
    }

    private void BtnTongKet_Click(object? sender, EventArgs e)
    {
        lblSoLuotNguoi.Text = tongSoLuotKhach.ToString();
        lblTongSoTien.Text = $"{tongTienThuDuoc:N0} VND";

        // Reset về 0 sau khi bấm tổng kết
        tongSoLuotKhach = 0;
        tongTienThuDuoc = 0;
        btnTongKet.Enabled = false;
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
    }
}
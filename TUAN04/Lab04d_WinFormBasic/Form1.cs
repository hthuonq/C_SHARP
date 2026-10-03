namespace Lab04d_WinFormBasic;

public partial class Form1 : Form
{
    // 1. Khai báo các thành phần trên giao diện
    private RadioButton rdoBacNhat = new RadioButton();
    private RadioButton rdoBacHai = new RadioButton();
    private TextBox txtA = new TextBox();
    private TextBox txtB = new TextBox();
    private TextBox txtC = new TextBox();
    private TextBox txtKetQua = new TextBox();
    private Button btnGiai = new Button();
    private Button btnThoat = new Button();
    private Label lblC = new Label();

    public Form1()
    {
        InitializeComponentCustom();
    }

    private void InitializeComponentCustom()
    {
        this.Text = "Giải phương trình bậc 1-2";
        this.Size = new Size(380, 420);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Tiêu đề
        Label lblTitle = new Label 
        { 
            Text = "GIẢI PHƯƠNG TRÌNH", 
            Font = new Font("Arial", 14, FontStyle.Bold), 
            ForeColor = Color.Red, 
            Location = new Point(80, 15), 
            AutoSize = true 
        };

        // GroupBox chọn loại phương trình
        GroupBox gbChon = new GroupBox { Text = "Bạn vui lòng chọn", Location = new Point(20, 50), Size = new Size(320, 80) };
        rdoBacNhat.Text = "Phương trình bậc nhất"; rdoBacNhat.Location = new Point(20, 25); rdoBacNhat.AutoSize = true; rdoBacNhat.Checked = true;
        rdoBacHai.Text = "Phương trình bậc hai"; rdoBacHai.Location = new Point(20, 50); rdoBacHai.AutoSize = true;
        gbChon.Controls.Add(rdoBacNhat);
        gbChon.Controls.Add(rdoBacHai);

        // Các ô nhập liệu
        Label lblA = new Label { Text = "Nhập a", Location = new Point(20, 150), AutoSize = true };
        txtA.Location = new Point(90, 147); txtA.Size = new Size(130, 23);

        Label lblB = new Label { Text = "Nhập b", Location = new Point(20, 185), AutoSize = true };
        txtB.Location = new Point(90, 182); txtB.Size = new Size(130, 23);

        lblC.Text = "Nhập c"; lblC.Location = new Point(20, 220); lblC.AutoSize = true; lblC.Enabled = false;
        txtC.Location = new Point(90, 217); txtC.Size = new Size(130, 23); txtC.Enabled = false;

        Label lblKQ = new Label { Text = "Kết quả", Location = new Point(20, 260), AutoSize = true };
        txtKetQua.Location = new Point(90, 257); txtKetQua.Size = new Size(250, 50); txtKetQua.Multiline = true; txtKetQua.ReadOnly = true;

        // Các nút bấm
        btnGiai.Text = "Giải"; btnGiai.Location = new Point(240, 147); btnGiai.Size = new Size(100, 40); btnGiai.Enabled = false;
        btnThoat.Text = "Thoát"; btnThoat.Location = new Point(240, 197); btnThoat.Size = new Size(100, 40);

        // 2. Đăng ký sự kiện
        rdoBacNhat.CheckedChanged += RdoBacNhat_CheckedChanged;
        rdoBacHai.CheckedChanged += RdoBacHai_CheckedChanged;
        
        // Khi thay đổi nội dung ô nhập -> kích hoạt nút Giải
        txtA.TextChanged += KiemTraNhapLieu;
        txtB.TextChanged += KiemTraNhapLieu;
        txtC.TextChanged += KiemTraNhapLieu;

        btnGiai.Click += BtnGiai_Click;
        btnThoat.Click += (s, e) => this.Close();
        this.FormClosing += Form1_FormClosing;

        // Thêm các control vào Form
        this.Controls.AddRange(new Control[] { lblTitle, gbChon, lblA, txtA, lblB, txtB, lblC, txtC, lblKQ, txtKetQua, btnGiai, btnThoat });
    }

    // Sự kiện khi chọn Phương trình bậc nhất -> Làm mờ/ẩn ô nhập C
    private void RdoBacNhat_CheckedChanged(object? sender, EventArgs e)
    {
        if (rdoBacNhat.Checked)
        {
            lblC.Enabled = false;
            txtC.Enabled = false;
            txtC.Clear();
        }
    }

    // Sự kiện khi chọn Phương trình bậc hai -> Hiện ô nhập C
    private void RdoBacHai_CheckedChanged(object? sender, EventArgs e)
    {
        if (rdoBacHai.Checked)
        {
            lblC.Enabled = true;
            txtC.Enabled = true;
        }
    }

    // Kiểm tra đã nhập đủ dữ liệu chưa để bật nút "Giải"
    private void KiemTraNhapLieu(object? sender, EventArgs e)
    {
        if (rdoBacNhat.Checked)
        {
            btnGiai.Enabled = !string.IsNullOrWhiteSpace(txtA.Text) && !string.IsNullOrWhiteSpace(txtB.Text);
        }
        else
        {
            btnGiai.Enabled = !string.IsNullOrWhiteSpace(txtA.Text) && 
                              !string.IsNullOrWhiteSpace(txtB.Text) && 
                              !string.IsNullOrWhiteSpace(txtC.Text);
        }
    }

    // 3. ĐÂY CHÍNH LÀ ĐOẠN GỌI CLASS PhuongTrinhBacHai KHI BẤM NÚT GIẢI
    private void BtnGiai_Click(object? sender, EventArgs e)
    {
        // Lấy số a, b người dùng gõ vào
        if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
        {
            MessageBox.Show("Dữ liệu nhập a, b không hợp lệ!", "Lỗi");
            return;
        }

        if (rdoBacNhat.Checked)
        {
            // TẠO ĐỐI TƯỢNG VÀ GỌI HÀM GIẢI BẬC NHẤT
            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b);
            txtKetQua.Text = pt.GiaiBacNhat();
        }
        else
        {
            if (!double.TryParse(txtC.Text, out double c))
            {
                MessageBox.Show("Dữ liệu nhập c không hợp lệ!", "Lỗi");
                return;
            }

            // TẠO ĐỐI TƯỢNG VÀ GỌI HÀM GIẢI BẬC HAI
            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);
            txtKetQua.Text = pt.GiaiBacHai();
        }

        // Sau khi giải xong thì làm mờ nút Giải theo yêu cầu đề bài
        btnGiai.Enabled = false;
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
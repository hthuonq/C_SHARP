namespace Lab04c_WinFormBasic;

public partial class Form1 : Form
{
    private TextBox txtA = new TextBox();
    private TextBox txtB = new TextBox();
    private TextBox txtKetQua = new TextBox();
    private Button btnCong = new Button();
    private Button btnTru = new Button();
    private Button btnNhan = new Button();
    private Button btnChia = new Button();
    private ErrorProvider errorProvider1 = new ErrorProvider();

    public Form1()
    {
        InitializeComponentCustom();
    }

    private void InitializeComponentCustom()
    {
        this.Text = "Cộng trừ nhân chia";
        this.Size = new Size(360, 230);
        this.StartPosition = FormStartPosition.CenterScreen;

        Label lblA = new Label { Text = "a =", Location = new Point(30, 30), AutoSize = true };
        txtA.Location = new Point(65, 27); txtA.Size = new Size(80, 23);

        Label lblB = new Label { Text = "b =", Location = new Point(175, 30), AutoSize = true };
        txtB.Location = new Point(205, 27); txtB.Size = new Size(80, 23);

        Label lblKQ = new Label { Text = "Kết quả", Location = new Point(10, 70), AutoSize = true };
        txtKetQua.Location = new Point(65, 67); txtKetQua.Size = new Size(220, 23); txtKetQua.ReadOnly = true;

        btnCong.Text = "+"; btnCong.Location = new Point(30, 110); btnCong.Size = new Size(55, 30);
        btnTru.Text = "-"; btnTru.Location = new Point(100, 110); btnTru.Size = new Size(55, 30);
        btnNhan.Text = "*"; btnNhan.Location = new Point(170, 110); btnNhan.Size = new Size(55, 30);
        btnChia.Text = "/"; btnChia.Location = new Point(240, 110); btnChia.Size = new Size(55, 30);

        // Sự kiện click phép tính
        btnCong.Click += (s, e) => TinhToan('+');
        btnTru.Click += (s, e) => TinhToan('-');
        btnNhan.Click += (s, e) => TinhToan('*');
        btnChia.Click += (s, e) => TinhToan('/');

        this.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB, lblKQ, txtKetQua, btnCong, btnTru, btnNhan, btnChia });
        this.FormClosing += Form1_FormClosing;
    }

    private bool KiemTraHopLe(out double a, out double b)
    {
        a = 0; b = 0;
        errorProvider1.Clear();
        bool isAValid = double.TryParse(txtA.Text, out a);
        bool isBValid = double.TryParse(txtB.Text, out b);

        if (!isAValid) errorProvider1.SetError(txtA, "Số a không hợp lệ!");
        if (!isBValid) errorProvider1.SetError(txtB, "Số b không hợp lệ!");

        return isAValid && isBValid;
    }

    private void TinhToan(char pht)
    {
        if (KiemTraHopLe(out double a, out double b))
        {
            switch (pht)
            {
                case '+': txtKetQua.Text = (a + b).ToString(); break;
                case '-': txtKetQua.Text = (a - b).ToString(); break;
                case '*': txtKetQua.Text = (a * b).ToString(); break;
                case '/': 
                    if (b == 0) MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else txtKetQua.Text = (a / b).ToString();
                    break;
            }
        }
    }

    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            e.Cancel = true;
    }
}
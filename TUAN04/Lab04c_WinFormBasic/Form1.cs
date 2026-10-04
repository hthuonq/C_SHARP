namespace Lab04c_WinFormBasic;

public partial class Form1 : Form
{
    private TextBox txtDisplay = new TextBox();
    private double result = 0;
    private string operation = "";
    private bool isOperationPerformed = false;

    public Form1()
    {
        InitializeComponentCustom();
    }

    private void InitializeComponentCustom()
    {
        this.Text = "Máy Tính Bỏ Túi";
        this.Size = new Size(300, 380);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        Label lblTitle = new Label
        {
            Text = "Máy Tính Bỏ Túi",
            Font = new Font("Arial", 14, FontStyle.Bold),
            ForeColor = Color.Red,
            Location = new Point(60, 10),
            AutoSize = true
        };

        txtDisplay.Location = new Point(25, 45);
        txtDisplay.Size = new Size(235, 30);
        txtDisplay.Font = new Font("Arial", 14, FontStyle.Bold);
        txtDisplay.TextAlign = HorizontalAlignment.Right;
        txtDisplay.ReadOnly = true;
        txtDisplay.Text = "0";

        // Tạo mảng các nút theo đúng giao diện PDF
        string[,] buttons = {
            { "1", "2", "3", "4" },
            { "5", "6", "7", "8" },
            { "9", "0", "=", "C" },
            { "+", "-", "*", "/" }
        };

        int startX = 25, startY = 90;
        int btnWidth = 50, btnHeight = 45;
        int padding = 12;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                Button btn = new Button();
                btn.Text = buttons[row, col];
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Location = new Point(startX + col * (btnWidth + padding), startY + row * (btnHeight + padding));
                btn.Font = new Font("Arial", 11, FontStyle.Bold);
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
            }
        }

        this.Controls.Add(lblTitle);
        this.Controls.Add(txtDisplay);
    }

    private void Btn_Click(object? sender, EventArgs e)
    {
        Button btn = (Button)sender!;
        string text = btn.Text;

        if (char.IsDigit(text[0]))
        {
            if (txtDisplay.Text == "0" || isOperationPerformed)
                txtDisplay.Text = "";

            isOperationPerformed = false;
            txtDisplay.Text += text;
        }
        else if (text == "C")
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
        }
        else if (text == "=")
        {
            TinhKetQua();
            operation = "";
        }
        else // Các phép tính +, -, *, /
        {
            if (!string.IsNullOrEmpty(operation))
            {
                TinhKetQua();
            }
            else
            {
                result = double.Parse(txtDisplay.Text);
            }
            operation = text;
            isOperationPerformed = true;
        }
    }

    private void TinhKetQua()
    {
        double secondNum = double.Parse(txtDisplay.Text);
        switch (operation)
        {
            case "+": txtDisplay.Text = (result + secondNum).ToString(); break;
            case "-": txtDisplay.Text = (result - secondNum).ToString(); break;
            case "*": txtDisplay.Text = (result * secondNum).ToString(); break;
            case "/":
                if (secondNum == 0)
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    txtDisplay.Text = (result / secondNum).ToString();
                break;
        }
        result = double.Parse(txtDisplay.Text);
    }
}
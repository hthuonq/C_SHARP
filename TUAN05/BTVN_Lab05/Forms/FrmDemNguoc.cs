using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTVN_Lab05.Forms
{
    public partial class FrmDemNguoc : Form
    {
        private Label lblTimer;
        private Button btnStart;
        // Chỉ định rõ System.Windows.Forms.Timer để không bị đụng độ với System.Threading.Timer
        private System.Windows.Forms.Timer timerCountDown;
        private int totalSeconds = 30 * 60; // 30 phút = 1800 giây
        private bool isRunning = false;

        public FrmDemNguoc()
        {
            KhoiTaoGiaoDien();
            KhoiTaoTimer();
        }

        /// <summary>
        /// Khởi tạo các Control trên Form
        /// </summary>
        private void KhoiTaoGiaoDien()
        {
            this.Text = "Đồng hồ";
            this.Size = new Size(300, 180);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Label hiển thị thời gian "30:00"
            lblTimer = new Label
            {
                Text = "30:00",
                Font = new Font("Consolas", 28, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(260, 50),
                Location = new Point(12, 15)
            };

            // Button Bắt đầu / Tạm dừng
            btnStart = new Button
            {
                Text = "Bắt đầu",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Size = new Size(110, 35),
                Location = new Point(87, 80)
            };

            btnStart.Click += BtnStart_Click;

            this.Controls.Add(lblTimer);
            this.Controls.Add(btnStart);
        }

        /// <summary>
        /// Khởi tạo Timer với chu kỳ 1000ms (1 giây)
        /// </summary>
        private void KhoiTaoTimer()
        {
            timerCountDown = new System.Windows.Forms.Timer();
            timerCountDown.Interval = 1000; // 1000ms = 1s
            timerCountDown.Tick += TimerCountDown_Tick;
        }

        /// <summary>
        /// Xử lý sự kiện đếm ngược sau mỗi 1 giây
        /// </summary>
        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                UpdateTimerDisplay();
            }
            else
            {
                timerCountDown.Stop();
                isRunning = false;
                btnStart.Text = "Bắt đầu";
                MessageBox.Show("Đã hết giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Cập nhật định dạng MM:ss lên Label
        /// </summary>
        private void UpdateTimerDisplay()
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        /// <summary>
        /// Sự kiện click nút Bắt đầu / Tạm dừng
        /// </summary>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                if (totalSeconds <= 0)
                {
                    totalSeconds = 30 * 60;
                    UpdateTimerDisplay();
                }

                timerCountDown.Start();
                isRunning = true;
                btnStart.Text = "Tạm dừng";
            }
            else
            {
                timerCountDown.Stop();
                isRunning = false;
                btnStart.Text = "Tiếp tục";
            }
        }
    }
}
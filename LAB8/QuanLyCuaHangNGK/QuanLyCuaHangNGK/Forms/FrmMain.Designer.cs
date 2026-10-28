namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNGK;
        private System.Windows.Forms.Button btnDonDatHang;
        private System.Windows.Forms.Button btnPhieuHen;
        private System.Windows.Forms.Button btnPhieuGhiNo;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnKiemTraKetNoi;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpDashboard;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblTongNGK;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblTongNo;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Label lblDonChoGiao;
        private System.Windows.Forms.GroupBox grpGanDay;
        private System.Windows.Forms.DataGridView dgvGanDay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNGK = new System.Windows.Forms.Button();
            this.btnDonDatHang = new System.Windows.Forms.Button();
            this.btnPhieuHen = new System.Windows.Forms.Button();
            this.btnPhieuGhiNo = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnKiemTraKetNoi = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpDashboard = new System.Windows.Forms.GroupBox();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblTongNGK = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lblTongNo = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.lblDonChoGiao = new System.Windows.Forms.Label();
            this.grpGanDay = new System.Windows.Forms.GroupBox();
            this.dgvGanDay = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 85;

            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.AutoSize = true;

            this.lblSubtitle.Text = "Môn học: PPPT Phần mềm Hướng đối tượng (Lab 08) | SVTH: Trần Nguyên - MSSV: 1250080121 - Lớp: 12_ĐH_CNPM2";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 50);
            this.lblSubtitle.AutoSize = true;

            // pnlNav
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(38, 50, 68);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Width = 230;
            this.pnlNav.Padding = new System.Windows.Forms.Padding(10);

            // Nav buttons
            int btnY = 15;
            int btnH = 45;
            int spacing = 10;

            this.btnBanHang.Text = "1. Bán Hàng & Hóa Đơn";
            this.btnBanHang.Location = new System.Drawing.Point(12, btnY);
            this.btnBanHang.Size = new System.Drawing.Size(206, btnH);
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            btnY += btnH + spacing;

            this.btnNGK.Text = "2. Quản Lý Nước Giải Khát";
            this.btnNGK.Location = new System.Drawing.Point(12, btnY);
            this.btnNGK.Size = new System.Drawing.Size(206, btnH);
            this.btnNGK.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnNGK.ForeColor = System.Drawing.Color.White;
            this.btnNGK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNGK.Click += new System.EventHandler(this.btnNGK_Click);
            btnY += btnH + spacing;

            this.btnDonDatHang.Text = "3. Đặt Hàng & Nhập Kho NCC";
            this.btnDonDatHang.Location = new System.Drawing.Point(12, btnY);
            this.btnDonDatHang.Size = new System.Drawing.Size(206, btnH);
            this.btnDonDatHang.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnDonDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDonDatHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            btnY += btnH + spacing;

            this.btnPhieuHen.Text = "4. Phiếu Hẹn Giao (Khách quen)";
            this.btnPhieuHen.Location = new System.Drawing.Point(12, btnY);
            this.btnPhieuHen.Size = new System.Drawing.Size(206, btnH);
            this.btnPhieuHen.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnPhieuHen.ForeColor = System.Drawing.Color.White;
            this.btnPhieuHen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPhieuHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuHen.Click += new System.EventHandler(this.btnPhieuHen_Click);
            btnY += btnH + spacing;

            this.btnPhieuGhiNo.Text = "5. Phiếu Ghi Nợ (Khách quen)";
            this.btnPhieuGhiNo.Location = new System.Drawing.Point(12, btnY);
            this.btnPhieuGhiNo.Size = new System.Drawing.Size(206, btnH);
            this.btnPhieuGhiNo.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnPhieuGhiNo.ForeColor = System.Drawing.Color.White;
            this.btnPhieuGhiNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPhieuGhiNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuGhiNo.Click += new System.EventHandler(this.btnPhieuGhiNo_Click);
            btnY += btnH + spacing;

            this.btnBaoCao.Text = "6. Báo Cáo & Thống Kê";
            this.btnBaoCao.Location = new System.Drawing.Point(12, btnY);
            this.btnBaoCao.Size = new System.Drawing.Size(206, btnH);
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            btnY += btnH + spacing + 20;

            this.btnKiemTraKetNoi.Text = "Kiểm Tra CSDL SQL";
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(12, btnY);
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(206, 38);
            this.btnKiemTraKetNoi.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnKiemTraKetNoi.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraKetNoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKiemTraKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTraKetNoi.Click += new System.EventHandler(this.btnKiemTraKetNoi_Click);

            this.pnlNav.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnBanHang, this.btnNGK, this.btnDonDatHang,
                this.btnPhieuHen, this.btnPhieuGhiNo, this.btnBaoCao, this.btnKiemTraKetNoi
            });

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // grpDashboard
            this.grpDashboard.Text = "TỔNG QUAN HỆ THỐNG KINH DOANH";
            this.grpDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDashboard.Height = 130;

            // Card 1: Tổng NGK
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Location = new System.Drawing.Point(20, 30);
            this.pnlCard1.Size = new System.Drawing.Size(200, 80);
            this.lblCard1Title.Text = "TỔNG MẶT HÀNG NGK";
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard1Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard1Title.AutoSize = true;
            this.lblTongNGK.Text = "0";
            this.lblTongNGK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongNGK.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTongNGK.Location = new System.Drawing.Point(10, 35);
            this.lblTongNGK.AutoSize = true;
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.lblTongNGK);

            // Card 2: Doanh Thu
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Location = new System.Drawing.Point(240, 30);
            this.pnlCard2.Size = new System.Drawing.Size(220, 80);
            this.lblCard2Title.Text = "TỔNG DOANH THU";
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard2Title.AutoSize = true;
            this.lblDoanhThu.Text = "0 VNĐ";
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblDoanhThu.Location = new System.Drawing.Point(10, 35);
            this.lblDoanhThu.AutoSize = true;
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.lblDoanhThu);

            // Card 3: Công Nợ
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Location = new System.Drawing.Point(480, 30);
            this.pnlCard3.Size = new System.Drawing.Size(220, 80);
            this.lblCard3Title.Text = "TỔNG NỢ KHÁCH QUEN";
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard3Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard3Title.AutoSize = true;
            this.lblTongNo.Text = "0 VNĐ";
            this.lblTongNo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongNo.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblTongNo.Location = new System.Drawing.Point(10, 35);
            this.lblTongNo.AutoSize = true;
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.lblTongNo);

            // Card 4: Phiếu Hẹn
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Location = new System.Drawing.Point(720, 30);
            this.pnlCard4.Size = new System.Drawing.Size(200, 80);
            this.lblCard4Title.Text = "PHIẾU HẸN CHỜ GIAO";
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCard4Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard4Title.Location = new System.Drawing.Point(10, 10);
            this.lblCard4Title.AutoSize = true;
            this.lblDonChoGiao.Text = "0";
            this.lblDonChoGiao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDonChoGiao.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblDonChoGiao.Location = new System.Drawing.Point(10, 35);
            this.lblDonChoGiao.AutoSize = true;
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Controls.Add(this.lblDonChoGiao);

            this.grpDashboard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlCard1, this.pnlCard2, this.pnlCard3, this.pnlCard4
            });

            // grpGanDay
            this.grpGanDay.Text = "DOANH THU THEO NGÀY GẦN ĐÂY";
            this.grpGanDay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpGanDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGanDay.Padding = new System.Windows.Forms.Padding(10);

            this.dgvGanDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGanDay.BackgroundColor = System.Drawing.Color.White;
            this.dgvGanDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGanDay.ReadOnly = true;
            this.dgvGanDay.AllowUserToAddRows = false;
            this.grpGanDay.Controls.Add(this.dgvGanDay);

            this.pnlContent.Controls.Add(this.grpGanDay);
            this.pnlContent.Controls.Add(this.grpDashboard);

            // statusStrip1
            this.statusStrip1.Items.Add(this.lblStatus);
            this.lblStatus.Text = "Hệ thống Quản lý Cửa hàng Nước giải khát - Sẵn sàng phục vụ.";

            // FrmMain
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Nước Giải Khát - Lab 08 OOSD - SVTH: Trần Nguyên";
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
        }
    }
}

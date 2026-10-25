namespace QuanLyDuLich.Forms
{
    partial class FrmDangKyDoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbPhieuDoan;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblKhachDoan;
        private System.Windows.Forms.ComboBox cboKhachDoan;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.Label lblSoKhach;
        private System.Windows.Forms.NumericUpDown nudSoKhach;
        private System.Windows.Forms.Label lblDiaDiemDon;
        private System.Windows.Forms.TextBox txtDiaDiemDon;
        private System.Windows.Forms.CheckBox chkMuaBaoHiem;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Button btnQuyetToan;
        private System.Windows.Forms.DataGridView dgvPhieuDoan;
        private System.Windows.Forms.GroupBox gbBaoHiem;
        private System.Windows.Forms.Label lblMaPhieuBaoHiem;
        private System.Windows.Forms.TextBox txtMaPhieuBaoHiem;
        private System.Windows.Forms.Label lblMaBaoHiem;
        private System.Windows.Forms.TextBox txtMaBaoHiem;
        private System.Windows.Forms.Label lblHoTenBH;
        private System.Windows.Forms.TextBox txtHoTenBH;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblQuanHe;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.Button btnThemNguoiBH;
        private System.Windows.Forms.DataGridView dgvBaoHiem;
        private System.Windows.Forms.Button btnDong;

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
            this.gbPhieuDoan = new System.Windows.Forms.GroupBox();
            this.btnQuyetToan = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.chkMuaBaoHiem = new System.Windows.Forms.CheckBox();
            this.txtDiaDiemDon = new System.Windows.Forms.TextBox();
            this.lblDiaDiemDon = new System.Windows.Forms.Label();
            this.nudSoKhach = new System.Windows.Forms.NumericUpDown();
            this.lblSoKhach = new System.Windows.Forms.Label();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.cboKhachDoan = new System.Windows.Forms.ComboBox();
            this.lblKhachDoan = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.dgvPhieuDoan = new System.Windows.Forms.DataGridView();
            this.gbBaoHiem = new System.Windows.Forms.GroupBox();
            this.btnThemNguoiBH = new System.Windows.Forms.Button();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.lblQuanHe = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTenBH = new System.Windows.Forms.TextBox();
            this.lblHoTenBH = new System.Windows.Forms.Label();
            this.txtMaBaoHiem = new System.Windows.Forms.TextBox();
            this.lblMaBaoHiem = new System.Windows.Forms.Label();
            this.txtMaPhieuBaoHiem = new System.Windows.Forms.TextBox();
            this.lblMaPhieuBaoHiem = new System.Windows.Forms.Label();
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbPhieuDoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDoan)).BeginInit();
            this.gbBaoHiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhieuDoan
            // 
            this.gbPhieuDoan.Controls.Add(this.btnQuyetToan);
            this.gbPhieuDoan.Controls.Add(this.btnLapPhieu);
            this.gbPhieuDoan.Controls.Add(this.txtTienCoc);
            this.gbPhieuDoan.Controls.Add(this.lblTienCoc);
            this.gbPhieuDoan.Controls.Add(this.chkMuaBaoHiem);
            this.gbPhieuDoan.Controls.Add(this.txtDiaDiemDon);
            this.gbPhieuDoan.Controls.Add(this.lblDiaDiemDon);
            this.gbPhieuDoan.Controls.Add(this.nudSoKhach);
            this.gbPhieuDoan.Controls.Add(this.lblSoKhach);
            this.gbPhieuDoan.Controls.Add(this.dtpNgayVe);
            this.gbPhieuDoan.Controls.Add(this.lblNgayVe);
            this.gbPhieuDoan.Controls.Add(this.dtpNgayDi);
            this.gbPhieuDoan.Controls.Add(this.lblNgayDi);
            this.gbPhieuDoan.Controls.Add(this.cboTour);
            this.gbPhieuDoan.Controls.Add(this.lblTour);
            this.gbPhieuDoan.Controls.Add(this.cboKhachDoan);
            this.gbPhieuDoan.Controls.Add(this.lblKhachDoan);
            this.gbPhieuDoan.Controls.Add(this.txtMaPhieu);
            this.gbPhieuDoan.Controls.Add(this.lblMaPhieu);
            this.gbPhieuDoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbPhieuDoan.Location = new System.Drawing.Point(12, 12);
            this.gbPhieuDoan.Name = "gbPhieuDoan";
            this.gbPhieuDoan.Size = new System.Drawing.Size(960, 140);
            this.gbPhieuDoan.TabIndex = 0;
            this.gbPhieuDoan.TabStop = false;
            this.gbPhieuDoan.Text = "Đăng Ký Tour Theo Đoàn (Số khách >= 12, Đón Tận Nơi, Đặt Cọc Trước)";
            // 
            // btnQuyetToan
            // 
            this.btnQuyetToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.btnQuyetToan.ForeColor = System.Drawing.Color.White;
            this.btnQuyetToan.Location = new System.Drawing.Point(830, 95);
            this.btnQuyetToan.Name = "btnQuyetToan";
            this.btnQuyetToan.Size = new System.Drawing.Size(115, 32);
            this.btnQuyetToan.TabIndex = 18;
            this.btnQuyetToan.Text = "Quyết Toán";
            this.btnQuyetToan.UseVisualStyleBackColor = false;
            this.btnQuyetToan.Click += new System.EventHandler(this.btnQuyetToan_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(705, 95);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(115, 32);
            this.btnLapPhieu.TabIndex = 17;
            this.btnLapPhieu.Text = "Lập Phiếu & Cọc";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(540, 100);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(140, 23);
            this.txtTienCoc.TabIndex = 16;
            this.txtTienCoc.Text = "30000000";
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienCoc.Location = new System.Drawing.Point(450, 103);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(76, 15);
            this.lblTienCoc.TabIndex = 15;
            this.lblTienCoc.Text = "Tiền đặt cọc:";
            // 
            // chkMuaBaoHiem
            // 
            this.chkMuaBaoHiem.AutoSize = true;
            this.chkMuaBaoHiem.Checked = true;
            this.chkMuaBaoHiem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMuaBaoHiem.Location = new System.Drawing.Point(260, 102);
            this.chkMuaBaoHiem.Name = "chkMuaBaoHiem";
            this.chkMuaBaoHiem.Size = new System.Drawing.Size(161, 19);
            this.chkMuaBaoHiem.TabIndex = 14;
            this.chkMuaBaoHiem.Text = "Có mua bảo hiểm du lịch";
            this.chkMuaBaoHiem.UseVisualStyleBackColor = true;
            // 
            // txtDiaDiemDon
            // 
            this.txtDiaDiemDon.Location = new System.Drawing.Point(120, 100);
            this.txtDiaDiemDon.Name = "txtDiaDiemDon";
            this.txtDiaDiemDon.Size = new System.Drawing.Size(120, 23);
            this.txtDiaDiemDon.TabIndex = 13;
            this.txtDiaDiemDon.Text = "Trụ sở cơ quan";
            // 
            // lblDiaDiemDon
            // 
            this.lblDiaDiemDon.AutoSize = true;
            this.lblDiaDiemDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiaDiemDon.Location = new System.Drawing.Point(20, 103);
            this.lblDiaDiemDon.Name = "lblDiaDiemDon";
            this.lblDiaDiemDon.Size = new System.Drawing.Size(81, 15);
            this.lblDiaDiemDon.TabIndex = 12;
            this.lblDiaDiemDon.Text = "Điểm đón Y/c:";
            // 
            // nudSoKhach
            // 
            this.nudSoKhach.Location = new System.Drawing.Point(830, 62);
            this.nudSoKhach.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.nudSoKhach.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            this.nudSoKhach.Name = "nudSoKhach";
            this.nudSoKhach.Size = new System.Drawing.Size(115, 23);
            this.nudSoKhach.TabIndex = 11;
            this.nudSoKhach.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblSoKhach
            // 
            this.lblSoKhach.AutoSize = true;
            this.lblSoKhach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoKhach.Location = new System.Drawing.Point(740, 65);
            this.lblSoKhach.Name = "lblSoKhach";
            this.lblSoKhach.Size = new System.Drawing.Size(79, 15);
            this.lblSoKhach.TabIndex = 10;
            this.lblSoKhach.Text = "Số khách(>=12):";
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVe.Location = new System.Drawing.Point(540, 62);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(140, 23);
            this.dtpNgayVe.TabIndex = 9;
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayVe.Location = new System.Drawing.Point(450, 65);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(53, 15);
            this.lblNgayVe.TabIndex = 8;
            this.lblNgayVe.Text = "Ngày về:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(260, 62);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(160, 23);
            this.dtpNgayDi.TabIndex = 7;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDi.Location = new System.Drawing.Point(200, 65);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(51, 15);
            this.lblNgayDi.TabIndex = 6;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(540, 25);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(405, 23);
            this.cboTour.TabIndex = 5;
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTour.Location = new System.Drawing.Point(450, 28);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(63, 15);
            this.lblTour.TabIndex = 4;
            this.lblTour.Text = "Chọn Tour:";
            // 
            // cboKhachDoan
            // 
            this.cboKhachDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachDoan.FormattingEnabled = true;
            this.cboKhachDoan.Location = new System.Drawing.Point(260, 25);
            this.cboKhachDoan.Name = "cboKhachDoan";
            this.cboKhachDoan.Size = new System.Drawing.Size(160, 23);
            this.cboKhachDoan.TabIndex = 3;
            // 
            // lblKhachDoan
            // 
            this.lblKhachDoan.AutoSize = true;
            this.lblKhachDoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachDoan.Location = new System.Drawing.Point(200, 28);
            this.lblKhachDoan.Name = "lblKhachDoan";
            this.lblKhachDoan.Size = new System.Drawing.Size(53, 15);
            this.lblKhachDoan.TabIndex = 2;
            this.lblKhachDoan.Text = "Cơ quan:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(120, 25);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(60, 23);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaPhieu.Location = new System.Drawing.Point(20, 28);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(60, 15);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // dgvPhieuDoan
            // 
            this.dgvPhieuDoan.AllowUserToAddRows = false;
            this.dgvPhieuDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDoan.Location = new System.Drawing.Point(12, 160);
            this.dgvPhieuDoan.MultiSelect = false;
            this.dgvPhieuDoan.Name = "dgvPhieuDoan";
            this.dgvPhieuDoan.ReadOnly = true;
            this.dgvPhieuDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDoan.Size = new System.Drawing.Size(960, 160);
            this.dgvPhieuDoan.TabIndex = 1;
            this.dgvPhieuDoan.SelectionChanged += new System.EventHandler(this.dgvPhieuDoan_SelectionChanged);
            // 
            // gbBaoHiem
            // 
            this.gbBaoHiem.Controls.Add(this.btnThemNguoiBH);
            this.gbBaoHiem.Controls.Add(this.txtQuanHe);
            this.gbBaoHiem.Controls.Add(this.lblQuanHe);
            this.gbBaoHiem.Controls.Add(this.cboGioiTinh);
            this.gbBaoHiem.Controls.Add(this.lblGioiTinh);
            this.gbBaoHiem.Controls.Add(this.txtCCCD);
            this.gbBaoHiem.Controls.Add(this.lblCCCD);
            this.gbBaoHiem.Controls.Add(this.dtpNgaySinh);
            this.gbBaoHiem.Controls.Add(this.lblNgaySinh);
            this.gbBaoHiem.Controls.Add(this.txtHoTenBH);
            this.gbBaoHiem.Controls.Add(this.lblHoTenBH);
            this.gbBaoHiem.Controls.Add(this.txtMaBaoHiem);
            this.gbBaoHiem.Controls.Add(this.lblMaBaoHiem);
            this.gbBaoHiem.Controls.Add(this.txtMaPhieuBaoHiem);
            this.gbBaoHiem.Controls.Add(this.lblMaPhieuBaoHiem);
            this.gbBaoHiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbBaoHiem.Location = new System.Drawing.Point(12, 330);
            this.gbBaoHiem.Name = "gbBaoHiem";
            this.gbBaoHiem.Size = new System.Drawing.Size(960, 95);
            this.gbBaoHiem.TabIndex = 2;
            this.gbBaoHiem.TabStop = false;
            this.gbBaoHiem.Text = "Danh Sách Người Tham Gia Bảo Hiểm Du Lịch Đính Kèm";
            // 
            // btnThemNguoiBH
            // 
            this.btnThemNguoiBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThemNguoiBH.ForeColor = System.Drawing.Color.White;
            this.btnThemNguoiBH.Location = new System.Drawing.Point(825, 55);
            this.btnThemNguoiBH.Name = "btnThemNguoiBH";
            this.btnThemNguoiBH.Size = new System.Drawing.Size(120, 30);
            this.btnThemNguoiBH.TabIndex = 14;
            this.btnThemNguoiBH.Text = "Thêm Người BH";
            this.btnThemNguoiBH.UseVisualStyleBackColor = false;
            this.btnThemNguoiBH.Click += new System.EventHandler(this.btnThemNguoiBH_Click);
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(630, 60);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(160, 23);
            this.txtQuanHe.TabIndex = 13;
            this.txtQuanHe.Text = "Nhân viên";
            // 
            // lblQuanHe
            // 
            this.lblQuanHe.AutoSize = true;
            this.lblQuanHe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuanHe.Location = new System.Drawing.Point(560, 63);
            this.lblQuanHe.Name = "lblQuanHe";
            this.lblQuanHe.Size = new System.Drawing.Size(55, 15);
            this.lblQuanHe.TabIndex = 12;
            this.lblQuanHe.Text = "Quan hệ:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(440, 60);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(80, 23);
            this.cboGioiTinh.TabIndex = 11;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.Location = new System.Drawing.Point(380, 63);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(55, 15);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(230, 60);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(120, 23);
            this.txtCCCD.TabIndex = 9;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCCCD.Location = new System.Drawing.Point(180, 63);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(42, 15);
            this.lblCCCD.TabIndex = 8;
            this.lblCCCD.Text = "CCCD:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(825, 25);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(120, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.Location = new System.Drawing.Point(750, 28);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(63, 15);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTenBH
            // 
            this.txtHoTenBH.Location = new System.Drawing.Point(440, 25);
            this.txtHoTenBH.Name = "txtHoTenBH";
            this.txtHoTenBH.Size = new System.Drawing.Size(280, 23);
            this.txtHoTenBH.TabIndex = 5;
            // 
            // lblHoTenBH
            // 
            this.lblHoTenBH.AutoSize = true;
            this.lblHoTenBH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTenBH.Location = new System.Drawing.Point(380, 28);
            this.lblHoTenBH.Name = "lblHoTenBH";
            this.lblHoTenBH.Size = new System.Drawing.Size(46, 15);
            this.lblHoTenBH.TabIndex = 4;
            this.lblHoTenBH.Text = "Họ tên:";
            // 
            // txtMaBaoHiem
            // 
            this.txtMaBaoHiem.Location = new System.Drawing.Point(230, 25);
            this.txtMaBaoHiem.Name = "txtMaBaoHiem";
            this.txtMaBaoHiem.Size = new System.Drawing.Size(120, 23);
            this.txtMaBaoHiem.TabIndex = 3;
            // 
            // lblMaBaoHiem
            // 
            this.lblMaBaoHiem.AutoSize = true;
            this.lblMaBaoHiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaBaoHiem.Location = new System.Drawing.Point(180, 28);
            this.lblMaBaoHiem.Name = "lblMaBaoHiem";
            this.lblMaBaoHiem.Size = new System.Drawing.Size(48, 15);
            this.lblMaBaoHiem.TabIndex = 2;
            this.lblMaBaoHiem.Text = "Mã BH:";
            // 
            // txtMaPhieuBaoHiem
            // 
            this.txtMaPhieuBaoHiem.Location = new System.Drawing.Point(80, 25);
            this.txtMaPhieuBaoHiem.Name = "txtMaPhieuBaoHiem";
            this.txtMaPhieuBaoHiem.ReadOnly = true;
            this.txtMaPhieuBaoHiem.Size = new System.Drawing.Size(80, 23);
            this.txtMaPhieuBaoHiem.TabIndex = 1;
            // 
            // lblMaPhieuBaoHiem
            // 
            this.lblMaPhieuBaoHiem.AutoSize = true;
            this.lblMaPhieuBaoHiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaPhieuBaoHiem.Location = new System.Drawing.Point(20, 28);
            this.lblMaPhieuBaoHiem.Name = "lblMaPhieuBaoHiem";
            this.lblMaPhieuBaoHiem.Size = new System.Drawing.Size(60, 15);
            this.lblMaPhieuBaoHiem.TabIndex = 0;
            this.lblMaPhieuBaoHiem.Text = "Mã Phiếu:";
            // 
            // dgvBaoHiem
            // 
            this.dgvBaoHiem.AllowUserToAddRows = false;
            this.dgvBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHiem.Location = new System.Drawing.Point(12, 435);
            this.dgvBaoHiem.Name = "dgvBaoHiem";
            this.dgvBaoHiem.ReadOnly = true;
            this.dgvBaoHiem.Size = new System.Drawing.Size(960, 110);
            this.dgvBaoHiem.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(852, 555);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 32);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDangKyDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvBaoHiem);
            this.Controls.Add(this.gbBaoHiem);
            this.Controls.Add(this.dgvPhieuDoan);
            this.Controls.Add(this.gbPhieuDoan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDangKyDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Ký Tour Theo Đoàn & Bảo Hiểm Du Lịch";
            this.Load += new System.EventHandler(this.FrmDangKyDoan_Load);
            this.gbPhieuDoan.ResumeLayout(false);
            this.gbPhieuDoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDoan)).EndInit();
            this.gbBaoHiem.ResumeLayout(false);
            this.gbBaoHiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

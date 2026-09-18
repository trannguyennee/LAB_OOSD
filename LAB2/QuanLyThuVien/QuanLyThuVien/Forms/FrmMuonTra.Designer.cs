namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMuon = new System.Windows.Forms.TabPage();
            this.lblSachChon = new System.Windows.Forms.Label();
            this.lblSachCon = new System.Windows.Forms.Label();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.dgvSachCon = new System.Windows.Forms.DataGridView();
            this.grpThongTinMuon = new System.Windows.Forms.GroupBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();
            this.lblHenTra = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.cboNhanVienMuon = new System.Windows.Forms.ComboBox();
            this.lblNhanVienMuon = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.lblDocGia = new System.Windows.Forms.Label();
            this.tabTra = new System.Windows.Forms.TabPage();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();
            this.grpThongTinTra = new System.Windows.Forms.GroupBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.numPhiPhat = new System.Windows.Forms.NumericUpDown();
            this.lblPhiPhat = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.cboNhanVienTra = new System.Windows.Forms.ComboBox();
            this.lblNhanVienTra = new System.Windows.Forms.Label();
            this.btnTaiSachMuon = new System.Windows.Forms.Button();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.lblDocGiaTra = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            this.grpThongTinMuon.SuspendLayout();
            this.tabTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            this.grpThongTinTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabMuon);
            this.tabs.Controls.Add(this.tabTra);
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1186, 690);
            this.tabs.TabIndex = 0;
            // 
            // tabMuon
            // 
            this.tabMuon.Controls.Add(this.lblSachChon);
            this.tabMuon.Controls.Add(this.lblSachCon);
            this.tabMuon.Controls.Add(this.dgvSachChon);
            this.tabMuon.Controls.Add(this.btnBoSach);
            this.tabMuon.Controls.Add(this.btnThemSach);
            this.tabMuon.Controls.Add(this.dgvSachCon);
            this.tabMuon.Controls.Add(this.grpThongTinMuon);
            this.tabMuon.Location = new System.Drawing.Point(4, 32);
            this.tabMuon.Name = "tabMuon";
            this.tabMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMuon.Size = new System.Drawing.Size(1178, 654);
            this.tabMuon.TabIndex = 0;
            this.tabMuon.Text = "Mượn sách";
            this.tabMuon.UseVisualStyleBackColor = true;
            // 
            // lblSachChon
            // 
            this.lblSachChon.AutoSize = true;
            this.lblSachChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachChon.Location = new System.Drawing.Point(825, 15);
            this.lblSachChon.Name = "lblSachChon";
            this.lblSachChon.Size = new System.Drawing.Size(262, 23);
            this.lblSachChon.TabIndex = 6;
            this.lblSachChon.Text = "Sách chọn mượn (tối đa 3 đầu):";
            // 
            // lblSachCon
            // 
            this.lblSachCon.AutoSize = true;
            this.lblSachCon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachCon.Location = new System.Drawing.Point(365, 15);
            this.lblSachCon.Name = "lblSachCon";
            this.lblSachCon.Size = new System.Drawing.Size(176, 23);
            this.lblSachCon.TabIndex = 5;
            this.lblSachCon.Text = "Sách có sẵn trong kho:";
            // 
            // dgvSachChon
            // 
            this.dgvSachChon.AllowUserToAddRows = false;
            this.dgvSachChon.AllowUserToDeleteRows = false;
            this.dgvSachChon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachChon.Location = new System.Drawing.Point(830, 45);
            this.dgvSachChon.MultiSelect = false;
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.RowHeadersWidth = 51;
            this.dgvSachChon.RowTemplate.Height = 24;
            this.dgvSachChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachChon.Size = new System.Drawing.Size(335, 590);
            this.dgvSachChon.TabIndex = 4;
            // 
            // btnBoSach
            // 
            this.btnBoSach.Location = new System.Drawing.Point(735, 300);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(85, 45);
            this.btnBoSach.TabIndex = 3;
            this.btnBoSach.Text = "<< Bỏ";
            this.btnBoSach.UseVisualStyleBackColor = true;
            this.btnBoSach.Click += new System.EventHandler(this.btnBoSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(735, 235);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(85, 45);
            this.btnThemSach.TabIndex = 2;
            this.btnThemSach.Text = "Thêm >>";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // dgvSachCon
            // 
            this.dgvSachCon.AllowUserToAddRows = false;
            this.dgvSachCon.AllowUserToDeleteRows = false;
            this.dgvSachCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSachCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachCon.Location = new System.Drawing.Point(370, 45);
            this.dgvSachCon.MultiSelect = false;
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.ReadOnly = true;
            this.dgvSachCon.RowHeadersWidth = 51;
            this.dgvSachCon.RowTemplate.Height = 24;
            this.dgvSachCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachCon.Size = new System.Drawing.Size(355, 590);
            this.dgvSachCon.TabIndex = 1;
            // 
            // grpThongTinMuon
            // 
            this.grpThongTinMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpThongTinMuon.Controls.Add(this.btnLapPhieu);
            this.grpThongTinMuon.Controls.Add(this.dtHenTra);
            this.grpThongTinMuon.Controls.Add(this.lblHenTra);
            this.grpThongTinMuon.Controls.Add(this.dtNgayMuon);
            this.grpThongTinMuon.Controls.Add(this.lblNgayMuon);
            this.grpThongTinMuon.Controls.Add(this.cboNhanVienMuon);
            this.grpThongTinMuon.Controls.Add(this.lblNhanVienMuon);
            this.grpThongTinMuon.Controls.Add(this.lblTrangThai);
            this.grpThongTinMuon.Controls.Add(this.btnKiemTra);
            this.grpThongTinMuon.Controls.Add(this.cboDocGia);
            this.grpThongTinMuon.Controls.Add(this.lblDocGia);
            this.grpThongTinMuon.Location = new System.Drawing.Point(15, 15);
            this.grpThongTinMuon.Name = "grpThongTinMuon";
            this.grpThongTinMuon.Size = new System.Drawing.Size(340, 620);
            this.grpThongTinMuon.TabIndex = 0;
            this.grpThongTinMuon.TabStop = false;
            this.grpThongTinMuon.Text = "Lập phiếu mượn";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.Location = new System.Drawing.Point(20, 390);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(295, 50);
            this.btnLapPhieu.TabIndex = 10;
            this.btnLapPhieu.Text = "LẬP PHIẾU MƯỢN";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dtHenTra
            // 
            this.dtHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHenTra.Location = new System.Drawing.Point(125, 325);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(190, 30);
            this.dtHenTra.TabIndex = 9;
            // 
            // lblHenTra
            // 
            this.lblHenTra.AutoSize = true;
            this.lblHenTra.Location = new System.Drawing.Point(15, 328);
            this.lblHenTra.Name = "lblHenTra";
            this.lblHenTra.Size = new System.Drawing.Size(80, 23);
            this.lblHenTra.TabIndex = 8;
            this.lblHenTra.Text = "Hẹn trả:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayMuon.Location = new System.Drawing.Point(125, 275);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(190, 30);
            this.dtNgayMuon.TabIndex = 7;
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(15, 278);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(104, 23);
            this.lblNgayMuon.TabIndex = 6;
            this.lblNgayMuon.Text = "Ngày mượn:";
            // 
            // cboNhanVienMuon
            // 
            this.cboNhanVienMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienMuon.FormattingEnabled = true;
            this.cboNhanVienMuon.Location = new System.Drawing.Point(125, 225);
            this.cboNhanVienMuon.Name = "cboNhanVienMuon";
            this.cboNhanVienMuon.Size = new System.Drawing.Size(190, 29);
            this.cboNhanVienMuon.TabIndex = 5;
            // 
            // lblNhanVienMuon
            // 
            this.lblNhanVienMuon.AutoSize = true;
            this.lblNhanVienMuon.Location = new System.Drawing.Point(15, 228);
            this.lblNhanVienMuon.Name = "lblNhanVienMuon";
            this.lblNhanVienMuon.Size = new System.Drawing.Size(92, 23);
            this.lblNhanVienMuon.TabIndex = 4;
            this.lblNhanVienMuon.Text = "Nhân viên:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(15, 135);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(300, 75);
            this.lblTrangThai.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(20, 85);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(295, 38);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra điều kiện mượn";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // cboDocGia
            // 
            this.cboDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(100, 40);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(215, 29);
            this.cboDocGia.TabIndex = 1;
            // 
            // lblDocGia
            // 
            this.lblDocGia.AutoSize = true;
            this.lblDocGia.Location = new System.Drawing.Point(15, 43);
            this.lblDocGia.Name = "lblDocGia";
            this.lblDocGia.Size = new System.Drawing.Size(73, 23);
            this.lblDocGia.TabIndex = 0;
            this.lblDocGia.Text = "Độc giả:";
            // 
            // tabTra
            // 
            this.tabTra.Controls.Add(this.dgvDangMuon);
            this.tabTra.Controls.Add(this.grpThongTinTra);
            this.tabTra.Location = new System.Drawing.Point(4, 32);
            this.tabTra.Name = "tabTra";
            this.tabTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabTra.Size = new System.Drawing.Size(1178, 654);
            this.tabTra.TabIndex = 1;
            this.tabTra.Text = "Trả sách & Phạt";
            this.tabTra.UseVisualStyleBackColor = true;
            // 
            // dgvDangMuon
            // 
            this.dgvDangMuon.AllowUserToAddRows = false;
            this.dgvDangMuon.AllowUserToDeleteRows = false;
            this.dgvDangMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDangMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangMuon.Location = new System.Drawing.Point(375, 15);
            this.dgvDangMuon.MultiSelect = false;
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.ReadOnly = true;
            this.dgvDangMuon.RowHeadersWidth = 51;
            this.dgvDangMuon.RowTemplate.Height = 24;
            this.dgvDangMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangMuon.Size = new System.Drawing.Size(785, 620);
            this.dgvDangMuon.TabIndex = 1;
            // 
            // grpThongTinTra
            // 
            this.grpThongTinTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpThongTinTra.Controls.Add(this.btnTraSach);
            this.grpThongTinTra.Controls.Add(this.numPhiPhat);
            this.grpThongTinTra.Controls.Add(this.lblPhiPhat);
            this.grpThongTinTra.Controls.Add(this.cboTinhTrang);
            this.grpThongTinTra.Controls.Add(this.lblTinhTrang);
            this.grpThongTinTra.Controls.Add(this.dtNgayTra);
            this.grpThongTinTra.Controls.Add(this.lblNgayTra);
            this.grpThongTinTra.Controls.Add(this.cboNhanVienTra);
            this.grpThongTinTra.Controls.Add(this.lblNhanVienTra);
            this.grpThongTinTra.Controls.Add(this.btnTaiSachMuon);
            this.grpThongTinTra.Controls.Add(this.cboDocGiaTra);
            this.grpThongTinTra.Controls.Add(this.lblDocGiaTra);
            this.grpThongTinTra.Location = new System.Drawing.Point(15, 15);
            this.grpThongTinTra.Name = "grpThongTinTra";
            this.grpThongTinTra.Size = new System.Drawing.Size(345, 620);
            this.grpThongTinTra.TabIndex = 0;
            this.grpThongTinTra.TabStop = false;
            this.grpThongTinTra.Text = "Xử lý trả sách";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Location = new System.Drawing.Point(20, 360);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(305, 50);
            this.btnTraSach.TabIndex = 11;
            this.btnTraSach.Text = "XÁC NHẬN TRẢ SÁCH";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // numPhiPhat
            // 
            this.numPhiPhat.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPhiPhat.Location = new System.Drawing.Point(125, 290);
            this.numPhiPhat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhiPhat.Name = "numPhiPhat";
            this.numPhiPhat.Size = new System.Drawing.Size(200, 30);
            this.numPhiPhat.TabIndex = 10;
            this.numPhiPhat.ThousandsSeparator = true;
            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.AutoSize = true;
            this.lblPhiPhat.Location = new System.Drawing.Point(15, 293);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(78, 23);
            this.lblPhiPhat.TabIndex = 9;
            this.lblPhiPhat.Text = "Phí phạt:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(125, 240);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(200, 29);
            this.cboTinhTrang.TabIndex = 8;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(15, 243);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(94, 23);
            this.lblTinhTrang.TabIndex = 7;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(125, 190);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(200, 30);
            this.dtNgayTra.TabIndex = 6;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(15, 193);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(80, 23);
            this.lblNgayTra.TabIndex = 5;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // cboNhanVienTra
            // 
            this.cboNhanVienTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTra.FormattingEnabled = true;
            this.cboNhanVienTra.Location = new System.Drawing.Point(125, 140);
            this.cboNhanVienTra.Name = "cboNhanVienTra";
            this.cboNhanVienTra.Size = new System.Drawing.Size(200, 29);
            this.cboNhanVienTra.TabIndex = 4;
            // 
            // lblNhanVienTra
            // 
            this.lblNhanVienTra.AutoSize = true;
            this.lblNhanVienTra.Location = new System.Drawing.Point(15, 143);
            this.lblNhanVienTra.Name = "lblNhanVienTra";
            this.lblNhanVienTra.Size = new System.Drawing.Size(92, 23);
            this.lblNhanVienTra.TabIndex = 3;
            this.lblNhanVienTra.Text = "Nhân viên:";
            // 
            // btnTaiSachMuon
            // 
            this.btnTaiSachMuon.Location = new System.Drawing.Point(20, 85);
            this.btnTaiSachMuon.Name = "btnTaiSachMuon";
            this.btnTaiSachMuon.Size = new System.Drawing.Size(305, 38);
            this.btnTaiSachMuon.TabIndex = 2;
            this.btnTaiSachMuon.Text = "Tải sách đang mượn";
            this.btnTaiSachMuon.UseVisualStyleBackColor = true;
            this.btnTaiSachMuon.Click += new System.EventHandler(this.btnTaiSachMuon_Click);
            // 
            // cboDocGiaTra
            // 
            this.cboDocGiaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(100, 40);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(225, 29);
            this.cboDocGiaTra.TabIndex = 1;
            this.cboDocGiaTra.SelectedIndexChanged += new System.EventHandler(this.cboDocGiaTra_SelectedIndexChanged);
            // 
            // lblDocGiaTra
            // 
            this.lblDocGiaTra.AutoSize = true;
            this.lblDocGiaTra.Location = new System.Drawing.Point(15, 43);
            this.lblDocGiaTra.Name = "lblDocGiaTra";
            this.lblDocGiaTra.Size = new System.Drawing.Size(73, 23);
            this.lblDocGiaTra.TabIndex = 0;
            this.lblDocGiaTra.Text = "Độc giả:";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(1075, 712);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 765);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mượn - Trả sách";
            this.Load += new System.EventHandler(this.FrmMuonTra_Load);
            this.tabs.ResumeLayout(false);
            this.tabMuon.ResumeLayout(false);
            this.tabMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            this.grpThongTinMuon.ResumeLayout(false);
            this.grpThongTinMuon.PerformLayout();
            this.tabTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            this.grpThongTinTra.ResumeLayout(false);
            this.grpThongTinTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMuon;
        private System.Windows.Forms.TabPage tabTra;
        private System.Windows.Forms.GroupBox grpThongTinMuon;
        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.Label lblDocGia;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboNhanVienMuon;
        private System.Windows.Forms.Label lblNhanVienMuon;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtHenTra;
        private System.Windows.Forms.Label lblHenTra;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridView dgvSachCon;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.Label lblSachChon;
        private System.Windows.Forms.Label lblSachCon;
        private System.Windows.Forms.GroupBox grpThongTinTra;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
        private System.Windows.Forms.Label lblDocGiaTra;
        private System.Windows.Forms.Button btnTaiSachMuon;
        private System.Windows.Forms.ComboBox cboNhanVienTra;
        private System.Windows.Forms.Label lblNhanVienTra;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.NumericUpDown numPhiPhat;
        private System.Windows.Forms.Label lblPhiPhat;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.DataGridView dgvDangMuon;
        private System.Windows.Forms.Button btnDong;
    }
}

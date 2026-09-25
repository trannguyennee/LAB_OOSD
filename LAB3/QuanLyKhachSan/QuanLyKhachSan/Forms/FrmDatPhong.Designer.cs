namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.pnlTopKhach = new System.Windows.Forms.Panel();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.lblPhieuHeader = new System.Windows.Forms.Label();
            this.pnlMiddleDat = new System.Windows.Forms.Panel();
            this.pnlRightDat = new System.Windows.Forms.Panel();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.pnlActionChon = new System.Windows.Forms.Panel();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.pnlLeftDat = new System.Windows.Forms.Panel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.pnlActionPhong = new System.Windows.Forms.Panel();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.pnlTopDat = new System.Windows.Forms.Panel();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.lblTra = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNhan = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.lblLap = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.lblCoc = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblKenh = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.tabNhanPhong = new System.Windows.Forms.TabPage();
            this.pnlSplitNhan = new System.Windows.Forms.SplitContainer();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.lblHeaderCT = new System.Windows.Forms.Label();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.lblHeaderNguoi = new System.Windows.Forms.Label();
            this.pnlTopNhan = new System.Windows.Forms.Panel();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.lblNguoiQT = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.lblNguoiCMND = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.lblNguoiTen = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.lblNguoiPhong = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.lblPhieuChon = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.pnlTopKhach.SuspendLayout();
            this.tabDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.pnlMiddleDat.SuspendLayout();
            this.pnlRightDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            this.pnlActionChon.SuspendLayout();
            this.pnlLeftDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.pnlActionPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            this.pnlTopDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            this.tabNhanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSplitNhan)).BeginInit();
            this.pnlSplitNhan.Panel1.SuspendLayout();
            this.pnlSplitNhan.Panel2.SuspendLayout();
            this.pnlSplitNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            this.pnlTopNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabKhachHang);
            this.tabMain.Controls.Add(this.tabDatPhong);
            this.tabMain.Controls.Add(this.tabNhanPhong);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 1;
            this.tabMain.Size = new System.Drawing.Size(984, 611);
            this.tabMain.TabIndex = 0;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.dgvKhach);
            this.tabKhachHang.Controls.Add(this.pnlTopKhach);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 26);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(976, 581);
            this.tabKhachHang.TabIndex = 0;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // dgvKhach
            // 
            this.dgvKhach.AllowUserToAddRows = false;
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhach.Location = new System.Drawing.Point(3, 58);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.RowHeadersWidth = 30;
            this.dgvKhach.Size = new System.Drawing.Size(970, 520);
            this.dgvKhach.TabIndex = 1;
            // 
            // pnlTopKhach
            // 
            this.pnlTopKhach.Controls.Add(this.btnThemKhach);
            this.pnlTopKhach.Controls.Add(this.txtSDT);
            this.pnlTopKhach.Controls.Add(this.lblSDT);
            this.pnlTopKhach.Controls.Add(this.txtQT);
            this.pnlTopKhach.Controls.Add(this.lblQT);
            this.pnlTopKhach.Controls.Add(this.txtCMND);
            this.pnlTopKhach.Controls.Add(this.lblCMND);
            this.pnlTopKhach.Controls.Add(this.txtTenKH);
            this.pnlTopKhach.Controls.Add(this.lblTenKH);
            this.pnlTopKhach.Controls.Add(this.txtMaKH);
            this.pnlTopKhach.Controls.Add(this.lblMaKH);
            this.pnlTopKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopKhach.Location = new System.Drawing.Point(3, 3);
            this.pnlTopKhach.Name = "pnlTopKhach";
            this.pnlTopKhach.Size = new System.Drawing.Size(970, 55);
            this.pnlTopKhach.TabIndex = 0;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(855, 12);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(95, 30);
            this.btnThemKhach.TabIndex = 10;
            this.btnThemKhach.Text = "Thêm khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(735, 15);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(105, 25);
            this.txtSDT.TabIndex = 9;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(695, 18);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(34, 17);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "SĐT:";
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(580, 15);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(100, 25);
            this.txtQT.TabIndex = 7;
            this.txtQT.Text = "Việt Nam";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(510, 18);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(66, 17);
            this.lblQT.TabIndex = 6;
            this.lblQT.Text = "Quốc tịch:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(385, 15);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(115, 25);
            this.txtCMND.TabIndex = 5;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(300, 18);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(81, 17);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CMND/CCCD:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(170, 15);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(120, 25);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(120, 18);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(50, 17);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(40, 15);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(70, 25);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(10, 18);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(30, 17);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã:";
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.dgvPhieu);
            this.tabDatPhong.Controls.Add(this.lblPhieuHeader);
            this.tabDatPhong.Controls.Add(this.pnlMiddleDat);
            this.tabDatPhong.Controls.Add(this.pnlTopDat);
            this.tabDatPhong.Location = new System.Drawing.Point(4, 26);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatPhong.Size = new System.Drawing.Size(976, 581);
            this.tabDatPhong.TabIndex = 1;
            this.tabDatPhong.Text = "Đặt phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieu.Location = new System.Drawing.Point(3, 375);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersWidth = 30;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(970, 203);
            this.dgvPhieu.TabIndex = 3;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // lblPhieuHeader
            // 
            this.lblPhieuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhieuHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuHeader.Location = new System.Drawing.Point(3, 345);
            this.lblPhieuHeader.Name = "lblPhieuHeader";
            this.lblPhieuHeader.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblPhieuHeader.Size = new System.Drawing.Size(970, 30);
            this.lblPhieuHeader.TabIndex = 2;
            this.lblPhieuHeader.Text = "Phiếu đặt phòng:";
            // 
            // pnlMiddleDat
            // 
            this.pnlMiddleDat.Controls.Add(this.pnlRightDat);
            this.pnlMiddleDat.Controls.Add(this.pnlLeftDat);
            this.pnlMiddleDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleDat.Location = new System.Drawing.Point(3, 90);
            this.pnlMiddleDat.Name = "pnlMiddleDat";
            this.pnlMiddleDat.Size = new System.Drawing.Size(970, 255);
            this.pnlMiddleDat.TabIndex = 1;
            // 
            // pnlRightDat
            // 
            this.pnlRightDat.Controls.Add(this.dgvChon);
            this.pnlRightDat.Controls.Add(this.pnlActionChon);
            this.pnlRightDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightDat.Location = new System.Drawing.Point(500, 0);
            this.pnlRightDat.Name = "pnlRightDat";
            this.pnlRightDat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlRightDat.Size = new System.Drawing.Size(470, 255);
            this.pnlRightDat.TabIndex = 1;
            // 
            // dgvChon
            // 
            this.dgvChon.AllowUserToAddRows = false;
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChon.Location = new System.Drawing.Point(5, 0);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.ReadOnly = true;
            this.dgvChon.RowHeadersWidth = 30;
            this.dgvChon.Size = new System.Drawing.Size(465, 210);
            this.dgvChon.TabIndex = 0;
            // 
            // pnlActionChon
            // 
            this.pnlActionChon.Controls.Add(this.btnBoPhong);
            this.pnlActionChon.Controls.Add(this.btnLapPhieu);
            this.pnlActionChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActionChon.Location = new System.Drawing.Point(5, 210);
            this.pnlActionChon.Name = "pnlActionChon";
            this.pnlActionChon.Size = new System.Drawing.Size(465, 45);
            this.pnlActionChon.TabIndex = 1;
            // 
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(10, 8);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(95, 30);
            this.btnBoPhong.TabIndex = 0;
            this.btnBoPhong.Text = "Xóa chọn";
            this.btnBoPhong.UseVisualStyleBackColor = true;
            this.btnBoPhong.Visible = false;
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.Location = new System.Drawing.Point(325, 7);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(135, 32);
            this.btnLapPhieu.TabIndex = 1;
            this.btnLapPhieu.Text = "Lập phiếu đặt";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // pnlLeftDat
            // 
            this.pnlLeftDat.Controls.Add(this.dgvPhong);
            this.pnlLeftDat.Controls.Add(this.pnlActionPhong);
            this.pnlLeftDat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftDat.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftDat.Name = "pnlLeftDat";
            this.pnlLeftDat.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlLeftDat.Size = new System.Drawing.Size(500, 255);
            this.pnlLeftDat.TabIndex = 0;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(495, 210);
            this.dgvPhong.TabIndex = 0;
            // 
            // pnlActionPhong
            // 
            this.pnlActionPhong.Controls.Add(this.btnThemPhong);
            this.pnlActionPhong.Controls.Add(this.numSoNguoi);
            this.pnlActionPhong.Controls.Add(this.lblSoNguoi);
            this.pnlActionPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActionPhong.Location = new System.Drawing.Point(0, 210);
            this.pnlActionPhong.Name = "pnlActionPhong";
            this.pnlActionPhong.Size = new System.Drawing.Size(495, 45);
            this.pnlActionPhong.TabIndex = 1;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(210, 8);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(140, 30);
            this.btnThemPhong.TabIndex = 2;
            this.btnThemPhong.Text = "Chọn phòng >>";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Visible = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(125, 11);
            this.numSoNguoi.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(65, 25);
            this.numSoNguoi.TabIndex = 1;
            this.numSoNguoi.Value = new decimal(new int[] { 2, 0, 0, 0 });
            this.numSoNguoi.Visible = false;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(10, 14);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(107, 17);
            this.lblSoNguoi.TabIndex = 0;
            this.lblSoNguoi.Text = "Số người phòng:";
            this.lblSoNguoi.Visible = false;
            // 
            // pnlTopDat
            // 
            this.pnlTopDat.Controls.Add(this.cboNV);
            this.pnlTopDat.Controls.Add(this.lblNV);
            this.pnlTopDat.Controls.Add(this.dtTra);
            this.pnlTopDat.Controls.Add(this.lblTra);
            this.pnlTopDat.Controls.Add(this.dtNhan);
            this.pnlTopDat.Controls.Add(this.lblNhan);
            this.pnlTopDat.Controls.Add(this.dtLap);
            this.pnlTopDat.Controls.Add(this.lblLap);
            this.pnlTopDat.Controls.Add(this.numCoc);
            this.pnlTopDat.Controls.Add(this.lblCoc);
            this.pnlTopDat.Controls.Add(this.cboKenh);
            this.pnlTopDat.Controls.Add(this.lblKenh);
            this.pnlTopDat.Controls.Add(this.cboKhach);
            this.pnlTopDat.Controls.Add(this.lblKhach);
            this.pnlTopDat.Controls.Add(this.txtSoPhieu);
            this.pnlTopDat.Controls.Add(this.lblSoPhieu);
            this.pnlTopDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDat.Location = new System.Drawing.Point(3, 3);
            this.pnlTopDat.Name = "pnlTopDat";
            this.pnlTopDat.Size = new System.Drawing.Size(970, 48);
            this.pnlTopDat.TabIndex = 0;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(775, 48);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(175, 25);
            this.cboNV.TabIndex = 15;
            this.cboNV.Visible = false;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(725, 51);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(46, 17);
            this.lblNV.TabIndex = 14;
            this.lblNV.Text = "Lễ tân:";
            this.lblNV.Visible = false;
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(595, 48);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(110, 25);
            this.dtTra.TabIndex = 13;
            this.dtTra.Visible = false;
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(525, 51);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(62, 17);
            this.lblTra.TabIndex = 12;
            this.lblTra.Text = "Ngày trả:";
            this.lblTra.Visible = false;
            // 
            // dtNhan
            // 
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNhan.Location = new System.Drawing.Point(395, 48);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(110, 25);
            this.dtNhan.TabIndex = 11;
            this.dtNhan.Visible = false;
            // 
            // lblNhan
            // 
            this.lblNhan.AutoSize = true;
            this.lblNhan.Location = new System.Drawing.Point(315, 51);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(74, 17);
            this.lblNhan.TabIndex = 10;
            this.lblNhan.Text = "Ngày nhận:";
            this.lblNhan.Visible = false;
            // 
            // dtLap
            // 
            this.dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLap.Location = new System.Drawing.Point(100, 48);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(120, 25);
            this.dtLap.TabIndex = 9;
            this.dtLap.Visible = false;
            // 
            // lblLap
            // 
            this.lblLap.AutoSize = true;
            this.lblLap.Location = new System.Drawing.Point(10, 51);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(64, 17);
            this.lblLap.TabIndex = 8;
            this.lblLap.Text = "Ngày lập:";
            this.lblLap.Visible = false;
            // 
            // numCoc
            // 
            this.numCoc.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numCoc.Location = new System.Drawing.Point(825, 12);
            this.numCoc.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(125, 25);
            this.numCoc.TabIndex = 7;
            this.numCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCoc.ThousandsSeparator = true;
            this.numCoc.Value = new decimal(new int[] { 500000, 0, 0, 0 });
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(760, 15);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(60, 17);
            this.lblCoc.TabIndex = 6;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // cboKenh
            // 
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(625, 12);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(115, 25);
            this.cboKenh.TabIndex = 5;
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Location = new System.Drawing.Point(560, 15);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(60, 17);
            this.lblKenh.TabIndex = 4;
            this.lblKenh.Text = "Kênh đặt:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(315, 12);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(225, 25);
            this.cboKhach.TabIndex = 3;
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(265, 15);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(46, 17);
            this.lblKhach.TabIndex = 2;
            this.lblKhach.Text = "Khách:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(100, 12);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(145, 25);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(10, 15);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(89, 17);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu đặt:";
            // 
            // tabNhanPhong
            // 
            this.tabNhanPhong.Controls.Add(this.pnlSplitNhan);
            this.tabNhanPhong.Controls.Add(this.pnlTopNhan);
            this.tabNhanPhong.Location = new System.Drawing.Point(4, 26);
            this.tabNhanPhong.Name = "tabNhanPhong";
            this.tabNhanPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanPhong.Size = new System.Drawing.Size(976, 581);
            this.tabNhanPhong.TabIndex = 2;
            this.tabNhanPhong.Text = "Nhận phòng / Người lưu trú";
            this.tabNhanPhong.UseVisualStyleBackColor = true;
            // 
            // pnlSplitNhan
            // 
            this.pnlSplitNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplitNhan.Location = new System.Drawing.Point(3, 90);
            this.pnlSplitNhan.Name = "pnlSplitNhan";
            // 
            // pnlSplitNhan.Panel1
            // 
            this.pnlSplitNhan.Panel1.Controls.Add(this.dgvCT);
            this.pnlSplitNhan.Panel1.Controls.Add(this.lblHeaderCT);
            // 
            // pnlSplitNhan.Panel2
            // 
            this.pnlSplitNhan.Panel2.Controls.Add(this.dgvNguoi);
            this.pnlSplitNhan.Panel2.Controls.Add(this.lblHeaderNguoi);
            this.pnlSplitNhan.Size = new System.Drawing.Size(970, 488);
            this.pnlSplitNhan.SplitterDistance = 450;
            this.pnlSplitNhan.TabIndex = 1;
            // 
            // dgvCT
            // 
            this.dgvCT.AllowUserToAddRows = false;
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.BackgroundColor = System.Drawing.Color.White;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCT.Location = new System.Drawing.Point(0, 25);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.ReadOnly = true;
            this.dgvCT.RowHeadersWidth = 30;
            this.dgvCT.Size = new System.Drawing.Size(450, 463);
            this.dgvCT.TabIndex = 1;
            // 
            // lblHeaderCT
            // 
            this.lblHeaderCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderCT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCT.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderCT.Name = "lblHeaderCT";
            this.lblHeaderCT.Size = new System.Drawing.Size(450, 25);
            this.lblHeaderCT.TabIndex = 0;
            this.lblHeaderCT.Text = "Danh sách phòng trong phiếu:";
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.AllowUserToAddRows = false;
            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoi.Location = new System.Drawing.Point(0, 25);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.ReadOnly = true;
            this.dgvNguoi.RowHeadersWidth = 30;
            this.dgvNguoi.Size = new System.Drawing.Size(516, 463);
            this.dgvNguoi.TabIndex = 1;
            // 
            // lblHeaderNguoi
            // 
            this.lblHeaderNguoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderNguoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderNguoi.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderNguoi.Name = "lblHeaderNguoi";
            this.lblHeaderNguoi.Size = new System.Drawing.Size(516, 25);
            this.lblHeaderNguoi.TabIndex = 0;
            this.lblHeaderNguoi.Text = "Danh sách người lưu trú thực tế:";
            // 
            // pnlTopNhan
            // 
            this.pnlTopNhan.Controls.Add(this.btnNoShow);
            this.pnlTopNhan.Controls.Add(this.btnNhanPhong);
            this.pnlTopNhan.Controls.Add(this.btnThemNguoi);
            this.pnlTopNhan.Controls.Add(this.txtNguoiQT);
            this.pnlTopNhan.Controls.Add(this.lblNguoiQT);
            this.pnlTopNhan.Controls.Add(this.txtNguoiCMND);
            this.pnlTopNhan.Controls.Add(this.lblNguoiCMND);
            this.pnlTopNhan.Controls.Add(this.txtNguoiTen);
            this.pnlTopNhan.Controls.Add(this.lblNguoiTen);
            this.pnlTopNhan.Controls.Add(this.txtNguoiPhong);
            this.pnlTopNhan.Controls.Add(this.lblNguoiPhong);
            this.pnlTopNhan.Controls.Add(this.txtPhieuChon);
            this.pnlTopNhan.Controls.Add(this.lblPhieuChon);
            this.pnlTopNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNhan.Location = new System.Drawing.Point(3, 3);
            this.pnlTopNhan.Name = "pnlTopNhan";
            this.pnlTopNhan.Size = new System.Drawing.Size(970, 87);
            this.pnlTopNhan.TabIndex = 0;
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(825, 48);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(125, 30);
            this.btnNoShow.TabIndex = 12;
            this.btnNoShow.Text = "Báo No-show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.Location = new System.Drawing.Point(685, 48);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(125, 30);
            this.btnNhanPhong.TabIndex = 11;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(545, 48);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(115, 30);
            this.btnThemNguoi.TabIndex = 10;
            this.btnThemNguoi.Text = "Thêm người";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(375, 51);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(140, 25);
            this.txtNguoiQT.TabIndex = 9;
            this.txtNguoiQT.Text = "Việt Nam";
            // 
            // lblNguoiQT
            // 
            this.lblNguoiQT.AutoSize = true;
            this.lblNguoiQT.Location = new System.Drawing.Point(305, 54);
            this.lblNguoiQT.Name = "lblNguoiQT";
            this.lblNguoiQT.Size = new System.Drawing.Size(66, 17);
            this.lblNguoiQT.TabIndex = 8;
            this.lblNguoiQT.Text = "Quốc tịch:";
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(100, 51);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(180, 25);
            this.txtNguoiCMND.TabIndex = 7;
            // 
            // lblNguoiCMND
            // 
            this.lblNguoiCMND.AutoSize = true;
            this.lblNguoiCMND.Location = new System.Drawing.Point(10, 54);
            this.lblNguoiCMND.Name = "lblNguoiCMND";
            this.lblNguoiCMND.Size = new System.Drawing.Size(81, 17);
            this.lblNguoiCMND.TabIndex = 6;
            this.lblNguoiCMND.Text = "CMND/CCCD:";
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(625, 12);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(185, 25);
            this.txtNguoiTen.TabIndex = 5;
            // 
            // lblNguoiTen
            // 
            this.lblNguoiTen.AutoSize = true;
            this.lblNguoiTen.Location = new System.Drawing.Point(545, 15);
            this.lblNguoiTen.Name = "lblNguoiTen";
            this.lblNguoiTen.Size = new System.Drawing.Size(76, 17);
            this.lblNguoiTen.TabIndex = 4;
            this.lblNguoiTen.Text = "Họ tên ở:";
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(375, 12);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(140, 25);
            this.txtNguoiPhong.TabIndex = 3;
            // 
            // lblNguoiPhong
            // 
            this.lblNguoiPhong.AutoSize = true;
            this.lblNguoiPhong.Location = new System.Drawing.Point(305, 15);
            this.lblNguoiPhong.Name = "lblNguoiPhong";
            this.lblNguoiPhong.Size = new System.Drawing.Size(65, 17);
            this.lblNguoiPhong.TabIndex = 2;
            this.lblNguoiPhong.Text = "Số phòng:";
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhieuChon.Location = new System.Drawing.Point(100, 12);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(180, 25);
            this.txtPhieuChon.TabIndex = 1;
            // 
            // lblPhieuChon
            // 
            this.lblPhieuChon.AutoSize = true;
            this.lblPhieuChon.Location = new System.Drawing.Point(10, 15);
            this.lblPhieuChon.Name = "lblPhieuChon";
            this.lblPhieuChon.Size = new System.Drawing.Size(76, 17);
            this.lblPhieuChon.TabIndex = 0;
            this.lblPhieuChon.Text = "Phiếu chọn:";
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            this.tabMain.ResumeLayout(false);
            this.tabKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.pnlTopKhach.ResumeLayout(false);
            this.pnlTopKhach.PerformLayout();
            this.tabDatPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.pnlMiddleDat.ResumeLayout(false);
            this.pnlRightDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            this.pnlActionChon.ResumeLayout(false);
            this.pnlLeftDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.pnlActionPhong.ResumeLayout(false);
            this.pnlActionPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            this.pnlTopDat.ResumeLayout(false);
            this.pnlTopDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            this.tabNhanPhong.ResumeLayout(false);
            this.pnlSplitNhan.Panel1.ResumeLayout(false);
            this.pnlSplitNhan.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSplitNhan)).EndInit();
            this.pnlSplitNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            this.pnlTopNhan.ResumeLayout(false);
            this.pnlTopNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Panel pnlTopKhach;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.Panel pnlTopDat;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.Label lblLap;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Panel pnlMiddleDat;
        private System.Windows.Forms.Panel pnlLeftDat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Panel pnlActionPhong;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Panel pnlRightDat;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Panel pnlActionChon;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblPhieuHeader;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.TabPage tabNhanPhong;
        private System.Windows.Forms.Panel pnlTopNhan;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.Label lblPhieuChon;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.Label lblNguoiPhong;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.Label lblNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.Label lblNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Label lblNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnNoShow;
        private System.Windows.Forms.SplitContainer pnlSplitNhan;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Label lblHeaderCT;
        private System.Windows.Forms.DataGridView dgvNguoi;
        private System.Windows.Forms.Label lblHeaderNguoi;
    }
}

namespace eShopping.Forms
{
    partial class FrmTrangChu
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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnXemLichSu = new System.Windows.Forms.Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.grpSanPham = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.pnlChonMua = new System.Windows.Forms.Panel();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cboNhomSanPham = new System.Windows.Forms.ComboBox();
            this.lblNhomSP = new System.Windows.Forms.Label();
            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlTongTien = new System.Windows.Forms.Panel();
            this.btnTienHanhDatHang = new System.Windows.Forms.Button();
            this.lblGiaTriTongTien = new System.Windows.Forms.Label();
            this.lblTongTienTieuDe = new System.Windows.Forms.Label();
            this.pnlThaoTacGio = new System.Windows.Forms.Panel();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.pnlChonMua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.pnlLoc.SuspendLayout();
            this.grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlTongTien.SuspendLayout();
            this.pnlThaoTacGio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.pnlHeader.Controls.Add(this.btnXemLichSu);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1264, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnXemLichSu
            // 
            this.btnXemLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnXemLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichSu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemLichSu.ForeColor = System.Drawing.Color.White;
            this.btnXemLichSu.Location = new System.Drawing.Point(1035, 18);
            this.btnXemLichSu.Name = "btnXemLichSu";
            this.btnXemLichSu.Size = new System.Drawing.Size(205, 38);
            this.btnXemLichSu.TabIndex = 2;
            this.btnXemLichSu.Text = "📜 Lịch Sử Đơn Hàng";
            this.btnXemLichSu.UseVisualStyleBackColor = false;
            this.btnXemLichSu.Click += new System.EventHandler(this.btnXemLichSu_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lblSubTitle.Location = new System.Drawing.Point(20, 43);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(512, 17);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Sinh viên thực hiện: Trần Nguyên - MSSV: 1250080121 - Lớp: 12CNPM2 - Môn: OOSD";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(572, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG CỬA HÀNG TRỰC TUYẾN e-SHOPPING";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 75);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.grpSanPham);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.grpGioHang);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitMain.Size = new System.Drawing.Size(1264, 606);
            this.splitMain.SplitterDistance = 750;
            this.splitMain.TabIndex = 1;
            // 
            // grpSanPham
            // 
            this.grpSanPham.Controls.Add(this.dgvSanPham);
            this.grpSanPham.Controls.Add(this.pnlChonMua);
            this.grpSanPham.Controls.Add(this.pnlLoc);
            this.grpSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpSanPham.Location = new System.Drawing.Point(10, 10);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.Padding = new System.Windows.Forms.Padding(8);
            this.grpSanPham.Size = new System.Drawing.Size(730, 586);
            this.grpSanPham.TabIndex = 0;
            this.grpSanPham.TabStop = false;
            this.grpSanPham.Text = "DANH SÁCH SẢN PHẨM TRỰC TUYẾN";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            dgvHeaderStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvSanPham.ColumnHeadersHeight = 32;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvSanPham.Location = new System.Drawing.Point(8, 76);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(714, 452);
            this.dgvSanPham.TabIndex = 1;
            // 
            // pnlChonMua
            // 
            this.pnlChonMua.Controls.Add(this.btnThemVaoGio);
            this.pnlChonMua.Controls.Add(this.nudSoLuong);
            this.pnlChonMua.Controls.Add(this.lblSoLuong);
            this.pnlChonMua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChonMua.Location = new System.Drawing.Point(8, 528);
            this.pnlChonMua.Name = "pnlChonMua";
            this.pnlChonMua.Size = new System.Drawing.Size(714, 50);
            this.pnlChonMua.TabIndex = 2;
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(500, 7);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(205, 36);
            this.btnThemVaoGio.TabIndex = 2;
            this.btnThemVaoGio.Text = "+ Thêm Vào Giỏ Hàng";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudSoLuong.Location = new System.Drawing.Point(395, 14);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(85, 25);
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(295, 17);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(95, 17);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng mua:";
            // 
            // pnlLoc
            // 
            this.pnlLoc.Controls.Add(this.btnLamMoi);
            this.pnlLoc.Controls.Add(this.btnTimKiem);
            this.pnlLoc.Controls.Add(this.txtTimKiem);
            this.pnlLoc.Controls.Add(this.lblTimKiem);
            this.pnlLoc.Controls.Add(this.cboNhomSanPham);
            this.pnlLoc.Controls.Add(this.lblNhomSP);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(8, 26);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(714, 50);
            this.pnlLoc.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(630, 9);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 29);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Tất cả";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(545, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 29);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTimKiem.Location = new System.Drawing.Point(375, 11);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 25);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTimKiem.ForeColor = System.Drawing.Color.Black;
            this.lblTimKiem.Location = new System.Drawing.Point(310, 15);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(62, 17);
            this.lblTimKiem.TabIndex = 2;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // cboNhomSanPham
            // 
            this.cboNhomSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboNhomSanPham.FormattingEnabled = true;
            this.cboNhomSanPham.Location = new System.Drawing.Point(120, 11);
            this.cboNhomSanPham.Name = "cboNhomSanPham";
            this.cboNhomSanPham.Size = new System.Drawing.Size(180, 25);
            this.cboNhomSanPham.TabIndex = 1;
            this.cboNhomSanPham.SelectedIndexChanged += new System.EventHandler(this.cboNhomSanPham_SelectedIndexChanged);
            // 
            // lblNhomSP
            // 
            this.lblNhomSP.AutoSize = true;
            this.lblNhomSP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNhomSP.ForeColor = System.Drawing.Color.Black;
            this.lblNhomSP.Location = new System.Drawing.Point(5, 15);
            this.lblNhomSP.Name = "lblNhomSP";
            this.lblNhomSP.Size = new System.Drawing.Size(110, 17);
            this.lblNhomSP.TabIndex = 0;
            this.lblNhomSP.Text = "Nhóm sản phẩm:";
            // 
            // grpGioHang
            // 
            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.grpGioHang.Controls.Add(this.pnlTongTien);
            this.grpGioHang.Controls.Add(this.pnlThaoTacGio);
            this.grpGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGioHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGioHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpGioHang.Location = new System.Drawing.Point(10, 10);
            this.grpGioHang.Name = "grpGioHang";
            this.grpGioHang.Padding = new System.Windows.Forms.Padding(8);
            this.grpGioHang.Size = new System.Drawing.Size(490, 586);
            this.grpGioHang.TabIndex = 0;
            this.grpGioHang.TabStop = false;
            this.grpGioHang.Text = "GIỎ HÀNG CỦA BẠN";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dgvHeaderStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            dgvHeaderStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvHeaderStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle = dgvHeaderStyle2;
            this.dgvGioHang.ColumnHeadersHeight = 32;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvGioHang.Location = new System.Drawing.Point(8, 26);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(474, 412);
            this.dgvGioHang.TabIndex = 0;
            // 
            // pnlTongTien
            // 
            this.pnlTongTien.Controls.Add(this.btnTienHanhDatHang);
            this.pnlTongTien.Controls.Add(this.lblGiaTriTongTien);
            this.pnlTongTien.Controls.Add(this.lblTongTienTieuDe);
            this.pnlTongTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTongTien.Location = new System.Drawing.Point(8, 438);
            this.pnlTongTien.Name = "pnlTongTien";
            this.pnlTongTien.Size = new System.Drawing.Size(474, 100);
            this.pnlTongTien.TabIndex = 2;
            // 
            // btnTienHanhDatHang
            // 
            this.btnTienHanhDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTienHanhDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnTienHanhDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienHanhDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTienHanhDatHang.ForeColor = System.Drawing.Color.White;
            this.btnTienHanhDatHang.Location = new System.Drawing.Point(8, 46);
            this.btnTienHanhDatHang.Name = "btnTienHanhDatHang";
            this.btnTienHanhDatHang.Size = new System.Drawing.Size(458, 46);
            this.btnTienHanhDatHang.TabIndex = 2;
            this.btnTienHanhDatHang.Text = "👉 Tiến Hành Đặt Hàng && Thanh Toán";
            this.btnTienHanhDatHang.UseVisualStyleBackColor = false;
            this.btnTienHanhDatHang.Click += new System.EventHandler(this.btnTienHanhDatHang_Click);
            // 
            // lblGiaTriTongTien
            // 
            this.lblGiaTriTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiaTriTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblGiaTriTongTien.Location = new System.Drawing.Point(190, 8);
            this.lblGiaTriTongTien.Name = "lblGiaTriTongTien";
            this.lblGiaTriTongTien.Size = new System.Drawing.Size(276, 28);
            this.lblGiaTriTongTien.TabIndex = 1;
            this.lblGiaTriTongTien.Text = "0 đ";
            this.lblGiaTriTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienTieuDe
            // 
            this.lblTongTienTieuDe.AutoSize = true;
            this.lblTongTienTieuDe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTienTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTongTienTieuDe.Location = new System.Drawing.Point(5, 12);
            this.lblTongTienTieuDe.Name = "lblTongTienTieuDe";
            this.lblTongTienTieuDe.Size = new System.Drawing.Size(142, 20);
            this.lblTongTienTieuDe.TabIndex = 0;
            this.lblTongTienTieuDe.Text = "Tổng tiền tạm tính:";
            // 
            // pnlThaoTacGio
            // 
            this.pnlThaoTacGio.Controls.Add(this.btnXoaTatCa);
            this.pnlThaoTacGio.Controls.Add(this.btnXoaMon);
            this.pnlThaoTacGio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThaoTacGio.Location = new System.Drawing.Point(8, 538);
            this.pnlThaoTacGio.Name = "pnlThaoTacGio";
            this.pnlThaoTacGio.Size = new System.Drawing.Size(474, 40);
            this.pnlThaoTacGio.TabIndex = 1;
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnXoaTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaTatCa.ForeColor = System.Drawing.Color.White;
            this.btnXoaTatCa.Location = new System.Drawing.Point(344, 4);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(122, 32);
            this.btnXoaTatCa.TabIndex = 1;
            this.btnXoaTatCa.Text = "Xóa toàn bộ";
            this.btnXoaTatCa.UseVisualStyleBackColor = false;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.Location = new System.Drawing.Point(8, 4);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(120, 32);
            this.btnXoaMon.TabIndex = 0;
            this.btnXoaMon.Text = "Xóa món chọn";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-SHOPPING - Cửa Hàng Trực Tuyến";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.pnlChonMua.ResumeLayout(false);
            this.pnlChonMua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.grpGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlTongTien.ResumeLayout(false);
            this.pnlTongTien.PerformLayout();
            this.pnlThaoTacGio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox grpSanPham;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label lblNhomSP;
        private System.Windows.Forms.ComboBox cboNhomSanPham;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel pnlChonMua;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel pnlThaoTacGio;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Panel pnlTongTien;
        private System.Windows.Forms.Label lblTongTienTieuDe;
        private System.Windows.Forms.Label lblGiaTriTongTien;
        private System.Windows.Forms.Button btnTienHanhDatHang;
        private System.Windows.Forms.Button btnXemLichSu;
    }
}

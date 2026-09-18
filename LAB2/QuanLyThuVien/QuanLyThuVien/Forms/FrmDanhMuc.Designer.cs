namespace QuanLyThuVien.Forms
{
    partial class FrmDanhMuc
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
            this.tabNV = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.grpNV = new System.Windows.Forms.GroupBox();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.lblNVChucVu = new System.Windows.Forms.Label();
            this.dtNVNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNVNgaySinh = new System.Windows.Forms.Label();
            this.cboNVPhai = new System.Windows.Forms.ComboBox();
            this.lblNVPhai = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVHo = new System.Windows.Forms.TextBox();
            this.lblNVHo = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.btnNVMoi = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVCapNhat = new System.Windows.Forms.Button();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.tabTL = new System.Windows.Forms.TabPage();
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.grpTL = new System.Windows.Forms.GroupBox();
            this.btnTLMoi = new System.Windows.Forms.Button();
            this.btnTLXoa = new System.Windows.Forms.Button();
            this.btnTLCapNhat = new System.Windows.Forms.Button();
            this.btnTLThem = new System.Windows.Forms.Button();
            this.txtTLTen = new System.Windows.Forms.TextBox();
            this.lblTLTen = new System.Windows.Forms.Label();
            this.txtTLMa = new System.Windows.Forms.TextBox();
            this.lblTLMa = new System.Windows.Forms.Label();
            this.tabNXB = new System.Windows.Forms.TabPage();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.grpNXB = new System.Windows.Forms.GroupBox();
            this.btnNXBMoi = new System.Windows.Forms.Button();
            this.btnNXBXoa = new System.Windows.Forms.Button();
            this.btnNXBCapNhat = new System.Windows.Forms.Button();
            this.btnNXBThem = new System.Windows.Forms.Button();
            this.txtNXBSDT = new System.Windows.Forms.TextBox();
            this.lblNXBSDT = new System.Windows.Forms.Label();
            this.txtNXBDiaChi = new System.Windows.Forms.TextBox();
            this.lblNXBDiaChi = new System.Windows.Forms.Label();
            this.txtNXBMa = new System.Windows.Forms.TextBox();
            this.lblNXBMa = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.grpNV.SuspendLayout();
            this.tabTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.grpTL.SuspendLayout();
            this.tabNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.grpNXB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabNV);
            this.tabs.Controls.Add(this.tabTL);
            this.tabs.Controls.Add(this.tabNXB);
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1036, 646);
            this.tabs.TabIndex = 0;
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Controls.Add(this.grpNV);
            this.tabNV.Location = new System.Drawing.Point(4, 32);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(1028, 610);
            this.tabNV.TabIndex = 0;
            this.tabNV.Text = "Nhân viên";
            this.tabNV.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(375, 15);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(635, 578);
            this.dgvNV.TabIndex = 1;
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);
            // 
            // grpNV
            // 
            this.grpNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpNV.Controls.Add(this.txtNVSDT);
            this.grpNV.Controls.Add(this.lblNVSDT);
            this.grpNV.Controls.Add(this.txtNVChucVu);
            this.grpNV.Controls.Add(this.lblNVChucVu);
            this.grpNV.Controls.Add(this.dtNVNgaySinh);
            this.grpNV.Controls.Add(this.lblNVNgaySinh);
            this.grpNV.Controls.Add(this.cboNVPhai);
            this.grpNV.Controls.Add(this.lblNVPhai);
            this.grpNV.Controls.Add(this.txtNVTen);
            this.grpNV.Controls.Add(this.lblNVTen);
            this.grpNV.Controls.Add(this.txtNVHo);
            this.grpNV.Controls.Add(this.lblNVHo);
            this.grpNV.Controls.Add(this.txtNVMa);
            this.grpNV.Controls.Add(this.lblNVMa);
            this.grpNV.Controls.Add(this.btnNVMoi);
            this.grpNV.Controls.Add(this.btnNVXoa);
            this.grpNV.Controls.Add(this.btnNVCapNhat);
            this.grpNV.Controls.Add(this.btnNVThem);
            this.grpNV.Location = new System.Drawing.Point(15, 15);
            this.grpNV.Name = "grpNV";
            this.grpNV.Size = new System.Drawing.Size(345, 578);
            this.grpNV.TabIndex = 0;
            this.grpNV.TabStop = false;
            this.grpNV.Text = "Thông tin nhân viên";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(120, 275);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(205, 30);
            this.txtNVSDT.TabIndex = 13;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(15, 278);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(93, 23);
            this.lblNVSDT.TabIndex = 12;
            this.lblNVSDT.Text = "Điện thoại:";
            // 
            // txtNVChucVu
            // 
            this.txtNVChucVu.Location = new System.Drawing.Point(120, 235);
            this.txtNVChucVu.Name = "txtNVChucVu";
            this.txtNVChucVu.Size = new System.Drawing.Size(205, 30);
            this.txtNVChucVu.TabIndex = 11;
            // 
            // lblNVChucVu
            // 
            this.lblNVChucVu.AutoSize = true;
            this.lblNVChucVu.Location = new System.Drawing.Point(15, 238);
            this.lblNVChucVu.Name = "lblNVChucVu";
            this.lblNVChucVu.Size = new System.Drawing.Size(76, 23);
            this.lblNVChucVu.TabIndex = 10;
            this.lblNVChucVu.Text = "Chức vụ:";
            // 
            // dtNVNgaySinh
            // 
            this.dtNVNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVNgaySinh.Location = new System.Drawing.Point(120, 195);
            this.dtNVNgaySinh.Name = "dtNVNgaySinh";
            this.dtNVNgaySinh.Size = new System.Drawing.Size(205, 30);
            this.dtNVNgaySinh.TabIndex = 9;
            // 
            // lblNVNgaySinh
            // 
            this.lblNVNgaySinh.AutoSize = true;
            this.lblNVNgaySinh.Location = new System.Drawing.Point(15, 198);
            this.lblNVNgaySinh.Name = "lblNVNgaySinh";
            this.lblNVNgaySinh.Size = new System.Drawing.Size(90, 23);
            this.lblNVNgaySinh.TabIndex = 8;
            this.lblNVNgaySinh.Text = "Ngày sinh:";
            // 
            // cboNVPhai
            // 
            this.cboNVPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVPhai.FormattingEnabled = true;
            this.cboNVPhai.Location = new System.Drawing.Point(120, 155);
            this.cboNVPhai.Name = "cboNVPhai";
            this.cboNVPhai.Size = new System.Drawing.Size(205, 29);
            this.cboNVPhai.TabIndex = 7;
            // 
            // lblNVPhai
            // 
            this.lblNVPhai.AutoSize = true;
            this.lblNVPhai.Location = new System.Drawing.Point(15, 158);
            this.lblNVPhai.Name = "lblNVPhai";
            this.lblNVPhai.Size = new System.Drawing.Size(47, 23);
            this.lblNVPhai.TabIndex = 6;
            this.lblNVPhai.Text = "Phái:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(120, 115);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(205, 30);
            this.txtNVTen.TabIndex = 5;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(15, 118);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(40, 23);
            this.lblNVTen.TabIndex = 4;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVHo
            // 
            this.txtNVHo.Location = new System.Drawing.Point(120, 75);
            this.txtNVHo.Name = "txtNVHo";
            this.txtNVHo.Size = new System.Drawing.Size(205, 30);
            this.txtNVHo.TabIndex = 3;
            // 
            // lblNVHo
            // 
            this.lblNVHo.AutoSize = true;
            this.lblNVHo.Location = new System.Drawing.Point(15, 78);
            this.lblNVHo.Name = "lblNVHo";
            this.lblNVHo.Size = new System.Drawing.Size(36, 23);
            this.lblNVHo.TabIndex = 2;
            this.lblNVHo.Text = "Họ:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(120, 35);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(205, 30);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(15, 38);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(68, 23);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã NV:";
            // 
            // btnNVMoi
            // 
            this.btnNVMoi.Location = new System.Drawing.Point(180, 390);
            this.btnNVMoi.Name = "btnNVMoi";
            this.btnNVMoi.Size = new System.Drawing.Size(145, 40);
            this.btnNVMoi.TabIndex = 17;
            this.btnNVMoi.Text = "Làm mới";
            this.btnNVMoi.UseVisualStyleBackColor = true;
            this.btnNVMoi.Click += new System.EventHandler(this.btnNVMoi_Click);
            // 
            // btnNVXoa
            // 
            this.btnNVXoa.Location = new System.Drawing.Point(19, 390);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(145, 40);
            this.btnNVXoa.TabIndex = 16;
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.UseVisualStyleBackColor = true;
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);
            // 
            // btnNVCapNhat
            // 
            this.btnNVCapNhat.Location = new System.Drawing.Point(180, 335);
            this.btnNVCapNhat.Name = "btnNVCapNhat";
            this.btnNVCapNhat.Size = new System.Drawing.Size(145, 40);
            this.btnNVCapNhat.TabIndex = 15;
            this.btnNVCapNhat.Text = "Cập nhật";
            this.btnNVCapNhat.UseVisualStyleBackColor = true;
            this.btnNVCapNhat.Click += new System.EventHandler(this.btnNVCapNhat_Click);
            // 
            // btnNVThem
            // 
            this.btnNVThem.Location = new System.Drawing.Point(19, 335);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(145, 40);
            this.btnNVThem.TabIndex = 14;
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.UseVisualStyleBackColor = true;
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);
            // 
            // tabTL
            // 
            this.tabTL.Controls.Add(this.dgvTL);
            this.tabTL.Controls.Add(this.grpTL);
            this.tabTL.Location = new System.Drawing.Point(4, 32);
            this.tabTL.Name = "tabTL";
            this.tabTL.Padding = new System.Windows.Forms.Padding(3);
            this.tabTL.Size = new System.Drawing.Size(1028, 610);
            this.tabTL.TabIndex = 1;
            this.tabTL.Text = "Thể loại";
            this.tabTL.UseVisualStyleBackColor = true;
            // 
            // dgvTL
            // 
            this.dgvTL.AllowUserToAddRows = false;
            this.dgvTL.AllowUserToDeleteRows = false;
            this.dgvTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Location = new System.Drawing.Point(375, 15);
            this.dgvTL.MultiSelect = false;
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.ReadOnly = true;
            this.dgvTL.RowHeadersWidth = 51;
            this.dgvTL.RowTemplate.Height = 24;
            this.dgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTL.Size = new System.Drawing.Size(635, 578);
            this.dgvTL.TabIndex = 3;
            this.dgvTL.SelectionChanged += new System.EventHandler(this.dgvTL_SelectionChanged);
            // 
            // grpTL
            // 
            this.grpTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpTL.Controls.Add(this.btnTLMoi);
            this.grpTL.Controls.Add(this.btnTLXoa);
            this.grpTL.Controls.Add(this.btnTLCapNhat);
            this.grpTL.Controls.Add(this.btnTLThem);
            this.grpTL.Controls.Add(this.txtTLTen);
            this.grpTL.Controls.Add(this.lblTLTen);
            this.grpTL.Controls.Add(this.txtTLMa);
            this.grpTL.Controls.Add(this.lblTLMa);
            this.grpTL.Location = new System.Drawing.Point(15, 15);
            this.grpTL.Name = "grpTL";
            this.grpTL.Size = new System.Drawing.Size(345, 578);
            this.grpTL.TabIndex = 2;
            this.grpTL.TabStop = false;
            this.grpTL.Text = "Thông tin thể loại";
            // 
            // btnTLMoi
            // 
            this.btnTLMoi.Location = new System.Drawing.Point(180, 160);
            this.btnTLMoi.Name = "btnTLMoi";
            this.btnTLMoi.Size = new System.Drawing.Size(145, 40);
            this.btnTLMoi.TabIndex = 7;
            this.btnTLMoi.Text = "Làm mới";
            this.btnTLMoi.UseVisualStyleBackColor = true;
            this.btnTLMoi.Click += new System.EventHandler(this.btnTLMoi_Click);
            // 
            // btnTLXoa
            // 
            this.btnTLXoa.Location = new System.Drawing.Point(19, 160);
            this.btnTLXoa.Name = "btnTLXoa";
            this.btnTLXoa.Size = new System.Drawing.Size(145, 40);
            this.btnTLXoa.TabIndex = 6;
            this.btnTLXoa.Text = "Xóa";
            this.btnTLXoa.UseVisualStyleBackColor = true;
            this.btnTLXoa.Click += new System.EventHandler(this.btnTLXoa_Click);
            // 
            // btnTLCapNhat
            // 
            this.btnTLCapNhat.Location = new System.Drawing.Point(180, 105);
            this.btnTLCapNhat.Name = "btnTLCapNhat";
            this.btnTLCapNhat.Size = new System.Drawing.Size(145, 40);
            this.btnTLCapNhat.TabIndex = 5;
            this.btnTLCapNhat.Text = "Cập nhật";
            this.btnTLCapNhat.UseVisualStyleBackColor = true;
            this.btnTLCapNhat.Click += new System.EventHandler(this.btnTLCapNhat_Click);
            // 
            // btnTLThem
            // 
            this.btnTLThem.Location = new System.Drawing.Point(19, 105);
            this.btnTLThem.Name = "btnTLThem";
            this.btnTLThem.Size = new System.Drawing.Size(145, 40);
            this.btnTLThem.TabIndex = 4;
            this.btnTLThem.Text = "Thêm";
            this.btnTLThem.UseVisualStyleBackColor = true;
            this.btnTLThem.Click += new System.EventHandler(this.btnTLThem_Click);
            // 
            // txtTLTen
            // 
            this.txtTLTen.Location = new System.Drawing.Point(120, 60);
            this.txtTLTen.Name = "txtTLTen";
            this.txtTLTen.Size = new System.Drawing.Size(205, 30);
            this.txtTLTen.TabIndex = 3;
            // 
            // lblTLTen
            // 
            this.lblTLTen.AutoSize = true;
            this.lblTLTen.Location = new System.Drawing.Point(15, 63);
            this.lblTLTen.Name = "lblTLTen";
            this.lblTLTen.Size = new System.Drawing.Size(102, 23);
            this.lblTLTen.TabIndex = 2;
            this.lblTLTen.Text = "Tên thể loại:";
            // 
            // txtTLMa
            // 
            this.txtTLMa.Location = new System.Drawing.Point(120, 25);
            this.txtTLMa.Name = "txtTLMa";
            this.txtTLMa.Size = new System.Drawing.Size(205, 30);
            this.txtTLMa.TabIndex = 1;
            // 
            // lblTLMa
            // 
            this.lblTLMa.AutoSize = true;
            this.lblTLMa.Location = new System.Drawing.Point(15, 28);
            this.lblTLMa.Name = "lblTLMa";
            this.lblTLMa.Size = new System.Drawing.Size(65, 23);
            this.lblTLMa.TabIndex = 0;
            this.lblTLMa.Text = "Mã TL:";
            // 
            // tabNXB
            // 
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Controls.Add(this.grpNXB);
            this.tabNXB.Location = new System.Drawing.Point(4, 32);
            this.tabNXB.Name = "tabNXB";
            this.tabNXB.Padding = new System.Windows.Forms.Padding(3);
            this.tabNXB.Size = new System.Drawing.Size(1028, 610);
            this.tabNXB.TabIndex = 2;
            this.tabNXB.Text = "Nhà xuất bản";
            this.tabNXB.UseVisualStyleBackColor = true;
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(375, 15);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersWidth = 51;
            this.dgvNXB.RowTemplate.Height = 24;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(635, 578);
            this.dgvNXB.TabIndex = 3;
            this.dgvNXB.SelectionChanged += new System.EventHandler(this.dgvNXB_SelectionChanged);
            // 
            // grpNXB
            // 
            this.grpNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpNXB.Controls.Add(this.btnNXBMoi);
            this.grpNXB.Controls.Add(this.btnNXBXoa);
            this.grpNXB.Controls.Add(this.btnNXBCapNhat);
            this.grpNXB.Controls.Add(this.btnNXBThem);
            this.grpNXB.Controls.Add(this.txtNXBSDT);
            this.grpNXB.Controls.Add(this.lblNXBSDT);
            this.grpNXB.Controls.Add(this.txtNXBDiaChi);
            this.grpNXB.Controls.Add(this.lblNXBDiaChi);
            this.grpNXB.Controls.Add(this.txtNXBMa);
            this.grpNXB.Controls.Add(this.lblNXBMa);
            this.grpNXB.Location = new System.Drawing.Point(15, 15);
            this.grpNXB.Name = "grpNXB";
            this.grpNXB.Size = new System.Drawing.Size(345, 578);
            this.grpNXB.TabIndex = 2;
            this.grpNXB.TabStop = false;
            this.grpNXB.Text = "Thông tin nhà xuất bản";
            // 
            // btnNXBMoi
            // 
            this.btnNXBMoi.Location = new System.Drawing.Point(180, 180);
            this.btnNXBMoi.Name = "btnNXBMoi";
            this.btnNXBMoi.Size = new System.Drawing.Size(145, 40);
            this.btnNXBMoi.TabIndex = 9;
            this.btnNXBMoi.Text = "Làm mới";
            this.btnNXBMoi.UseVisualStyleBackColor = true;
            this.btnNXBMoi.Click += new System.EventHandler(this.btnNXBMoi_Click);
            // 
            // btnNXBXoa
            // 
            this.btnNXBXoa.Location = new System.Drawing.Point(19, 180);
            this.btnNXBXoa.Name = "btnNXBXoa";
            this.btnNXBXoa.Size = new System.Drawing.Size(145, 40);
            this.btnNXBXoa.TabIndex = 8;
            this.btnNXBXoa.Text = "Xóa";
            this.btnNXBXoa.UseVisualStyleBackColor = true;
            this.btnNXBXoa.Click += new System.EventHandler(this.btnNXBXoa_Click);
            // 
            // btnNXBCapNhat
            // 
            this.btnNXBCapNhat.Location = new System.Drawing.Point(180, 125);
            this.btnNXBCapNhat.Name = "btnNXBCapNhat";
            this.btnNXBCapNhat.Size = new System.Drawing.Size(145, 40);
            this.btnNXBCapNhat.TabIndex = 7;
            this.btnNXBCapNhat.Text = "Cập nhật";
            this.btnNXBCapNhat.UseVisualStyleBackColor = true;
            this.btnNXBCapNhat.Click += new System.EventHandler(this.btnNXBCapNhat_Click);
            // 
            // btnNXBThem
            // 
            this.btnNXBThem.Location = new System.Drawing.Point(19, 125);
            this.btnNXBThem.Name = "btnNXBThem";
            this.btnNXBThem.Size = new System.Drawing.Size(145, 40);
            this.btnNXBThem.TabIndex = 6;
            this.btnNXBThem.Text = "Thêm";
            this.btnNXBThem.UseVisualStyleBackColor = true;
            this.btnNXBThem.Click += new System.EventHandler(this.btnNXBThem_Click);
            // 
            // txtNXBSDT
            // 
            this.txtNXBSDT.Location = new System.Drawing.Point(120, 80);
            this.txtNXBSDT.Name = "txtNXBSDT";
            this.txtNXBSDT.Size = new System.Drawing.Size(205, 30);
            this.txtNXBSDT.TabIndex = 5;
            // 
            // lblNXBSDT
            // 
            this.lblNXBSDT.AutoSize = true;
            this.lblNXBSDT.Location = new System.Drawing.Point(15, 83);
            this.lblNXBSDT.Name = "lblNXBSDT";
            this.lblNXBSDT.Size = new System.Drawing.Size(93, 23);
            this.lblNXBSDT.TabIndex = 4;
            this.lblNXBSDT.Text = "Điện thoại:";
            // 
            // txtNXBDiaChi
            // 
            this.txtNXBDiaChi.Location = new System.Drawing.Point(120, 45);
            this.txtNXBDiaChi.Name = "txtNXBDiaChi";
            this.txtNXBDiaChi.Size = new System.Drawing.Size(205, 30);
            this.txtNXBDiaChi.TabIndex = 3;
            // 
            // lblNXBDiaChi
            // 
            this.lblNXBDiaChi.AutoSize = true;
            this.lblNXBDiaChi.Location = new System.Drawing.Point(15, 48);
            this.lblNXBDiaChi.Name = "lblNXBDiaChi";
            this.lblNXBDiaChi.Size = new System.Drawing.Size(66, 23);
            this.lblNXBDiaChi.TabIndex = 2;
            this.lblNXBDiaChi.Text = "Địa chỉ:";
            // 
            // txtNXBMa
            // 
            this.txtNXBMa.Location = new System.Drawing.Point(120, 10);
            this.txtNXBMa.Name = "txtNXBMa";
            this.txtNXBMa.Size = new System.Drawing.Size(205, 30);
            this.txtNXBMa.TabIndex = 1;
            // 
            // lblNXBMa
            // 
            this.lblNXBMa.AutoSize = true;
            this.lblNXBMa.Location = new System.Drawing.Point(15, 13);
            this.lblNXBMa.Name = "lblNXBMa";
            this.lblNXBMa.Size = new System.Drawing.Size(78, 23);
            this.lblNXBMa.TabIndex = 0;
            this.lblNXBMa.Text = "Mã NXB:";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(928, 668);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục và nhân viên";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabs.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.grpNV.ResumeLayout(false);
            this.grpNV.PerformLayout();
            this.tabTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.grpTL.ResumeLayout(false);
            this.grpTL.PerformLayout();
            this.tabNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.grpNXB.ResumeLayout(false);
            this.grpNXB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabTL;
        private System.Windows.Forms.TabPage tabNXB;
        private System.Windows.Forms.GroupBox grpNV;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.Label lblNVChucVu;
        private System.Windows.Forms.DateTimePicker dtNVNgaySinh;
        private System.Windows.Forms.Label lblNVNgaySinh;
        private System.Windows.Forms.ComboBox cboNVPhai;
        private System.Windows.Forms.Label lblNVPhai;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVHo;
        private System.Windows.Forms.Label lblNVHo;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.Button btnNVMoi;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVCapNhat;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.GroupBox grpTL;
        private System.Windows.Forms.Button btnTLMoi;
        private System.Windows.Forms.Button btnTLXoa;
        private System.Windows.Forms.Button btnTLCapNhat;
        private System.Windows.Forms.Button btnTLThem;
        private System.Windows.Forms.TextBox txtTLTen;
        private System.Windows.Forms.Label lblTLTen;
        private System.Windows.Forms.TextBox txtTLMa;
        private System.Windows.Forms.Label lblTLMa;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.GroupBox grpNXB;
        private System.Windows.Forms.Button btnNXBMoi;
        private System.Windows.Forms.Button btnNXBXoa;
        private System.Windows.Forms.Button btnNXBCapNhat;
        private System.Windows.Forms.Button btnNXBThem;
        private System.Windows.Forms.TextBox txtNXBSDT;
        private System.Windows.Forms.Label lblNXBSDT;
        private System.Windows.Forms.TextBox txtNXBDiaChi;
        private System.Windows.Forms.Label lblNXBDiaChi;
        private System.Windows.Forms.TextBox txtNXBMa;
        private System.Windows.Forms.Label lblNXBMa;
        private System.Windows.Forms.Button btnDong;
    }
}

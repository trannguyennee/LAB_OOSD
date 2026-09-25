namespace QuanLyKhachSan.Forms
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
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.pnlKhu = new System.Windows.Forms.Panel();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.txtKhuDonVi = new System.Windows.Forms.TextBox();
            this.lblKhuDonVi = new System.Windows.Forms.Label();
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.pnlNV = new System.Windows.Forms.Panel();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.pnlLoaiTN = new System.Windows.Forms.Panel();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.lblLoaiTen = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.lblLoaiMa = new System.Windows.Forms.Label();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.pnlDV = new System.Windows.Forms.Panel();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.lblDVGia = new System.Windows.Forms.Label();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.lblDVMa = new System.Windows.Forms.Label();
            this.tabQuyDinh = new System.Windows.Forms.TabPage();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.pnlQD = new System.Windows.Forms.Panel();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.lblQDTien = new System.Windows.Forms.Label();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.lblQDMucDo = new System.Windows.Forms.Label();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.lblQDMa = new System.Windows.Forms.Label();
            this.tabDanhMuc.SuspendLayout();
            this.tabKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.pnlKhu.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.pnlNV.SuspendLayout();
            this.tabLoaiTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.pnlLoaiTN.SuspendLayout();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.pnlDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            this.tabQuyDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.pnlQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.tabKhuVuc);
            this.tabDanhMuc.Controls.Add(this.tabNhanVien);
            this.tabDanhMuc.Controls.Add(this.tabLoaiTN);
            this.tabDanhMuc.Controls.Add(this.tabDichVu);
            this.tabDanhMuc.Controls.Add(this.tabQuyDinh);
            this.tabDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 0;
            this.tabDanhMuc.Size = new System.Drawing.Size(834, 461);
            this.tabDanhMuc.TabIndex = 0;
            // 
            // tabKhuVuc
            // 
            this.tabKhuVuc.Controls.Add(this.dgvKhu);
            this.tabKhuVuc.Controls.Add(this.pnlKhu);
            this.tabKhuVuc.Location = new System.Drawing.Point(4, 26);
            this.tabKhuVuc.Name = "tabKhuVuc";
            this.tabKhuVuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhuVuc.Size = new System.Drawing.Size(826, 431);
            this.tabKhuVuc.TabIndex = 0;
            this.tabKhuVuc.Text = "Khu vực";
            this.tabKhuVuc.UseVisualStyleBackColor = true;
            // 
            // dgvKhu
            // 
            this.dgvKhu.AllowUserToAddRows = false;
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhu.Location = new System.Drawing.Point(3, 58);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.ReadOnly = true;
            this.dgvKhu.RowHeadersWidth = 30;
            this.dgvKhu.Size = new System.Drawing.Size(820, 370);
            this.dgvKhu.TabIndex = 1;
            // 
            // pnlKhu
            // 
            this.pnlKhu.Controls.Add(this.btnThemKhu);
            this.pnlKhu.Controls.Add(this.txtKhuDonVi);
            this.pnlKhu.Controls.Add(this.lblKhuDonVi);
            this.pnlKhu.Controls.Add(this.txtKhuTen);
            this.pnlKhu.Controls.Add(this.lblKhuTen);
            this.pnlKhu.Controls.Add(this.txtKhuMa);
            this.pnlKhu.Controls.Add(this.lblKhuMa);
            this.pnlKhu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhu.Location = new System.Drawing.Point(3, 3);
            this.pnlKhu.Name = "pnlKhu";
            this.pnlKhu.Size = new System.Drawing.Size(820, 55);
            this.pnlKhu.TabIndex = 0;
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(710, 12);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(90, 30);
            this.btnThemKhu.TabIndex = 6;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            // 
            // txtKhuDonVi
            // 
            this.txtKhuDonVi.Location = new System.Drawing.Point(525, 15);
            this.txtKhuDonVi.Name = "txtKhuDonVi";
            this.txtKhuDonVi.Size = new System.Drawing.Size(160, 25);
            this.txtKhuDonVi.TabIndex = 5;
            // 
            // lblKhuDonVi
            // 
            this.lblKhuDonVi.AutoSize = true;
            this.lblKhuDonVi.Location = new System.Drawing.Point(415, 18);
            this.lblKhuDonVi.Name = "lblKhuDonVi";
            this.lblKhuDonVi.Size = new System.Drawing.Size(105, 17);
            this.lblKhuDonVi.TabIndex = 4;
            this.lblKhuDonVi.Text = "Đơn vị / Vai trò:";
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(235, 15);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(160, 25);
            this.txtKhuTen.TabIndex = 3;
            // 
            // lblKhuTen
            // 
            this.lblKhuTen.AutoSize = true;
            this.lblKhuTen.Location = new System.Drawing.Point(195, 18);
            this.lblKhuTen.Name = "lblKhuTen";
            this.lblKhuTen.Size = new System.Drawing.Size(32, 17);
            this.lblKhuTen.TabIndex = 2;
            this.lblKhuTen.Text = "Tên:";
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(55, 15);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(125, 25);
            this.txtKhuMa.TabIndex = 1;
            // 
            // lblKhuMa
            // 
            this.lblKhuMa.AutoSize = true;
            this.lblKhuMa.Location = new System.Drawing.Point(15, 18);
            this.lblKhuMa.Name = "lblKhuMa";
            this.lblKhuMa.Size = new System.Drawing.Size(30, 17);
            this.lblKhuMa.TabIndex = 0;
            this.lblKhuMa.Text = "Mã:";
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.dgvNV);
            this.tabNhanVien.Controls.Add(this.pnlNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 26);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(826, 431);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.Location = new System.Drawing.Point(3, 58);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.ReadOnly = true;
            this.dgvNV.RowHeadersWidth = 30;
            this.dgvNV.Size = new System.Drawing.Size(820, 370);
            this.dgvNV.TabIndex = 1;
            // 
            // pnlNV
            // 
            this.pnlNV.Controls.Add(this.btnThemNV);
            this.pnlNV.Controls.Add(this.txtNVSDT);
            this.pnlNV.Controls.Add(this.lblNVSDT);
            this.pnlNV.Controls.Add(this.txtNVVaiTro);
            this.pnlNV.Controls.Add(this.lblNVVaiTro);
            this.pnlNV.Controls.Add(this.txtNVTen);
            this.pnlNV.Controls.Add(this.lblNVTen);
            this.pnlNV.Controls.Add(this.txtNVMa);
            this.pnlNV.Controls.Add(this.lblNVMa);
            this.pnlNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNV.Location = new System.Drawing.Point(3, 3);
            this.pnlNV.Name = "pnlNV";
            this.pnlNV.Size = new System.Drawing.Size(820, 55);
            this.pnlNV.TabIndex = 0;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(720, 12);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(85, 30);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(600, 15);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(105, 25);
            this.txtNVSDT.TabIndex = 7;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(560, 18);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(34, 17);
            this.lblNVSDT.TabIndex = 6;
            this.lblNVSDT.Text = "SĐT:";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(435, 15);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(115, 25);
            this.txtNVVaiTro.TabIndex = 5;
            // 
            // lblNVVaiTro
            // 
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location = new System.Drawing.Point(375, 18);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.Size = new System.Drawing.Size(49, 17);
            this.lblNVVaiTro.TabIndex = 4;
            this.lblNVVaiTro.Text = "Vai trò:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(205, 15);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(160, 25);
            this.txtNVTen.TabIndex = 3;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(165, 18);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(32, 17);
            this.lblNVTen.TabIndex = 2;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(55, 15);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(95, 25);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(15, 18);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(30, 17);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã:";
            // 
            // tabLoaiTN
            // 
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTN.Controls.Add(this.pnlLoaiTN);
            this.tabLoaiTN.Location = new System.Drawing.Point(4, 26);
            this.tabLoaiTN.Name = "tabLoaiTN";
            this.tabLoaiTN.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoaiTN.Size = new System.Drawing.Size(826, 431);
            this.tabLoaiTN.TabIndex = 2;
            this.tabLoaiTN.Text = "Loại tiện nghi";
            this.tabLoaiTN.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.AllowUserToAddRows = false;
            this.dgvLoaiTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTN.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiTN.Location = new System.Drawing.Point(3, 58);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.ReadOnly = true;
            this.dgvLoaiTN.RowHeadersWidth = 30;
            this.dgvLoaiTN.Size = new System.Drawing.Size(820, 370);
            this.dgvLoaiTN.TabIndex = 1;
            // 
            // pnlLoaiTN
            // 
            this.pnlLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.pnlLoaiTN.Controls.Add(this.txtLoaiTen);
            this.pnlLoaiTN.Controls.Add(this.lblLoaiTen);
            this.pnlLoaiTN.Controls.Add(this.txtLoaiMa);
            this.pnlLoaiTN.Controls.Add(this.lblLoaiMa);
            this.pnlLoaiTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoaiTN.Location = new System.Drawing.Point(3, 3);
            this.pnlLoaiTN.Name = "pnlLoaiTN";
            this.pnlLoaiTN.Size = new System.Drawing.Size(820, 55);
            this.pnlLoaiTN.TabIndex = 0;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(490, 12);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(95, 30);
            this.btnThemLoaiTN.TabIndex = 4;
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(265, 15);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(200, 25);
            this.txtLoaiTen.TabIndex = 3;
            // 
            // lblLoaiTen
            // 
            this.lblLoaiTen.AutoSize = true;
            this.lblLoaiTen.Location = new System.Drawing.Point(225, 18);
            this.lblLoaiTen.Name = "lblLoaiTen";
            this.lblLoaiTen.Size = new System.Drawing.Size(32, 17);
            this.lblLoaiTen.TabIndex = 2;
            this.lblLoaiTen.Text = "Tên:";
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(60, 15);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(140, 25);
            this.txtLoaiMa.TabIndex = 1;
            // 
            // lblLoaiMa
            // 
            this.lblLoaiMa.AutoSize = true;
            this.lblLoaiMa.Location = new System.Drawing.Point(15, 18);
            this.lblLoaiMa.Name = "lblLoaiMa";
            this.lblLoaiMa.Size = new System.Drawing.Size(30, 17);
            this.lblLoaiMa.TabIndex = 0;
            this.lblLoaiMa.Text = "Mã:";
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvDV);
            this.tabDichVu.Controls.Add(this.pnlDV);
            this.tabDichVu.Location = new System.Drawing.Point(4, 26);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(826, 431);
            this.tabDichVu.TabIndex = 3;
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDV.Location = new System.Drawing.Point(3, 58);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 30;
            this.dgvDV.Size = new System.Drawing.Size(820, 370);
            this.dgvDV.TabIndex = 1;
            // 
            // pnlDV
            // 
            this.pnlDV.Controls.Add(this.numDVGia);
            this.pnlDV.Controls.Add(this.btnThemDV);
            this.pnlDV.Controls.Add(this.lblDVGia);
            this.pnlDV.Controls.Add(this.txtDVDVT);
            this.pnlDV.Controls.Add(this.lblDVDVT);
            this.pnlDV.Controls.Add(this.txtDVTen);
            this.pnlDV.Controls.Add(this.lblDVTen);
            this.pnlDV.Controls.Add(this.txtDVMa);
            this.pnlDV.Controls.Add(this.lblDVMa);
            this.pnlDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDV.Location = new System.Drawing.Point(3, 3);
            this.pnlDV.Name = "pnlDV";
            this.pnlDV.Size = new System.Drawing.Size(820, 55);
            this.pnlDV.TabIndex = 0;
            // 
            // numDVGia
            // 
            this.numDVGia.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numDVGia.Location = new System.Drawing.Point(600, 15);
            this.numDVGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(115, 25);
            this.numDVGia.TabIndex = 7;
            this.numDVGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDVGia.ThousandsSeparator = true;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(725, 12);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(85, 30);
            this.btnThemDV.TabIndex = 8;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // lblDVGia
            // 
            this.lblDVGia.AutoSize = true;
            this.lblDVGia.Location = new System.Drawing.Point(540, 18);
            this.lblDVGia.Name = "lblDVGia";
            this.lblDVGia.Size = new System.Drawing.Size(56, 17);
            this.lblDVGia.TabIndex = 6;
            this.lblDVGia.Text = "Đơn giá:";
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(425, 15);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(100, 25);
            this.txtDVDVT.TabIndex = 5;
            // 
            // lblDVDVT
            // 
            this.lblDVDVT.AutoSize = true;
            this.lblDVDVT.Location = new System.Drawing.Point(315, 18);
            this.lblDVDVT.Name = "lblDVDVT";
            this.lblDVDVT.Size = new System.Drawing.Size(105, 17);
            this.lblDVDVT.TabIndex = 4;
            this.lblDVDVT.Text = "Đơn vị / Vai trò:";
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(180, 15);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(125, 25);
            this.txtDVTen.TabIndex = 3;
            // 
            // lblDVTen
            // 
            this.lblDVTen.AutoSize = true;
            this.lblDVTen.Location = new System.Drawing.Point(145, 18);
            this.lblDVTen.Name = "lblDVTen";
            this.lblDVTen.Size = new System.Drawing.Size(32, 17);
            this.lblDVTen.TabIndex = 2;
            this.lblDVTen.Text = "Tên:";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(50, 15);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(85, 25);
            this.txtDVMa.TabIndex = 1;
            // 
            // lblDVMa
            // 
            this.lblDVMa.AutoSize = true;
            this.lblDVMa.Location = new System.Drawing.Point(15, 18);
            this.lblDVMa.Name = "lblDVMa";
            this.lblDVMa.Size = new System.Drawing.Size(30, 17);
            this.lblDVMa.TabIndex = 0;
            this.lblDVMa.Text = "Mã:";
            // 
            // tabQuyDinh
            // 
            this.tabQuyDinh.Controls.Add(this.dgvQD);
            this.tabQuyDinh.Controls.Add(this.pnlQD);
            this.tabQuyDinh.Location = new System.Drawing.Point(4, 26);
            this.tabQuyDinh.Name = "tabQuyDinh";
            this.tabQuyDinh.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuyDinh.Size = new System.Drawing.Size(826, 431);
            this.tabQuyDinh.TabIndex = 4;
            this.tabQuyDinh.Text = "Quy định đền bù";
            this.tabQuyDinh.UseVisualStyleBackColor = true;
            // 
            // dgvQD
            // 
            this.dgvQD.AllowUserToAddRows = false;
            this.dgvQD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQD.BackgroundColor = System.Drawing.Color.White;
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQD.Location = new System.Drawing.Point(3, 58);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.ReadOnly = true;
            this.dgvQD.RowHeadersWidth = 30;
            this.dgvQD.Size = new System.Drawing.Size(820, 370);
            this.dgvQD.TabIndex = 1;
            // 
            // pnlQD
            // 
            this.pnlQD.Controls.Add(this.numQDTien);
            this.pnlQD.Controls.Add(this.cboQDLoai);
            this.pnlQD.Controls.Add(this.btnThemQD);
            this.pnlQD.Controls.Add(this.lblQDTien);
            this.pnlQD.Controls.Add(this.txtQDMucDo);
            this.pnlQD.Controls.Add(this.lblQDMucDo);
            this.pnlQD.Controls.Add(this.lblQDLoai);
            this.pnlQD.Controls.Add(this.txtQDMa);
            this.pnlQD.Controls.Add(this.lblQDMa);
            this.pnlQD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQD.Location = new System.Drawing.Point(3, 3);
            this.pnlQD.Name = "pnlQD";
            this.pnlQD.Size = new System.Drawing.Size(820, 55);
            this.pnlQD.TabIndex = 0;
            // 
            // numQDTien
            // 
            this.numQDTien.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numQDTien.Location = new System.Drawing.Point(600, 15);
            this.numQDTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(115, 25);
            this.numQDTien.TabIndex = 7;
            this.numQDTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQDTien.ThousandsSeparator = true;
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(195, 15);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(130, 25);
            this.cboQDLoai.TabIndex = 3;
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(725, 12);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(85, 30);
            this.btnThemQD.TabIndex = 8;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = true;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            // 
            // lblQDTien
            // 
            this.lblQDTien.AutoSize = true;
            this.lblQDTien.Location = new System.Drawing.Point(540, 18);
            this.lblQDTien.Name = "lblQDTien";
            this.lblQDTien.Size = new System.Drawing.Size(56, 17);
            this.lblQDTien.TabIndex = 6;
            this.lblQDTien.Text = "Mức đền:";
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(400, 15);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(130, 25);
            this.txtQDMucDo.TabIndex = 5;
            // 
            // lblQDMucDo
            // 
            this.lblQDMucDo.AutoSize = true;
            this.lblQDMucDo.Location = new System.Drawing.Point(340, 18);
            this.lblQDMucDo.Name = "lblQDMucDo";
            this.lblQDMucDo.Size = new System.Drawing.Size(55, 17);
            this.lblQDMucDo.TabIndex = 4;
            this.lblQDMucDo.Text = "Mức độ:";
            // 
            // lblQDLoai
            // 
            this.lblQDLoai.AutoSize = true;
            this.lblQDLoai.Location = new System.Drawing.Point(135, 18);
            this.lblQDLoai.Name = "lblQDLoai";
            this.lblQDLoai.Size = new System.Drawing.Size(56, 17);
            this.lblQDLoai.TabIndex = 2;
            this.lblQDLoai.Text = "Loại TN:";
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(45, 15);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(80, 25);
            this.txtQDMa.TabIndex = 1;
            // 
            // lblQDMa
            // 
            this.lblQDMa.AutoSize = true;
            this.lblQDMa.Location = new System.Drawing.Point(12, 18);
            this.lblQDMa.Name = "lblQDMa";
            this.lblQDMa.Size = new System.Drawing.Size(30, 17);
            this.lblQDMa.TabIndex = 0;
            this.lblQDMa.Text = "Mã:";
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tabDanhMuc);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khách sạn";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabDanhMuc.ResumeLayout(false);
            this.tabKhuVuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.pnlKhu.ResumeLayout(false);
            this.pnlKhu.PerformLayout();
            this.tabNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.pnlNV.ResumeLayout(false);
            this.pnlNV.PerformLayout();
            this.tabLoaiTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.pnlLoaiTN.ResumeLayout(false);
            this.pnlLoaiTN.PerformLayout();
            this.tabDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.pnlDV.ResumeLayout(false);
            this.pnlDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            this.tabQuyDinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.pnlQD.ResumeLayout(false);
            this.pnlQD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabKhuVuc;
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.Panel pnlKhu;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Label lblKhuTen;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Label lblKhuMa;
        private System.Windows.Forms.Label lblKhuDonVi;
        private System.Windows.Forms.TextBox txtKhuDonVi;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Panel pnlNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TabPage tabLoaiTN;
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.Panel pnlLoaiTN;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Label lblLoaiTen;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Label lblLoaiMa;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Panel pnlDV;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label lblDVGia;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label lblDVDVT;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label lblDVTen;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label lblDVMa;
        private System.Windows.Forms.TabPage tabQuyDinh;
        private System.Windows.Forms.DataGridView dgvQD;
        private System.Windows.Forms.Panel pnlQD;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.Label lblQDTien;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label lblQDMucDo;
        private System.Windows.Forms.Label lblQDLoai;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label lblQDMa;
    }
}

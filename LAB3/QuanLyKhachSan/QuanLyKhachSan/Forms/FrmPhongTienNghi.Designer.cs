namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
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
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.pnlTopPhong = new System.Windows.Forms.Panel();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.lblKhu = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.pnlBottomPhong = new System.Windows.Forms.Panel();
            this.btnLapDatQuick = new System.Windows.Forms.Button();
            this.txtTTLDQuick = new System.Windows.Forms.TextBox();
            this.lblTTLDQuick = new System.Windows.Forms.Label();
            this.cboPhongQuick = new System.Windows.Forms.ComboBox();
            this.lblPhongQuick = new System.Windows.Forms.Label();
            this.cboTNQuick = new System.Windows.Forms.ComboBox();
            this.lblTNQuick = new System.Windows.Forms.Label();
            this.txtSoLDQuick = new System.Windows.Forms.TextBox();
            this.lblSoLDQuick = new System.Windows.Forms.Label();
            this.tabTienNghi = new System.Windows.Forms.TabPage();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.pnlTopTN = new System.Windows.Forms.Panel();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.lblSTT = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.lblMaTN = new System.Windows.Forms.Label();
            this.tabLapDat = new System.Windows.Forms.TabPage();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.pnlTopLD = new System.Windows.Forms.Panel();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.lblTTLD = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblPhongLD = new System.Windows.Forms.Label();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.lblTN = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.lblSoLD = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.pnlTopPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.pnlBottomPhong.SuspendLayout();
            this.tabTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.pnlTopTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            this.tabLapDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.pnlTopLD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPhong);
            this.tabMain.Controls.Add(this.tabTienNghi);
            this.tabMain.Controls.Add(this.tabLapDat);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(884, 511);
            this.tabMain.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Controls.Add(this.pnlBottomPhong);
            this.tabPhong.Controls.Add(this.pnlTopPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(876, 481);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(3, 58);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.Size = new System.Drawing.Size(870, 365);
            this.dgvPhong.TabIndex = 1;
            // 
            // pnlTopPhong
            // 
            this.pnlTopPhong.Controls.Add(this.btnThemPhong);
            this.pnlTopPhong.Controls.Add(this.numGia);
            this.pnlTopPhong.Controls.Add(this.lblGia);
            this.pnlTopPhong.Controls.Add(this.numMax);
            this.pnlTopPhong.Controls.Add(this.lblMax);
            this.pnlTopPhong.Controls.Add(this.cboKhu);
            this.pnlTopPhong.Controls.Add(this.lblKhu);
            this.pnlTopPhong.Controls.Add(this.txtPhong);
            this.pnlTopPhong.Controls.Add(this.lblPhong);
            this.pnlTopPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPhong.Location = new System.Drawing.Point(3, 3);
            this.pnlTopPhong.Name = "pnlTopPhong";
            this.pnlTopPhong.Size = new System.Drawing.Size(870, 55);
            this.pnlTopPhong.TabIndex = 0;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(760, 12);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(95, 30);
            this.btnThemPhong.TabIndex = 8;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // numGia
            // 
            this.numGia.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numGia.Location = new System.Drawing.Point(625, 15);
            this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(120, 25);
            this.numGia.TabIndex = 7;
            this.numGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGia.ThousandsSeparator = true;
            this.numGia.Value = new decimal(new int[] { 600000, 0, 0, 0 });
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(530, 18);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(91, 17);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Đơn giá/ngày:";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(460, 15);
            this.numMax.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(55, 25);
            this.numMax.TabIndex = 5;
            this.numMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(355, 18);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(102, 17);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Số người tối đa:";
            // 
            // cboKhu
            // 
            this.cboKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(230, 15);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(110, 25);
            this.cboKhu.TabIndex = 3;
            // 
            // lblKhu
            // 
            this.lblKhu.AutoSize = true;
            this.lblKhu.Location = new System.Drawing.Point(170, 18);
            this.lblKhu.Name = "lblKhu";
            this.lblKhu.Size = new System.Drawing.Size(57, 17);
            this.lblKhu.TabIndex = 2;
            this.lblKhu.Text = "Khu vực:";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(75, 15);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(85, 25);
            this.txtPhong.TabIndex = 1;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(10, 18);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(66, 17);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Số phòng:";
            // 
            // pnlBottomPhong
            // 
            this.pnlBottomPhong.Controls.Add(this.btnLapDatQuick);
            this.pnlBottomPhong.Controls.Add(this.txtTTLDQuick);
            this.pnlBottomPhong.Controls.Add(this.lblTTLDQuick);
            this.pnlBottomPhong.Controls.Add(this.cboPhongQuick);
            this.pnlBottomPhong.Controls.Add(this.lblPhongQuick);
            this.pnlBottomPhong.Controls.Add(this.cboTNQuick);
            this.pnlBottomPhong.Controls.Add(this.lblTNQuick);
            this.pnlBottomPhong.Controls.Add(this.txtSoLDQuick);
            this.pnlBottomPhong.Controls.Add(this.lblSoLDQuick);
            this.pnlBottomPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomPhong.Location = new System.Drawing.Point(3, 423);
            this.pnlBottomPhong.Name = "pnlBottomPhong";
            this.pnlBottomPhong.Size = new System.Drawing.Size(870, 55);
            this.pnlBottomPhong.TabIndex = 2;
            // 
            // btnLapDatQuick
            // 
            this.btnLapDatQuick.Location = new System.Drawing.Point(760, 12);
            this.btnLapDatQuick.Name = "btnLapDatQuick";
            this.btnLapDatQuick.Size = new System.Drawing.Size(95, 30);
            this.btnLapDatQuick.TabIndex = 8;
            this.btnLapDatQuick.Text = "Lập phiếu";
            this.btnLapDatQuick.UseVisualStyleBackColor = true;
            this.btnLapDatQuick.Click += new System.EventHandler(this.btnLapDatQuick_Click);
            // 
            // txtTTLDQuick
            // 
            this.txtTTLDQuick.Location = new System.Drawing.Point(625, 15);
            this.txtTTLDQuick.Name = "txtTTLDQuick";
            this.txtTTLDQuick.Size = new System.Drawing.Size(120, 25);
            this.txtTTLDQuick.TabIndex = 7;
            this.txtTTLDQuick.Text = "Tốt";
            // 
            // lblTTLDQuick
            // 
            this.lblTTLDQuick.AutoSize = true;
            this.lblTTLDQuick.Location = new System.Drawing.Point(550, 18);
            this.lblTTLDQuick.Name = "lblTTLDQuick";
            this.lblTTLDQuick.Size = new System.Drawing.Size(71, 17);
            this.lblTTLDQuick.TabIndex = 6;
            this.lblTTLDQuick.Text = "Tình trạng:";
            // 
            // cboPhongQuick
            // 
            this.cboPhongQuick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongQuick.FormattingEnabled = true;
            this.cboPhongQuick.Location = new System.Drawing.Point(445, 15);
            this.cboPhongQuick.Name = "cboPhongQuick";
            this.cboPhongQuick.Size = new System.Drawing.Size(95, 25);
            this.cboPhongQuick.TabIndex = 5;
            // 
            // lblPhongQuick
            // 
            this.lblPhongQuick.AutoSize = true;
            this.lblPhongQuick.Location = new System.Drawing.Point(395, 18);
            this.lblPhongQuick.Name = "lblPhongQuick";
            this.lblPhongQuick.Size = new System.Drawing.Size(48, 17);
            this.lblPhongQuick.TabIndex = 4;
            this.lblPhongQuick.Text = "Phòng:";
            // 
            // cboTNQuick
            // 
            this.cboTNQuick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTNQuick.FormattingEnabled = true;
            this.cboTNQuick.Location = new System.Drawing.Point(275, 15);
            this.cboTNQuick.Name = "cboTNQuick";
            this.cboTNQuick.Size = new System.Drawing.Size(105, 25);
            this.cboTNQuick.TabIndex = 3;
            // 
            // lblTNQuick
            // 
            this.lblTNQuick.AutoSize = true;
            this.lblTNQuick.Location = new System.Drawing.Point(210, 18);
            this.lblTNQuick.Name = "lblTNQuick";
            this.lblTNQuick.Size = new System.Drawing.Size(64, 17);
            this.lblTNQuick.TabIndex = 2;
            this.lblTNQuick.Text = "Tiện nghi:";
            // 
            // txtSoLDQuick
            // 
            this.txtSoLDQuick.Location = new System.Drawing.Point(100, 15);
            this.txtSoLDQuick.Name = "txtSoLDQuick";
            this.txtSoLDQuick.Size = new System.Drawing.Size(95, 25);
            this.txtSoLDQuick.TabIndex = 1;
            // 
            // lblSoLDQuick
            // 
            this.lblSoLDQuick.AutoSize = true;
            this.lblSoLDQuick.Location = new System.Drawing.Point(10, 18);
            this.lblSoLDQuick.Name = "lblSoLDQuick";
            this.lblSoLDQuick.Size = new System.Drawing.Size(89, 17);
            this.lblSoLDQuick.TabIndex = 0;
            this.lblSoLDQuick.Text = "Phiếu lắp đặt:";
            // 
            // tabTienNghi
            // 
            this.tabTienNghi.Controls.Add(this.dgvTN);
            this.tabTienNghi.Controls.Add(this.pnlTopTN);
            this.tabTienNghi.Location = new System.Drawing.Point(4, 26);
            this.tabTienNghi.Name = "tabTienNghi";
            this.tabTienNghi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTienNghi.Size = new System.Drawing.Size(876, 481);
            this.tabTienNghi.TabIndex = 1;
            this.tabTienNghi.Text = "Tiện nghi";
            this.tabTienNghi.UseVisualStyleBackColor = true;
            // 
            // dgvTN
            // 
            this.dgvTN.AllowUserToAddRows = false;
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.BackgroundColor = System.Drawing.Color.White;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTN.Location = new System.Drawing.Point(3, 58);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.RowHeadersWidth = 30;
            this.dgvTN.Size = new System.Drawing.Size(870, 420);
            this.dgvTN.TabIndex = 1;
            // 
            // pnlTopTN
            // 
            this.pnlTopTN.Controls.Add(this.btnThemTN);
            this.pnlTopTN.Controls.Add(this.txtTinhTrang);
            this.pnlTopTN.Controls.Add(this.lblTinhTrang);
            this.pnlTopTN.Controls.Add(this.numSTT);
            this.pnlTopTN.Controls.Add(this.lblSTT);
            this.pnlTopTN.Controls.Add(this.cboLoai);
            this.pnlTopTN.Controls.Add(this.lblLoai);
            this.pnlTopTN.Controls.Add(this.txtMaTN);
            this.pnlTopTN.Controls.Add(this.lblMaTN);
            this.pnlTopTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTN.Location = new System.Drawing.Point(3, 3);
            this.pnlTopTN.Name = "pnlTopTN";
            this.pnlTopTN.Size = new System.Drawing.Size(870, 55);
            this.pnlTopTN.TabIndex = 0;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(750, 12);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(105, 30);
            this.btnThemTN.TabIndex = 8;
            this.btnThemTN.Text = "Thêm tiện nghi";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(600, 15);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(130, 25);
            this.txtTinhTrang.TabIndex = 7;
            this.txtTinhTrang.Text = "Tốt";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(525, 18);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(71, 17);
            this.lblTinhTrang.TabIndex = 6;
            this.lblTinhTrang.Text = "Tình trạng:";
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(455, 15);
            this.numSTT.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numSTT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(55, 25);
            this.numSTT.TabIndex = 5;
            this.numSTT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(415, 18);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(32, 17);
            this.lblSTT.TabIndex = 4;
            this.lblSTT.Text = "STT:";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(265, 15);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(135, 25);
            this.cboLoai.TabIndex = 3;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(180, 18);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(82, 17);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "Loại tiện nghi:";
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(75, 15);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(95, 25);
            this.txtMaTN.TabIndex = 1;
            // 
            // lblMaTN
            // 
            this.lblMaTN.AutoSize = true;
            this.lblMaTN.Location = new System.Drawing.Point(15, 18);
            this.lblMaTN.Name = "lblMaTN";
            this.lblMaTN.Size = new System.Drawing.Size(53, 17);
            this.lblMaTN.TabIndex = 0;
            this.lblMaTN.Text = "Mã TN:";
            // 
            // tabLapDat
            // 
            this.tabLapDat.Controls.Add(this.dgvLD);
            this.tabLapDat.Controls.Add(this.pnlTopLD);
            this.tabLapDat.Location = new System.Drawing.Point(4, 26);
            this.tabLapDat.Name = "tabLapDat";
            this.tabLapDat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLapDat.Size = new System.Drawing.Size(876, 481);
            this.tabLapDat.TabIndex = 2;
            this.tabLapDat.Text = "Lắp đặt / luân chuyển";
            this.tabLapDat.UseVisualStyleBackColor = true;
            // 
            // dgvLD
            // 
            this.dgvLD.AllowUserToAddRows = false;
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.BackgroundColor = System.Drawing.Color.White;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLD.Location = new System.Drawing.Point(3, 90);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.ReadOnly = true;
            this.dgvLD.RowHeadersWidth = 30;
            this.dgvLD.Size = new System.Drawing.Size(870, 388);
            this.dgvLD.TabIndex = 1;
            // 
            // pnlTopLD
            // 
            this.pnlTopLD.Controls.Add(this.btnLapDat);
            this.pnlTopLD.Controls.Add(this.txtGhiChu);
            this.pnlTopLD.Controls.Add(this.lblGhiChu);
            this.pnlTopLD.Controls.Add(this.cboNV);
            this.pnlTopLD.Controls.Add(this.lblNV);
            this.pnlTopLD.Controls.Add(this.txtTTLD);
            this.pnlTopLD.Controls.Add(this.lblTTLD);
            this.pnlTopLD.Controls.Add(this.dtNgay);
            this.pnlTopLD.Controls.Add(this.lblNgay);
            this.pnlTopLD.Controls.Add(this.cboPhong);
            this.pnlTopLD.Controls.Add(this.lblPhongLD);
            this.pnlTopLD.Controls.Add(this.cboTN);
            this.pnlTopLD.Controls.Add(this.lblTN);
            this.pnlTopLD.Controls.Add(this.txtSoLD);
            this.pnlTopLD.Controls.Add(this.lblSoLD);
            this.pnlTopLD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopLD.Location = new System.Drawing.Point(3, 3);
            this.pnlTopLD.Name = "pnlTopLD";
            this.pnlTopLD.Size = new System.Drawing.Size(870, 87);
            this.pnlTopLD.TabIndex = 0;
            // 
            // btnLapDat
            // 
            this.btnLapDat.Location = new System.Drawing.Point(745, 46);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(105, 30);
            this.btnLapDat.TabIndex = 14;
            this.btnLapDat.Text = "Lập phiếu";
            this.btnLapDat.UseVisualStyleBackColor = true;
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(490, 49);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(235, 25);
            this.txtGhiChu.TabIndex = 13;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(430, 52);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 17);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(270, 49);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(140, 25);
            this.cboNV.TabIndex = 11;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(200, 52);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(69, 17);
            this.lblNV.TabIndex = 10;
            this.lblNV.Text = "Nhân viên:";
            // 
            // txtTTLD
            // 
            this.txtTTLD.Location = new System.Drawing.Point(85, 49);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(95, 25);
            this.txtTTLD.TabIndex = 9;
            this.txtTTLD.Text = "Tốt";
            // 
            // lblTTLD
            // 
            this.lblTTLD.AutoSize = true;
            this.lblTTLD.Location = new System.Drawing.Point(10, 52);
            this.lblTTLD.Name = "lblTTLD";
            this.lblTTLD.Size = new System.Drawing.Size(71, 17);
            this.lblTTLD.TabIndex = 8;
            this.lblTTLD.Text = "Tình trạng:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(695, 12);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(110, 25);
            this.dtNgay.TabIndex = 7;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(625, 15);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(64, 17);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày lập:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(490, 12);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(110, 25);
            this.cboPhong.TabIndex = 5;
            // 
            // lblPhongLD
            // 
            this.lblPhongLD.AutoSize = true;
            this.lblPhongLD.Location = new System.Drawing.Point(435, 15);
            this.lblPhongLD.Name = "lblPhongLD";
            this.lblPhongLD.Size = new System.Drawing.Size(48, 17);
            this.lblPhongLD.TabIndex = 4;
            this.lblPhongLD.Text = "Phòng:";
            // 
            // cboTN
            // 
            this.cboTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTN.FormattingEnabled = true;
            this.cboTN.Location = new System.Drawing.Point(270, 12);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(140, 25);
            this.cboTN.TabIndex = 3;
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(205, 15);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(64, 17);
            this.lblTN.TabIndex = 2;
            this.lblTN.Text = "Tiện nghi:";
            // 
            // txtSoLD
            // 
            this.txtSoLD.Location = new System.Drawing.Point(85, 12);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(95, 25);
            this.txtSoLD.TabIndex = 1;
            // 
            // lblSoLD
            // 
            this.lblSoLD.AutoSize = true;
            this.lblSoLD.Location = new System.Drawing.Point(10, 15);
            this.lblSoLD.Name = "lblSoLD";
            this.lblSoLD.Size = new System.Drawing.Size(62, 17);
            this.lblSoLD.TabIndex = 0;
            this.lblSoLD.Text = "Số phiếu:";
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.Load += new System.EventHandler(this.FrmPhongTienNghi_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.pnlTopPhong.ResumeLayout(false);
            this.pnlTopPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.pnlBottomPhong.ResumeLayout(false);
            this.pnlBottomPhong.PerformLayout();
            this.tabTienNghi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.pnlTopTN.ResumeLayout(false);
            this.pnlTopTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            this.tabLapDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.pnlTopLD.ResumeLayout(false);
            this.pnlTopLD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Panel pnlTopPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.Label lblKhu;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Panel pnlBottomPhong;
        private System.Windows.Forms.Button btnLapDatQuick;
        private System.Windows.Forms.TextBox txtTTLDQuick;
        private System.Windows.Forms.Label lblTTLDQuick;
        private System.Windows.Forms.ComboBox cboPhongQuick;
        private System.Windows.Forms.Label lblPhongQuick;
        private System.Windows.Forms.ComboBox cboTNQuick;
        private System.Windows.Forms.Label lblTNQuick;
        private System.Windows.Forms.TextBox txtSoLDQuick;
        private System.Windows.Forms.Label lblSoLDQuick;
        private System.Windows.Forms.TabPage tabTienNghi;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.Panel pnlTopTN;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label lblMaTN;
        private System.Windows.Forms.TabPage tabLapDat;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.Panel pnlTopLD;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.Label lblTTLD;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblPhongLD;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label lblSoLD;
    }
}

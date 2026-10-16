namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmThanhToan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitTop;
        private System.Windows.Forms.GroupBox grpPhieuKham;
        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.Label lblTienKham;
        private System.Windows.Forms.Label lblValTienKham;
        private System.Windows.Forms.Label lblTienXN;
        private System.Windows.Forms.Label lblValTienXN;
        private System.Windows.Forms.Label lblTienThuoc;
        private System.Windows.Forms.Label lblValTienThuoc;
        private System.Windows.Forms.Label lblMienGiam;
        private System.Windows.Forms.Label lblValMienGiam;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblValTongTien;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox grpHDBool;
        private System.Windows.Forms.DataGridView dgvHoaDon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitTop = new System.Windows.Forms.SplitContainer();
            this.grpPhieuKham = new System.Windows.Forms.GroupBox();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblValTienKham = new System.Windows.Forms.Label();
            this.lblTienXN = new System.Windows.Forms.Label();
            this.lblValTienXN = new System.Windows.Forms.Label();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.lblValTienThuoc = new System.Windows.Forms.Label();
            this.lblMienGiam = new System.Windows.Forms.Label();
            this.lblValMienGiam = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblValTongTien = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpHDBool = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).BeginInit();
            this.splitTop.Panel1.SuspendLayout();
            this.splitTop.Panel2.SuspendLayout();
            this.splitTop.SuspendLayout();
            this.grpPhieuKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.pnlThanhToan.SuspendLayout();
            this.grpHDBool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitTop
            // 
            this.splitTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitTop.Location = new System.Drawing.Point(10, 10);
            this.splitTop.Name = "splitTop";
            // 
            // splitTop.Panel1
            // 
            this.splitTop.Panel1.Controls.Add(this.grpPhieuKham);
            // 
            // splitTop.Panel2
            // 
            this.splitTop.Panel2.Controls.Add(this.grpChiTiet);
            this.splitTop.Size = new System.Drawing.Size(980, 230);
            this.splitTop.SplitterDistance = 480;
            this.splitTop.TabIndex = 0;
            // 
            // grpPhieuKham
            // 
            this.grpPhieuKham.Controls.Add(this.dgvPhieuKham);
            this.grpPhieuKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPhieuKham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpPhieuKham.Location = new System.Drawing.Point(0, 0);
            this.grpPhieuKham.Name = "grpPhieuKham";
            this.grpPhieuKham.Size = new System.Drawing.Size(480, 230);
            this.grpPhieuKham.TabIndex = 0;
            this.grpPhieuKham.TabStop = false;
            this.grpPhieuKham.Text = "DANH SÁCH ĐỢT KHÁM CHỜ THANH TOÁN";
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuKham.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuKham.Location = new System.Drawing.Point(3, 22);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.ReadOnly = true;
            this.dgvPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuKham.Size = new System.Drawing.Size(474, 205);
            this.dgvPhieuKham.TabIndex = 0;
            this.dgvPhieuKham.SelectionChanged += new System.EventHandler(this.dgvPhieuKham_SelectionChanged);
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpChiTiet.Location = new System.Drawing.Point(0, 0);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Size = new System.Drawing.Size(496, 230);
            this.grpChiTiet.TabIndex = 0;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "CHI TIẾT VIỆN PHÍ (KHÁM + XÉT NGHIỆM + TOA THUỐC)";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 22);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.Size = new System.Drawing.Size(490, 205);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThanhToan.Controls.Add(this.lblTienKham);
            this.pnlThanhToan.Controls.Add(this.lblValTienKham);
            this.pnlThanhToan.Controls.Add(this.lblTienXN);
            this.pnlThanhToan.Controls.Add(this.lblValTienXN);
            this.pnlThanhToan.Controls.Add(this.lblTienThuoc);
            this.pnlThanhToan.Controls.Add(this.lblValTienThuoc);
            this.pnlThanhToan.Controls.Add(this.lblMienGiam);
            this.pnlThanhToan.Controls.Add(this.lblValMienGiam);
            this.pnlThanhToan.Controls.Add(this.lblTongTien);
            this.pnlThanhToan.Controls.Add(this.lblValTongTien);
            this.pnlThanhToan.Controls.Add(this.lblHinhThuc);
            this.pnlThanhToan.Controls.Add(this.cboHinhThuc);
            this.pnlThanhToan.Controls.Add(this.btnXacNhan);
            this.pnlThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThanhToan.Location = new System.Drawing.Point(10, 240);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(980, 130);
            this.pnlThanhToan.TabIndex = 1;
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Location = new System.Drawing.Point(20, 15);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(71, 17);
            this.lblTienKham.TabIndex = 0;
            this.lblTienKham.Text = "Tiền khám:";
            // 
            // lblValTienKham
            // 
            this.lblValTienKham.AutoSize = true;
            this.lblValTienKham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValTienKham.Location = new System.Drawing.Point(100, 15);
            this.lblValTienKham.Name = "lblValTienKham";
            this.lblValTienKham.Size = new System.Drawing.Size(29, 17);
            this.lblValTienKham.TabIndex = 1;
            this.lblValTienKham.Text = "0 đ";
            // 
            // lblTienXN
            // 
            this.lblTienXN.AutoSize = true;
            this.lblTienXN.Location = new System.Drawing.Point(200, 15);
            this.lblTienXN.Name = "lblTienXN";
            this.lblTienXN.Size = new System.Drawing.Size(56, 17);
            this.lblTienXN.TabIndex = 2;
            this.lblTienXN.Text = "Tiền XN:";
            // 
            // lblValTienXN
            // 
            this.lblValTienXN.AutoSize = true;
            this.lblValTienXN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValTienXN.Location = new System.Drawing.Point(270, 15);
            this.lblValTienXN.Name = "lblValTienXN";
            this.lblValTienXN.Size = new System.Drawing.Size(29, 17);
            this.lblValTienXN.TabIndex = 3;
            this.lblValTienXN.Text = "0 đ";
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Location = new System.Drawing.Point(380, 15);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(71, 17);
            this.lblTienThuoc.TabIndex = 4;
            this.lblTienThuoc.Text = "Tiền thuốc:";
            // 
            // lblValTienThuoc
            // 
            this.lblValTienThuoc.AutoSize = true;
            this.lblValTienThuoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValTienThuoc.Location = new System.Drawing.Point(460, 15);
            this.lblValTienThuoc.Name = "lblValTienThuoc";
            this.lblValTienThuoc.Size = new System.Drawing.Size(29, 17);
            this.lblValTienThuoc.TabIndex = 5;
            this.lblValTienThuoc.Text = "0 đ";
            // 
            // lblMienGiam
            // 
            this.lblMienGiam.AutoSize = true;
            this.lblMienGiam.Location = new System.Drawing.Point(20, 50);
            this.lblMienGiam.Name = "lblMienGiam";
            this.lblMienGiam.Size = new System.Drawing.Size(72, 17);
            this.lblMienGiam.TabIndex = 6;
            this.lblMienGiam.Text = "Miễn giảm:";
            // 
            // lblValMienGiam
            // 
            this.lblValMienGiam.AutoSize = true;
            this.lblValMienGiam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValMienGiam.ForeColor = System.Drawing.Color.Green;
            this.lblValMienGiam.Location = new System.Drawing.Point(100, 50);
            this.lblValMienGiam.Name = "lblValMienGiam";
            this.lblValMienGiam.Size = new System.Drawing.Size(29, 17);
            this.lblValMienGiam.TabIndex = 7;
            this.lblValMienGiam.Text = "0 đ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(20, 90);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(155, 20);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "TỔNG THANH TOÁN:";
            // 
            // lblValTongTien
            // 
            this.lblValTongTien.AutoSize = true;
            this.lblValTongTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblValTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblValTongTien.Location = new System.Drawing.Point(180, 87);
            this.lblValTongTien.Name = "lblValTongTien";
            this.lblValTongTien.Size = new System.Drawing.Size(74, 25);
            this.lblValTongTien.TabIndex = 9;
            this.lblValTongTien.Text = "0 VNĐ";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(400, 93);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(66, 17);
            this.lblHinhThuc.TabIndex = 10;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ POS" });
            this.cboHinhThuc.Location = new System.Drawing.Point(475, 90);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(140, 25);
            this.cboHinhThuc.TabIndex = 11;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(640, 80);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(320, 42);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "XÁC NHẬN THANH TOÁN & ĐÓNG BỆNH ÁN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // grpHDBool
            // 
            this.grpHDBool.Controls.Add(this.dgvHoaDon);
            this.grpHDBool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHDBool.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpHDBool.Location = new System.Drawing.Point(10, 370);
            this.grpHDBool.Name = "grpHDBool";
            this.grpHDBool.Size = new System.Drawing.Size(980, 240);
            this.grpHDBool.TabIndex = 2;
            this.grpHDBool.TabStop = false;
            this.grpHDBool.Text = "LỊCH SỬ HÓA ĐƠN VIỆN PHÍ ĐÃ XUẤT (QUY TẮC #5)";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 22);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(974, 215);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // FrmThanhToan
            // 
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.grpHDBool);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.splitTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FrmThanhToan";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh Toán Viện Phí & Đóng Bệnh Án Xuất Viện";
            this.splitTop.Panel1.ResumeLayout(false);
            this.splitTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).EndInit();
            this.splitTop.ResumeLayout(false);
            this.grpPhieuKham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.pnlThanhToan.ResumeLayout(false);
            this.pnlThanhToan.PerformLayout();
            this.grpHDBool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
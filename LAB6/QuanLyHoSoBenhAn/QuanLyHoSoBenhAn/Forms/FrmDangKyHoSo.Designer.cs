namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmDangKyHoSo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblTienSu;
        private System.Windows.Forms.TextBox txtTienSu;
        private System.Windows.Forms.Label lblDiUng;
        private System.Windows.Forms.TextBox txtDiUng;
        private System.Windows.Forms.Label lblPhiNam;
        private System.Windows.Forms.NumericUpDown nudPhiNam;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgvHoSo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblMaBN = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblTienSu = new System.Windows.Forms.Label();
            this.txtTienSu = new System.Windows.Forms.TextBox();
            this.lblDiUng = new System.Windows.Forms.Label();
            this.txtDiUng = new System.Windows.Forms.TextBox();
            this.lblPhiNam = new System.Windows.Forms.Label();
            this.nudPhiNam = new System.Windows.Forms.NumericUpDown();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgvHoSo = new System.Windows.Forms.DataGridView();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhiNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblMaBN);
            this.grpInfo.Controls.Add(this.txtMaBN);
            this.grpInfo.Controls.Add(this.lblHoTen);
            this.grpInfo.Controls.Add(this.txtHoTen);
            this.grpInfo.Controls.Add(this.lblNgaySinh);
            this.grpInfo.Controls.Add(this.dtpNgaySinh);
            this.grpInfo.Controls.Add(this.lblGioiTinh);
            this.grpInfo.Controls.Add(this.cboGioiTinh);
            this.grpInfo.Controls.Add(this.lblCCCD);
            this.grpInfo.Controls.Add(this.txtCCCD);
            this.grpInfo.Controls.Add(this.lblSdt);
            this.grpInfo.Controls.Add(this.txtSdt);
            this.grpInfo.Controls.Add(this.lblDiaChi);
            this.grpInfo.Controls.Add(this.txtDiaChi);
            this.grpInfo.Controls.Add(this.lblTienSu);
            this.grpInfo.Controls.Add(this.txtTienSu);
            this.grpInfo.Controls.Add(this.lblDiUng);
            this.grpInfo.Controls.Add(this.txtDiUng);
            this.grpInfo.Controls.Add(this.lblPhiNam);
            this.grpInfo.Controls.Add(this.nudPhiNam);
            this.grpInfo.Controls.Add(this.btnDangKy);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(10, 10);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(960, 270);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "THÔNG TIN ĐĂNG KÝ BỆNH NHÂN LẦN ĐẦU (QUY TẮC #1)";
            // 
            // lblMaBN
            // 
            this.lblMaBN.AutoSize = true;
            this.lblMaBN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaBN.Location = new System.Drawing.Point(20, 35);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(51, 17);
            this.lblMaBN.Text = "Mã BN:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaBN.Location = new System.Drawing.Point(90, 32);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(120, 25);
            this.txtMaBN.TabIndex = 0;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHoTen.Location = new System.Drawing.Point(230, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 17);
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtHoTen.Location = new System.Drawing.Point(310, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 25);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgaySinh.Location = new System.Drawing.Point(550, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(630, 32);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(130, 25);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGioiTinh.Location = new System.Drawing.Point(780, 35);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(59, 17);
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cboGioiTinh.Location = new System.Drawing.Point(850, 32);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(90, 25);
            this.cboGioiTinh.TabIndex = 3;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCCCD.Location = new System.Drawing.Point(20, 80);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(61, 17);
            this.lblCCCD.Text = "Số CCCD:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCCCD.Location = new System.Drawing.Point(90, 77);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(180, 25);
            this.txtCCCD.TabIndex = 4;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSdt.Location = new System.Drawing.Point(290, 80);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(46, 17);
            this.lblSdt.Text = "Số ĐT:";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSdt.Location = new System.Drawing.Point(350, 77);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(150, 25);
            this.txtSdt.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDiaChi.Location = new System.Drawing.Point(520, 80);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 17);
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDiaChi.Location = new System.Drawing.Point(580, 77);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(360, 25);
            this.txtDiaChi.TabIndex = 6;
            // 
            // lblTienSu
            // 
            this.lblTienSu.AutoSize = true;
            this.lblTienSu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTienSu.Location = new System.Drawing.Point(20, 125);
            this.lblTienSu.Name = "lblTienSu";
            this.lblTienSu.Size = new System.Drawing.Size(81, 17);
            this.lblTienSu.Text = "Tiền sử bệnh:";
            // 
            // txtTienSu
            // 
            this.txtTienSu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTienSu.Location = new System.Drawing.Point(110, 122);
            this.txtTienSu.Name = "txtTienSu";
            this.txtTienSu.Size = new System.Drawing.Size(390, 25);
            this.txtTienSu.TabIndex = 7;
            // 
            // lblDiUng
            // 
            this.lblDiUng.AutoSize = true;
            this.lblDiUng.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDiUng.Location = new System.Drawing.Point(520, 125);
            this.lblDiUng.Name = "lblDiUng";
            this.lblDiUng.Size = new System.Drawing.Size(88, 17);
            this.lblDiUng.Text = "Dị ứng thuốc:";
            // 
            // txtDiUng
            // 
            this.txtDiUng.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDiUng.Location = new System.Drawing.Point(620, 122);
            this.txtDiUng.Name = "txtDiUng";
            this.txtDiUng.Size = new System.Drawing.Size(320, 25);
            this.txtDiUng.TabIndex = 8;
            // 
            // lblPhiNam
            // 
            this.lblPhiNam.AutoSize = true;
            this.lblPhiNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPhiNam.Location = new System.Drawing.Point(20, 175);
            this.lblPhiNam.Name = "lblPhiNam";
            this.lblPhiNam.Size = new System.Drawing.Size(147, 17);
            this.lblPhiNam.Text = "Lệ phí thường niên (VNĐ):";
            // 
            // nudPhiNam
            // 
            this.nudPhiNam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.nudPhiNam.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.nudPhiNam.Location = new System.Drawing.Point(180, 172);
            this.nudPhiNam.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.nudPhiNam.Name = "nudPhiNam";
            this.nudPhiNam.Size = new System.Drawing.Size(160, 26);
            this.nudPhiNam.TabIndex = 9;
            this.nudPhiNam.ThousandsSeparator = true;
            this.nudPhiNam.Value = new decimal(new int[] { 500000, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(380, 210);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(280, 45);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "ĐĂNG KÝ & CẤP HỒ SƠ BỆNH ÁN";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dgvHoSo
            // 
            this.dgvHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoSo.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoSo.Location = new System.Drawing.Point(10, 280);
            this.dgvHoSo.Name = "dgvHoSo";
            this.dgvHoSo.ReadOnly = true;
            this.dgvHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoSo.Size = new System.Drawing.Size(960, 310);
            this.dgvHoSo.TabIndex = 1;
            // 
            // FrmDangKyHoSo
            // 
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.dgvHoSo);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FrmDangKyHoSo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Ký & Cấp Hồ Sơ Bệnh Án";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhiNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
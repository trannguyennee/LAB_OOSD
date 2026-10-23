namespace QuanLyNhanSu.Forms
{
    partial class FrmNhanVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnQDTuyenDung;
        private System.Windows.Forms.DataGridView dgvNhanVien;

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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnQDTuyenDung = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnQDTuyenDung);
            this.grpInfo.Controls.Add(this.btnXoa);
            this.grpInfo.Controls.Add(this.btnCapNhat);
            this.grpInfo.Controls.Add(this.btnLuu);
            this.grpInfo.Controls.Add(this.btnThem);
            this.grpInfo.Controls.Add(this.cboTrangThai);
            this.grpInfo.Controls.Add(this.lblTrangThai);
            this.grpInfo.Controls.Add(this.cboChucVu);
            this.grpInfo.Controls.Add(this.lblChucVu);
            this.grpInfo.Controls.Add(this.cboPhongBan);
            this.grpInfo.Controls.Add(this.lblPhongBan);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.txtDienThoai);
            this.grpInfo.Controls.Add(this.lblDienThoai);
            this.grpInfo.Controls.Add(this.txtCCCD);
            this.grpInfo.Controls.Add(this.lblCCCD);
            this.grpInfo.Controls.Add(this.cboGioiTinh);
            this.grpInfo.Controls.Add(this.lblGioiTinh);
            this.grpInfo.Controls.Add(this.dtpNgaySinh);
            this.grpInfo.Controls.Add(this.lblNgaySinh);
            this.grpInfo.Controls.Add(this.txtHoTen);
            this.grpInfo.Controls.Add(this.lblHoTen);
            this.grpInfo.Controls.Add(this.txtMaNV);
            this.grpInfo.Controls.Add(this.lblMaNV);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.grpInfo.Location = new System.Drawing.Point(10, 10);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(920, 240);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "THÔNG TIN HỒ SƠ NHÂN SỰ";
            // 
            // btnQDTuyenDung
            // 
            this.btnQDTuyenDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnQDTuyenDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQDTuyenDung.ForeColor = System.Drawing.Color.White;
            this.btnQDTuyenDung.Location = new System.Drawing.Point(580, 185);
            this.btnQDTuyenDung.Name = "btnQDTuyenDung";
            this.btnQDTuyenDung.Size = new System.Drawing.Size(260, 38);
            this.btnQDTuyenDung.TabIndex = 24;
            this.btnQDTuyenDung.Text = "Lập QĐ Tuyển Dụng / Thử Việc";
            this.btnQDTuyenDung.UseVisualStyleBackColor = false;
            this.btnQDTuyenDung.Click += new System.EventHandler(this.btnQDTuyenDung_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(440, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(320, 185);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 38);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(200, 185);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu Mới";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(80, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 38);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(680, 135);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(180, 24);
            this.cboTrangThai.TabIndex = 19;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lblTrangThai.Location = new System.Drawing.Point(590, 138);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(70, 16);
            this.lblTrangThai.TabIndex = 18;
            this.lblTrangThai.Text = "Trạng Thái:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(380, 135);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(180, 24);
            this.cboChucVu.TabIndex = 17;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblChucVu.ForeColor = System.Drawing.Color.Black;
            this.lblChucVu.Location = new System.Drawing.Point(310, 138);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(60, 16);
            this.lblChucVu.TabIndex = 16;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(100, 135);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(180, 24);
            this.cboPhongBan.TabIndex = 15;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPhongBan.ForeColor = System.Drawing.Color.Black;
            this.lblPhongBan.Location = new System.Drawing.Point(20, 138);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(73, 16);
            this.lblPhongBan.TabIndex = 14;
            this.lblPhongBan.Text = "Phòng Ban:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(680, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 24);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(620, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.txtDienThoai.Location = new System.Drawing.Point(380, 85);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(180, 24);
            this.txtDienThoai.TabIndex = 11;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienThoai.Location = new System.Drawing.Point(300, 88);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(74, 16);
            this.lblDienThoai.TabIndex = 10;
            this.lblDienThoai.Text = "Điện Thoại:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.txtCCCD.Location = new System.Drawing.Point(100, 85);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(180, 24);
            this.txtCCCD.TabIndex = 9;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblCCCD.ForeColor = System.Drawing.Color.Black;
            this.lblCCCD.Location = new System.Drawing.Point(25, 88);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(68, 16);
            this.lblCCCD.TabIndex = 8;
            this.lblCCCD.Text = "Số CCCD:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(760, 35);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(100, 24);
            this.cboGioiTinh.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(690, 38);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 16);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(540, 35);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(130, 24);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(465, 38);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(68, 16);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.txtHoTen.Location = new System.Drawing.Point(260, 35);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 24);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(200, 38);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(53, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.txtMaNV.Location = new System.Drawing.Point(80, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblMaNV.ForeColor = System.Drawing.Color.Black;
            this.lblMaNV.Location = new System.Drawing.Point(20, 38);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(52, 16);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(10, 250);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 30;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(920, 380);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Quản Lý Hồ Sơ Nhân Sự";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

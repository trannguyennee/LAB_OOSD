namespace QuanLyDuLich.Forms
{
    partial class FrmPhanCongHDV
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbPhanCong;
        private System.Windows.Forms.Label lblMaPhanCong;
        private System.Windows.Forms.TextBox txtMaPhanCong;
        private System.Windows.Forms.Label lblHDV;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.Label lblLoaiTour;
        private System.Windows.Forms.ComboBox cboLoaiTour;
        private System.Windows.Forms.Label lblMaTourDung;
        private System.Windows.Forms.ComboBox cboMaTourDung;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Label lblTieuDeHDV;
        private System.Windows.Forms.DataGridView dgvHDV;
        private System.Windows.Forms.Label lblTieuDePC;
        private System.Windows.Forms.DataGridView dgvPhanCong;
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
            this.gbPhanCong = new System.Windows.Forms.GroupBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.cboMaTourDung = new System.Windows.Forms.ComboBox();
            this.lblMaTourDung = new System.Windows.Forms.Label();
            this.cboLoaiTour = new System.Windows.Forms.ComboBox();
            this.lblLoaiTour = new System.Windows.Forms.Label();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.lblHDV = new System.Windows.Forms.Label();
            this.txtMaPhanCong = new System.Windows.Forms.TextBox();
            this.lblMaPhanCong = new System.Windows.Forms.Label();
            this.lblTieuDeHDV = new System.Windows.Forms.Label();
            this.dgvHDV = new System.Windows.Forms.DataGridView();
            this.lblTieuDePC = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhanCong
            // 
            this.gbPhanCong.Controls.Add(this.btnPhanCong);
            this.gbPhanCong.Controls.Add(this.txtGhiChu);
            this.gbPhanCong.Controls.Add(this.lblGhiChu);
            this.gbPhanCong.Controls.Add(this.cboVaiTro);
            this.gbPhanCong.Controls.Add(this.lblVaiTro);
            this.gbPhanCong.Controls.Add(this.dtpNgayKetThuc);
            this.gbPhanCong.Controls.Add(this.lblNgayKetThuc);
            this.gbPhanCong.Controls.Add(this.dtpNgayBatDau);
            this.gbPhanCong.Controls.Add(this.lblNgayBatDau);
            this.gbPhanCong.Controls.Add(this.cboMaTourDung);
            this.gbPhanCong.Controls.Add(this.lblMaTourDung);
            this.gbPhanCong.Controls.Add(this.cboLoaiTour);
            this.gbPhanCong.Controls.Add(this.lblLoaiTour);
            this.gbPhanCong.Controls.Add(this.cboHDV);
            this.gbPhanCong.Controls.Add(this.lblHDV);
            this.gbPhanCong.Controls.Add(this.txtMaPhanCong);
            this.gbPhanCong.Controls.Add(this.lblMaPhanCong);
            this.gbPhanCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbPhanCong.Location = new System.Drawing.Point(12, 12);
            this.gbPhanCong.Name = "gbPhanCong";
            this.gbPhanCong.Size = new System.Drawing.Size(960, 115);
            this.gbPhanCong.TabIndex = 0;
            this.gbPhanCong.TabStop = false;
            this.gbPhanCong.Text = "Phân Công Hướng Dẫn Viên Dẫn Tour (Kiểm Soát Chống Trùng Lịch BR12, BR13)";
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Location = new System.Drawing.Point(820, 68);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(125, 32);
            this.btnPhanCong.TabIndex = 16;
            this.btnPhanCong.Text = "Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = false;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(540, 73);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(260, 23);
            this.txtGhiChu.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.Location = new System.Drawing.Point(470, 76);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 14;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Items.AddRange(new object[] {
            "TruongDoan",
            "PhuTa"});
            this.cboVaiTro.Location = new System.Drawing.Point(340, 73);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(110, 23);
            this.cboVaiTro.TabIndex = 13;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVaiTro.Location = new System.Drawing.Point(260, 76);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(70, 15);
            this.lblVaiTro.TabIndex = 12;
            this.lblVaiTro.Text = "Vai trò HDV:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(120, 73);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(120, 23);
            this.dtpNgayKetThuc.TabIndex = 11;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayKetThuc.Location = new System.Drawing.Point(20, 76);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(53, 15);
            this.lblNgayKetThuc.TabIndex = 10;
            this.lblNgayKetThuc.Text = "Ngày KT:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(820, 25);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(125, 23);
            this.dtpNgayBatDau.TabIndex = 9;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayBatDau.Location = new System.Drawing.Point(760, 28);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(54, 15);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Ngày BĐ:";
            // 
            // cboMaTourDung
            // 
            this.cboMaTourDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTourDung.FormattingEnabled = true;
            this.cboMaTourDung.Location = new System.Drawing.Point(620, 25);
            this.cboMaTourDung.Name = "cboMaTourDung";
            this.cboMaTourDung.Size = new System.Drawing.Size(120, 23);
            this.cboMaTourDung.TabIndex = 7;
            // 
            // lblMaTourDung
            // 
            this.lblMaTourDung.AutoSize = true;
            this.lblMaTourDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaTourDung.Location = new System.Drawing.Point(540, 28);
            this.lblMaTourDung.Name = "lblMaTourDung";
            this.lblMaTourDung.Size = new System.Drawing.Size(73, 15);
            this.lblMaTourDung.TabIndex = 6;
            this.lblMaTourDung.Text = "Mã chuyến/đoàn:";
            // 
            // cboLoaiTour
            // 
            this.cboLoaiTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTour.FormattingEnabled = true;
            this.cboLoaiTour.Items.AddRange(new object[] {
            "CHUYEN_LE",
            "DOAN"});
            this.cboLoaiTour.Location = new System.Drawing.Point(420, 25);
            this.cboLoaiTour.Name = "cboLoaiTour";
            this.cboLoaiTour.Size = new System.Drawing.Size(100, 23);
            this.cboLoaiTour.TabIndex = 5;
            this.cboLoaiTour.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTour_SelectedIndexChanged);
            // 
            // lblLoaiTour
            // 
            this.lblLoaiTour.AutoSize = true;
            this.lblLoaiTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiTour.Location = new System.Drawing.Point(360, 28);
            this.lblLoaiTour.Name = "lblLoaiTour";
            this.lblLoaiTour.Size = new System.Drawing.Size(58, 15);
            this.lblLoaiTour.TabIndex = 4;
            this.lblLoaiTour.Text = "Loại Tour:";
            // 
            // cboHDV
            // 
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDV.FormattingEnabled = true;
            this.cboHDV.Location = new System.Drawing.Point(220, 25);
            this.cboHDV.Name = "cboHDV";
            this.cboHDV.Size = new System.Drawing.Size(125, 23);
            this.cboHDV.TabIndex = 3;
            // 
            // lblHDV
            // 
            this.lblHDV.AutoSize = true;
            this.lblHDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHDV.Location = new System.Drawing.Point(180, 28);
            this.lblHDV.Name = "lblHDV";
            this.lblHDV.Size = new System.Drawing.Size(35, 15);
            this.lblHDV.TabIndex = 2;
            this.lblHDV.Text = "HDV:";
            // 
            // txtMaPhanCong
            // 
            this.txtMaPhanCong.Location = new System.Drawing.Point(120, 25);
            this.txtMaPhanCong.Name = "txtMaPhanCong";
            this.txtMaPhanCong.Size = new System.Drawing.Size(50, 23);
            this.txtMaPhanCong.TabIndex = 1;
            // 
            // lblMaPhanCong
            // 
            this.lblMaPhanCong.AutoSize = true;
            this.lblMaPhanCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaPhanCong.Location = new System.Drawing.Point(20, 28);
            this.lblMaPhanCong.Name = "lblMaPhanCong";
            this.lblMaPhanCong.Size = new System.Drawing.Size(46, 15);
            this.lblMaPhanCong.TabIndex = 0;
            this.lblMaPhanCong.Text = "Mã PC:";
            // 
            // lblTieuDeHDV
            // 
            this.lblTieuDeHDV.AutoSize = true;
            this.lblTieuDeHDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeHDV.Location = new System.Drawing.Point(12, 135);
            this.lblTieuDeHDV.Name = "lblTieuDeHDV";
            this.lblTieuDeHDV.Size = new System.Drawing.Size(325, 15);
            this.lblTieuDeHDV.TabIndex = 1;
            this.lblTieuDeHDV.Text = "Danh Sách Hướng Dẫn Viên & Trạng Thái Lịch (Rảnh rỗi / Dẫn tour):";
            // 
            // dgvHDV
            // 
            this.dgvHDV.AllowUserToAddRows = false;
            this.dgvHDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDV.Location = new System.Drawing.Point(12, 155);
            this.dgvHDV.Name = "dgvHDV";
            this.dgvHDV.ReadOnly = true;
            this.dgvHDV.Size = new System.Drawing.Size(960, 160);
            this.dgvHDV.TabIndex = 2;
            // 
            // lblTieuDePC
            // 
            this.lblTieuDePC.AutoSize = true;
            this.lblTieuDePC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTieuDePC.Location = new System.Drawing.Point(12, 325);
            this.lblTieuDePC.Name = "lblTieuDePC";
            this.lblTieuDePC.Size = new System.Drawing.Size(262, 15);
            this.lblTieuDePC.TabIndex = 3;
            this.lblTieuDePC.Text = "Bảng Phân Công Lịch Dẫn Tour Trong Hệ Thống:";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Location = new System.Drawing.Point(12, 345);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.Size = new System.Drawing.Size(960, 195);
            this.dgvPhanCong.TabIndex = 4;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(852, 550);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhanCongHDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.lblTieuDePC);
            this.Controls.Add(this.dgvHDV);
            this.Controls.Add(this.lblTieuDeHDV);
            this.Controls.Add(this.gbPhanCong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhanCongHDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều Hành Phân Công Hướng Dẫn Viên Dẫn Tour";
            this.Load += new System.EventHandler(this.FrmPhanCongHDV_Load);
            this.gbPhanCong.ResumeLayout(false);
            this.gbPhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

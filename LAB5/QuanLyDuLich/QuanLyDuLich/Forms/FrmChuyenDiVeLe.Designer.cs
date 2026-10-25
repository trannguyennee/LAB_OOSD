namespace QuanLyDuLich.Forms
{
    partial class FrmChuyenDiVeLe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbTaoChuyen;
        private System.Windows.Forms.Label lblMaChuyenMoi;
        private System.Windows.Forms.TextBox txtMaChuyenMoi;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.DateTimePicker dtpNgayVe;
        private System.Windows.Forms.Label lblSoCho;
        private System.Windows.Forms.NumericUpDown nudSoCho;
        private System.Windows.Forms.Label lblDiemDon;
        private System.Windows.Forms.TextBox txtDiemDon;
        private System.Windows.Forms.Button btnTaoChuyen;
        private System.Windows.Forms.DataGridView dgvChuyenDi;
        private System.Windows.Forms.GroupBox gbBanVe;
        private System.Windows.Forms.Label lblMaVe;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label lblMaChuyenDat;
        private System.Windows.Forms.TextBox txtMaChuyenDat;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblDiemBanVe;
        private System.Windows.Forms.ComboBox cboDiemBanVe;
        private System.Windows.Forms.Label lblSoVe;
        private System.Windows.Forms.NumericUpDown nudSoVe;
        private System.Windows.Forms.Label lblHinhThucTT;
        private System.Windows.Forms.ComboBox cboHinhThucTT;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.DataGridView dgvVe;
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
            this.gbTaoChuyen = new System.Windows.Forms.GroupBox();
            this.btnTaoChuyen = new System.Windows.Forms.Button();
            this.txtDiemDon = new System.Windows.Forms.TextBox();
            this.lblDiemDon = new System.Windows.Forms.Label();
            this.nudSoCho = new System.Windows.Forms.NumericUpDown();
            this.lblSoCho = new System.Windows.Forms.Label();
            this.dtpNgayVe = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.txtMaChuyenMoi = new System.Windows.Forms.TextBox();
            this.lblMaChuyenMoi = new System.Windows.Forms.Label();
            this.dgvChuyenDi = new System.Windows.Forms.DataGridView();
            this.gbBanVe = new System.Windows.Forms.GroupBox();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.cboHinhThucTT = new System.Windows.Forms.ComboBox();
            this.lblHinhThucTT = new System.Windows.Forms.Label();
            this.nudSoVe = new System.Windows.Forms.NumericUpDown();
            this.lblSoVe = new System.Windows.Forms.Label();
            this.cboDiemBanVe = new System.Windows.Forms.ComboBox();
            this.lblDiemBanVe = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtMaChuyenDat = new System.Windows.Forms.TextBox();
            this.lblMaChuyenDat = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.lblMaVe = new System.Windows.Forms.Label();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbTaoChuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            this.gbBanVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTaoChuyen
            // 
            this.gbTaoChuyen.Controls.Add(this.btnTaoChuyen);
            this.gbTaoChuyen.Controls.Add(this.txtDiemDon);
            this.gbTaoChuyen.Controls.Add(this.lblDiemDon);
            this.gbTaoChuyen.Controls.Add(this.nudSoCho);
            this.gbTaoChuyen.Controls.Add(this.lblSoCho);
            this.gbTaoChuyen.Controls.Add(this.dtpNgayVe);
            this.gbTaoChuyen.Controls.Add(this.lblNgayVe);
            this.gbTaoChuyen.Controls.Add(this.dtpNgayDi);
            this.gbTaoChuyen.Controls.Add(this.lblNgayDi);
            this.gbTaoChuyen.Controls.Add(this.cboTour);
            this.gbTaoChuyen.Controls.Add(this.lblTour);
            this.gbTaoChuyen.Controls.Add(this.txtMaChuyenMoi);
            this.gbTaoChuyen.Controls.Add(this.lblMaChuyenMoi);
            this.gbTaoChuyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbTaoChuyen.Location = new System.Drawing.Point(12, 12);
            this.gbTaoChuyen.Name = "gbTaoChuyen";
            this.gbTaoChuyen.Size = new System.Drawing.Size(960, 100);
            this.gbTaoChuyen.TabIndex = 0;
            this.gbTaoChuyen.TabStop = false;
            this.gbTaoChuyen.Text = "Lập Lịch Chuyến Đi Cố Định (Dành cho Khách Lẻ)";
            // 
            // btnTaoChuyen
            // 
            this.btnTaoChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnTaoChuyen.ForeColor = System.Drawing.Color.White;
            this.btnTaoChuyen.Location = new System.Drawing.Point(830, 58);
            this.btnTaoChuyen.Name = "btnTaoChuyen";
            this.btnTaoChuyen.Size = new System.Drawing.Size(110, 30);
            this.btnTaoChuyen.TabIndex = 12;
            this.btnTaoChuyen.Text = "Tạo Chuyến";
            this.btnTaoChuyen.UseVisualStyleBackColor = false;
            this.btnTaoChuyen.Click += new System.EventHandler(this.btnTaoChuyen_Click);
            // 
            // txtDiemDon
            // 
            this.txtDiemDon.Location = new System.Drawing.Point(540, 62);
            this.txtDiemDon.Name = "txtDiemDon";
            this.txtDiemDon.Size = new System.Drawing.Size(270, 23);
            this.txtDiemDon.TabIndex = 11;
            this.txtDiemDon.Text = "Nhà hát Lớn TP.HCM, Q.1";
            // 
            // lblDiemDon
            // 
            this.lblDiemDon.AutoSize = true;
            this.lblDiemDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemDon.Location = new System.Drawing.Point(450, 65);
            this.lblDiemDon.Name = "lblDiemDon";
            this.lblDiemDon.Size = new System.Drawing.Size(86, 15);
            this.lblDiemDon.TabIndex = 10;
            this.lblDiemDon.Text = "Điểm đón QĐ:";
            // 
            // nudSoCho
            // 
            this.nudSoCho.Location = new System.Drawing.Point(360, 62);
            this.nudSoCho.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.nudSoCho.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudSoCho.Name = "nudSoCho";
            this.nudSoCho.Size = new System.Drawing.Size(70, 23);
            this.nudSoCho.TabIndex = 9;
            this.nudSoCho.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // lblSoCho
            // 
            this.lblSoCho.AutoSize = true;
            this.lblSoCho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoCho.Location = new System.Drawing.Point(260, 65);
            this.lblSoCho.Name = "lblSoCho";
            this.lblSoCho.Size = new System.Drawing.Size(91, 15);
            this.lblSoCho.TabIndex = 8;
            this.lblSoCho.Text = "Số chỗ tối đa:";
            // 
            // dtpNgayVe
            // 
            this.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVe.Location = new System.Drawing.Point(120, 62);
            this.dtpNgayVe.Name = "dtpNgayVe";
            this.dtpNgayVe.Size = new System.Drawing.Size(120, 23);
            this.dtpNgayVe.TabIndex = 7;
            // 
            // lblNgayVe
            // 
            this.lblNgayVe.AutoSize = true;
            this.lblNgayVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayVe.Location = new System.Drawing.Point(20, 65);
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Size = new System.Drawing.Size(53, 15);
            this.lblNgayVe.TabIndex = 6;
            this.lblNgayVe.Text = "Ngày về:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(740, 25);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(120, 23);
            this.dtpNgayDi.TabIndex = 5;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayDi.Location = new System.Drawing.Point(670, 28);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(51, 15);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(330, 25);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(320, 23);
            this.cboTour.TabIndex = 3;
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTour.Location = new System.Drawing.Point(260, 28);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(63, 15);
            this.lblTour.TabIndex = 2;
            this.lblTour.Text = "Chọn Tour:";
            // 
            // txtMaChuyenMoi
            // 
            this.txtMaChuyenMoi.Location = new System.Drawing.Point(120, 25);
            this.txtMaChuyenMoi.Name = "txtMaChuyenMoi";
            this.txtMaChuyenMoi.Size = new System.Drawing.Size(120, 23);
            this.txtMaChuyenMoi.TabIndex = 1;
            // 
            // lblMaChuyenMoi
            // 
            this.lblMaChuyenMoi.AutoSize = true;
            this.lblMaChuyenMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaChuyenMoi.Location = new System.Drawing.Point(20, 28);
            this.lblMaChuyenMoi.Name = "lblMaChuyenMoi";
            this.lblMaChuyenMoi.Size = new System.Drawing.Size(70, 15);
            this.lblMaChuyenMoi.TabIndex = 0;
            this.lblMaChuyenMoi.Text = "Mã Chuyến:";
            // 
            // dgvChuyenDi
            // 
            this.dgvChuyenDi.AllowUserToAddRows = false;
            this.dgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDi.Location = new System.Drawing.Point(12, 120);
            this.dgvChuyenDi.MultiSelect = false;
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.ReadOnly = true;
            this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenDi.Size = new System.Drawing.Size(960, 160);
            this.dgvChuyenDi.TabIndex = 1;
            this.dgvChuyenDi.SelectionChanged += new System.EventHandler(this.dgvChuyenDi_SelectionChanged);
            // 
            // gbBanVe
            // 
            this.gbBanVe.Controls.Add(this.btnBanVe);
            this.gbBanVe.Controls.Add(this.cboHinhThucTT);
            this.gbBanVe.Controls.Add(this.lblHinhThucTT);
            this.gbBanVe.Controls.Add(this.nudSoVe);
            this.gbBanVe.Controls.Add(this.lblSoVe);
            this.gbBanVe.Controls.Add(this.cboDiemBanVe);
            this.gbBanVe.Controls.Add(this.lblDiemBanVe);
            this.gbBanVe.Controls.Add(this.cboKhachHang);
            this.gbBanVe.Controls.Add(this.lblKhachHang);
            this.gbBanVe.Controls.Add(this.txtMaChuyenDat);
            this.gbBanVe.Controls.Add(this.lblMaChuyenDat);
            this.gbBanVe.Controls.Add(this.txtMaVe);
            this.gbBanVe.Controls.Add(this.lblMaVe);
            this.gbBanVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbBanVe.Location = new System.Drawing.Point(12, 290);
            this.gbBanVe.Name = "gbBanVe";
            this.gbBanVe.Size = new System.Drawing.Size(960, 105);
            this.gbBanVe.TabIndex = 2;
            this.gbBanVe.TabStop = false;
            this.gbBanVe.Text = "Bán Vé Khách Lẻ (Mua & Thanh toán 100% Tiền Vé Ngay)";
            // 
            // btnBanVe
            // 
            this.btnBanVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBanVe.ForeColor = System.Drawing.Color.White;
            this.btnBanVe.Location = new System.Drawing.Point(830, 62);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(110, 32);
            this.btnBanVe.TabIndex = 12;
            this.btnBanVe.Text = "Xuất Vé";
            this.btnBanVe.UseVisualStyleBackColor = false;
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // cboHinhThucTT
            // 
            this.cboHinhThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucTT.FormattingEnabled = true;
            this.cboHinhThucTT.Items.AddRange(new object[] {
            "TienMat",
            "ChuyenKhoan",
            "The"});
            this.cboHinhThucTT.Location = new System.Drawing.Point(620, 68);
            this.cboHinhThucTT.Name = "cboHinhThucTT";
            this.cboHinhThucTT.Size = new System.Drawing.Size(180, 23);
            this.cboHinhThucTT.TabIndex = 11;
            // 
            // lblHinhThucTT
            // 
            this.lblHinhThucTT.AutoSize = true;
            this.lblHinhThucTT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHinhThucTT.Location = new System.Drawing.Point(530, 71);
            this.lblHinhThucTT.Name = "lblHinhThucTT";
            this.lblHinhThucTT.Size = new System.Drawing.Size(86, 15);
            this.lblHinhThucTT.TabIndex = 10;
            this.lblHinhThucTT.Text = "Hình thức TT:";
            // 
            // nudSoVe
            // 
            this.nudSoVe.Location = new System.Drawing.Point(360, 68);
            this.nudSoVe.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            this.nudSoVe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoVe.Name = "nudSoVe";
            this.nudSoVe.Size = new System.Drawing.Size(70, 23);
            this.nudSoVe.TabIndex = 9;
            this.nudSoVe.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoVe
            // 
            this.lblSoVe.AutoSize = true;
            this.lblSoVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoVe.Location = new System.Drawing.Point(260, 71);
            this.lblSoVe.Name = "lblSoVe";
            this.lblSoVe.Size = new System.Drawing.Size(87, 15);
            this.lblSoVe.TabIndex = 8;
            this.lblSoVe.Text = "Số vé mua (<12):";
            // 
            // cboDiemBanVe
            // 
            this.cboDiemBanVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemBanVe.FormattingEnabled = true;
            this.cboDiemBanVe.Location = new System.Drawing.Point(120, 68);
            this.cboDiemBanVe.Name = "cboDiemBanVe";
            this.cboDiemBanVe.Size = new System.Drawing.Size(120, 23);
            this.cboDiemBanVe.TabIndex = 7;
            // 
            // lblDiemBanVe
            // 
            this.lblDiemBanVe.AutoSize = true;
            this.lblDiemBanVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemBanVe.Location = new System.Drawing.Point(20, 71);
            this.lblDiemBanVe.Name = "lblDiemBanVe";
            this.lblDiemBanVe.Size = new System.Drawing.Size(78, 15);
            this.lblDiemBanVe.TabIndex = 6;
            this.lblDiemBanVe.Text = "Điểm bán vé:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(620, 25);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(260, 23);
            this.cboKhachHang.TabIndex = 5;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachHang.Location = new System.Drawing.Point(530, 28);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(74, 15);
            this.lblKhachHang.TabIndex = 4;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // txtMaChuyenDat
            // 
            this.txtMaChuyenDat.Location = new System.Drawing.Point(360, 25);
            this.txtMaChuyenDat.Name = "txtMaChuyenDat";
            this.txtMaChuyenDat.ReadOnly = true;
            this.txtMaChuyenDat.Size = new System.Drawing.Size(120, 23);
            this.txtMaChuyenDat.TabIndex = 3;
            // 
            // lblMaChuyenDat
            // 
            this.lblMaChuyenDat.AutoSize = true;
            this.lblMaChuyenDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaChuyenDat.Location = new System.Drawing.Point(260, 28);
            this.lblMaChuyenDat.Name = "lblMaChuyenDat";
            this.lblMaChuyenDat.Size = new System.Drawing.Size(70, 15);
            this.lblMaChuyenDat.TabIndex = 2;
            this.lblMaChuyenDat.Text = "Mã Chuyến:";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(120, 25);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(120, 23);
            this.txtMaVe.TabIndex = 1;
            // 
            // lblMaVe
            // 
            this.lblMaVe.AutoSize = true;
            this.lblMaVe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaVe.Location = new System.Drawing.Point(20, 28);
            this.lblMaVe.Name = "lblMaVe";
            this.lblMaVe.Size = new System.Drawing.Size(43, 15);
            this.lblMaVe.TabIndex = 0;
            this.lblMaVe.Text = "Mã Vé:";
            // 
            // dgvVe
            // 
            this.dgvVe.AllowUserToAddRows = false;
            this.dgvVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Location = new System.Drawing.Point(12, 405);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.Size = new System.Drawing.Size(960, 130);
            this.dgvVe.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(852, 545);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 32);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmChuyenDiVeLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.gbBanVe);
            this.Controls.Add(this.dgvChuyenDi);
            this.Controls.Add(this.gbTaoChuyen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmChuyenDiVeLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Lịch Chuyến Đi Cố Định & Bán Vé Khách Lẻ";
            this.Load += new System.EventHandler(this.FrmChuyenDiVeLe_Load);
            this.gbTaoChuyen.ResumeLayout(false);
            this.gbTaoChuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            this.gbBanVe.ResumeLayout(false);
            this.gbBanVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

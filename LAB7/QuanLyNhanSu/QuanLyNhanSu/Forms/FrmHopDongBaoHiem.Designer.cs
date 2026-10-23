namespace QuanLyNhanSu.Forms
{
    partial class FrmHopDongBaoHiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHD;
        private System.Windows.Forms.TabPage tabBH;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DataGridView dgvBaoHiem;
        private System.Windows.Forms.DataGridView dgvQDLuong;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.ComboBox cboLoaiHD;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.NumericUpDown nudLuong;
        private System.Windows.Forms.CheckBox chkCoBaoHiem;
        private System.Windows.Forms.CheckBox chkDocHai;
        private System.Windows.Forms.Label lblDocHai;
        private System.Windows.Forms.NumericUpDown nudDocHai;
        private System.Windows.Forms.Button btnKyHD;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHD = new System.Windows.Forms.TabPage();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.tabBH = new System.Windows.Forms.TabPage();
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.dgvQDLuong = new System.Windows.Forms.DataGridView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnKyHD = new System.Windows.Forms.Button();
            this.nudDocHai = new System.Windows.Forms.NumericUpDown();
            this.lblDocHai = new System.Windows.Forms.Label();
            this.chkDocHai = new System.Windows.Forms.CheckBox();
            this.chkCoBaoHiem = new System.Windows.Forms.CheckBox();
            this.nudLuong = new System.Windows.Forms.NumericUpDown();
            this.lblLuong = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cboLoaiHD = new System.Windows.Forms.ComboBox();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.tabBH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).BeginInit();
            this.tabLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDLuong)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDocHai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHD);
            this.tabControl.Controls.Add(this.tabBH);
            this.tabControl.Controls.Add(this.tabLuong);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(10, 160);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 470);
            this.tabControl.TabIndex = 0;
            // 
            // tabHD
            // 
            this.tabHD.Controls.Add(this.dgvHopDong);
            this.tabHD.Location = new System.Drawing.Point(4, 26);
            this.tabHD.Name = "tabHD";
            this.tabHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabHD.Size = new System.Drawing.Size(912, 440);
            this.tabHD.TabIndex = 0;
            this.tabHD.Text = "Hợp Đồng Lao Động";
            this.tabHD.UseVisualStyleBackColor = true;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(3, 3);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.Size = new System.Drawing.Size(906, 434);
            this.dgvHopDong.TabIndex = 0;
            // 
            // tabBH
            // 
            this.tabBH.Controls.Add(this.dgvBaoHiem);
            this.tabBH.Location = new System.Drawing.Point(4, 26);
            this.tabBH.Name = "tabBH";
            this.tabBH.Padding = new System.Windows.Forms.Padding(3);
            this.tabBH.Size = new System.Drawing.Size(912, 440);
            this.tabBH.TabIndex = 1;
            this.tabBH.Text = "Hồ Sơ Bảo Hiểm (BHXH, BHYT)";
            this.tabBH.UseVisualStyleBackColor = true;
            // 
            // dgvBaoHiem
            // 
            this.dgvBaoHiem.AllowUserToAddRows = false;
            this.dgvBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoHiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoHiem.Location = new System.Drawing.Point(3, 3);
            this.dgvBaoHiem.Name = "dgvBaoHiem";
            this.dgvBaoHiem.ReadOnly = true;
            this.dgvBaoHiem.Size = new System.Drawing.Size(906, 434);
            this.dgvBaoHiem.TabIndex = 0;
            // 
            // tabLuong
            // 
            this.tabLuong.Controls.Add(this.dgvQDLuong);
            this.tabLuong.Location = new System.Drawing.Point(4, 26);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuong.Size = new System.Drawing.Size(912, 440);
            this.tabLuong.TabIndex = 2;
            this.tabLuong.Text = "Quyết Định Lương & Phụ Cấp Độc Hại";
            this.tabLuong.UseVisualStyleBackColor = true;
            // 
            // dgvQDLuong
            // 
            this.dgvQDLuong.AllowUserToAddRows = false;
            this.dgvQDLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQDLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvQDLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQDLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQDLuong.Location = new System.Drawing.Point(3, 3);
            this.dgvQDLuong.Name = "dgvQDLuong";
            this.dgvQDLuong.ReadOnly = true;
            this.dgvQDLuong.Size = new System.Drawing.Size(906, 434);
            this.dgvQDLuong.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnKyHD);
            this.pnlInput.Controls.Add(this.nudDocHai);
            this.pnlInput.Controls.Add(this.lblDocHai);
            this.pnlInput.Controls.Add(this.chkDocHai);
            this.pnlInput.Controls.Add(this.chkCoBaoHiem);
            this.pnlInput.Controls.Add(this.nudLuong);
            this.pnlInput.Controls.Add(this.lblLuong);
            this.pnlInput.Controls.Add(this.dtpDenNgay);
            this.pnlInput.Controls.Add(this.lblDenNgay);
            this.pnlInput.Controls.Add(this.dtpTuNgay);
            this.pnlInput.Controls.Add(this.lblTuNgay);
            this.pnlInput.Controls.Add(this.cboLoaiHD);
            this.pnlInput.Controls.Add(this.lblLoaiHD);
            this.pnlInput.Controls.Add(this.cboNhanVien);
            this.pnlInput.Controls.Add(this.lblNV);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(10, 10);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(920, 150);
            this.pnlInput.TabIndex = 1;
            // 
            // btnKyHD
            // 
            this.btnKyHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnKyHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyHD.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnKyHD.ForeColor = System.Drawing.Color.White;
            this.btnKyHD.Location = new System.Drawing.Point(620, 85);
            this.btnKyHD.Name = "btnKyHD";
            this.btnKyHD.Size = new System.Drawing.Size(270, 48);
            this.btnKyHD.TabIndex = 14;
            this.btnKyHD.Text = "Ký HĐLĐ & Thiết Lập Quyết Định";
            this.btnKyHD.UseVisualStyleBackColor = false;
            this.btnKyHD.Click += new System.EventHandler(this.btnKyHD_Click);
            // 
            // nudDocHai
            // 
            this.nudDocHai.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudDocHai.Location = new System.Drawing.Point(460, 98);
            this.nudDocHai.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            this.nudDocHai.Name = "nudDocHai";
            this.nudDocHai.Size = new System.Drawing.Size(130, 24);
            this.nudDocHai.TabIndex = 13;
            this.nudDocHai.Value = new decimal(new int[] { 1200000, 0, 0, 0 });
            // 
            // lblDocHai
            // 
            this.lblDocHai.AutoSize = true;
            this.lblDocHai.Location = new System.Drawing.Point(375, 101);
            this.lblDocHai.Name = "lblDocHai";
            this.lblDocHai.Size = new System.Drawing.Size(81, 16);
            this.lblDocHai.TabIndex = 12;
            this.lblDocHai.Text = "Mức độc hại:";
            // 
            // chkDocHai
            // 
            this.chkDocHai.AutoSize = true;
            this.chkDocHai.Checked = true;
            this.chkDocHai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDocHai.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.chkDocHai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            this.chkDocHai.Location = new System.Drawing.Point(150, 99);
            this.chkDocHai.Name = "chkDocHai";
            this.chkDocHai.Size = new System.Drawing.Size(217, 21);
            this.chkDocHai.TabIndex = 11;
            this.chkDocHai.Text = "Thuộc xưởng sơn (Có độc hại)";
            this.chkDocHai.UseVisualStyleBackColor = true;
            // 
            // chkCoBaoHiem
            // 
            this.chkCoBaoHiem.AutoSize = true;
            this.chkCoBaoHiem.Checked = true;
            this.chkCoBaoHiem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoBaoHiem.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.chkCoBaoHiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.chkCoBaoHiem.Location = new System.Drawing.Point(20, 99);
            this.chkCoBaoHiem.Name = "chkCoBaoHiem";
            this.chkCoBaoHiem.Size = new System.Drawing.Size(123, 21);
            this.chkCoBaoHiem.TabIndex = 10;
            this.chkCoBaoHiem.Text = "Trích BH (10.5%)";
            this.chkCoBaoHiem.UseVisualStyleBackColor = true;
            // 
            // nudLuong
            // 
            this.nudLuong.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            this.nudLuong.Location = new System.Drawing.Point(760, 28);
            this.nudLuong.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudLuong.Name = "nudLuong";
            this.nudLuong.Size = new System.Drawing.Size(130, 24);
            this.nudLuong.TabIndex = 9;
            this.nudLuong.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(685, 31);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(68, 16);
            this.lblLuong.TabIndex = 8;
            this.lblLuong.Text = "Lương CB:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(555, 28);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(115, 24);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(490, 31);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(64, 16);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(365, 28);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(115, 24);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(305, 31);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(58, 16);
            this.lblTuNgay.TabIndex = 4;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // cboLoaiHD
            // 
            this.cboLoaiHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHD.FormattingEnabled = true;
            this.cboLoaiHD.Location = new System.Drawing.Point(200, 28);
            this.cboLoaiHD.Name = "cboLoaiHD";
            this.cboLoaiHD.Size = new System.Drawing.Size(95, 24);
            this.cboLoaiHD.TabIndex = 3;
            this.cboLoaiHD.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHD_SelectedIndexChanged);
            // 
            // lblLoaiHD
            // 
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Location = new System.Drawing.Point(140, 31);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.Size = new System.Drawing.Size(59, 16);
            this.lblLoaiHD.TabIndex = 2;
            this.lblLoaiHD.Text = "Loại HĐ:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(20, 28);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(110, 24);
            this.cboNhanVien.TabIndex = 1;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(20, 9);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(102, 16);
            this.lblNV.TabIndex = 0;
            this.lblNV.Text = "Chọn Nhân Viên:";
            // 
            // FrmHopDongBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHopDongBaoHiem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Quản Lý Hợp Đồng & Chế Độ Lương";
            this.Load += new System.EventHandler(this.FrmHopDongBaoHiem_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.tabBH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).EndInit();
            this.tabLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDLuong)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDocHai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

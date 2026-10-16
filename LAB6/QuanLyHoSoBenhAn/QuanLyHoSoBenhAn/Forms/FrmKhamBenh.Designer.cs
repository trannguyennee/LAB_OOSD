namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmKhamBenh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpKham;
        private System.Windows.Forms.Label lblMaPK;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.Label lblHoSo;
        private System.Windows.Forms.ComboBox cboHoSo;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblThanNhiet;
        private System.Windows.Forms.NumericUpDown nudThanNhiet;
        private System.Windows.Forms.Label lblHuyetAp;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.CheckBox chkCoXetNghiem;
        private System.Windows.Forms.ComboBox cboXetNghiem;
        private System.Windows.Forms.Label lblChiSoKQ;
        private System.Windows.Forms.TextBox txtChiSoKQ;
        private System.Windows.Forms.CheckBox chkCoKeToa;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvLichSu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpKham = new System.Windows.Forms.GroupBox();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.lblHoSo = new System.Windows.Forms.Label();
            this.cboHoSo = new System.Windows.Forms.ComboBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblThanNhiet = new System.Windows.Forms.Label();
            this.nudThanNhiet = new System.Windows.Forms.NumericUpDown();
            this.lblHuyetAp = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.chkCoXetNghiem = new System.Windows.Forms.CheckBox();
            this.cboXetNghiem = new System.Windows.Forms.ComboBox();
            this.lblChiSoKQ = new System.Windows.Forms.Label();
            this.txtChiSoKQ = new System.Windows.Forms.TextBox();
            this.chkCoKeToa = new System.Windows.Forms.CheckBox();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.grpKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanNhiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKham
            // 
            this.grpKham.Controls.Add(this.lblMaPK);
            this.grpKham.Controls.Add(this.txtMaPK);
            this.grpKham.Controls.Add(this.lblHoSo);
            this.grpKham.Controls.Add(this.cboHoSo);
            this.grpKham.Controls.Add(this.lblBacSi);
            this.grpKham.Controls.Add(this.cboBacSi);
            this.grpKham.Controls.Add(this.lblKhoa);
            this.grpKham.Controls.Add(this.txtKhoa);
            this.grpKham.Controls.Add(this.lblTrieuChung);
            this.grpKham.Controls.Add(this.txtTrieuChung);
            this.grpKham.Controls.Add(this.lblThanNhiet);
            this.grpKham.Controls.Add(this.nudThanNhiet);
            this.grpKham.Controls.Add(this.lblHuyetAp);
            this.grpKham.Controls.Add(this.txtHuyetAp);
            this.grpKham.Controls.Add(this.lblChanDoan);
            this.grpKham.Controls.Add(this.txtChanDoan);
            this.grpKham.Controls.Add(this.chkCoXetNghiem);
            this.grpKham.Controls.Add(this.cboXetNghiem);
            this.grpKham.Controls.Add(this.lblChiSoKQ);
            this.grpKham.Controls.Add(this.txtChiSoKQ);
            this.grpKham.Controls.Add(this.chkCoKeToa);
            this.grpKham.Controls.Add(this.cboThuoc);
            this.grpKham.Controls.Add(this.lblSoLuong);
            this.grpKham.Controls.Add(this.nudSoLuong);
            this.grpKham.Controls.Add(this.lblCachDung);
            this.grpKham.Controls.Add(this.txtCachDung);
            this.grpKham.Controls.Add(this.btnLuu);
            this.grpKham.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpKham.Location = new System.Drawing.Point(10, 10);
            this.grpKham.Name = "grpKham";
            this.grpKham.Size = new System.Drawing.Size(980, 310);
            this.grpKham.TabIndex = 0;
            this.grpKham.TabStop = false;
            this.grpKham.Text = "KHÁM BỆNH, CHỈ ĐỊNH XÉT NGHIỆM & KÊ TOA THUỐC (QUY TẮC #4)";
            // 
            // lblMaPK
            // 
            this.lblMaPK.AutoSize = true;
            this.lblMaPK.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaPK.Location = new System.Drawing.Point(15, 30);
            this.lblMaPK.Name = "lblMaPK";
            this.lblMaPK.Size = new System.Drawing.Size(49, 17);
            this.lblMaPK.TabIndex = 0;
            this.lblMaPK.Text = "Mã PK:";
            // 
            // txtMaPK
            // 
            this.txtMaPK.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaPK.Location = new System.Drawing.Point(70, 27);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.ReadOnly = true;
            this.txtMaPK.Size = new System.Drawing.Size(90, 25);
            this.txtMaPK.TabIndex = 1;
            // 
            // lblHoSo
            // 
            this.lblHoSo.AutoSize = true;
            this.lblHoSo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHoSo.Location = new System.Drawing.Point(170, 30);
            this.lblHoSo.Name = "lblHoSo";
            this.lblHoSo.Size = new System.Drawing.Size(89, 17);
            this.lblHoSo.TabIndex = 2;
            this.lblHoSo.Text = "Chọn Hồ Sơ:";
            // 
            // cboHoSo
            // 
            this.cboHoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoSo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboHoSo.FormattingEnabled = true;
            this.cboHoSo.Location = new System.Drawing.Point(265, 27);
            this.cboHoSo.Name = "cboHoSo";
            this.cboHoSo.Size = new System.Drawing.Size(130, 25);
            this.cboHoSo.TabIndex = 3;
            this.cboHoSo.SelectedIndexChanged += new System.EventHandler(this.cboHoSo_SelectedIndexChanged);
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBacSi.Location = new System.Drawing.Point(410, 30);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(45, 17);
            this.lblBacSi.TabIndex = 4;
            this.lblBacSi.Text = "Bác sĩ:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(465, 27);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(210, 25);
            this.cboBacSi.TabIndex = 5;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblKhoa.Location = new System.Drawing.Point(690, 30);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(41, 17);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtKhoa.Location = new System.Drawing.Point(740, 27);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(220, 25);
            this.txtKhoa.TabIndex = 7;
            this.txtKhoa.Text = "Khoa Nội Tổng Quát";
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTrieuChung.Location = new System.Drawing.Point(15, 75);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(78, 17);
            this.lblTrieuChung.TabIndex = 8;
            this.lblTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTrieuChung.Location = new System.Drawing.Point(100, 72);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(430, 25);
            this.txtTrieuChung.TabIndex = 9;
            this.txtTrieuChung.Text = "Nhức đầu ê ẩm vùng thái dương, ho khan";
            // 
            // lblThanNhiet
            // 
            this.lblThanNhiet.AutoSize = true;
            this.lblThanNhiet.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThanNhiet.Location = new System.Drawing.Point(545, 75);
            this.lblThanNhiet.Name = "lblThanNhiet";
            this.lblThanNhiet.Size = new System.Drawing.Size(95, 17);
            this.lblThanNhiet.TabIndex = 10;
            this.lblThanNhiet.Text = "Nhiệt độ (°C):";
            // 
            // nudThanNhiet
            // 
            this.nudThanNhiet.DecimalPlaces = 1;
            this.nudThanNhiet.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudThanNhiet.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudThanNhiet.Location = new System.Drawing.Point(645, 72);
            this.nudThanNhiet.Maximum = new decimal(new int[] { 43, 0, 0, 0 });
            this.nudThanNhiet.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            this.nudThanNhiet.Name = "nudThanNhiet";
            this.nudThanNhiet.Size = new System.Drawing.Size(70, 25);
            this.nudThanNhiet.TabIndex = 11;
            this.nudThanNhiet.Value = new decimal(new int[] { 378, 0, 0, 65536 });
            // 
            // lblHuyetAp
            // 
            this.lblHuyetAp.AutoSize = true;
            this.lblHuyetAp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHuyetAp.Location = new System.Drawing.Point(730, 75);
            this.lblHuyetAp.Name = "lblHuyetAp";
            this.lblHuyetAp.Size = new System.Drawing.Size(63, 17);
            this.lblHuyetAp.TabIndex = 12;
            this.lblHuyetAp.Text = "Huyết áp:";
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtHuyetAp.Location = new System.Drawing.Point(800, 72);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(160, 25);
            this.txtHuyetAp.TabIndex = 13;
            this.txtHuyetAp.Text = "125/80 mmHg";
            // 
            // lblChanDoan
            // 
            this.lblChanDoan.AutoSize = true;
            this.lblChanDoan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblChanDoan.Location = new System.Drawing.Point(15, 118);
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Size = new System.Drawing.Size(73, 17);
            this.lblChanDoan.TabIndex = 14;
            this.lblChanDoan.Text = "Chẩn đoán:";
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtChanDoan.Location = new System.Drawing.Point(100, 115);
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new System.Drawing.Size(860, 25);
            this.txtChanDoan.TabIndex = 15;
            this.txtChanDoan.Text = "Viêm đường hô hấp trên / Cảm cúm nhẹ";
            // 
            // chkCoXetNghiem
            // 
            this.chkCoXetNghiem.AutoSize = true;
            this.chkCoXetNghiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkCoXetNghiem.Location = new System.Drawing.Point(18, 160);
            this.chkCoXetNghiem.Name = "chkCoXetNghiem";
            this.chkCoXetNghiem.Size = new System.Drawing.Size(155, 21);
            this.chkCoXetNghiem.TabIndex = 16;
            this.chkCoXetNghiem.Text = "Chỉ định xét nghiệm:";
            this.chkCoXetNghiem.UseVisualStyleBackColor = true;
            // 
            // cboXetNghiem
            // 
            this.cboXetNghiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXetNghiem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboXetNghiem.FormattingEnabled = true;
            this.cboXetNghiem.Location = new System.Drawing.Point(180, 158);
            this.cboXetNghiem.Name = "cboXetNghiem";
            this.cboXetNghiem.Size = new System.Drawing.Size(280, 25);
            this.cboXetNghiem.TabIndex = 17;
            // 
            // lblChiSoKQ
            // 
            this.lblChiSoKQ.AutoSize = true;
            this.lblChiSoKQ.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblChiSoKQ.Location = new System.Drawing.Point(480, 162);
            this.lblChiSoKQ.Name = "lblChiSoKQ";
            this.lblChiSoKQ.Size = new System.Drawing.Size(65, 17);
            this.lblChiSoKQ.TabIndex = 18;
            this.lblChiSoKQ.Text = "Chỉ số KQ:";
            // 
            // txtChiSoKQ
            // 
            this.txtChiSoKQ.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtChiSoKQ.Location = new System.Drawing.Point(555, 158);
            this.txtChiSoKQ.Name = "txtChiSoKQ";
            this.txtChiSoKQ.Size = new System.Drawing.Size(405, 25);
            this.txtChiSoKQ.TabIndex = 19;
            this.txtChiSoKQ.Text = "Bạch cầu bình thường (WBC 6.5)";
            // 
            // chkCoKeToa
            // 
            this.chkCoKeToa.AutoSize = true;
            this.chkCoKeToa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkCoKeToa.Location = new System.Drawing.Point(18, 205);
            this.chkCoKeToa.Name = "chkCoKeToa";
            this.chkCoKeToa.Size = new System.Drawing.Size(147, 21);
            this.chkCoKeToa.TabIndex = 20;
            this.chkCoKeToa.Text = "Kê toa thuốc trị liệu:";
            this.chkCoKeToa.UseVisualStyleBackColor = true;
            // 
            // cboThuoc
            // 
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Location = new System.Drawing.Point(180, 203);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(280, 25);
            this.cboThuoc.TabIndex = 21;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSoLuong.Location = new System.Drawing.Point(480, 207);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 22;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudSoLuong.Location = new System.Drawing.Point(555, 203);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(70, 25);
            this.nudSoLuong.TabIndex = 23;
            this.nudSoLuong.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblCachDung
            // 
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCachDung.Location = new System.Drawing.Point(645, 207);
            this.lblCachDung.Name = "lblCachDung";
            this.lblCachDung.Size = new System.Drawing.Size(71, 17);
            this.lblCachDung.TabIndex = 24;
            this.lblCachDung.Text = "Cách dùng:";
            // 
            // txtCachDung
            // 
            this.txtCachDung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCachDung.Location = new System.Drawing.Point(725, 203);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(235, 25);
            this.txtCachDung.TabIndex = 25;
            this.txtCachDung.Text = "Uống sau ăn sáng 1v, tối 1v";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(340, 250);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(320, 45);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "LƯU PHIẾU KHÁM, XN & KÊ TOA THUỐC";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.Location = new System.Drawing.Point(10, 320);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(980, 290);
            this.dgvLichSu.TabIndex = 1;
            // 
            // FrmKhamBenh
            // 
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.grpKham);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FrmKhamBenh";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bác Sĩ Khám Bệnh, Chỉ Định Xét Nghiệm & Kê Toa Thuốc";
            this.grpKham.ResumeLayout(false);
            this.grpKham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanNhiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
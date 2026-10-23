namespace QuanLyNhanSu.Forms
{
    partial class FrmPhanCaPhuTroi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhanCa;
        private System.Windows.Forms.TabPage tabPhuTroi;
        private System.Windows.Forms.SplitContainer splitPhanCa;
        private System.Windows.Forms.DataGridView dgvKeHoach;
        private System.Windows.Forms.DataGridView dgvChiTietPC;
        private System.Windows.Forms.SplitContainer splitPhuTroi;
        private System.Windows.Forms.DataGridView dgvPhieuPT;
        private System.Windows.Forms.DataGridView dgvChiTietPT;
        private System.Windows.Forms.Panel pnlPT;
        private System.Windows.Forms.Label lblNgayPT;
        private System.Windows.Forms.DateTimePicker dtpNgayPT;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Button btnTaoPhieuPT;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblSoGio;
        private System.Windows.Forms.NumericUpDown nudSoGio;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnThemNV;

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
            this.tabPhanCa = new System.Windows.Forms.TabPage();
            this.splitPhanCa = new System.Windows.Forms.SplitContainer();
            this.dgvKeHoach = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPC = new System.Windows.Forms.DataGridView();
            this.tabPhuTroi = new System.Windows.Forms.TabPage();
            this.splitPhuTroi = new System.Windows.Forms.SplitContainer();
            this.dgvPhieuPT = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPT = new System.Windows.Forms.DataGridView();
            this.pnlPT = new System.Windows.Forms.Panel();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.nudSoGio = new System.Windows.Forms.NumericUpDown();
            this.lblSoGio = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.btnTaoPhieuPT = new System.Windows.Forms.Button();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.dtpNgayPT = new System.Windows.Forms.DateTimePicker();
            this.lblNgayPT = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPhanCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPhanCa)).BeginInit();
            this.splitPhanCa.Panel1.SuspendLayout();
            this.splitPhanCa.Panel2.SuspendLayout();
            this.splitPhanCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeHoach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPC)).BeginInit();
            this.tabPhuTroi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPhuTroi)).BeginInit();
            this.splitPhuTroi.Panel1.SuspendLayout();
            this.splitPhuTroi.Panel2.SuspendLayout();
            this.splitPhuTroi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPT)).BeginInit();
            this.pnlPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPhanCa);
            this.tabControl.Controls.Add(this.tabPhuTroi);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 620);
            this.tabControl.TabIndex = 0;
            // 
            // tabPhanCa
            // 
            this.tabPhanCa.Controls.Add(this.splitPhanCa);
            this.tabPhanCa.Location = new System.Drawing.Point(4, 26);
            this.tabPhanCa.Name = "tabPhanCa";
            this.tabPhanCa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanCa.Size = new System.Drawing.Size(912, 590);
            this.tabPhanCa.TabIndex = 0;
            this.tabPhanCa.Text = "Kế Hoạch Phân Ca Tuần";
            this.tabPhanCa.UseVisualStyleBackColor = true;
            // 
            // splitPhanCa
            // 
            this.splitPhanCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPhanCa.Location = new System.Drawing.Point(3, 3);
            this.splitPhanCa.Name = "splitPhanCa";
            this.splitPhanCa.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPhanCa.Panel1
            // 
            this.splitPhanCa.Panel1.Controls.Add(this.dgvKeHoach);
            // 
            // splitPhanCa.Panel2
            // 
            this.splitPhanCa.Panel2.Controls.Add(this.dgvChiTietPC);
            this.splitPhanCa.Size = new System.Drawing.Size(906, 584);
            this.splitPhanCa.SplitterDistance = 240;
            this.splitPhanCa.TabIndex = 0;
            // 
            // dgvKeHoach
            // 
            this.dgvKeHoach.AllowUserToAddRows = false;
            this.dgvKeHoach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeHoach.BackgroundColor = System.Drawing.Color.White;
            this.dgvKeHoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeHoach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeHoach.Location = new System.Drawing.Point(0, 0);
            this.dgvKeHoach.Name = "dgvKeHoach";
            this.dgvKeHoach.ReadOnly = true;
            this.dgvKeHoach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeHoach.Size = new System.Drawing.Size(906, 240);
            this.dgvKeHoach.TabIndex = 0;
            this.dgvKeHoach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeHoach_CellClick);
            // 
            // dgvChiTietPC
            // 
            this.dgvChiTietPC.AllowUserToAddRows = false;
            this.dgvChiTietPC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPC.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPC.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietPC.Name = "dgvChiTietPC";
            this.dgvChiTietPC.ReadOnly = true;
            this.dgvChiTietPC.Size = new System.Drawing.Size(906, 340);
            this.dgvChiTietPC.TabIndex = 0;
            // 
            // tabPhuTroi
            // 
            this.tabPhuTroi.Controls.Add(this.splitPhuTroi);
            this.tabPhuTroi.Controls.Add(this.pnlPT);
            this.tabPhuTroi.Location = new System.Drawing.Point(4, 26);
            this.tabPhuTroi.Name = "tabPhuTroi";
            this.tabPhuTroi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhuTroi.Size = new System.Drawing.Size(912, 590);
            this.tabPhuTroi.TabIndex = 1;
            this.tabPhuTroi.Text = "Ghi Nhận Giờ Phụ Trội (Tăng Ca x1.5)";
            this.tabPhuTroi.UseVisualStyleBackColor = true;
            // 
            // splitPhuTroi
            // 
            this.splitPhuTroi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPhuTroi.Location = new System.Drawing.Point(3, 113);
            this.splitPhuTroi.Name = "splitPhuTroi";
            // 
            // splitPhuTroi.Panel1
            // 
            this.splitPhuTroi.Panel1.Controls.Add(this.dgvPhieuPT);
            // 
            // splitPhuTroi.Panel2
            // 
            this.splitPhuTroi.Panel2.Controls.Add(this.dgvChiTietPT);
            this.splitPhuTroi.Size = new System.Drawing.Size(906, 474);
            this.splitPhuTroi.SplitterDistance = 380;
            this.splitPhuTroi.TabIndex = 1;
            // 
            // dgvPhieuPT
            // 
            this.dgvPhieuPT.AllowUserToAddRows = false;
            this.dgvPhieuPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuPT.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuPT.Name = "dgvPhieuPT";
            this.dgvPhieuPT.ReadOnly = true;
            this.dgvPhieuPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuPT.Size = new System.Drawing.Size(380, 474);
            this.dgvPhieuPT.TabIndex = 0;
            this.dgvPhieuPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuPT_CellClick);
            // 
            // dgvChiTietPT
            // 
            this.dgvChiTietPT.AllowUserToAddRows = false;
            this.dgvChiTietPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPT.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietPT.Name = "dgvChiTietPT";
            this.dgvChiTietPT.ReadOnly = true;
            this.dgvChiTietPT.Size = new System.Drawing.Size(522, 474);
            this.dgvChiTietPT.TabIndex = 0;
            // 
            // pnlPT
            // 
            this.pnlPT.BackColor = System.Drawing.Color.White;
            this.pnlPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPT.Controls.Add(this.btnThemNV);
            this.pnlPT.Controls.Add(this.txtNoiDung);
            this.pnlPT.Controls.Add(this.lblNoiDung);
            this.pnlPT.Controls.Add(this.nudSoGio);
            this.pnlPT.Controls.Add(this.lblSoGio);
            this.pnlPT.Controls.Add(this.cboNV);
            this.pnlPT.Controls.Add(this.lblNV);
            this.pnlPT.Controls.Add(this.txtSoPhieu);
            this.pnlPT.Controls.Add(this.lblSoPhieu);
            this.pnlPT.Controls.Add(this.btnTaoPhieuPT);
            this.pnlPT.Controls.Add(this.cboHinhThuc);
            this.pnlPT.Controls.Add(this.lblHinhThuc);
            this.pnlPT.Controls.Add(this.dtpNgayPT);
            this.pnlPT.Controls.Add(this.lblNgayPT);
            this.pnlPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPT.Location = new System.Drawing.Point(3, 3);
            this.pnlPT.Name = "pnlPT";
            this.pnlPT.Size = new System.Drawing.Size(906, 110);
            this.pnlPT.TabIndex = 0;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(750, 60);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(130, 32);
            this.btnThemNV.TabIndex = 13;
            this.btnThemNV.Text = "Thêm NV vào Phiếu";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(470, 64);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(260, 24);
            this.txtNoiDung.TabIndex = 12;
            this.txtNoiDung.Text = "Tăng ca sản xuất mẻ sơn theo kế hoạch";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(400, 67);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(69, 16);
            this.lblNoiDung.TabIndex = 11;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // nudSoGio
            // 
            this.nudSoGio.DecimalPlaces = 1;
            this.nudSoGio.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.nudSoGio.Location = new System.Drawing.Point(325, 64);
            this.nudSoGio.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.nudSoGio.Name = "nudSoGio";
            this.nudSoGio.Size = new System.Drawing.Size(65, 24);
            this.nudSoGio.TabIndex = 10;
            this.nudSoGio.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            // 
            // lblSoGio
            // 
            this.lblSoGio.AutoSize = true;
            this.lblSoGio.Location = new System.Drawing.Point(270, 67);
            this.lblSoGio.Name = "lblSoGio";
            this.lblSoGio.Size = new System.Drawing.Size(51, 16);
            this.lblSoGio.TabIndex = 9;
            this.lblSoGio.Text = "Số giờ:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(85, 64);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(175, 24);
            this.cboNV.TabIndex = 8;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(10, 67);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(73, 16);
            this.lblNV.TabIndex = 7;
            this.lblNV.Text = "Nhân viên:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(620, 15);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(110, 24);
            this.txtSoPhieu.TabIndex = 6;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(555, 18);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(64, 16);
            this.lblSoPhieu.TabIndex = 5;
            this.lblSoPhieu.Text = "Số Phiếu:";
            // 
            // btnTaoPhieuPT
            // 
            this.btnTaoPhieuPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnTaoPhieuPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuPT.ForeColor = System.Drawing.Color.White;
            this.btnTaoPhieuPT.Location = new System.Drawing.Point(750, 12);
            this.btnTaoPhieuPT.Name = "btnTaoPhieuPT";
            this.btnTaoPhieuPT.Size = new System.Drawing.Size(130, 32);
            this.btnTaoPhieuPT.TabIndex = 4;
            this.btnTaoPhieuPT.Text = "Tạo Phiếu PT";
            this.btnTaoPhieuPT.UseVisualStyleBackColor = false;
            this.btnTaoPhieuPT.Click += new System.EventHandler(this.btnTaoPhieuPT_Click);
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Location = new System.Drawing.Point(310, 15);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(230, 24);
            this.cboHinhThuc.TabIndex = 3;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(235, 18);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(73, 16);
            this.lblHinhThuc.TabIndex = 2;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // dtpNgayPT
            // 
            this.dtpNgayPT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayPT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayPT.Location = new System.Drawing.Point(110, 15);
            this.dtpNgayPT.Name = "dtpNgayPT";
            this.dtpNgayPT.Size = new System.Drawing.Size(115, 24);
            this.dtpNgayPT.TabIndex = 1;
            // 
            // lblNgayPT
            // 
            this.lblNgayPT.AutoSize = true;
            this.lblNgayPT.Location = new System.Drawing.Point(10, 18);
            this.lblNgayPT.Name = "lblNgayPT";
            this.lblNgayPT.Size = new System.Drawing.Size(98, 16);
            this.lblNgayPT.TabIndex = 0;
            this.lblNgayPT.Text = "Ngày Phụ Trội:";
            // 
            // FrmPhanCaPhuTroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhanCaPhuTroi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Phân Ca & Phụ Trội";
            this.Load += new System.EventHandler(this.FrmPhanCaPhuTroi_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPhanCa.ResumeLayout(false);
            this.splitPhanCa.Panel1.ResumeLayout(false);
            this.splitPhanCa.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPhanCa)).EndInit();
            this.splitPhanCa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeHoach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPC)).EndInit();
            this.tabPhuTroi.ResumeLayout(false);
            this.splitPhuTroi.Panel1.ResumeLayout(false);
            this.splitPhuTroi.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPhuTroi)).EndInit();
            this.splitPhuTroi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPT)).EndInit();
            this.pnlPT.ResumeLayout(false);
            this.pnlPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoGio)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

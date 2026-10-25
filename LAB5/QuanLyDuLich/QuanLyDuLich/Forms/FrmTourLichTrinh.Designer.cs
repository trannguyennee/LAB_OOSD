namespace QuanLyDuLich.Forms
{
    partial class FrmTourLichTrinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbTour;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Label lblMaTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label lblTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown nudSoNgay;
        private System.Windows.Forms.Label lblSoDem;
        private System.Windows.Forms.NumericUpDown nudSoDem;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TabControl tabChiTiet;
        private System.Windows.Forms.TabPage tabNoiDungChan;
        private System.Windows.Forms.DataGridView dgvNoiDungChan;
        private System.Windows.Forms.TabPage tabDiemThamQuan;
        private System.Windows.Forms.DataGridView dgvDiemThamQuan;

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
            this.gbTour = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.nudSoDem = new System.Windows.Forms.NumericUpDown();
            this.lblSoDem = new System.Windows.Forms.Label();
            this.nudSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.lblMaTour = new System.Windows.Forms.Label();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.tabChiTiet = new System.Windows.Forms.TabControl();
            this.tabNoiDungChan = new System.Windows.Forms.TabPage();
            this.dgvNoiDungChan = new System.Windows.Forms.DataGridView();
            this.tabDiemThamQuan = new System.Windows.Forms.TabPage();
            this.dgvDiemThamQuan = new System.Windows.Forms.DataGridView();
            this.gbTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.tabChiTiet.SuspendLayout();
            this.tabNoiDungChan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoiDungChan)).BeginInit();
            this.tabDiemThamQuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThamQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTour
            // 
            this.gbTour.Controls.Add(this.btnDong);
            this.gbTour.Controls.Add(this.btnThemTour);
            this.gbTour.Controls.Add(this.txtDonGia);
            this.gbTour.Controls.Add(this.lblDonGia);
            this.gbTour.Controls.Add(this.nudSoDem);
            this.gbTour.Controls.Add(this.lblSoDem);
            this.gbTour.Controls.Add(this.nudSoNgay);
            this.gbTour.Controls.Add(this.lblSoNgay);
            this.gbTour.Controls.Add(this.txtTenTour);
            this.gbTour.Controls.Add(this.lblTenTour);
            this.gbTour.Controls.Add(this.txtMaTour);
            this.gbTour.Controls.Add(this.lblMaTour);
            this.gbTour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbTour.Location = new System.Drawing.Point(12, 12);
            this.gbTour.Name = "gbTour";
            this.gbTour.Size = new System.Drawing.Size(960, 110);
            this.gbTour.TabIndex = 0;
            this.gbTour.TabStop = false;
            this.gbTour.Text = "Thông tin Tour Du Lịch (Xuất phát & Kết thúc tại TP.HCM)";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(840, 65);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThemTour
            // 
            this.btnThemTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThemTour.ForeColor = System.Drawing.Color.White;
            this.btnThemTour.Location = new System.Drawing.Point(720, 65);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(110, 32);
            this.btnThemTour.TabIndex = 10;
            this.btnThemTour.Text = "Thêm Tour";
            this.btnThemTour.UseVisualStyleBackColor = false;
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(540, 70);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(150, 23);
            this.txtDonGia.TabIndex = 9;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonGia.Location = new System.Drawing.Point(440, 73);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(91, 15);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá/khách:";
            // 
            // nudSoDem
            // 
            this.nudSoDem.Location = new System.Drawing.Point(330, 70);
            this.nudSoDem.Name = "nudSoDem";
            this.nudSoDem.Size = new System.Drawing.Size(80, 23);
            this.nudSoDem.TabIndex = 7;
            // 
            // lblSoDem
            // 
            this.lblSoDem.AutoSize = true;
            this.lblSoDem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDem.Location = new System.Drawing.Point(260, 73);
            this.lblSoDem.Name = "lblSoDem";
            this.lblSoDem.Size = new System.Drawing.Size(51, 15);
            this.lblSoDem.TabIndex = 6;
            this.lblSoDem.Text = "Số đêm:";
            // 
            // nudSoNgay
            // 
            this.nudSoNgay.Location = new System.Drawing.Point(120, 70);
            this.nudSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoNgay.Name = "nudSoNgay";
            this.nudSoNgay.Size = new System.Drawing.Size(80, 23);
            this.nudSoNgay.TabIndex = 5;
            this.nudSoNgay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoNgay.Location = new System.Drawing.Point(20, 73);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(53, 15);
            this.lblSoNgay.TabIndex = 4;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(330, 30);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(610, 23);
            this.txtTenTour.TabIndex = 3;
            // 
            // lblTenTour
            // 
            this.lblTenTour.AutoSize = true;
            this.lblTenTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenTour.Location = new System.Drawing.Point(260, 33);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(54, 15);
            this.lblTenTour.TabIndex = 2;
            this.lblTenTour.Text = "Tên Tour:";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(120, 30);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(120, 23);
            this.txtMaTour.TabIndex = 1;
            // 
            // lblMaTour
            // 
            this.lblMaTour.AutoSize = true;
            this.lblMaTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaTour.Location = new System.Drawing.Point(20, 33);
            this.lblMaTour.Name = "lblMaTour";
            this.lblMaTour.Size = new System.Drawing.Size(54, 15);
            this.lblMaTour.TabIndex = 0;
            this.lblMaTour.Text = "Mã Tour:";
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(12, 135);
            this.dgvTour.MultiSelect = false;
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(960, 180);
            this.dgvTour.TabIndex = 1;
            this.dgvTour.SelectionChanged += new System.EventHandler(this.dgvTour_SelectionChanged);
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.tabNoiDungChan);
            this.tabChiTiet.Controls.Add(this.tabDiemThamQuan);
            this.tabChiTiet.Location = new System.Drawing.Point(12, 330);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.SelectedIndex = 0;
            this.tabChiTiet.Size = new System.Drawing.Size(960, 240);
            this.tabChiTiet.TabIndex = 2;
            // 
            // tabNoiDungChan
            // 
            this.tabNoiDungChan.Controls.Add(this.dgvNoiDungChan);
            this.tabNoiDungChan.Location = new System.Drawing.Point(4, 24);
            this.tabNoiDungChan.Name = "tabNoiDungChan";
            this.tabNoiDungChan.Padding = new System.Windows.Forms.Padding(3);
            this.tabNoiDungChan.Size = new System.Drawing.Size(952, 212);
            this.tabNoiDungChan.TabIndex = 0;
            this.tabNoiDungChan.Text = "Các Chặng Nơi Dừng Chân Liên Hoàn (Đổi PT / Ăn / Khách Sạn 2-5 Sao)";
            this.tabNoiDungChan.UseVisualStyleBackColor = true;
            // 
            // dgvNoiDungChan
            // 
            this.dgvNoiDungChan.AllowUserToAddRows = false;
            this.dgvNoiDungChan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoiDungChan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoiDungChan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoiDungChan.Location = new System.Drawing.Point(3, 3);
            this.dgvNoiDungChan.Name = "dgvNoiDungChan";
            this.dgvNoiDungChan.ReadOnly = true;
            this.dgvNoiDungChan.Size = new System.Drawing.Size(946, 206);
            this.dgvNoiDungChan.TabIndex = 0;
            // 
            // tabDiemThamQuan
            // 
            this.tabDiemThamQuan.Controls.Add(this.dgvDiemThamQuan);
            this.tabDiemThamQuan.Location = new System.Drawing.Point(4, 24);
            this.tabDiemThamQuan.Name = "tabDiemThamQuan";
            this.tabDiemThamQuan.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiemThamQuan.Size = new System.Drawing.Size(952, 212);
            this.tabDiemThamQuan.TabIndex = 1;
            this.tabDiemThamQuan.Text = "Danh Sách Điểm Tham Quan (Di Tích, Thắng Cảnh, Ý Nghĩa)";
            this.tabDiemThamQuan.UseVisualStyleBackColor = true;
            // 
            // dgvDiemThamQuan
            // 
            this.dgvDiemThamQuan.AllowUserToAddRows = false;
            this.dgvDiemThamQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemThamQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThamQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemThamQuan.Location = new System.Drawing.Point(3, 3);
            this.dgvDiemThamQuan.Name = "dgvDiemThamQuan";
            this.dgvDiemThamQuan.ReadOnly = true;
            this.dgvDiemThamQuan.Size = new System.Drawing.Size(946, 206);
            this.dgvDiemThamQuan.TabIndex = 0;
            // 
            // FrmTourLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 580);
            this.Controls.Add(this.tabChiTiet);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.gbTour);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTourLichTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Tour Du Lịch & Lộ Trình Tuyến Điểm";
            this.Load += new System.EventHandler(this.FrmTourLichTrinh_Load);
            this.gbTour.ResumeLayout(false);
            this.gbTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.tabChiTiet.ResumeLayout(false);
            this.tabNoiDungChan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoiDungChan)).EndInit();
            this.tabDiemThamQuan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThamQuan)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

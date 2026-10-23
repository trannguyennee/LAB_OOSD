namespace QuanLyNhanSu.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnPhanCa;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnKhenThuong;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnThoat;

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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnKhenThuong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnPhanCa = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelSidebar.Controls.Add(this.btnThoat);
            this.panelSidebar.Controls.Add(this.btnBangLuong);
            this.panelSidebar.Controls.Add(this.btnKhenThuong);
            this.panelSidebar.Controls.Add(this.btnChamCong);
            this.panelSidebar.Controls.Add(this.btnPhanCa);
            this.panelSidebar.Controls.Add(this.btnHopDong);
            this.panelSidebar.Controls.Add(this.btnNhanVien);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(260, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(0, 665);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(260, 55);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBangLuong.FlatAppearance.BorderSize = 0;
            this.btnBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangLuong.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular);
            this.btnBangLuong.ForeColor = System.Drawing.Color.White;
            this.btnBangLuong.Location = new System.Drawing.Point(0, 360);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBangLuong.Size = new System.Drawing.Size(260, 52);
            this.btnBangLuong.TabIndex = 6;
            this.btnBangLuong.Text = "6. Bảng Lương & Phiếu Lương";
            this.btnBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhenThuong.FlatAppearance.BorderSize = 0;
            this.btnKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhenThuong.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular);
            this.btnKhenThuong.ForeColor = System.Drawing.Color.White;
            this.btnKhenThuong.Location = new System.Drawing.Point(0, 308);
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKhenThuong.Size = new System.Drawing.Size(260, 52);
            this.btnKhenThuong.TabIndex = 5;
            this.btnKhenThuong.Text = "5. Khen Thưởng & Kỷ Luật";
            this.btnKhenThuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhenThuong.UseVisualStyleBackColor = true;
            this.btnKhenThuong.Click += new System.EventHandler(this.btnKhenThuong_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular);
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Location = new System.Drawing.Point(0, 256);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnChamCong.Size = new System.Drawing.Size(260, 52);
            this.btnChamCong.TabIndex = 4;
            this.btnChamCong.Text = "4. Chấm Công Tháng";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnPhanCa
            // 
            this.btnPhanCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCa.FlatAppearance.BorderSize = 0;
            this.btnPhanCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCa.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular);
            this.btnPhanCa.ForeColor = System.Drawing.Color.White;
            this.btnPhanCa.Location = new System.Drawing.Point(0, 204);
            this.btnPhanCa.Name = "btnPhanCa";
            this.btnPhanCa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPhanCa.Size = new System.Drawing.Size(260, 52);
            this.btnPhanCa.TabIndex = 3;
            this.btnPhanCa.Text = "3. Phân Ca & Phụ Trội";
            this.btnPhanCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCa.UseVisualStyleBackColor = true;
            this.btnPhanCa.Click += new System.EventHandler(this.btnPhanCa_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular);
            this.btnHopDong.ForeColor = System.Drawing.Color.White;
            this.btnHopDong.Location = new System.Drawing.Point(0, 152);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHopDong.Size = new System.Drawing.Size(260, 52);
            this.btnHopDong.TabIndex = 2;
            this.btnHopDong.Text = "2. Hợp Đồng & Chế Độ Lương";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Regular);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 100);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(260, 52);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "1. Quản Lý Hồ Sơ Nhân Sự";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(260, 100);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "CÔNG TY SƠN ĐÔNG Á\r\nQUẢN LÝ NHÂN SỰ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblStudentInfo);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(260, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(940, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic);
            this.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStudentInfo.Location = new System.Drawing.Point(540, 12);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(388, 45);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "SVTH: Trần Nguyên - MSSV: 1250080121 - Lớp: 12CNPM2\r\nGVHD: ThS. Phạm Trọng Huynh" +
    " - Môn: OOSD";
            this.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HỒ SƠ NHÂN SỰ";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(260, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(940, 650);
            this.panelContent.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Nhân sự & Tiền lương - Công ty Sơn Đông Á";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

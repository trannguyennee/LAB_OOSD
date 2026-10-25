namespace QuanLyDuLich.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnChuyenDi;
        private System.Windows.Forms.Button btnDoan;
        private System.Windows.Forms.Button btnHDV;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnKhaoSat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnChuyenDi = new System.Windows.Forms.Button();
            this.btnDoan = new System.Windows.Forms.Button();
            this.btnHDV = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnKhaoSat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(710, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.lblSub.Location = new System.Drawing.Point(42, 60);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(600, 19);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Hệ thống Quản lý Tour, Chuyến đi, Khách đoàn/lẻ, Điều hành HDV & Khảo sát Dịch vụ";
            // 
            // btnTour
            // 
            this.btnTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTour.ForeColor = System.Drawing.Color.White;
            this.btnTour.Location = new System.Drawing.Point(60, 130);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(240, 90);
            this.btnTour.TabIndex = 1;
            this.btnTour.Text = "1. Quản lý Tour &\nLộ trình Dừng chân";
            this.btnTour.UseVisualStyleBackColor = false;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnChuyenDi
            // 
            this.btnChuyenDi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnChuyenDi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChuyenDi.ForeColor = System.Drawing.Color.White;
            this.btnChuyenDi.Location = new System.Drawing.Point(330, 130);
            this.btnChuyenDi.Name = "btnChuyenDi";
            this.btnChuyenDi.Size = new System.Drawing.Size(240, 90);
            this.btnChuyenDi.TabIndex = 2;
            this.btnChuyenDi.Text = "2. Chuyến đi Cố định &\nBán vé Khách lẻ";
            this.btnChuyenDi.UseVisualStyleBackColor = false;
            this.btnChuyenDi.Click += new System.EventHandler(this.btnChuyenDi_Click);
            // 
            // btnDoan
            // 
            this.btnDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDoan.ForeColor = System.Drawing.Color.White;
            this.btnDoan.Location = new System.Drawing.Point(600, 130);
            this.btnDoan.Name = "btnDoan";
            this.btnDoan.Size = new System.Drawing.Size(240, 90);
            this.btnDoan.TabIndex = 3;
            this.btnDoan.Text = "3. Đăng ký Tour Đoàn &\nBảo hiểm Du lịch";
            this.btnDoan.UseVisualStyleBackColor = false;
            this.btnDoan.Click += new System.EventHandler(this.btnDoan_Click);
            // 
            // btnHDV
            // 
            this.btnHDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(115)))), ((int)(((byte)(51)))));
            this.btnHDV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHDV.ForeColor = System.Drawing.Color.White;
            this.btnHDV.Location = new System.Drawing.Point(60, 250);
            this.btnHDV.Name = "btnHDV";
            this.btnHDV.Size = new System.Drawing.Size(240, 90);
            this.btnHDV.TabIndex = 4;
            this.btnHDV.Text = "4. Điều hành Phân công\nHướng dẫn viên (HDV)";
            this.btnHDV.UseVisualStyleBackColor = false;
            this.btnHDV.Click += new System.EventHandler(this.btnHDV_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnLuong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuong.ForeColor = System.Drawing.Color.White;
            this.btnLuong.Location = new System.Drawing.Point(330, 250);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(240, 90);
            this.btnLuong.TabIndex = 5;
            this.btnLuong.Text = "5. Bảng tính lương HDV\n(Lương CB + Lương Tour)";
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnKhaoSat
            // 
            this.btnKhaoSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnKhaoSat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKhaoSat.ForeColor = System.Drawing.Color.White;
            this.btnKhaoSat.Location = new System.Drawing.Point(600, 250);
            this.btnKhaoSat.Name = "btnKhaoSat";
            this.btnKhaoSat.Size = new System.Drawing.Size(240, 90);
            this.btnKhaoSat.TabIndex = 6;
            this.btnKhaoSat.Text = "6. Khảo sát Chất lượng\nDịch vụ Hậu mãi";
            this.btnKhaoSat.UseVisualStyleBackColor = false;
            this.btnKhaoSat.Click += new System.EventHandler(this.btnKhaoSat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(680, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát Hệ Thống";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(430, 17);
            this.lblStatus.Text = "Sinh viên: Trần Nguyên - MSSV: 1250080121 - Lớp: 12CNPM2 - HCMUNRE 2026";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKhaoSat);
            this.Controls.Add(this.btnLuong);
            this.Controls.Add(this.btnHDV);
            this.Controls.Add(this.btnDoan);
            this.Controls.Add(this.btnChuyenDi);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Công ty Du lịch Văn Hóa Việt TP.HCM - [Trần Nguyên - 1250080121]";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

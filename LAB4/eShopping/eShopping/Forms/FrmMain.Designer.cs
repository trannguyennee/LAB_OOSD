namespace eShopping.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnXuLyDon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblThongTinSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(12, 35);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(836, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỆ THỐNG CỬA HÀNG ONLINE e-SHOPPING";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.BackColor = System.Drawing.Color.White;
            this.btnMuaHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnMuaHang.FlatAppearance.BorderSize = 2;
            this.btnMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaHang.ForeColor = System.Drawing.Color.Black;
            this.btnMuaHang.Location = new System.Drawing.Point(135, 125);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(275, 75);
            this.btnMuaHang.TabIndex = 1;
            this.btnMuaHang.Text = "1. Mua sắm & Đặt hàng";
            this.btnMuaHang.UseVisualStyleBackColor = false;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Location = new System.Drawing.Point(135, 225);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(275, 75);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "2. Quản lý Tài khoản & Đăng ký";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnChuaPhatTrien_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.btnDanhMuc.Location = new System.Drawing.Point(135, 325);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(275, 75);
            this.btnDanhMuc.TabIndex = 3;
            this.btnDanhMuc.Text = "3. Quản lý Danh mục & Sản phẩm";
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnChuaPhatTrien_Click);
            // 
            // btnXuLyDon
            // 
            this.btnXuLyDon.BackColor = System.Drawing.Color.White;
            this.btnXuLyDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnXuLyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLyDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyDon.ForeColor = System.Drawing.Color.Black;
            this.btnXuLyDon.Location = new System.Drawing.Point(450, 125);
            this.btnXuLyDon.Name = "btnXuLyDon";
            this.btnXuLyDon.Size = new System.Drawing.Size(275, 75);
            this.btnXuLyDon.TabIndex = 4;
            this.btnXuLyDon.Text = "4. Xử lý & Giao nhận đơn hàng";
            this.btnXuLyDon.UseVisualStyleBackColor = false;
            this.btnXuLyDon.Click += new System.EventHandler(this.btnChuaPhatTrien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(450, 225);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(275, 75);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "5. Báo cáo & Thống kê doanh thu";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnChuaPhatTrien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(450, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(275, 75);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "6. Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblThongTinSV
            // 
            this.lblThongTinSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblThongTinSV.ForeColor = System.Drawing.Color.DimGray;
            this.lblThongTinSV.Location = new System.Drawing.Point(12, 440);
            this.lblThongTinSV.Name = "lblThongTinSV";
            this.lblThongTinSV.Size = new System.Drawing.Size(836, 25);
            this.lblThongTinSV.TabIndex = 7;
            this.lblThongTinSV.Text = "Sinh viên thực hiện: Trần Nguyên - MSSV: 1250080121 - Lớp: 12CNPM2 - HCMUNRE";
            this.lblThongTinSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.lblThongTinSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnXuLyDon);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnMuaHang);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-SHOPPING - Hệ Thống Cửa Hàng Trực Tuyến";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnMuaHang;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnXuLyDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblThongTinSV;
    }
}

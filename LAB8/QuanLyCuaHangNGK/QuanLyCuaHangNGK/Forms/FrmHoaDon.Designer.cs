namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblLoaiKH;
        private System.Windows.Forms.Label lblNoHienTai;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.GroupBox grpChonHang;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.ComboBox cboNGK;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown nudSLMua;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnXoaGioHang;
        private System.Windows.Forms.Button btnKiemTraKho;
        private System.Windows.Forms.Label lblKetQuaKT;
        private System.Windows.Forms.Panel pnlPhieuHen;
        private System.Windows.Forms.Label lblPHHeader;
        private System.Windows.Forms.Label txtHenDot1;
        private System.Windows.Forms.Label txtHenDot2;
        private System.Windows.Forms.Label lblNgayHen;
        private System.Windows.Forms.DateTimePicker dtpHenGiao;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.CheckBox chkGhiNo;
        private System.Windows.Forms.Panel pnlGhiNo;
        private System.Windows.Forms.Label lblTienNo;
        private System.Windows.Forms.NumericUpDown nudSoTienNo;
        private System.Windows.Forms.Label lblHanTra;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDoNo;
        private System.Windows.Forms.Label lblTongTienHeader;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.SplitContainer splitCenter;
        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.SplitContainer splitBottom;
        private System.Windows.Forms.GroupBox grpListHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox grpCTHD;
        private System.Windows.Forms.DataGridView dgvCTHD;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblLoaiKH = new System.Windows.Forms.Label();
            this.lblNoHienTai = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.grpChonHang = new System.Windows.Forms.GroupBox();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.cboNGK = new System.Windows.Forms.ComboBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.nudSLMua = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.btnKiemTraKho = new System.Windows.Forms.Button();
            this.lblKetQuaKT = new System.Windows.Forms.Label();
            this.pnlPhieuHen = new System.Windows.Forms.Panel();
            this.lblPHHeader = new System.Windows.Forms.Label();
            this.txtHenDot1 = new System.Windows.Forms.Label();
            this.txtHenDot2 = new System.Windows.Forms.Label();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtpHenGiao = new System.Windows.Forms.DateTimePicker();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.chkGhiNo = new System.Windows.Forms.CheckBox();
            this.pnlGhiNo = new System.Windows.Forms.Panel();
            this.lblTienNo = new System.Windows.Forms.Label();
            this.nudSoTienNo = new System.Windows.Forms.NumericUpDown();
            this.lblHanTra = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDoNo = new System.Windows.Forms.TextBox();
            this.lblTongTienHeader = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.splitCenter = new System.Windows.Forms.SplitContainer();
            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitBottom = new System.Windows.Forms.SplitContainer();
            this.grpListHD = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.grpCTHD = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();

            // pnlTop
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 160;

            // grpKhachHang
            this.grpKhachHang.Text = "THÔNG TIN KHÁCH HÀNG & HÓA ĐƠN";
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpKhachHang.Location = new System.Drawing.Point(10, 5);
            this.grpKhachHang.Size = new System.Drawing.Size(620, 150);

            this.lblSoHD.Text = "Số HĐ:";
            this.lblSoHD.Location = new System.Drawing.Point(15, 25);
            this.lblSoHD.AutoSize = true;
            this.txtSoHD.Location = new System.Drawing.Point(75, 22);
            this.txtSoHD.Size = new System.Drawing.Size(120, 23);
            this.txtSoHD.Text = "HD_" + System.DateTime.Now.ToString("MMdd_HHmmss");

            this.lblKH.Text = "Khách hàng:";
            this.lblKH.Location = new System.Drawing.Point(210, 25);
            this.lblKH.AutoSize = true;
            this.cboKhachHang.Location = new System.Drawing.Point(290, 22);
            this.cboKhachHang.Size = new System.Drawing.Size(315, 23);
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);

            this.lblLoaiKH.Text = "Loại khách: Đang tải...";
            this.lblLoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoaiKH.Location = new System.Drawing.Point(75, 55);
            this.lblLoaiKH.AutoSize = true;

            this.lblNoHienTai.Text = "Công nợ hiện tại: 0 VNĐ";
            this.lblNoHienTai.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNoHienTai.Location = new System.Drawing.Point(75, 80);
            this.lblNoHienTai.AutoSize = true;

            this.lblNV.Text = "Thu ngân:";
            this.lblNV.Location = new System.Drawing.Point(15, 115);
            this.lblNV.AutoSize = true;
            this.cboNhanVien.Location = new System.Drawing.Point(75, 112);
            this.cboNhanVien.Size = new System.Drawing.Size(200, 23);
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.grpKhachHang.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSoHD, this.txtSoHD, this.lblKH, this.cboKhachHang, this.lblLoaiKH,
                this.lblNoHienTai, this.lblNV, this.cboNhanVien
            });

            // grpChonHang
            this.grpChonHang.Text = "CHỌN NƯỚC GIẢI KHÁT VÀO GIỎ HÀNG";
            this.grpChonHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpChonHang.Location = new System.Drawing.Point(640, 5);
            this.grpChonHang.Size = new System.Drawing.Size(540, 150);

            this.lblMatHang.Text = "Mặt hàng:";
            this.lblMatHang.Location = new System.Drawing.Point(15, 25);
            this.lblMatHang.AutoSize = true;
            this.cboNGK.Location = new System.Drawing.Point(85, 22);
            this.cboNGK.Size = new System.Drawing.Size(230, 23);
            this.cboNGK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblSL.Text = "Số lượng:";
            this.lblSL.Location = new System.Drawing.Point(330, 25);
            this.lblSL.AutoSize = true;
            this.nudSLMua.Location = new System.Drawing.Point(395, 22);
            this.nudSLMua.Size = new System.Drawing.Size(70, 23);
            this.nudSLMua.Maximum = 1000;
            this.nudSLMua.Value = 10;

            this.btnThemVaoGio.Text = "+ Thêm Vào Giỏ";
            this.btnThemVaoGio.Location = new System.Drawing.Point(85, 60);
            this.btnThemVaoGio.Size = new System.Drawing.Size(120, 32);
            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);

            this.btnXoaGioHang.Text = "Dọn giỏ hàng";
            this.btnXoaGioHang.Location = new System.Drawing.Point(215, 60);
            this.btnXoaGioHang.Size = new System.Drawing.Size(100, 32);
            this.btnXoaGioHang.BackColor = System.Drawing.Color.Gray;
            this.btnXoaGioHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);

            this.btnKiemTraKho.Text = "Kiểm Tra Tồn Kho (Đủ/Thiếu)";
            this.btnKiemTraKho.Location = new System.Drawing.Point(325, 60);
            this.btnKiemTraKho.Size = new System.Drawing.Size(195, 32);
            this.btnKiemTraKho.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnKiemTraKho.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTraKho.Click += new System.EventHandler(this.btnKiemTraKho_Click);

            this.lblKetQuaKT.Text = "Nhấn 'Kiểm Tra Tồn Kho' để phân tích nghiệp vụ.";
            this.lblKetQuaKT.Location = new System.Drawing.Point(15, 105);
            this.lblKetQuaKT.Size = new System.Drawing.Size(510, 35);

            this.grpChonHang.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMatHang, this.cboNGK, this.lblSL, this.nudSLMua,
                this.btnThemVaoGio, this.btnXoaGioHang, this.btnKiemTraKho, this.lblKetQuaKT
            });

            this.pnlTop.Controls.Add(this.grpChonHang);
            this.pnlTop.Controls.Add(this.grpKhachHang);

            // pnlPhieuHen (Hẹn đợt giao khi khách quen thiếu hàng)
            this.pnlPhieuHen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhieuHen.Height = 70;
            this.pnlPhieuHen.BackColor = System.Drawing.Color.FromArgb(235, 245, 251);
            this.pnlPhieuHen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhieuHen.Visible = false;

            this.lblPHHeader.Text = "LẬP PHIẾU HẸN GIAO HÀNG NHIỀU ĐỢT (Chỉ áp dụng Khách quen):";
            this.lblPHHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPHHeader.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblPHHeader.Location = new System.Drawing.Point(15, 10);
            this.lblPHHeader.AutoSize = true;

            this.txtHenDot1.Text = "Đợt 1 (Giao ngay): 0 lon";
            this.txtHenDot1.Location = new System.Drawing.Point(15, 35);
            this.txtHenDot1.AutoSize = true;

            this.txtHenDot2.Text = "Đợt 2 (Hẹn giao): 0 lon";
            this.txtHenDot2.Location = new System.Drawing.Point(220, 35);
            this.txtHenDot2.AutoSize = true;

            this.lblNgayHen.Text = "Ngày hẹn giao đợt 2:";
            this.lblNgayHen.Location = new System.Drawing.Point(500, 35);
            this.lblNgayHen.AutoSize = true;

            this.dtpHenGiao.Location = new System.Drawing.Point(630, 32);
            this.dtpHenGiao.Size = new System.Drawing.Size(140, 23);
            this.dtpHenGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHenGiao.Value = System.DateTime.Now.AddDays(3);

            this.pnlPhieuHen.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPHHeader, this.txtHenDot1, this.txtHenDot2, this.lblNgayHen, this.dtpHenGiao
            });

            // pnlThanhToan (Bottom of center)
            this.pnlThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThanhToan.Height = 90;
            this.pnlThanhToan.BackColor = System.Drawing.Color.White;
            this.pnlThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.chkGhiNo.Text = "Khách quen trả chậm (Lập Phiếu Ghi Nợ)";
            this.chkGhiNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkGhiNo.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.chkGhiNo.Location = new System.Drawing.Point(15, 12);
            this.chkGhiNo.AutoSize = true;
            this.chkGhiNo.CheckedChanged += new System.EventHandler(this.chkGhiNo_CheckedChanged);

            // pnlGhiNo (sub-panel)
            this.pnlGhiNo.Location = new System.Drawing.Point(15, 38);
            this.pnlGhiNo.Size = new System.Drawing.Size(700, 45);
            this.pnlGhiNo.Visible = false;

            this.lblTienNo.Text = "Số tiền nợ:";
            this.lblTienNo.Location = new System.Drawing.Point(0, 10);
            this.lblTienNo.AutoSize = true;

            this.nudSoTienNo.Location = new System.Drawing.Point(65, 7);
            this.nudSoTienNo.Size = new System.Drawing.Size(120, 23);
            this.nudSoTienNo.Maximum = 100000000;

            this.lblHanTra.Text = "Hạn trả:";
            this.lblHanTra.Location = new System.Drawing.Point(195, 10);
            this.lblHanTra.AutoSize = true;

            this.dtpHanTra.Location = new System.Drawing.Point(245, 7);
            this.dtpHanTra.Size = new System.Drawing.Size(120, 23);
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Value = System.DateTime.Now.AddDays(30);

            this.lblLyDo.Text = "Lý do:";
            this.lblLyDo.Location = new System.Drawing.Point(375, 10);
            this.lblLyDo.AutoSize = true;

            this.txtLyDoNo.Location = new System.Drawing.Point(415, 7);
            this.txtLyDoNo.Size = new System.Drawing.Size(270, 23);
            this.txtLyDoNo.Text = "Khách quen lấy hàng thanh toán cuối tháng";

            this.pnlGhiNo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTienNo, this.nudSoTienNo, this.lblHanTra, this.dtpHanTra, this.lblLyDo, this.txtLyDoNo
            });

            this.lblTongTienHeader.Text = "TỔNG TIỀN:";
            this.lblTongTienHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTienHeader.Location = new System.Drawing.Point(740, 15);
            this.lblTongTienHeader.AutoSize = true;

            this.lblTongTien.Text = "0 VNĐ";
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblTongTien.Location = new System.Drawing.Point(840, 12);
            this.lblTongTien.AutoSize = true;

            this.btnXuatHoaDon.Text = "HOÀN TẤT & LẬP HÓA ĐƠN";
            this.btnXuatHoaDon.Location = new System.Drawing.Point(740, 45);
            this.btnXuatHoaDon.Size = new System.Drawing.Size(260, 38);
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);

            this.pnlThanhToan.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.chkGhiNo, this.pnlGhiNo, this.lblTongTienHeader, this.lblTongTien, this.btnXuatHoaDon
            });

            // splitCenter
            this.splitCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCenter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitCenter.SplitterDistance = 200;

            // grpGioHang
            this.grpGioHang.Text = "GIỎ HÀNG CHỜ XUẤT BÁN";
            this.grpGioHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGioHang.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.AllowUserToAddRows = false;

            this.colMa.HeaderText = "Mã NGK";
            this.colTen.HeaderText = "Tên NGK";
            this.colSL.HeaderText = "SL Đặt Mua";
            this.colTon.HeaderText = "Tồn Kho";
            this.colGia.HeaderText = "Đơn Giá";
            this.colTT.HeaderText = "Thành Tiền";
            this.colTinhTrang.HeaderText = "Tình Trạng Kho";

            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMa, this.colTen, this.colSL, this.colTon, this.colGia, this.colTT, this.colTinhTrang
            });

            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.splitCenter.Panel1.Controls.Add(this.grpGioHang);

            // splitBottom
            this.splitBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBottom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitBottom.SplitterDistance = 600;

            // grpListHD
            this.grpListHD.Text = "DANH SÁCH HÓA ĐƠN ĐÃ LẬP";
            this.grpListHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpListHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.grpListHD.Controls.Add(this.dgvHoaDon);
            this.splitBottom.Panel1.Controls.Add(this.grpListHD);

            // grpCTHD
            this.grpCTHD.Text = "CHI TIẾT HÓA ĐƠN CHỌN";
            this.grpCTHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.AllowUserToAddRows = false;
            this.grpCTHD.Controls.Add(this.dgvCTHD);
            this.splitBottom.Panel2.Controls.Add(this.grpCTHD);

            this.splitCenter.Panel2.Controls.Add(this.splitBottom);

            // FrmHoaDon
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nghiệp Vụ Bán Hàng & Lập Hóa Đơn (Kiểm tra kho, Hẹn đợt & Ghi nợ)";
            this.Controls.Add(this.splitCenter);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.pnlPhieuHen);
            this.Controls.Add(this.pnlTop);
        }
    }
}

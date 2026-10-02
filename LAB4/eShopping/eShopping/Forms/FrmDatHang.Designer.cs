namespace eShopping.Forms
{
    partial class FrmDatHang
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpNguoiNhan = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpGiaoHang = new System.Windows.Forms.GroupBox();
            this.radGiaoHoaToc = new System.Windows.Forms.RadioButton();
            this.radGiaoNhanh = new System.Windows.Forms.RadioButton();
            this.radGiaoThuong = new System.Windows.Forms.RadioButton();
            this.grpTheTinDung = new System.Windows.Forms.GroupBox();
            this.lblGhiChuThe = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.lblSoThe = new System.Windows.Forms.Label();
            this.txtTenChuThe = new System.Windows.Forms.TextBox();
            this.lblTenChuThe = new System.Windows.Forms.Label();
            this.cboLoaiThe = new System.Windows.Forms.ComboBox();
            this.lblLoaiThe = new System.Windows.Forms.Label();
            this.grpTongKet = new System.Windows.Forms.GroupBox();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.lblTieuDeTongCong = new System.Windows.Forms.Label();
            this.lblPhiShip = new System.Windows.Forms.Label();
            this.lblTieuDePhiShip = new System.Windows.Forms.Label();
            this.lblTienHang = new System.Windows.Forms.Label();
            this.lblTieuDeTienHang = new System.Windows.Forms.Label();
            this.btnXacNhanDatHang = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpNguoiNhan.SuspendLayout();
            this.grpGiaoHang.SuspendLayout();
            this.grpTheTinDung.SuspendLayout();
            this.grpTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lblSubTitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(462, 17);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Hệ thống xác thực thẻ thanh toán trực tuyến qua Cổng dịch vụ Ngân hàng";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP PHIẾU ĐẶT HÀNG && THANH TOÁN THẺ TÍN DỤNG";
            // 
            // grpNguoiNhan
            // 
            this.grpNguoiNhan.Controls.Add(this.txtDiaChi);
            this.grpNguoiNhan.Controls.Add(this.lblDiaChi);
            this.grpNguoiNhan.Controls.Add(this.txtEmail);
            this.grpNguoiNhan.Controls.Add(this.lblEmail);
            this.grpNguoiNhan.Controls.Add(this.txtSoDienThoai);
            this.grpNguoiNhan.Controls.Add(this.lblSDT);
            this.grpNguoiNhan.Controls.Add(this.txtHoTen);
            this.grpNguoiNhan.Controls.Add(this.lblHoTen);
            this.grpNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNguoiNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpNguoiNhan.Location = new System.Drawing.Point(20, 85);
            this.grpNguoiNhan.Name = "grpNguoiNhan";
            this.grpNguoiNhan.Size = new System.Drawing.Size(420, 230);
            this.grpNguoiNhan.TabIndex = 1;
            this.grpNguoiNhan.TabStop = false;
            this.grpNguoiNhan.Text = "1. THÔNG TIN NGƯỜI NHẬN";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDiaChi.Location = new System.Drawing.Point(125, 137);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiaChi.Size = new System.Drawing.Size(275, 75);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 140);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(81, 17);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ nhận:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(125, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 25);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(15, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(125, 66);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(275, 25);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(15, 69);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 17);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtHoTen.Location = new System.Drawing.Point(125, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(275, 25);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(15, 33);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // grpGiaoHang
            // 
            this.grpGiaoHang.Controls.Add(this.radGiaoHoaToc);
            this.grpGiaoHang.Controls.Add(this.radGiaoNhanh);
            this.grpGiaoHang.Controls.Add(this.radGiaoThuong);
            this.grpGiaoHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGiaoHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpGiaoHang.Location = new System.Drawing.Point(20, 325);
            this.grpGiaoHang.Name = "grpGiaoHang";
            this.grpGiaoHang.Size = new System.Drawing.Size(420, 155);
            this.grpGiaoHang.TabIndex = 2;
            this.grpGiaoHang.TabStop = false;
            this.grpGiaoHang.Text = "2. HÌNH THỨC GIAO HÀNG";
            // 
            // radGiaoHoaToc
            // 
            this.radGiaoHoaToc.AutoSize = true;
            this.radGiaoHoaToc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radGiaoHoaToc.ForeColor = System.Drawing.Color.Black;
            this.radGiaoHoaToc.Location = new System.Drawing.Point(18, 107);
            this.radGiaoHoaToc.Name = "radGiaoHoaToc";
            this.radGiaoHoaToc.Size = new System.Drawing.Size(378, 38);
            this.radGiaoHoaToc.TabIndex = 2;
            this.radGiaoHoaToc.Text = "Chuyển phát nhanh trong ngày - 100.000 đ\r\n(Miễn phí giao hàng cho đơn từ 5.000.00" +
    "0 đ)";
            this.radGiaoHoaToc.UseVisualStyleBackColor = true;
            this.radGiaoHoaToc.CheckedChanged += new System.EventHandler(this.radGiaoHang_CheckedChanged);
            // 
            // radGiaoNhanh
            // 
            this.radGiaoNhanh.AutoSize = true;
            this.radGiaoNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radGiaoNhanh.ForeColor = System.Drawing.Color.Black;
            this.radGiaoNhanh.Location = new System.Drawing.Point(18, 62);
            this.radGiaoNhanh.Name = "radGiaoNhanh";
            this.radGiaoNhanh.Size = new System.Drawing.Size(359, 38);
            this.radGiaoNhanh.TabIndex = 1;
            this.radGiaoNhanh.Text = "Chuyển phát nhanh (1-2 ngày) - 50.000 đ\r\n(Miễn phí giao hàng cho đơn từ 1.000.000" +
    " đ)";
            this.radGiaoNhanh.UseVisualStyleBackColor = true;
            this.radGiaoNhanh.CheckedChanged += new System.EventHandler(this.radGiaoHang_CheckedChanged);
            // 
            // radGiaoThuong
            // 
            this.radGiaoThuong.AutoSize = true;
            this.radGiaoThuong.Checked = true;
            this.radGiaoThuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radGiaoThuong.ForeColor = System.Drawing.Color.Black;
            this.radGiaoThuong.Location = new System.Drawing.Point(18, 30);
            this.radGiaoThuong.Name = "radGiaoThuong";
            this.radGiaoThuong.Size = new System.Drawing.Size(306, 21);
            this.radGiaoThuong.TabIndex = 0;
            this.radGiaoThuong.TabStop = true;
            this.radGiaoThuong.Text = "Giao hàng tiêu chuẩn thường (3-5 ngày) - 30.000 đ";
            this.radGiaoThuong.UseVisualStyleBackColor = true;
            this.radGiaoThuong.CheckedChanged += new System.EventHandler(this.radGiaoHang_CheckedChanged);
            // 
            // grpTheTinDung
            // 
            this.grpTheTinDung.Controls.Add(this.lblGhiChuThe);
            this.grpTheTinDung.Controls.Add(this.txtCVV);
            this.grpTheTinDung.Controls.Add(this.lblCVV);
            this.grpTheTinDung.Controls.Add(this.txtNgayHetHan);
            this.grpTheTinDung.Controls.Add(this.lblNgayHetHan);
            this.grpTheTinDung.Controls.Add(this.txtSoThe);
            this.grpTheTinDung.Controls.Add(this.lblSoThe);
            this.grpTheTinDung.Controls.Add(this.txtTenChuThe);
            this.grpTheTinDung.Controls.Add(this.lblTenChuThe);
            this.grpTheTinDung.Controls.Add(this.cboLoaiThe);
            this.grpTheTinDung.Controls.Add(this.lblLoaiThe);
            this.grpTheTinDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTheTinDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpTheTinDung.Location = new System.Drawing.Point(460, 85);
            this.grpTheTinDung.Name = "grpTheTinDung";
            this.grpTheTinDung.Size = new System.Drawing.Size(405, 230);
            this.grpTheTinDung.TabIndex = 3;
            this.grpTheTinDung.TabStop = false;
            this.grpTheTinDung.Text = "3. THÔNG TIN THẺ TÍN DỤNG";
            // 
            // lblGhiChuThe
            // 
            this.lblGhiChuThe.AutoSize = true;
            this.lblGhiChuThe.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblGhiChuThe.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChuThe.Location = new System.Drawing.Point(125, 203);
            this.lblGhiChuThe.Name = "lblGhiChuThe";
            this.lblGhiChuThe.Size = new System.Drawing.Size(248, 15);
            this.lblGhiChuThe.TabIndex = 10;
            this.lblGhiChuThe.Text = "* Visa/Master: 16 số, CVV 3 số | Amex: 15 số, CVV 4 số";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCVV.Location = new System.Drawing.Point(320, 169);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '●';
            this.txtCVV.Size = new System.Drawing.Size(70, 25);
            this.txtCVV.TabIndex = 9;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCVV.ForeColor = System.Drawing.Color.Black;
            this.lblCVV.Location = new System.Drawing.Point(235, 172);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(62, 17);
            this.lblCVV.TabIndex = 8;
            this.lblCVV.Text = "Mã CVV:";
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNgayHetHan.Location = new System.Drawing.Point(125, 169);
            this.txtNgayHetHan.MaxLength = 5;
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Size = new System.Drawing.Size(95, 25);
            this.txtNgayHetHan.TabIndex = 7;
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgayHetHan.ForeColor = System.Drawing.Color.Black;
            this.lblNgayHetHan.Location = new System.Drawing.Point(15, 172);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(90, 17);
            this.lblNgayHetHan.TabIndex = 6;
            this.lblNgayHetHan.Text = "Hạn (MM/YY):";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSoThe.Location = new System.Drawing.Point(125, 122);
            this.txtSoThe.MaxLength = 19;
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(265, 25);
            this.txtSoThe.TabIndex = 5;
            // 
            // lblSoThe
            // 
            this.lblSoThe.AutoSize = true;
            this.lblSoThe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSoThe.ForeColor = System.Drawing.Color.Black;
            this.lblSoThe.Location = new System.Drawing.Point(15, 125);
            this.lblSoThe.Name = "lblSoThe";
            this.lblSoThe.Size = new System.Drawing.Size(49, 17);
            this.lblSoThe.TabIndex = 4;
            this.lblSoThe.Text = "Số thẻ:";
            // 
            // txtTenChuThe
            // 
            this.txtTenChuThe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTenChuThe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenChuThe.Location = new System.Drawing.Point(125, 75);
            this.txtTenChuThe.Name = "txtTenChuThe";
            this.txtTenChuThe.Size = new System.Drawing.Size(265, 25);
            this.txtTenChuThe.TabIndex = 3;
            // 
            // lblTenChuThe
            // 
            this.lblTenChuThe.AutoSize = true;
            this.lblTenChuThe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTenChuThe.ForeColor = System.Drawing.Color.Black;
            this.lblTenChuThe.Location = new System.Drawing.Point(15, 78);
            this.lblTenChuThe.Name = "lblTenChuThe";
            this.lblTenChuThe.Size = new System.Drawing.Size(78, 17);
            this.lblTenChuThe.TabIndex = 2;
            this.lblTenChuThe.Text = "Tên chủ thẻ:";
            // 
            // cboLoaiThe
            // 
            this.cboLoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboLoaiThe.FormattingEnabled = true;
            this.cboLoaiThe.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "American Express"});
            this.cboLoaiThe.Location = new System.Drawing.Point(125, 30);
            this.cboLoaiThe.Name = "cboLoaiThe";
            this.cboLoaiThe.Size = new System.Drawing.Size(265, 25);
            this.cboLoaiThe.TabIndex = 1;
            this.cboLoaiThe.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThe_SelectedIndexChanged);
            // 
            // lblLoaiThe
            // 
            this.lblLoaiThe.AutoSize = true;
            this.lblLoaiThe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLoaiThe.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiThe.Location = new System.Drawing.Point(15, 33);
            this.lblLoaiThe.Name = "lblLoaiThe";
            this.lblLoaiThe.Size = new System.Drawing.Size(57, 17);
            this.lblLoaiThe.TabIndex = 0;
            this.lblLoaiThe.Text = "Loại thẻ:";
            // 
            // grpTongKet
            // 
            this.grpTongKet.Controls.Add(this.lblTongCong);
            this.grpTongKet.Controls.Add(this.lblTieuDeTongCong);
            this.grpTongKet.Controls.Add(this.lblPhiShip);
            this.grpTongKet.Controls.Add(this.lblTieuDePhiShip);
            this.grpTongKet.Controls.Add(this.lblTienHang);
            this.grpTongKet.Controls.Add(this.lblTieuDeTienHang);
            this.grpTongKet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTongKet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpTongKet.Location = new System.Drawing.Point(460, 325);
            this.grpTongKet.Name = "grpTongKet";
            this.grpTongKet.Size = new System.Drawing.Size(405, 155);
            this.grpTongKet.TabIndex = 4;
            this.grpTongKet.TabStop = false;
            this.grpTongKet.Text = "4. TỔNG KẾT ĐƠN HÀNG";
            // 
            // lblTongCong
            // 
            this.lblTongCong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTongCong.Location = new System.Drawing.Point(180, 107);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(210, 28);
            this.lblTongCong.TabIndex = 5;
            this.lblTongCong.Text = "0 đ";
            this.lblTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTieuDeTongCong
            // 
            this.lblTieuDeTongCong.AutoSize = true;
            this.lblTieuDeTongCong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeTongCong.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDeTongCong.Location = new System.Drawing.Point(15, 112);
            this.lblTieuDeTongCong.Name = "lblTieuDeTongCong";
            this.lblTieuDeTongCong.Size = new System.Drawing.Size(127, 20);
            this.lblTieuDeTongCong.TabIndex = 4;
            this.lblTieuDeTongCong.Text = "Tổng thanh toán:";
            // 
            // lblPhiShip
            // 
            this.lblPhiShip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhiShip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblPhiShip.Location = new System.Drawing.Point(180, 68);
            this.lblPhiShip.Name = "lblPhiShip";
            this.lblPhiShip.Size = new System.Drawing.Size(210, 20);
            this.lblPhiShip.TabIndex = 3;
            this.lblPhiShip.Text = "0 đ";
            this.lblPhiShip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTieuDePhiShip
            // 
            this.lblTieuDePhiShip.AutoSize = true;
            this.lblTieuDePhiShip.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTieuDePhiShip.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDePhiShip.Location = new System.Drawing.Point(15, 70);
            this.lblTieuDePhiShip.Name = "lblTieuDePhiShip";
            this.lblTieuDePhiShip.Size = new System.Drawing.Size(95, 17);
            this.lblTieuDePhiShip.TabIndex = 2;
            this.lblTieuDePhiShip.Text = "Phí vận chuyển:";
            // 
            // lblTienHang
            // 
            this.lblTienHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTienHang.ForeColor = System.Drawing.Color.Black;
            this.lblTienHang.Location = new System.Drawing.Point(180, 31);
            this.lblTienHang.Name = "lblTienHang";
            this.lblTienHang.Size = new System.Drawing.Size(210, 20);
            this.lblTienHang.TabIndex = 1;
            this.lblTienHang.Text = "0 đ";
            this.lblTienHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTieuDeTienHang
            // 
            this.lblTieuDeTienHang.AutoSize = true;
            this.lblTieuDeTienHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTieuDeTienHang.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDeTienHang.Location = new System.Drawing.Point(15, 33);
            this.lblTieuDeTienHang.Name = "lblTieuDeTienHang";
            this.lblTieuDeTienHang.Size = new System.Drawing.Size(98, 17);
            this.lblTieuDeTienHang.TabIndex = 0;
            this.lblTieuDeTienHang.Text = "Tổng tiền hàng:";
            // 
            // btnXacNhanDatHang
            // 
            this.btnXacNhanDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXacNhanDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDatHang.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDatHang.Location = new System.Drawing.Point(460, 498);
            this.btnXacNhanDatHang.Name = "btnXacNhanDatHang";
            this.btnXacNhanDatHang.Size = new System.Drawing.Size(405, 48);
            this.btnXacNhanDatHang.TabIndex = 5;
            this.btnXacNhanDatHang.Text = "💳 XÁC NHẬN THANH TOÁN && ĐẶT HÀNG";
            this.btnXacNhanDatHang.UseVisualStyleBackColor = false;
            this.btnXacNhanDatHang.Click += new System.EventHandler(this.btnXacNhanDatHang_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(20, 498);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(180, 48);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay Lại Giỏ Hàng";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 566);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhanDatHang);
            this.Controls.Add(this.grpTongKet);
            this.Controls.Add(this.grpTheTinDung);
            this.Controls.Add(this.grpGiaoHang);
            this.Controls.Add(this.grpNguoiNhan);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Phiếu Đặt Hàng & Thanh Toán Trực Tuyến";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpNguoiNhan.ResumeLayout(false);
            this.grpNguoiNhan.PerformLayout();
            this.grpGiaoHang.ResumeLayout(false);
            this.grpGiaoHang.PerformLayout();
            this.grpTheTinDung.ResumeLayout(false);
            this.grpTheTinDung.PerformLayout();
            this.grpTongKet.ResumeLayout(false);
            this.grpTongKet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox grpNguoiNhan;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox grpGiaoHang;
        private System.Windows.Forms.RadioButton radGiaoThuong;
        private System.Windows.Forms.RadioButton radGiaoNhanh;
        private System.Windows.Forms.RadioButton radGiaoHoaToc;
        private System.Windows.Forms.GroupBox grpTheTinDung;
        private System.Windows.Forms.Label lblLoaiThe;
        private System.Windows.Forms.ComboBox cboLoaiThe;
        private System.Windows.Forms.Label lblTenChuThe;
        private System.Windows.Forms.TextBox txtTenChuThe;
        private System.Windows.Forms.Label lblSoThe;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblGhiChuThe;
        private System.Windows.Forms.GroupBox grpTongKet;
        private System.Windows.Forms.Label lblTieuDeTienHang;
        private System.Windows.Forms.Label lblTienHang;
        private System.Windows.Forms.Label lblTieuDePhiShip;
        private System.Windows.Forms.Label lblPhiShip;
        private System.Windows.Forms.Label lblTieuDeTongCong;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Button btnXacNhanDatHang;
        private System.Windows.Forms.Button btnQuayLai;
    }
}

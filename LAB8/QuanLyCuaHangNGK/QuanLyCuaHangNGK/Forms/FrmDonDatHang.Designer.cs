namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmDonDatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpTaoDDH;
        private System.Windows.Forms.Label lblSoDDH;
        private System.Windows.Forms.TextBox txtSoDDH;
        private System.Windows.Forms.Label lblNCU;
        private System.Windows.Forms.ComboBox cboNCU;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label lblNGK;
        private System.Windows.Forms.ComboBox cboNGK;
        private System.Windows.Forms.Label lblSLDat;
        private System.Windows.Forms.NumericUpDown nudSLDat;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.NumericUpDown nudGiaNhap;
        private System.Windows.Forms.Button btnTaoDDH;
        private System.Windows.Forms.GroupBox grpPGH;
        private System.Windows.Forms.Label lblSLGiao;
        private System.Windows.Forms.NumericUpDown nudSLGiao;
        private System.Windows.Forms.Button btnNhanGiaoHang;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox grpDDH;
        private System.Windows.Forms.DataGridView dgvDDH;
        private System.Windows.Forms.SplitContainer splitSub;
        private System.Windows.Forms.GroupBox grpCTDDH;
        private System.Windows.Forms.DataGridView dgvCTDDH;
        private System.Windows.Forms.GroupBox grpListPGH;
        private System.Windows.Forms.DataGridView dgvPGH;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpTaoDDH = new System.Windows.Forms.GroupBox();
            this.lblSoDDH = new System.Windows.Forms.Label();
            this.txtSoDDH = new System.Windows.Forms.TextBox();
            this.lblNCU = new System.Windows.Forms.Label();
            this.cboNCU = new System.Windows.Forms.ComboBox();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNGK = new System.Windows.Forms.Label();
            this.cboNGK = new System.Windows.Forms.ComboBox();
            this.lblSLDat = new System.Windows.Forms.Label();
            this.nudSLDat = new System.Windows.Forms.NumericUpDown();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.nudGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.btnTaoDDH = new System.Windows.Forms.Button();
            this.grpPGH = new System.Windows.Forms.GroupBox();
            this.lblSLGiao = new System.Windows.Forms.Label();
            this.nudSLGiao = new System.Windows.Forms.NumericUpDown();
            this.btnNhanGiaoHang = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.grpDDH = new System.Windows.Forms.GroupBox();
            this.dgvDDH = new System.Windows.Forms.DataGridView();
            this.splitSub = new System.Windows.Forms.SplitContainer();
            this.grpCTDDH = new System.Windows.Forms.GroupBox();
            this.dgvCTDDH = new System.Windows.Forms.DataGridView();
            this.grpListPGH = new System.Windows.Forms.GroupBox();
            this.dgvPGH = new System.Windows.Forms.DataGridView();

            // grpTaoDDH
            this.grpTaoDDH.Text = "LẬP ĐƠN ĐẶT HÀNG GỬI NHÀ CUNG ỨNG (Mỗi ĐĐH giao tối đa 3 đợt)";
            this.grpTaoDDH.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTaoDDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTaoDDH.Height = 115;
            this.grpTaoDDH.Padding = new System.Windows.Forms.Padding(10);

            this.lblSoDDH.Text = "Số ĐĐH:";
            this.lblSoDDH.Location = new System.Drawing.Point(15, 28);
            this.lblSoDDH.AutoSize = true;
            this.txtSoDDH.Location = new System.Drawing.Point(80, 25);
            this.txtSoDDH.Size = new System.Drawing.Size(100, 24);
            this.txtSoDDH.Text = "DDH_" + System.DateTime.Now.ToString("MMdd_HHmm");

            this.lblNCU.Text = "Nhà cung ứng:";
            this.lblNCU.Location = new System.Drawing.Point(195, 28);
            this.lblNCU.AutoSize = true;
            this.cboNCU.Location = new System.Drawing.Point(300, 25);
            this.cboNCU.Size = new System.Drawing.Size(220, 24);
            this.cboNCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblNgayNhan.Text = "Ngày hẹn nhận:";
            this.lblNgayNhan.Location = new System.Drawing.Point(535, 28);
            this.lblNgayNhan.AutoSize = true;
            this.dtpNgayNhan.Location = new System.Drawing.Point(645, 25);
            this.dtpNgayNhan.Size = new System.Drawing.Size(140, 24);
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Row 2
            this.lblNGK.Text = "Mặt hàng:";
            this.lblNGK.Location = new System.Drawing.Point(15, 68);
            this.lblNGK.AutoSize = true;
            this.cboNGK.Location = new System.Drawing.Point(80, 65);
            this.cboNGK.Size = new System.Drawing.Size(200, 24);
            this.cboNGK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblSLDat.Text = "SL đặt:";
            this.lblSLDat.Location = new System.Drawing.Point(290, 68);
            this.lblSLDat.AutoSize = true;
            this.nudSLDat.Location = new System.Drawing.Point(345, 65);
            this.nudSLDat.Size = new System.Drawing.Size(80, 24);
            this.nudSLDat.Maximum = 10000;
            this.nudSLDat.Value = 100;

            this.lblGiaNhap.Text = "Giá nhập:";
            this.lblGiaNhap.Location = new System.Drawing.Point(435, 68);
            this.lblGiaNhap.AutoSize = true;
            this.nudGiaNhap.Location = new System.Drawing.Point(505, 65);
            this.nudGiaNhap.Size = new System.Drawing.Size(100, 24);
            this.nudGiaNhap.Maximum = 1000000;
            this.nudGiaNhap.Increment = 500;
            this.nudGiaNhap.Value = 7500;

            this.btnTaoDDH.Text = "Gửi Đơn Đặt Hàng";
            this.btnTaoDDH.Location = new System.Drawing.Point(630, 62);
            this.btnTaoDDH.Size = new System.Drawing.Size(155, 30);
            this.btnTaoDDH.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnTaoDDH.ForeColor = System.Drawing.Color.White;
            this.btnTaoDDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDDH.Click += new System.EventHandler(this.btnTaoDDH_Click);

            this.grpTaoDDH.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSoDDH, this.txtSoDDH, this.lblNCU, this.cboNCU, this.lblNgayNhan, this.dtpNgayNhan,
                this.lblNGK, this.cboNGK, this.lblSLDat, this.nudSLDat, this.lblGiaNhap, this.nudGiaNhap, this.btnTaoDDH
            });

            // grpPGH (Tiếp nhận giao hàng)
            this.grpPGH.Text = "TIẾP NHẬN PHIẾU GIAO HÀNG TỪ NCC (Tối đa 3 đợt)";
            this.grpPGH.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpPGH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPGH.Height = 70;
            this.grpPGH.Padding = new System.Windows.Forms.Padding(10);

            this.lblSLGiao.Text = "Số lượng giao đợt này:";
            this.lblSLGiao.Location = new System.Drawing.Point(15, 28);
            this.lblSLGiao.AutoSize = true;
            this.nudSLGiao.Location = new System.Drawing.Point(170, 25);
            this.nudSLGiao.Size = new System.Drawing.Size(90, 24);
            this.nudSLGiao.Maximum = 10000;
            this.nudSLGiao.Value = 50;

            this.btnNhanGiaoHang.Text = "Nhận Hàng Đợt Này & Nhập Kho";
            this.btnNhanGiaoHang.Location = new System.Drawing.Point(280, 22);
            this.btnNhanGiaoHang.Size = new System.Drawing.Size(230, 30);
            this.btnNhanGiaoHang.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnNhanGiaoHang.ForeColor = System.Drawing.Color.White;
            this.btnNhanGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanGiaoHang.Click += new System.EventHandler(this.btnNhanGiaoHang_Click);

            this.grpPGH.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSLGiao, this.nudSLGiao, this.btnNhanGiaoHang
            });

            // splitMain
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitMain.SplitterDistance = 550;

            // grpDDH
            this.grpDDH.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG";
            this.grpDDH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDDH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDDH.ReadOnly = true;
            this.dgvDDH.AllowUserToAddRows = false;
            this.dgvDDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDDH_CellClick);
            this.grpDDH.Controls.Add(this.dgvDDH);
            this.splitMain.Panel1.Controls.Add(this.grpDDH);

            // splitSub
            this.splitSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSub.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitSub.SplitterDistance = 200;

            // grpCTDDH
            this.grpCTDDH.Text = "CHI TIẾT MẶT HÀNG ĐẶT";
            this.grpCTDDH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDDH.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTDDH.ReadOnly = true;
            this.dgvCTDDH.AllowUserToAddRows = false;
            this.grpCTDDH.Controls.Add(this.dgvCTDDH);
            this.splitSub.Panel1.Controls.Add(this.grpCTDDH);

            // grpListPGH
            this.grpListPGH.Text = "CÁC ĐỢT ĐÃ GIAO HÀNG (TỐI ĐA 3 ĐỢT)";
            this.grpListPGH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpListPGH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPGH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPGH.BackgroundColor = System.Drawing.Color.White;
            this.dgvPGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPGH.ReadOnly = true;
            this.dgvPGH.AllowUserToAddRows = false;
            this.grpListPGH.Controls.Add(this.dgvPGH);
            this.splitSub.Panel2.Controls.Add(this.grpListPGH);

            this.splitMain.Panel2.Controls.Add(this.splitSub);

            // FrmDonDatHang
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Đơn Đặt Hàng & Giao Hàng NCC (Tối đa 3 đợt)";
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.grpPGH);
            this.Controls.Add(this.grpTaoDDH);
        }
    }
}

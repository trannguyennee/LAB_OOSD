namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmNuocGiaiKhat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblTon;
        private System.Windows.Forms.NumericUpDown nudTonKho;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvNGK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblTon = new System.Windows.Forms.Label();
            this.nudTonKho = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvNGK = new System.Windows.Forms.DataGridView();

            // grpInfo
            this.grpInfo.Text = "THÔNG TIN NƯỚC GIẢI KHÁT";
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfo.Height = 150;
            this.grpInfo.Padding = new System.Windows.Forms.Padding(10);

            // Row 1
            this.lblMa.Text = "Mã NGK:";
            this.lblMa.Location = new System.Drawing.Point(20, 30);
            this.lblMa.AutoSize = true;
            this.txtMa.Location = new System.Drawing.Point(90, 27);
            this.txtMa.Size = new System.Drawing.Size(140, 24);

            this.lblTen.Text = "Tên NGK:";
            this.lblTen.Location = new System.Drawing.Point(250, 30);
            this.lblTen.AutoSize = true;
            this.txtTen.Location = new System.Drawing.Point(320, 27);
            this.txtTen.Size = new System.Drawing.Size(220, 24);

            this.lblLoai.Text = "Loại NGK:";
            this.lblLoai.Location = new System.Drawing.Point(560, 30);
            this.lblLoai.AutoSize = true;
            this.cboLoai.Location = new System.Drawing.Point(630, 27);
            this.cboLoai.Size = new System.Drawing.Size(220, 24);
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Row 2
            this.lblDVT.Text = "Đơn vị tính:";
            this.lblDVT.Location = new System.Drawing.Point(20, 70);
            this.lblDVT.AutoSize = true;
            this.txtDVT.Location = new System.Drawing.Point(90, 67);
            this.txtDVT.Size = new System.Drawing.Size(140, 24);
            this.txtDVT.Text = "Lon";

            this.lblTon.Text = "Tồn kho:";
            this.lblTon.Location = new System.Drawing.Point(250, 70);
            this.lblTon.AutoSize = true;
            this.nudTonKho.Location = new System.Drawing.Point(320, 67);
            this.nudTonKho.Size = new System.Drawing.Size(100, 24);
            this.nudTonKho.Maximum = 10000;

            this.lblGia.Text = "Đơn giá bán:";
            this.lblGia.Location = new System.Drawing.Point(440, 70);
            this.lblGia.AutoSize = true;
            this.nudDonGia.Location = new System.Drawing.Point(525, 67);
            this.nudDonGia.Size = new System.Drawing.Size(130, 24);
            this.nudDonGia.Maximum = 1000000;
            this.nudDonGia.Increment = 1000;
            this.nudDonGia.Value = 10000;

            // Buttons
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Location = new System.Drawing.Point(20, 105);
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Cập nhật";
            this.btnSua.Location = new System.Drawing.Point(130, 105);
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(240, 105);
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(350, 105);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.grpInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMa, this.txtMa, this.lblTen, this.txtTen, this.lblLoai, this.cboLoai,
                this.lblDVT, this.txtDVT, this.lblTon, this.nudTonKho, this.lblGia, this.nudDonGia,
                this.btnThem, this.btnSua, this.btnXoa, this.btnLamMoi
            });

            // grpList
            this.grpList.Text = "DANH SÁCH NƯỚC GIẢI KHÁT & TỒN KHO";
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Padding = new System.Windows.Forms.Padding(10);

            this.dgvNGK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNGK.BackgroundColor = System.Drawing.Color.White;
            this.dgvNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNGK.ReadOnly = true;
            this.dgvNGK.AllowUserToAddRows = false;
            this.dgvNGK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNGK_CellClick);
            this.grpList.Controls.Add(this.dgvNGK);

            // FrmNuocGiaiKhat
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Nước Giải Khát & Tồn Kho";
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpInfo);
        }
    }
}

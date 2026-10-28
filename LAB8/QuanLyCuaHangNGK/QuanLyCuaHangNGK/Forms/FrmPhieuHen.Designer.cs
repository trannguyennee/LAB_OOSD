namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmPhieuHen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnXacNhanGiao;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvPhieuHen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnXacNhanGiao = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvPhieuHen = new System.Windows.Forms.DataGridView();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(15);

            this.lblHeader.Text = "QUẢN LÝ PHIẾU HẸN GIAO HÀNG THEO ĐỢT (DÀNH CHO KHÁCH QUEN)";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(15, 12);
            this.lblHeader.AutoSize = true;

            this.lblDesc.Text = "Theo dõi và thực hiện xuất giao các đợt hẹn khi cửa hàng đã nhập đủ hàng về kho.";
            this.lblDesc.ForeColor = System.Drawing.Color.LightCyan;
            this.lblDesc.Location = new System.Drawing.Point(17, 38);
            this.lblDesc.AutoSize = true;

            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblDesc);

            // pnlAction
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Height = 50;
            this.pnlAction.Padding = new System.Windows.Forms.Padding(10);

            this.btnXacNhanGiao.Text = "Xác Nhận Đã Giao Đợt Hẹn (Trừ Tồn Kho)";
            this.btnXacNhanGiao.Location = new System.Drawing.Point(15, 10);
            this.btnXacNhanGiao.Size = new System.Drawing.Size(280, 32);
            this.btnXacNhanGiao.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnXacNhanGiao.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanGiao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanGiao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanGiao.Click += new System.EventHandler(this.btnXacNhanGiao_Click);
            this.pnlAction.Controls.Add(this.btnXacNhanGiao);

            // grpList
            this.grpList.Text = "DANH SÁCH CÁC PHIẾU HẸN GIAO HÀNG";
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Padding = new System.Windows.Forms.Padding(10);

            this.dgvPhieuHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuHen.ReadOnly = true;
            this.dgvPhieuHen.AllowUserToAddRows = false;
            this.grpList.Controls.Add(this.dgvPhieuHen);

            // FrmPhieuHen
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phiếu Hẹn Giao Hàng";
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlHeader);
        }
    }
}

namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmPhieuGhiNo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvPGN;

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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvPGN = new System.Windows.Forms.DataGridView();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(15);

            this.lblHeader.Text = "QUẢN LÝ PHIẾU GHI NỢ & CÔNG NỢ KHÁCH QUEN (TRẢ CHẬM)";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(15, 12);
            this.lblHeader.AutoSize = true;

            this.lblDesc.Text = "Ghi nhận thông tin nợ, ngày hẹn trả, lý do nợ và nhân viên lập phiếu; hỗ trợ thu nợ.";
            this.lblDesc.ForeColor = System.Drawing.Color.LightPink;
            this.lblDesc.Location = new System.Drawing.Point(17, 38);
            this.lblDesc.AutoSize = true;

            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblDesc);

            // pnlAction
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Height = 50;
            this.pnlAction.Padding = new System.Windows.Forms.Padding(10);

            this.btnThanhToan.Text = "Thu Nợ / Tất Toán Phiếu Nợ (Giảm Công Nợ)";
            this.btnThanhToan.Location = new System.Drawing.Point(15, 10);
            this.btnThanhToan.Size = new System.Drawing.Size(300, 32);
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.pnlAction.Controls.Add(this.btnThanhToan);

            // grpList
            this.grpList.Text = "DANH SÁCH CÁC PHIẾU GHI NỢ";
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Padding = new System.Windows.Forms.Padding(10);

            this.dgvPGN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPGN.BackgroundColor = System.Drawing.Color.White;
            this.dgvPGN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPGN.ReadOnly = true;
            this.dgvPGN.AllowUserToAddRows = false;
            this.grpList.Controls.Add(this.dgvPGN);

            // FrmPhieuGhiNo
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phiếu Ghi Nợ";
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlHeader);
        }
    }
}

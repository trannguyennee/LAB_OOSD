namespace eShopping.Forms
{
    partial class FrmLichSuDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.splitLichSu = new System.Windows.Forms.SplitContainer();
            this.grpDonHang = new System.Windows.Forms.GroupBox();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLichSu)).BeginInit();
            this.splitLichSu.Panel1.SuspendLayout();
            this.splitLichSu.Panel2.SuspendLayout();
            this.splitLichSu.SuspendLayout();
            this.grpDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1100, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lblSubTitle.Location = new System.Drawing.Point(20, 42);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(434, 17);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Theo dõi tiến độ, trạng thái và chi tiết sản phẩm của các đơn hàng đã đặt";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LỊCH SỬ MUA HÀNG && TRA CỨU ĐƠN HÀNG";
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pnlTimKiem.Controls.Add(this.btnDong);
            this.pnlTimKiem.Controls.Add(this.btnTatCa);
            this.pnlTimKiem.Controls.Add(this.btnTraCuu);
            this.pnlTimKiem.Controls.Add(this.txtTuKhoa);
            this.pnlTimKiem.Controls.Add(this.lblTimKiem);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 70);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1100, 50);
            this.pnlTimKiem.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(985, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 30);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Location = new System.Drawing.Point(620, 10);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(110, 30);
            this.btnTatCa.TabIndex = 3;
            this.btnTatCa.Text = "Tất Cả Đơn";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(515, 10);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(95, 30);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTuKhoa.Location = new System.Drawing.Point(230, 13);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(275, 25);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.lblTimKiem.Location = new System.Drawing.Point(18, 17);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(206, 17);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Nhập SĐT / Mã ĐH / Tên người:";
            // 
            // splitLichSu
            // 
            this.splitLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLichSu.Location = new System.Drawing.Point(0, 120);
            this.splitLichSu.Name = "splitLichSu";
            this.splitLichSu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLichSu.Panel1
            // 
            this.splitLichSu.Panel1.Controls.Add(this.grpDonHang);
            this.splitLichSu.Panel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            // 
            // splitLichSu.Panel2
            // 
            this.splitLichSu.Panel2.Controls.Add(this.grpChiTiet);
            this.splitLichSu.Panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.splitLichSu.Size = new System.Drawing.Size(1100, 541);
            this.splitLichSu.SplitterDistance = 290;
            this.splitLichSu.TabIndex = 2;
            // 
            // grpDonHang
            // 
            this.grpDonHang.Controls.Add(this.dgvDonHang);
            this.grpDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDonHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpDonHang.Location = new System.Drawing.Point(10, 5);
            this.grpDonHang.Name = "grpDonHang";
            this.grpDonHang.Padding = new System.Windows.Forms.Padding(8);
            this.grpDonHang.Size = new System.Drawing.Size(1080, 280);
            this.grpDonHang.TabIndex = 0;
            this.grpDonHang.TabStop = false;
            this.grpDonHang.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dgvHeaderStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            dgvHeaderStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dgvHeaderStyle1;
            this.dgvDonHang.ColumnHeadersHeight = 30;
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.EnableHeadersVisualStyles = false;
            this.dgvDonHang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvDonHang.Location = new System.Drawing.Point(8, 26);
            this.dgvDonHang.MultiSelect = false;
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.RowTemplate.Height = 26;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(1064, 246);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.SelectionChanged += new System.EventHandler(this.dgvDonHang_SelectionChanged);
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.dgvChiTiet);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            this.grpChiTiet.Location = new System.Drawing.Point(10, 5);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Padding = new System.Windows.Forms.Padding(8);
            this.grpChiTiet.Size = new System.Drawing.Size(1080, 232);
            this.grpChiTiet.TabIndex = 0;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "CHI TIẾT MẶT HÀNG TRONG ĐƠN ĐANG CHỌN";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dgvHeaderStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(54)))), ((int)(((byte)(104)))));
            dgvHeaderStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvHeaderStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTiet.ColumnHeadersDefaultCellStyle = dgvHeaderStyle2;
            this.dgvChiTiet.ColumnHeadersHeight = 30;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.EnableHeadersVisualStyles = false;
            this.dgvChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvChiTiet.Location = new System.Drawing.Point(8, 26);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowTemplate.Height = 26;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(1064, 198);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // FrmLichSuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.splitLichSu);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLichSuDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Lịch Sử Đơn Hàng";
            this.Load += new System.EventHandler(this.FrmLichSuDonHang_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.splitLichSu.Panel1.ResumeLayout(false);
            this.splitLichSu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLichSu)).EndInit();
            this.splitLichSu.ResumeLayout(false);
            this.grpDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.SplitContainer splitLichSu;
        private System.Windows.Forms.GroupBox grpDonHang;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
    }
}

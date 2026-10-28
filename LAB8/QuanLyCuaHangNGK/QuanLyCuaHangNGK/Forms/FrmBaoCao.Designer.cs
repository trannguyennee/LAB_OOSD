namespace QuanLyCuaHangNGK.Forms
{
    partial class FrmBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.TabPage tabCongNo;
        private System.Windows.Forms.DataGridView dgvCongNo;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.DataGridView dgvTonKhoCanhBao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tabCongNo = new System.Windows.Forms.TabPage();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.dgvTonKhoCanhBao = new System.Windows.Forms.DataGridView();

            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // tabDoanhThu
            this.tabDoanhThu.Text = "1. BÁO CÁO DOANH THU BÁN HÀNG";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(10);
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ReadOnly = true;
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);

            // tabCongNo
            this.tabCongNo.Text = "2. BÁO CÁO CÔNG NỢ KHÁCH QUEN";
            this.tabCongNo.Padding = new System.Windows.Forms.Padding(10);
            this.dgvCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNo.ReadOnly = true;
            this.tabCongNo.Controls.Add(this.dgvCongNo);

            // tabTonKho
            this.tabTonKho.Text = "3. CẢNH BÁO TỒN KHO THẤP (<= 50 ĐƠN VỊ)";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(10);
            this.dgvTonKhoCanhBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKhoCanhBao.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKhoCanhBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKhoCanhBao.ReadOnly = true;
            this.tabTonKho.Controls.Add(this.dgvTonKhoCanhBao);

            this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.tabDoanhThu, this.tabCongNo, this.tabTonKho
            });

            // FrmBaoCao
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo Cáo & Thống Kê Doanh Thu, Công Nợ, Tồn Kho";
            this.Controls.Add(this.tabControl1);
        }
    }
}

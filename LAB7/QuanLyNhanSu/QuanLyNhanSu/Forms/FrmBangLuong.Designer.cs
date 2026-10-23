namespace QuanLyNhanSu.Forms
{
    partial class FrmBangLuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.ComboBox cboThangNam;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnInPhieuLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;

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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnInPhieuLuong = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.cboThangNam = new System.Windows.Forms.ComboBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnInPhieuLuong);
            this.pnlTop.Controls.Add(this.btnTinhLuong);
            this.pnlTop.Controls.Add(this.cboThangNam);
            this.pnlTop.Controls.Add(this.lblThangNam);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 65);
            this.pnlTop.TabIndex = 0;
            // 
            // btnInPhieuLuong
            // 
            this.btnInPhieuLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnInPhieuLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieuLuong.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnInPhieuLuong.ForeColor = System.Drawing.Color.White;
            this.btnInPhieuLuong.Location = new System.Drawing.Point(580, 14);
            this.btnInPhieuLuong.Name = "btnInPhieuLuong";
            this.btnInPhieuLuong.Size = new System.Drawing.Size(240, 35);
            this.btnInPhieuLuong.TabIndex = 3;
            this.btnInPhieuLuong.Text = "In / Xem Phiếu Lương (Pay Slip)";
            this.btnInPhieuLuong.UseVisualStyleBackColor = false;
            this.btnInPhieuLuong.Click += new System.EventHandler(this.btnInPhieuLuong_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(320, 14);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(240, 35);
            this.btnTinhLuong.TabIndex = 2;
            this.btnTinhLuong.Text = "Tính Lương Toàn Công Ty";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // cboThangNam
            // 
            this.cboThangNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThangNam.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.cboThangNam.FormattingEnabled = true;
            this.cboThangNam.Location = new System.Drawing.Point(150, 19);
            this.cboThangNam.Name = "cboThangNam";
            this.cboThangNam.Size = new System.Drawing.Size(140, 25);
            this.cboThangNam.TabIndex = 1;
            this.cboThangNam.SelectedIndexChanged += new System.EventHandler(this.cboThangNam_SelectedIndexChanged);
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblThangNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblThangNam.Location = new System.Drawing.Point(20, 23);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(120, 17);
            this.lblThangNam.TabIndex = 0;
            this.lblThangNam.Text = "Chọn Kỳ Lương:";
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBangLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangLuong.Location = new System.Drawing.Point(10, 75);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(920, 555);
            this.dgvBangLuong.TabIndex = 1;
            // 
            // FrmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBangLuong";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Bảng Lương & Phiếu Lương";
            this.Load += new System.EventHandler(this.FrmBangLuong_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

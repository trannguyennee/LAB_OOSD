namespace QuanLyDuLich.Forms
{
    partial class FrmBangLuongHDV
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbTinhLuong;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.ComboBox cboThangNam;
        private System.Windows.Forms.Label lblMaBangLuong;
        private System.Windows.Forms.TextBox txtMaBangLuong;
        private System.Windows.Forms.Label lblHDV;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnChiLuong;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Button btnDong;

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
            this.gbTinhLuong = new System.Windows.Forms.GroupBox();
            this.btnChiLuong = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.lblHDV = new System.Windows.Forms.Label();
            this.txtMaBangLuong = new System.Windows.Forms.TextBox();
            this.lblMaBangLuong = new System.Windows.Forms.Label();
            this.cboThangNam = new System.Windows.Forms.ComboBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbTinhLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTinhLuong
            // 
            this.gbTinhLuong.Controls.Add(this.btnChiLuong);
            this.gbTinhLuong.Controls.Add(this.btnTinhLuong);
            this.gbTinhLuong.Controls.Add(this.txtPhuCap);
            this.gbTinhLuong.Controls.Add(this.lblPhuCap);
            this.gbTinhLuong.Controls.Add(this.cboHDV);
            this.gbTinhLuong.Controls.Add(this.lblHDV);
            this.gbTinhLuong.Controls.Add(this.txtMaBangLuong);
            this.gbTinhLuong.Controls.Add(this.lblMaBangLuong);
            this.gbTinhLuong.Controls.Add(this.cboThangNam);
            this.gbTinhLuong.Controls.Add(this.lblThangNam);
            this.gbTinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbTinhLuong.Location = new System.Drawing.Point(12, 12);
            this.gbTinhLuong.Name = "gbTinhLuong";
            this.gbTinhLuong.Size = new System.Drawing.Size(960, 100);
            this.gbTinhLuong.TabIndex = 0;
            this.gbTinhLuong.TabStop = false;
            this.gbTinhLuong.Text = "Tính Lương Hướng Dẫn Viên Theo Tháng (Lương Căn Bản + Thù Lao Từng Tour Dẫn BR14)";
            // 
            // btnChiLuong
            // 
            this.btnChiLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChiLuong.ForeColor = System.Drawing.Color.White;
            this.btnChiLuong.Location = new System.Drawing.Point(830, 60);
            this.btnChiLuong.Name = "btnChiLuong";
            this.btnChiLuong.Size = new System.Drawing.Size(115, 30);
            this.btnChiLuong.TabIndex = 9;
            this.btnChiLuong.Text = "Xác Nhận Chi";
            this.btnChiLuong.UseVisualStyleBackColor = false;
            this.btnChiLuong.Click += new System.EventHandler(this.btnChiLuong_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(705, 60);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(115, 30);
            this.btnTinhLuong.TabIndex = 8;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(540, 65);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(140, 23);
            this.txtPhuCap.TabIndex = 7;
            this.txtPhuCap.Text = "500000";
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhuCap.Location = new System.Drawing.Point(450, 68);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(77, 15);
            this.lblPhuCap.TabIndex = 6;
            this.lblPhuCap.Text = "Phụ cấp khác:";
            // 
            // cboHDV
            // 
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDV.FormattingEnabled = true;
            this.cboHDV.Location = new System.Drawing.Point(540, 25);
            this.cboHDV.Name = "cboHDV";
            this.cboHDV.Size = new System.Drawing.Size(260, 23);
            this.cboHDV.TabIndex = 5;
            // 
            // lblHDV
            // 
            this.lblHDV.AutoSize = true;
            this.lblHDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHDV.Location = new System.Drawing.Point(450, 28);
            this.lblHDV.Name = "lblHDV";
            this.lblHDV.Size = new System.Drawing.Size(65, 15);
            this.lblHDV.TabIndex = 4;
            this.lblHDV.Text = "Chọn HDV:";
            // 
            // txtMaBangLuong
            // 
            this.txtMaBangLuong.Location = new System.Drawing.Point(330, 25);
            this.txtMaBangLuong.Name = "txtMaBangLuong";
            this.txtMaBangLuong.Size = new System.Drawing.Size(100, 23);
            this.txtMaBangLuong.TabIndex = 3;
            // 
            // lblMaBangLuong
            // 
            this.lblMaBangLuong.AutoSize = true;
            this.lblMaBangLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaBangLuong.Location = new System.Drawing.Point(240, 28);
            this.lblMaBangLuong.Name = "lblMaBangLuong";
            this.lblMaBangLuong.Size = new System.Drawing.Size(46, 15);
            this.lblMaBangLuong.TabIndex = 2;
            this.lblMaBangLuong.Text = "Mã BL:";
            // 
            // cboThangNam
            // 
            this.cboThangNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThangNam.FormattingEnabled = true;
            this.cboThangNam.Location = new System.Drawing.Point(120, 25);
            this.cboThangNam.Name = "cboThangNam";
            this.cboThangNam.Size = new System.Drawing.Size(100, 23);
            this.cboThangNam.TabIndex = 1;
            this.cboThangNam.SelectedIndexChanged += new System.EventHandler(this.cboThangNam_SelectedIndexChanged);
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThangNam.Location = new System.Drawing.Point(20, 28);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(71, 15);
            this.lblThangNam.TabIndex = 0;
            this.lblThangNam.Text = "Tháng/Năm:";
            // 
            // dgvLuong
            // 
            this.dgvLuong.AllowUserToAddRows = false;
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(12, 125);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong.Size = new System.Drawing.Size(960, 410);
            this.dgvLuong.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(852, 545);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 32);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmBangLuongHDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.gbTinhLuong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBangLuongHDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Tính Lương Hướng Dẫn Viên Du Lịch";
            this.Load += new System.EventHandler(this.FrmBangLuongHDV_Load);
            this.gbTinhLuong.ResumeLayout(false);
            this.gbTinhLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

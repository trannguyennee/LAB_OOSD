namespace QuanLyDuLich.Forms
{
    partial class FrmPhieuKhaoSat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbKhaoSat;
        private System.Windows.Forms.Label lblMaKhaoSat;
        private System.Windows.Forms.TextBox txtMaKhaoSat;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblLoaiLich;
        private System.Windows.Forms.ComboBox cboLoaiLich;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblDiemPT;
        private System.Windows.Forms.NumericUpDown nudDiemPT;
        private System.Windows.Forms.Label lblDiemKS;
        private System.Windows.Forms.NumericUpDown nudDiemKS;
        private System.Windows.Forms.Label lblDiemAn;
        private System.Windows.Forms.NumericUpDown nudDiemAn;
        private System.Windows.Forms.Label lblDiemHDV;
        private System.Windows.Forms.NumericUpDown nudDiemHDV;
        private System.Windows.Forms.Label lblDiemTong;
        private System.Windows.Forms.NumericUpDown nudDiemTong;
        private System.Windows.Forms.Label lblYKien;
        private System.Windows.Forms.TextBox txtYKien;
        private System.Windows.Forms.Button btnGuiKhaoSat;
        private System.Windows.Forms.DataGridView dgvKhaoSat;
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
            this.gbKhaoSat = new System.Windows.Forms.GroupBox();
            this.btnGuiKhaoSat = new System.Windows.Forms.Button();
            this.txtYKien = new System.Windows.Forms.TextBox();
            this.lblYKien = new System.Windows.Forms.Label();
            this.nudDiemTong = new System.Windows.Forms.NumericUpDown();
            this.lblDiemTong = new System.Windows.Forms.Label();
            this.nudDiemHDV = new System.Windows.Forms.NumericUpDown();
            this.lblDiemHDV = new System.Windows.Forms.Label();
            this.nudDiemAn = new System.Windows.Forms.NumericUpDown();
            this.lblDiemAn = new System.Windows.Forms.Label();
            this.nudDiemKS = new System.Windows.Forms.NumericUpDown();
            this.lblDiemKS = new System.Windows.Forms.Label();
            this.nudDiemPT = new System.Windows.Forms.NumericUpDown();
            this.lblDiemPT = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.cboLoaiLich = new System.Windows.Forms.ComboBox();
            this.lblLoaiLich = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhaoSat = new System.Windows.Forms.TextBox();
            this.lblMaKhaoSat = new System.Windows.Forms.Label();
            this.dgvKhaoSat = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbKhaoSat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemHDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhaoSat)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKhaoSat
            // 
            this.gbKhaoSat.Controls.Add(this.btnGuiKhaoSat);
            this.gbKhaoSat.Controls.Add(this.txtYKien);
            this.gbKhaoSat.Controls.Add(this.lblYKien);
            this.gbKhaoSat.Controls.Add(this.nudDiemTong);
            this.gbKhaoSat.Controls.Add(this.lblDiemTong);
            this.gbKhaoSat.Controls.Add(this.nudDiemHDV);
            this.gbKhaoSat.Controls.Add(this.lblDiemHDV);
            this.gbKhaoSat.Controls.Add(this.nudDiemAn);
            this.gbKhaoSat.Controls.Add(this.lblDiemAn);
            this.gbKhaoSat.Controls.Add(this.nudDiemKS);
            this.gbKhaoSat.Controls.Add(this.lblDiemKS);
            this.gbKhaoSat.Controls.Add(this.nudDiemPT);
            this.gbKhaoSat.Controls.Add(this.lblDiemPT);
            this.gbKhaoSat.Controls.Add(this.cboTour);
            this.gbKhaoSat.Controls.Add(this.lblTour);
            this.gbKhaoSat.Controls.Add(this.cboLoaiLich);
            this.gbKhaoSat.Controls.Add(this.lblLoaiLich);
            this.gbKhaoSat.Controls.Add(this.cboKhachHang);
            this.gbKhaoSat.Controls.Add(this.lblKhachHang);
            this.gbKhaoSat.Controls.Add(this.txtMaKhaoSat);
            this.gbKhaoSat.Controls.Add(this.lblMaKhaoSat);
            this.gbKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbKhaoSat.Location = new System.Drawing.Point(12, 12);
            this.gbKhaoSat.Name = "gbKhaoSat";
            this.gbKhaoSat.Size = new System.Drawing.Size(960, 140);
            this.gbKhaoSat.TabIndex = 0;
            this.gbKhaoSat.TabStop = false;
            this.gbKhaoSat.Text = "Phiếu Khảo Sát & Đánh Giá Chất Lượng Dịch Vụ Sau Khi Kết Thúc Tour";
            // 
            // btnGuiKhaoSat
            // 
            this.btnGuiKhaoSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnGuiKhaoSat.ForeColor = System.Drawing.Color.White;
            this.btnGuiKhaoSat.Location = new System.Drawing.Point(825, 95);
            this.btnGuiKhaoSat.Name = "btnGuiKhaoSat";
            this.btnGuiKhaoSat.Size = new System.Drawing.Size(120, 32);
            this.btnGuiKhaoSat.TabIndex = 20;
            this.btnGuiKhaoSat.Text = "Lưu Khảo Sát";
            this.btnGuiKhaoSat.UseVisualStyleBackColor = false;
            this.btnGuiKhaoSat.Click += new System.EventHandler(this.btnGuiKhaoSat_Click);
            // 
            // txtYKien
            // 
            this.txtYKien.Location = new System.Drawing.Point(120, 100);
            this.txtYKien.Name = "txtYKien";
            this.txtYKien.Size = new System.Drawing.Size(685, 23);
            this.txtYKien.TabIndex = 19;
            this.txtYKien.Text = "Dịch vụ chu đáo, hướng dẫn viên nhiệt tình vui vẻ!";
            // 
            // lblYKien
            // 
            this.lblYKien.AutoSize = true;
            this.lblYKien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblYKien.Location = new System.Drawing.Point(20, 103);
            this.lblYKien.Name = "lblYKien";
            this.lblYKien.Size = new System.Drawing.Size(92, 15);
            this.lblYKien.TabIndex = 18;
            this.lblYKien.Text = "Ý kiến đóng góp:";
            // 
            // nudDiemTong
            // 
            this.nudDiemTong.Location = new System.Drawing.Point(890, 62);
            this.nudDiemTong.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudDiemTong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDiemTong.Name = "nudDiemTong";
            this.nudDiemTong.Size = new System.Drawing.Size(55, 23);
            this.nudDiemTong.TabIndex = 17;
            this.nudDiemTong.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblDiemTong
            // 
            this.lblDiemTong.AutoSize = true;
            this.lblDiemTong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemTong.Location = new System.Drawing.Point(820, 65);
            this.lblDiemTong.Name = "lblDiemTong";
            this.lblDiemTong.Size = new System.Drawing.Size(66, 15);
            this.lblDiemTong.TabIndex = 16;
            this.lblDiemTong.Text = "Tổng quan:";
            // 
            // nudDiemHDV
            // 
            this.nudDiemHDV.Location = new System.Drawing.Point(750, 62);
            this.nudDiemHDV.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudDiemHDV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDiemHDV.Name = "nudDiemHDV";
            this.nudDiemHDV.Size = new System.Drawing.Size(55, 23);
            this.nudDiemHDV.TabIndex = 15;
            this.nudDiemHDV.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblDiemHDV
            // 
            this.lblDiemHDV.AutoSize = true;
            this.lblDiemHDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemHDV.Location = new System.Drawing.Point(700, 65);
            this.lblDiemHDV.Name = "lblDiemHDV";
            this.lblDiemHDV.Size = new System.Drawing.Size(35, 15);
            this.lblDiemHDV.TabIndex = 14;
            this.lblDiemHDV.Text = "HDV:";
            // 
            // nudDiemAn
            // 
            this.nudDiemAn.Location = new System.Drawing.Point(630, 62);
            this.nudDiemAn.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudDiemAn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDiemAn.Name = "nudDiemAn";
            this.nudDiemAn.Size = new System.Drawing.Size(55, 23);
            this.nudDiemAn.TabIndex = 13;
            this.nudDiemAn.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblDiemAn
            // 
            this.lblDiemAn.AutoSize = true;
            this.lblDiemAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemAn.Location = new System.Drawing.Point(570, 65);
            this.lblDiemAn.Name = "lblDiemAn";
            this.lblDiemAn.Size = new System.Drawing.Size(54, 15);
            this.lblDiemAn.TabIndex = 12;
            this.lblDiemAn.Text = "Ăn uống:";
            // 
            // nudDiemKS
            // 
            this.nudDiemKS.Location = new System.Drawing.Point(500, 62);
            this.nudDiemKS.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudDiemKS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDiemKS.Name = "nudDiemKS";
            this.nudDiemKS.Size = new System.Drawing.Size(55, 23);
            this.nudDiemKS.TabIndex = 11;
            this.nudDiemKS.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblDiemKS
            // 
            this.lblDiemKS.AutoSize = true;
            this.lblDiemKS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemKS.Location = new System.Drawing.Point(430, 65);
            this.lblDiemKS.Name = "lblDiemKS";
            this.lblDiemKS.Size = new System.Drawing.Size(65, 15);
            this.lblDiemKS.TabIndex = 10;
            this.lblDiemKS.Text = "Khách sạn:";
            // 
            // nudDiemPT
            // 
            this.nudDiemPT.Location = new System.Drawing.Point(360, 62);
            this.nudDiemPT.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudDiemPT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDiemPT.Name = "nudDiemPT";
            this.nudDiemPT.Size = new System.Drawing.Size(55, 23);
            this.nudDiemPT.TabIndex = 9;
            this.nudDiemPT.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblDiemPT
            // 
            this.lblDiemPT.AutoSize = true;
            this.lblDiemPT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiemPT.Location = new System.Drawing.Point(260, 65);
            this.lblDiemPT.Name = "lblDiemPT";
            this.lblDiemPT.Size = new System.Drawing.Size(95, 15);
            this.lblDiemPT.TabIndex = 8;
            this.lblDiemPT.Text = "Phương tiện (1-5):";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Location = new System.Drawing.Point(620, 25);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(325, 23);
            this.cboTour.TabIndex = 7;
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTour.Location = new System.Drawing.Point(570, 28);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(33, 15);
            this.lblTour.TabIndex = 6;
            this.lblTour.Text = "Tour:";
            // 
            // cboLoaiLich
            // 
            this.cboLoaiLich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiLich.FormattingEnabled = true;
            this.cboLoaiLich.Items.AddRange(new object[] {
            "CHUYEN_LE",
            "DOAN"});
            this.cboLoaiLich.Location = new System.Drawing.Point(440, 25);
            this.cboLoaiLich.Name = "cboLoaiLich";
            this.cboLoaiLich.Size = new System.Drawing.Size(115, 23);
            this.cboLoaiLich.TabIndex = 5;
            // 
            // lblLoaiLich
            // 
            this.lblLoaiLich.AutoSize = true;
            this.lblLoaiLich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiLich.Location = new System.Drawing.Point(380, 28);
            this.lblLoaiLich.Name = "lblLoaiLich";
            this.lblLoaiLich.Size = new System.Drawing.Size(53, 15);
            this.lblLoaiLich.TabIndex = 4;
            this.lblLoaiLich.Text = "Loại lịch:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(230, 25);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(140, 23);
            this.cboKhachHang.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachHang.Location = new System.Drawing.Point(180, 28);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(43, 15);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách:";
            // 
            // txtMaKhaoSat
            // 
            this.txtMaKhaoSat.Location = new System.Drawing.Point(120, 25);
            this.txtMaKhaoSat.Name = "txtMaKhaoSat";
            this.txtMaKhaoSat.Size = new System.Drawing.Size(50, 23);
            this.txtMaKhaoSat.TabIndex = 1;
            // 
            // lblMaKhaoSat
            // 
            this.lblMaKhaoSat.AutoSize = true;
            this.lblMaKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaKhaoSat.Location = new System.Drawing.Point(20, 28);
            this.lblMaKhaoSat.Name = "lblMaKhaoSat";
            this.lblMaKhaoSat.Size = new System.Drawing.Size(52, 15);
            this.lblMaKhaoSat.TabIndex = 0;
            this.lblMaKhaoSat.Text = "Mã PKS:";
            // 
            // dgvKhaoSat
            // 
            this.dgvKhaoSat.AllowUserToAddRows = false;
            this.dgvKhaoSat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhaoSat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhaoSat.Location = new System.Drawing.Point(12, 160);
            this.dgvKhaoSat.Name = "dgvKhaoSat";
            this.dgvKhaoSat.ReadOnly = true;
            this.dgvKhaoSat.Size = new System.Drawing.Size(960, 375);
            this.dgvKhaoSat.TabIndex = 1;
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
            // FrmPhieuKhaoSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvKhaoSat);
            this.Controls.Add(this.gbKhaoSat);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPhieuKhaoSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khảo Sát Đánh Giá Chất Lượng Dịch Vụ Du Lịch";
            this.Load += new System.EventHandler(this.FrmPhieuKhaoSat_Load);
            this.gbKhaoSat.ResumeLayout(false);
            this.gbKhaoSat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemHDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiemPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhaoSat)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

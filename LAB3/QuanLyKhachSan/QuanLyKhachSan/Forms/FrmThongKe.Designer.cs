namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.lblDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.lblDichVuTitle = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(32, 22);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(58, 17);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(96, 18);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(130, 25);
            this.dtTu.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(262, 22);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(66, 17);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(334, 18);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(130, 25);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(490, 15);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(115, 30);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuDat.Location = new System.Drawing.Point(32, 65);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(95, 20);
            this.lblPhieuDat.TabIndex = 5;
            this.lblPhieuDat.Text = "Phiếu đặt: 28";
            // 
            // lblDangO
            // 
            this.lblDangO.AutoSize = true;
            this.lblDangO.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangO.Location = new System.Drawing.Point(420, 65);
            this.lblDangO.Name = "lblDangO";
            this.lblDangO.Size = new System.Drawing.Size(71, 20);
            this.lblDangO.TabIndex = 6;
            this.lblDangO.Text = "Đang ở: 7";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(32, 100);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(90, 20);
            this.lblHoaDon.TabIndex = 7;
            this.lblHoaDon.Text = "Hóa đơn: 21";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(420, 100);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(186, 20);
            this.lblDoanhThu.TabIndex = 8;
            this.lblDoanhThu.Text = "Doanh thu HĐ: 52.600.000 đ";
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenBu.Location = new System.Drawing.Point(32, 136);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(170, 20);
            this.lblDenBu.TabIndex = 9;
            this.lblDenBu.Text = "Tổng đền bù: 2.100.000 đ";
            // 
            // lblDichVuTitle
            // 
            this.lblDichVuTitle.AutoSize = true;
            this.lblDichVuTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVuTitle.Location = new System.Drawing.Point(32, 178);
            this.lblDichVuTitle.Name = "lblDichVuTitle";
            this.lblDichVuTitle.Size = new System.Drawing.Size(117, 19);
            this.lblDichVuTitle.TabIndex = 10;
            this.lblDichVuTitle.Text = "Dịch vụ sử dụng:";
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AllowUserToDeleteRows = false;
            this.dgvDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(32, 206);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 30;
            this.dgvDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV.Size = new System.Drawing.Size(756, 260);
            this.dgvDV.TabIndex = 11;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 495);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblDichVuTitle);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDangO);
            this.Controls.Add(this.lblPhieuDat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê khách sạn";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label lblPhieuDat;
        private System.Windows.Forms.Label lblDangO;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.Label lblDichVuTitle;
        private System.Windows.Forms.DataGridView dgvDV;
    }
}

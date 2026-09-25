namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.lblDat = new System.Windows.Forms.Label();
            this.pnl3Grids = new System.Windows.Forms.Panel();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.pnlDenBuBar = new System.Windows.Forms.Panel();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.lblTienDB = new System.Windows.Forms.Label();
            this.cboMucDo = new System.Windows.Forms.ComboBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.pnlHoaDonBar = new System.Windows.Forms.Panel();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.lblTienTT = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnl3Grids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.pnlDenBuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            this.pnlHoaDonBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtHDChon);
            this.pnlTop.Controls.Add(this.txtPhong);
            this.pnlTop.Controls.Add(this.txtMaTT);
            this.pnlTop.Controls.Add(this.cboNV2);
            this.pnlTop.Controls.Add(this.cboNV);
            this.pnlTop.Controls.Add(this.cboDat);
            this.pnlTop.Controls.Add(this.lblDat);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // txtHDChon
            // 
            this.txtHDChon.Location = new System.Drawing.Point(620, 10);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.Size = new System.Drawing.Size(70, 25);
            this.txtHDChon.TabIndex = 6;
            this.txtHDChon.Visible = false;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(540, 10);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(70, 25);
            this.txtPhong.TabIndex = 5;
            this.txtPhong.Visible = false;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(460, 10);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(70, 25);
            this.txtMaTT.TabIndex = 4;
            this.txtMaTT.Visible = false;
            // 
            // cboNV2
            // 
            this.cboNV2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV2.FormattingEnabled = true;
            this.cboNV2.Location = new System.Drawing.Point(380, 10);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(70, 25);
            this.cboNV2.TabIndex = 3;
            this.cboNV2.Visible = false;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(300, 10);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(70, 25);
            this.cboNV.TabIndex = 2;
            this.cboNV.Visible = false;
            // 
            // cboDat
            // 
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.FormattingEnabled = true;
            this.cboDat.Location = new System.Drawing.Point(120, 10);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(160, 25);
            this.cboDat.TabIndex = 1;
            this.cboDat.SelectedIndexChanged += new System.EventHandler(this.cboDat_SelectedIndexChanged);
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(15, 13);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(89, 17);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Phiếu đang ở:";
            // 
            // pnl3Grids
            // 
            this.pnl3Grids.Controls.Add(this.dgvDBChon);
            this.pnl3Grids.Controls.Add(this.dgvTN);
            this.pnl3Grids.Controls.Add(this.dgvPhong);
            this.pnl3Grids.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3Grids.Location = new System.Drawing.Point(0, 45);
            this.pnl3Grids.Name = "pnl3Grids";
            this.pnl3Grids.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.pnl3Grids.Size = new System.Drawing.Size(984, 155);
            this.pnl3Grids.TabIndex = 1;
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.AllowUserToAddRows = false;
            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDBChon.Location = new System.Drawing.Point(630, 0);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.ReadOnly = true;
            this.dgvDBChon.RowHeadersWidth = 30;
            this.dgvDBChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDBChon.Size = new System.Drawing.Size(339, 155);
            this.dgvDBChon.TabIndex = 2;
            // 
            // dgvTN
            // 
            this.dgvTN.AllowUserToAddRows = false;
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.BackgroundColor = System.Drawing.Color.White;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTN.Location = new System.Drawing.Point(285, 0);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.RowHeadersWidth = 30;
            this.dgvTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTN.Size = new System.Drawing.Size(345, 155);
            this.dgvTN.TabIndex = 1;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvPhong.Location = new System.Drawing.Point(15, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 30;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(270, 155);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // pnlDenBuBar
            // 
            this.pnlDenBuBar.Controls.Add(this.btnLapDB);
            this.pnlDenBuBar.Controls.Add(this.numDenBu);
            this.pnlDenBuBar.Controls.Add(this.lblTienDB);
            this.pnlDenBuBar.Controls.Add(this.cboMucDo);
            this.pnlDenBuBar.Controls.Add(this.lblMucDo);
            this.pnlDenBuBar.Controls.Add(this.txtSoDB);
            this.pnlDenBuBar.Controls.Add(this.lblSoDB);
            this.pnlDenBuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDenBuBar.Location = new System.Drawing.Point(0, 200);
            this.pnlDenBuBar.Name = "pnlDenBuBar";
            this.pnlDenBuBar.Size = new System.Drawing.Size(984, 45);
            this.pnlDenBuBar.TabIndex = 2;
            // 
            // btnLapDB
            // 
            this.btnLapDB.Location = new System.Drawing.Point(780, 7);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(160, 30);
            this.btnLapDB.TabIndex = 6;
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.UseVisualStyleBackColor = true;
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            // 
            // numDenBu
            // 
            this.numDenBu.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numDenBu.Location = new System.Drawing.Point(625, 10);
            this.numDenBu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(130, 25);
            this.numDenBu.TabIndex = 5;
            this.numDenBu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDenBu.ThousandsSeparator = true;
            this.numDenBu.Value = new decimal(new int[] { 500000, 0, 0, 0 });
            // 
            // lblTienDB
            // 
            this.lblTienDB.AutoSize = true;
            this.lblTienDB.Location = new System.Drawing.Point(565, 13);
            this.lblTienDB.Name = "lblTienDB";
            this.lblTienDB.Size = new System.Drawing.Size(51, 17);
            this.lblTienDB.TabIndex = 4;
            this.lblTienDB.Text = "Số tiền:";
            // 
            // cboMucDo
            // 
            this.cboMucDo.FormattingEnabled = true;
            this.cboMucDo.Items.AddRange(new object[] {
            "Hư hỏng nhẹ",
            "Hư hỏng nặng",
            "Mất mát"});
            this.cboMucDo.Location = new System.Drawing.Point(385, 10);
            this.cboMucDo.Name = "cboMucDo";
            this.cboMucDo.Size = new System.Drawing.Size(145, 25);
            this.cboMucDo.TabIndex = 3;
            this.cboMucDo.Text = "Hư hỏng nhẹ";
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Location = new System.Drawing.Point(325, 13);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(57, 17);
            this.lblMucDo.TabIndex = 2;
            this.lblMucDo.Text = "Mức độ:";
            // 
            // txtSoDB
            // 
            this.txtSoDB.Location = new System.Drawing.Point(145, 10);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(135, 25);
            this.txtSoDB.TabIndex = 1;
            this.txtSoDB.Text = "DB001";
            // 
            // lblSoDB
            // 
            this.lblSoDB.AutoSize = true;
            this.lblSoDB.Location = new System.Drawing.Point(15, 13);
            this.lblSoDB.Name = "lblSoDB";
            this.lblSoDB.Size = new System.Drawing.Size(111, 17);
            this.lblSoDB.TabIndex = 0;
            this.lblSoDB.Text = "Số phiếu đền bù:";
            // 
            // pnlHoaDonBar
            // 
            this.pnlHoaDonBar.Controls.Add(this.btnLapHD);
            this.pnlHoaDonBar.Controls.Add(this.numSoNgay);
            this.pnlHoaDonBar.Controls.Add(this.lblSoNgay);
            this.pnlHoaDonBar.Controls.Add(this.txtSoHD);
            this.pnlHoaDonBar.Controls.Add(this.lblSoHD);
            this.pnlHoaDonBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHoaDonBar.Location = new System.Drawing.Point(0, 245);
            this.pnlHoaDonBar.Name = "pnlHoaDonBar";
            this.pnlHoaDonBar.Size = new System.Drawing.Size(984, 45);
            this.pnlHoaDonBar.TabIndex = 3;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(540, 7);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(135, 30);
            this.btnLapHD.TabIndex = 4;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // numSoNgay
            // 
            this.numSoNgay.Location = new System.Drawing.Point(420, 10);
            this.numSoNgay.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            this.numSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(90, 25);
            this.numSoNgay.TabIndex = 3;
            this.numSoNgay.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(295, 13);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(117, 17);
            this.lblSoNgay.TabIndex = 2;
            this.lblSoNgay.Text = "Số ngày tính tiền:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(120, 10);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(135, 25);
            this.txtSoHD.TabIndex = 1;
            this.txtSoHD.Text = "HD001";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(15, 13);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(78, 17);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số hóa đơn:";
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD.Location = new System.Drawing.Point(0, 290);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersWidth = 30;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(984, 265);
            this.dgvHD.TabIndex = 4;
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnTraPhong);
            this.pnlBottom.Controls.Add(this.btnThanhToan);
            this.pnlBottom.Controls.Add(this.numTienTT);
            this.pnlBottom.Controls.Add(this.lblTienTT);
            this.pnlBottom.Controls.Add(this.cboHT);
            this.pnlBottom.Controls.Add(this.lblHinhThuc);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 555);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(984, 55);
            this.pnlBottom.TabIndex = 5;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.Location = new System.Drawing.Point(650, 12);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(175, 32);
            this.btnTraPhong.TabIndex = 5;
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(500, 12);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(130, 32);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // numTienTT
            // 
            this.numTienTT.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numTienTT.Location = new System.Drawing.Point(355, 16);
            this.numTienTT.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(125, 25);
            this.numTienTT.TabIndex = 3;
            this.numTienTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTienTT.ThousandsSeparator = true;
            this.numTienTT.Value = new decimal(new int[] { 1200000, 0, 0, 0 });
            // 
            // lblTienTT
            // 
            this.lblTienTT.AutoSize = true;
            this.lblTienTT.Location = new System.Drawing.Point(295, 19);
            this.lblTienTT.Name = "lblTienTT";
            this.lblTienTT.Size = new System.Drawing.Size(51, 17);
            this.lblTienTT.TabIndex = 2;
            this.lblTienTT.Text = "Số tiền:";
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Location = new System.Drawing.Point(120, 16);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(140, 25);
            this.cboHT.TabIndex = 1;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(15, 19);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(66, 17);
            this.lblHinhThuc.TabIndex = 0;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 610);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHoaDonBar);
            this.Controls.Add(this.pnlDenBuBar);
            this.Controls.Add(this.pnl3Grids);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl3Grids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.pnlDenBuBar.ResumeLayout(false);
            this.pnlDenBuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            this.pnlHoaDonBar.ResumeLayout(false);
            this.pnlHoaDonBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.Panel pnl3Grids;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.Panel pnlDenBuBar;
        private System.Windows.Forms.Label lblSoDB;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.ComboBox cboMucDo;
        private System.Windows.Forms.Label lblTienDB;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnLapDB;
        private System.Windows.Forms.Panel pnlHoaDonBar;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblTienTT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
    }
}

namespace QuanLyNhanSu.Forms
{
    partial class FrmKhenThuongKyLuat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKT;
        private System.Windows.Forms.TabPage tabPC;
        private System.Windows.Forms.TabPage tabKL;
        private System.Windows.Forms.DataGridView dgvKhenThuong;
        private System.Windows.Forms.DataGridView dgvPhieuChi;
        private System.Windows.Forms.DataGridView dgvKyLuat;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblLoaiKT;
        private System.Windows.Forms.ComboBox cboLoaiKT;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThucChi;
        private System.Windows.Forms.Button btnLapQDKhenThuong;
        private System.Windows.Forms.Button btnLapQDKyLuat;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKT = new System.Windows.Forms.TabPage();
            this.dgvKhenThuong = new System.Windows.Forms.DataGridView();
            this.tabPC = new System.Windows.Forms.TabPage();
            this.dgvPhieuChi = new System.Windows.Forms.DataGridView();
            this.tabKL = new System.Windows.Forms.TabPage();
            this.dgvKyLuat = new System.Windows.Forms.DataGridView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnLapQDKyLuat = new System.Windows.Forms.Button();
            this.btnLapQDKhenThuong = new System.Windows.Forms.Button();
            this.cboHinhThucChi = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.nudSoTien = new System.Windows.Forms.NumericUpDown();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.cboLoaiKT = new System.Windows.Forms.ComboBox();
            this.lblLoaiKT = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();
            this.tabPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).BeginInit();
            this.tabKL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKT);
            this.tabControl.Controls.Add(this.tabPC);
            this.tabControl.Controls.Add(this.tabKL);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(10, 130);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 500);
            this.tabControl.TabIndex = 0;
            // 
            // tabKT
            // 
            this.tabKT.Controls.Add(this.dgvKhenThuong);
            this.tabKT.Location = new System.Drawing.Point(4, 26);
            this.tabKT.Name = "tabKT";
            this.tabKT.Padding = new System.Windows.Forms.Padding(3);
            this.tabKT.Size = new System.Drawing.Size(912, 470);
            this.tabKT.TabIndex = 0;
            this.tabKT.Text = "Quyết Định Khen Thưởng";
            this.tabKT.UseVisualStyleBackColor = true;
            // 
            // dgvKhenThuong
            // 
            this.dgvKhenThuong.AllowUserToAddRows = false;
            this.dgvKhenThuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhenThuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhenThuong.Location = new System.Drawing.Point(3, 3);
            this.dgvKhenThuong.Name = "dgvKhenThuong";
            this.dgvKhenThuong.ReadOnly = true;
            this.dgvKhenThuong.Size = new System.Drawing.Size(906, 464);
            this.dgvKhenThuong.TabIndex = 0;
            // 
            // tabPC
            // 
            this.tabPC.Controls.Add(this.dgvPhieuChi);
            this.tabPC.Location = new System.Drawing.Point(4, 26);
            this.tabPC.Name = "tabPC";
            this.tabPC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPC.Size = new System.Drawing.Size(912, 470);
            this.tabPC.TabIndex = 1;
            this.tabPC.Text = "Phiếu Chi Tiền Khen Thưởng (Tiền mặt)";
            this.tabPC.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuChi
            // 
            this.dgvPhieuChi.AllowUserToAddRows = false;
            this.dgvPhieuChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuChi.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuChi.Location = new System.Drawing.Point(3, 3);
            this.dgvPhieuChi.Name = "dgvPhieuChi";
            this.dgvPhieuChi.ReadOnly = true;
            this.dgvPhieuChi.Size = new System.Drawing.Size(906, 464);
            this.dgvPhieuChi.TabIndex = 0;
            // 
            // tabKL
            // 
            this.tabKL.Controls.Add(this.dgvKyLuat);
            this.tabKL.Location = new System.Drawing.Point(4, 26);
            this.tabKL.Name = "tabKL";
            this.tabKL.Padding = new System.Windows.Forms.Padding(3);
            this.tabKL.Size = new System.Drawing.Size(912, 470);
            this.tabKL.TabIndex = 2;
            this.tabKL.Text = "Quyết Định Kỷ Luật & Xử Phạt";
            this.tabKL.UseVisualStyleBackColor = true;
            // 
            // dgvKyLuat
            // 
            this.dgvKyLuat.AllowUserToAddRows = false;
            this.dgvKyLuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyLuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvKyLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyLuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKyLuat.Location = new System.Drawing.Point(3, 3);
            this.dgvKyLuat.Name = "dgvKyLuat";
            this.dgvKyLuat.ReadOnly = true;
            this.dgvKyLuat.Size = new System.Drawing.Size(906, 464);
            this.dgvKyLuat.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.btnLapQDKyLuat);
            this.pnlInput.Controls.Add(this.btnLapQDKhenThuong);
            this.pnlInput.Controls.Add(this.cboHinhThucChi);
            this.pnlInput.Controls.Add(this.lblHinhThuc);
            this.pnlInput.Controls.Add(this.nudSoTien);
            this.pnlInput.Controls.Add(this.lblSoTien);
            this.pnlInput.Controls.Add(this.txtLyDo);
            this.pnlInput.Controls.Add(this.lblLyDo);
            this.pnlInput.Controls.Add(this.cboLoaiKT);
            this.pnlInput.Controls.Add(this.lblLoaiKT);
            this.pnlInput.Controls.Add(this.cboNhanVien);
            this.pnlInput.Controls.Add(this.lblNV);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(10, 10);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(920, 120);
            this.pnlInput.TabIndex = 1;
            // 
            // btnLapQDKyLuat
            // 
            this.btnLapQDKyLuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            this.btnLapQDKyLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapQDKyLuat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnLapQDKyLuat.ForeColor = System.Drawing.Color.White;
            this.btnLapQDKyLuat.Location = new System.Drawing.Point(700, 65);
            this.btnLapQDKyLuat.Name = "btnLapQDKyLuat";
            this.btnLapQDKyLuat.Size = new System.Drawing.Size(200, 36);
            this.btnLapQDKyLuat.TabIndex = 11;
            this.btnLapQDKyLuat.Text = "Lập QĐ Kỷ Luật";
            this.btnLapQDKyLuat.UseVisualStyleBackColor = false;
            this.btnLapQDKyLuat.Click += new System.EventHandler(this.btnLapQDKyLuat_Click);
            // 
            // btnLapQDKhenThuong
            // 
            this.btnLapQDKhenThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnLapQDKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapQDKhenThuong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnLapQDKhenThuong.ForeColor = System.Drawing.Color.White;
            this.btnLapQDKhenThuong.Location = new System.Drawing.Point(700, 18);
            this.btnLapQDKhenThuong.Name = "btnLapQDKhenThuong";
            this.btnLapQDKhenThuong.Size = new System.Drawing.Size(200, 36);
            this.btnLapQDKhenThuong.TabIndex = 10;
            this.btnLapQDKhenThuong.Text = "Lập QĐ Khen Thưởng";
            this.btnLapQDKhenThuong.UseVisualStyleBackColor = false;
            this.btnLapQDKhenThuong.Click += new System.EventHandler(this.btnLapQDKhenThuong_Click);
            // 
            // cboHinhThucChi
            // 
            this.cboHinhThucChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucChi.FormattingEnabled = true;
            this.cboHinhThucChi.Location = new System.Drawing.Point(490, 70);
            this.cboHinhThucChi.Name = "cboHinhThucChi";
            this.cboHinhThucChi.Size = new System.Drawing.Size(180, 24);
            this.cboHinhThucChi.TabIndex = 9;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(400, 73);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(89, 16);
            this.lblHinhThuc.TabIndex = 8;
            this.lblHinhThuc.Text = "Hình thức chi:";
            // 
            // nudSoTien
            // 
            this.nudSoTien.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            this.nudSoTien.Location = new System.Drawing.Point(245, 70);
            this.nudSoTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudSoTien.Name = "nudSoTien";
            this.nudSoTien.Size = new System.Drawing.Size(130, 24);
            this.nudSoTien.TabIndex = 7;
            this.nudSoTien.Value = new decimal(new int[] { 2000000, 0, 0, 0 });
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(165, 73);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(76, 16);
            this.lblSoTien.TabIndex = 6;
            this.lblSoTien.Text = "Tiền thưởng:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(375, 22);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(295, 24);
            this.txtLyDo.TabIndex = 5;
            this.txtLyDo.Text = "Sáng kiến cải tiến sản xuất sơn";
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(330, 25);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(43, 16);
            this.lblLyDo.TabIndex = 4;
            this.lblLyDo.Text = "Lý do:";
            // 
            // cboLoaiKT
            // 
            this.cboLoaiKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKT.FormattingEnabled = true;
            this.cboLoaiKT.Location = new System.Drawing.Point(225, 22);
            this.cboLoaiKT.Name = "cboLoaiKT";
            this.cboLoaiKT.Size = new System.Drawing.Size(90, 24);
            this.cboLoaiKT.TabIndex = 3;
            // 
            // lblLoaiKT
            // 
            this.lblLoaiKT.AutoSize = true;
            this.lblLoaiKT.Location = new System.Drawing.Point(185, 25);
            this.lblLoaiKT.Name = "lblLoaiKT";
            this.lblLoaiKT.Size = new System.Drawing.Size(36, 16);
            this.lblLoaiKT.TabIndex = 2;
            this.lblLoaiKT.Text = "Loại:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(20, 22);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(150, 24);
            this.cboNhanVien.TabIndex = 1;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(20, 5);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(73, 16);
            this.lblNV.TabIndex = 0;
            this.lblNV.Text = "Đối Tượng:";
            // 
            // FrmKhenThuongKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhenThuongKyLuat";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Khen Thưởng & Kỷ Luật";
            this.Load += new System.EventHandler(this.FrmKhenThuongKyLuat_Load);
            this.tabControl.ResumeLayout(false);
            this.tabKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();
            this.tabPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).EndInit();
            this.tabKL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyLuat)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

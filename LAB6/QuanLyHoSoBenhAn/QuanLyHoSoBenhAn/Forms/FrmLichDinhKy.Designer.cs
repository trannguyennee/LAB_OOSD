namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmLichDinhKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpDatLich;
        private System.Windows.Forms.Label lblHoSo;
        private System.Windows.Forms.ComboBox cboHoSo;
        private System.Windows.Forms.Label lblQuy;
        private System.Windows.Forms.NumericUpDown nudQuy;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Label lblNgayHen;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.DataGridView dgvLich;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpDatLich = new System.Windows.Forms.GroupBox();
            this.lblHoSo = new System.Windows.Forms.Label();
            this.cboHoSo = new System.Windows.Forms.ComboBox();
            this.lblQuy = new System.Windows.Forms.Label();
            this.nudQuy = new System.Windows.Forms.NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.lblGio = new System.Windows.Forms.Label();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.dgvLich = new System.Windows.Forms.DataGridView();
            this.grpDatLich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatLich
            // 
            this.grpDatLich.Controls.Add(this.lblHoSo);
            this.grpDatLich.Controls.Add(this.cboHoSo);
            this.grpDatLich.Controls.Add(this.lblQuy);
            this.grpDatLich.Controls.Add(this.nudQuy);
            this.grpDatLich.Controls.Add(this.lblNam);
            this.grpDatLich.Controls.Add(this.nudNam);
            this.grpDatLich.Controls.Add(this.lblNgayHen);
            this.grpDatLich.Controls.Add(this.dtpNgayHen);
            this.grpDatLich.Controls.Add(this.lblGio);
            this.grpDatLich.Controls.Add(this.txtGio);
            this.grpDatLich.Controls.Add(this.lblGhiChu);
            this.grpDatLich.Controls.Add(this.txtGhiChu);
            this.grpDatLich.Controls.Add(this.btnDatLich);
            this.grpDatLich.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDatLich.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpDatLich.Location = new System.Drawing.Point(10, 10);
            this.grpDatLich.Name = "grpDatLich";
            this.grpDatLich.Size = new System.Drawing.Size(960, 190);
            this.grpDatLich.TabIndex = 0;
            this.grpDatLich.TabStop = false;
            this.grpDatLich.Text = "ĐẶT LỊCH KHÁM ĐỊNH KỲ THEO QUÝ (QUY TẮC #3: MIỄN PHÍ KHÁM)";
            // 
            // lblHoSo
            // 
            this.lblHoSo.AutoSize = true;
            this.lblHoSo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHoSo.Location = new System.Drawing.Point(20, 35);
            this.lblHoSo.Name = "lblHoSo";
            this.lblHoSo.Size = new System.Drawing.Size(89, 17);
            this.lblHoSo.TabIndex = 0;
            this.lblHoSo.Text = "Chọn Hồ Sơ:";
            // 
            // cboHoSo
            // 
            this.cboHoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoSo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboHoSo.FormattingEnabled = true;
            this.cboHoSo.Location = new System.Drawing.Point(120, 32);
            this.cboHoSo.Name = "cboHoSo";
            this.cboHoSo.Size = new System.Drawing.Size(200, 25);
            this.cboHoSo.TabIndex = 1;
            // 
            // lblQuy
            // 
            this.lblQuy.AutoSize = true;
            this.lblQuy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblQuy.Location = new System.Drawing.Point(350, 35);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Size = new System.Drawing.Size(73, 17);
            this.lblQuy.TabIndex = 2;
            this.lblQuy.Text = "Quý khám:";
            // 
            // nudQuy
            // 
            this.nudQuy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudQuy.Location = new System.Drawing.Point(430, 32);
            this.nudQuy.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            this.nudQuy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudQuy.Name = "nudQuy";
            this.nudQuy.Size = new System.Drawing.Size(60, 25);
            this.nudQuy.TabIndex = 3;
            this.nudQuy.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNam.Location = new System.Drawing.Point(520, 35);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(39, 17);
            this.lblNam.TabIndex = 4;
            this.lblNam.Text = "Năm:";
            // 
            // nudNam
            // 
            this.nudNam.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudNam.Location = new System.Drawing.Point(570, 32);
            this.nudNam.Maximum = new decimal(new int[] { 2035, 0, 0, 0 });
            this.nudNam.Minimum = new decimal(new int[] { 2020, 0, 0, 0 });
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(90, 25);
            this.nudNam.TabIndex = 5;
            this.nudNam.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblNgayHen
            // 
            this.lblNgayHen.AutoSize = true;
            this.lblNgayHen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNgayHen.Location = new System.Drawing.Point(20, 85);
            this.lblNgayHen.Name = "lblNgayHen";
            this.lblNgayHen.Size = new System.Drawing.Size(68, 17);
            this.lblNgayHen.TabIndex = 6;
            this.lblNgayHen.Text = "Ngày hẹn:";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHen.Location = new System.Drawing.Point(120, 82);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(140, 25);
            this.dtpNgayHen.TabIndex = 7;
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGio.Location = new System.Drawing.Point(290, 85);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(56, 17);
            this.lblGio.TabIndex = 8;
            this.lblGio.Text = "Giờ hẹn:";
            // 
            // txtGio
            // 
            this.txtGio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGio.Location = new System.Drawing.Point(360, 82);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(100, 25);
            this.txtGio.TabIndex = 9;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblGhiChu.Location = new System.Drawing.Point(490, 85);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 17);
            this.lblGhiChu.TabIndex = 10;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtGhiChu.Location = new System.Drawing.Point(560, 82);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(370, 25);
            this.txtGhiChu.TabIndex = 11;
            // 
            // btnDatLich
            // 
            this.btnDatLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnDatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Location = new System.Drawing.Point(360, 130);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(260, 45);
            this.btnDatLich.TabIndex = 12;
            this.btnDatLich.Text = "ĐẶT LỊCH ĐỊNH KỲ MIỄN PHÍ";
            this.btnDatLich.UseVisualStyleBackColor = false;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // dgvLich
            // 
            this.dgvLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLich.BackgroundColor = System.Drawing.Color.White;
            this.dgvLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLich.Location = new System.Drawing.Point(10, 200);
            this.dgvLich.Name = "dgvLich";
            this.dgvLich.ReadOnly = true;
            this.dgvLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLich.Size = new System.Drawing.Size(960, 370);
            this.dgvLich.TabIndex = 1;
            // 
            // FrmLichDinhKy
            // 
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.dgvLich);
            this.Controls.Add(this.grpDatLich);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FrmLichDinhKy";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Lịch Khám Định Kỳ Theo Quý";
            this.grpDatLich.ResumeLayout(false);
            this.grpDatLich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
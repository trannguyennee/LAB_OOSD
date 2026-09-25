namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
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
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.lblSL = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.lblLuot = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cboNV);
            this.pnlTop.Controls.Add(this.btnGhi);
            this.pnlTop.Controls.Add(this.numSL);
            this.pnlTop.Controls.Add(this.lblSL);
            this.pnlTop.Controls.Add(this.dtNgay);
            this.pnlTop.Controls.Add(this.lblNgay);
            this.pnlTop.Controls.Add(this.cboDV);
            this.pnlTop.Controls.Add(this.lblDV);
            this.pnlTop.Controls.Add(this.txtPhong);
            this.pnlTop.Controls.Add(this.lblPhong);
            this.pnlTop.Controls.Add(this.cboLuot);
            this.pnlTop.Controls.Add(this.lblLuot);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 95);
            this.pnlTop.TabIndex = 0;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(700, 52);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(85, 25);
            this.cboNV.TabIndex = 11;
            this.cboNV.Visible = false;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(545, 50);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(140, 30);
            this.btnGhi.TabIndex = 10;
            this.btnGhi.Text = "Ghi nhận";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(345, 52);
            this.numSL.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(100, 25);
            this.numSL.TabIndex = 9;
            this.numSL.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(280, 55);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(64, 17);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "Số lượng:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(115, 52);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(145, 25);
            this.dtNgay.TabIndex = 7;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(20, 55);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(92, 17);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày sử dụng:";
            // 
            // cboDV
            // 
            this.cboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDV.FormattingEnabled = true;
            this.cboDV.Location = new System.Drawing.Point(545, 17);
            this.cboDV.Name = "cboDV";
            this.cboDV.Size = new System.Drawing.Size(185, 25);
            this.cboDV.TabIndex = 5;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(475, 20);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(54, 17);
            this.lblDV.TabIndex = 4;
            this.lblDV.Text = "Dịch vụ:";
            // 
            // txtPhong
            // 
            this.txtPhong.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhong.Location = new System.Drawing.Point(345, 17);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(100, 25);
            this.txtPhong.TabIndex = 3;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(280, 20);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(48, 17);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng:";
            // 
            // cboLuot
            // 
            this.cboLuot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuot.FormattingEnabled = true;
            this.cboLuot.Location = new System.Drawing.Point(115, 17);
            this.cboLuot.Name = "cboLuot";
            this.cboLuot.Size = new System.Drawing.Size(145, 25);
            this.cboLuot.TabIndex = 1;
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);
            // 
            // lblLuot
            // 
            this.lblLuot.AutoSize = true;
            this.lblLuot.Location = new System.Drawing.Point(20, 20);
            this.lblLuot.Name = "lblLuot";
            this.lblLuot.Size = new System.Drawing.Size(83, 17);
            this.lblLuot.TabIndex = 0;
            this.lblLuot.Text = "Phiếu lưu trú:";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.Location = new System.Drawing.Point(0, 95);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 30;
            this.dgvLichSu.Size = new System.Drawing.Size(800, 355);
            this.dgvLichSu.TabIndex = 1;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLuot;
        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}

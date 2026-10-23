namespace QuanLyNhanSu.Forms
{
    partial class FrmChamCong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.ComboBox cboThangNam;
        private System.Windows.Forms.Button btnDongBo;
        private System.Windows.Forms.DataGridView dgvChamCong;

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
            this.btnDongBo = new System.Windows.Forms.Button();
            this.cboThangNam = new System.Windows.Forms.ComboBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnDongBo);
            this.pnlTop.Controls.Add(this.cboThangNam);
            this.pnlTop.Controls.Add(this.lblThangNam);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 65);
            this.pnlTop.TabIndex = 0;
            // 
            // btnDongBo
            // 
            this.btnDongBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnDongBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongBo.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDongBo.ForeColor = System.Drawing.Color.White;
            this.btnDongBo.Location = new System.Drawing.Point(320, 14);
            this.btnDongBo.Name = "btnDongBo";
            this.btnDongBo.Size = new System.Drawing.Size(260, 35);
            this.btnDongBo.TabIndex = 2;
            this.btnDongBo.Text = "Đồng Bộ Dữ Liệu Từ Máy Chấm Công";
            this.btnDongBo.UseVisualStyleBackColor = false;
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);
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
            this.lblThangNam.Size = new System.Drawing.Size(123, 17);
            this.lblThangNam.TabIndex = 0;
            this.lblThangNam.Text = "Chọn Kỳ Chấm Công:";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamCong.Location = new System.Drawing.Point(10, 75);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.ReadOnly = true;
            this.dgvChamCong.Size = new System.Drawing.Size(920, 555);
            this.dgvChamCong.TabIndex = 1;
            // 
            // FrmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChamCong";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Chấm Công Tháng";
            this.Load += new System.EventHandler(this.FrmChamCong_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

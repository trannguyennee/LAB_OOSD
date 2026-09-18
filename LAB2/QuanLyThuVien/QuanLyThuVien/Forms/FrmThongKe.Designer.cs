namespace QuanLyThuVien.Forms
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabUC13 = new System.Windows.Forms.TabPage();
            this.lblFooterUC13 = new System.Windows.Forms.Label();
            this.pnlBottomUC13 = new System.Windows.Forms.Panel();
            this.btnBieuDo = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnXuatExcelUC13 = new System.Windows.Forms.Button();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.pnlKpi = new System.Windows.Forms.Panel();
            this.pnlKpiPhat = new System.Windows.Forms.Panel();
            this.lblValTongPhat = new System.Windows.Forms.Label();
            this.lblTitlePhat = new System.Windows.Forms.Label();
            this.pnlKpiQuaHan = new System.Windows.Forms.Panel();
            this.lblValQuaHan = new System.Windows.Forms.Label();
            this.lblTitleQuaHan = new System.Windows.Forms.Label();
            this.pnlKpiDungHan = new System.Windows.Forms.Panel();
            this.lblValDungHan = new System.Windows.Forms.Label();
            this.lblTitleDungHan = new System.Windows.Forms.Label();
            this.pnlKpiMuon = new System.Windows.Forms.Panel();
            this.lblValLuotMuon = new System.Windows.Forms.Label();
            this.lblTitleMuon = new System.Windows.Forms.Label();
            this.pnlFilterUC13 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblHeaderUC13 = new System.Windows.Forms.Label();
            this.tabUC10 = new System.Windows.Forms.TabPage();
            this.lblFooterUC10 = new System.Windows.Forms.Label();
            this.pnlBottomUC10 = new System.Windows.Forms.Panel();
            this.btnInNoSach = new System.Windows.Forms.Button();
            this.btnXuatExcelUC10 = new System.Windows.Forms.Button();
            this.btnGuiEmailUC14 = new System.Windows.Forms.Button();
            this.dgvQuaHan = new System.Windows.Forms.DataGridView();
            this.grpFilterUC10 = new System.Windows.Forms.GroupBox();
            this.btnLamMoiQuaHan = new System.Windows.Forms.Button();
            this.btnTraCuuQuaHan = new System.Windows.Forms.Button();
            this.txtTimDocGia = new System.Windows.Forms.TextBox();
            this.lblTimDocGia = new System.Windows.Forms.Label();
            this.cboMucQuaHan = new System.Windows.Forms.ComboBox();
            this.lblMucQuaHan = new System.Windows.Forms.Label();
            this.lblHeaderUC10 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabUC13.SuspendLayout();
            this.pnlBottomUC13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.pnlKpi.SuspendLayout();
            this.pnlKpiPhat.SuspendLayout();
            this.pnlKpiQuaHan.SuspendLayout();
            this.pnlKpiDungHan.SuspendLayout();
            this.pnlKpiMuon.SuspendLayout();
            this.pnlFilterUC13.SuspendLayout();
            this.tabUC10.SuspendLayout();
            this.pnlBottomUC10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaHan)).BeginInit();
            this.grpFilterUC10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabUC13);
            this.tabMain.Controls.Add(this.tabUC10);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1200, 720);
            this.tabMain.TabIndex = 0;
            // 
            // tabUC13
            // 
            this.tabUC13.Controls.Add(this.lblFooterUC13);
            this.tabUC13.Controls.Add(this.pnlBottomUC13);
            this.tabUC13.Controls.Add(this.dgvTheLoai);
            this.tabUC13.Controls.Add(this.pnlKpi);
            this.tabUC13.Controls.Add(this.pnlFilterUC13);
            this.tabUC13.Controls.Add(this.lblHeaderUC13);
            this.tabUC13.Location = new System.Drawing.Point(4, 32);
            this.tabUC13.Name = "tabUC13";
            this.tabUC13.Padding = new System.Windows.Forms.Padding(3);
            this.tabUC13.Size = new System.Drawing.Size(1192, 684);
            this.tabUC13.TabIndex = 0;
            this.tabUC13.Text = "Báo cáo Thống kê (UC13)";
            this.tabUC13.UseVisualStyleBackColor = true;
            // 
            // lblFooterUC13
            // 
            this.lblFooterUC13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.lblFooterUC13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooterUC13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterUC13.ForeColor = System.Drawing.Color.DimGray;
            this.lblFooterUC13.Location = new System.Drawing.Point(3, 656);
            this.lblFooterUC13.Name = "lblFooterUC13";
            this.lblFooterUC13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFooterUC13.Size = new System.Drawing.Size(1186, 25);
            this.lblFooterUC13.TabIndex = 5;
            this.lblFooterUC13.Text = "Báo cáo được trích xuất tự động từ cơ sở dữ liệu SQL Server QuanLyThuVienDB.";
            this.lblFooterUC13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottomUC13
            // 
            this.pnlBottomUC13.Controls.Add(this.btnBieuDo);
            this.pnlBottomUC13.Controls.Add(this.btnInBaoCao);
            this.pnlBottomUC13.Controls.Add(this.btnXuatExcelUC13);
            this.pnlBottomUC13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomUC13.Location = new System.Drawing.Point(3, 591);
            this.pnlBottomUC13.Name = "pnlBottomUC13";
            this.pnlBottomUC13.Size = new System.Drawing.Size(1186, 65);
            this.pnlBottomUC13.TabIndex = 4;
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnBieuDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBieuDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBieuDo.ForeColor = System.Drawing.Color.White;
            this.btnBieuDo.Location = new System.Drawing.Point(680, 10);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(280, 45);
            this.btnBieuDo.TabIndex = 2;
            this.btnBieuDo.Text = "Biểu đồ trực quan";
            this.btnBieuDo.UseVisualStyleBackColor = false;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnInBaoCao.Location = new System.Drawing.Point(350, 10);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(280, 45);
            this.btnInBaoCao.TabIndex = 1;
            this.btnInBaoCao.Text = "In báo cáo thống kê PDF";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnXuatExcelUC13
            // 
            this.btnXuatExcelUC13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXuatExcelUC13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcelUC13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelUC13.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelUC13.Location = new System.Drawing.Point(20, 10);
            this.btnXuatExcelUC13.Name = "btnXuatExcelUC13";
            this.btnXuatExcelUC13.Size = new System.Drawing.Size(280, 45);
            this.btnXuatExcelUC13.TabIndex = 0;
            this.btnXuatExcelUC13.Text = "XUẤT BÁO CÁO RA EXCEL";
            this.btnXuatExcelUC13.UseVisualStyleBackColor = false;
            this.btnXuatExcelUC13.Click += new System.EventHandler(this.btnXuatExcelUC13_Click);
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.AllowUserToDeleteRows = false;
            this.dgvTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvTheLoai.ColumnHeadersHeight = 35;
            this.dgvTheLoai.Location = new System.Drawing.Point(10, 205);
            this.dgvTheLoai.MultiSelect = false;
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersWidth = 40;
            this.dgvTheLoai.RowTemplate.Height = 28;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(1172, 380);
            this.dgvTheLoai.TabIndex = 3;
            // 
            // pnlKpi
            // 
            this.pnlKpi.Controls.Add(this.pnlKpiPhat);
            this.pnlKpi.Controls.Add(this.pnlKpiQuaHan);
            this.pnlKpi.Controls.Add(this.pnlKpiDungHan);
            this.pnlKpi.Controls.Add(this.pnlKpiMuon);
            this.pnlKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpi.Location = new System.Drawing.Point(3, 110);
            this.pnlKpi.Name = "pnlKpi";
            this.pnlKpi.Size = new System.Drawing.Size(1186, 90);
            this.pnlKpi.TabIndex = 2;
            // 
            // pnlKpiPhat
            // 
            this.pnlKpiPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pnlKpiPhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiPhat.Controls.Add(this.lblValTongPhat);
            this.pnlKpiPhat.Controls.Add(this.lblTitlePhat);
            this.pnlKpiPhat.Location = new System.Drawing.Point(890, 8);
            this.pnlKpiPhat.Name = "pnlKpiPhat";
            this.pnlKpiPhat.Size = new System.Drawing.Size(280, 72);
            this.pnlKpiPhat.TabIndex = 3;
            // 
            // lblValTongPhat
            // 
            this.lblValTongPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValTongPhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValTongPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblValTongPhat.Location = new System.Drawing.Point(0, 26);
            this.lblValTongPhat.Name = "lblValTongPhat";
            this.lblValTongPhat.Size = new System.Drawing.Size(278, 44);
            this.lblValTongPhat.TabIndex = 1;
            this.lblValTongPhat.Text = "0 VNĐ";
            this.lblValTongPhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitlePhat
            // 
            this.lblTitlePhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitlePhat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.lblTitlePhat.Location = new System.Drawing.Point(0, 0);
            this.lblTitlePhat.Name = "lblTitlePhat";
            this.lblTitlePhat.Size = new System.Drawing.Size(278, 26);
            this.lblTitlePhat.TabIndex = 0;
            this.lblTitlePhat.Text = "TỔNG PHÍ PHẠT";
            this.lblTitlePhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiQuaHan
            // 
            this.pnlKpiQuaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.pnlKpiQuaHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiQuaHan.Controls.Add(this.lblValQuaHan);
            this.pnlKpiQuaHan.Controls.Add(this.lblTitleQuaHan);
            this.pnlKpiQuaHan.Location = new System.Drawing.Point(600, 8);
            this.pnlKpiQuaHan.Name = "pnlKpiQuaHan";
            this.pnlKpiQuaHan.Size = new System.Drawing.Size(270, 72);
            this.pnlKpiQuaHan.TabIndex = 2;
            // 
            // lblValQuaHan
            // 
            this.lblValQuaHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValQuaHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValQuaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(149)))), ((int)(((byte)(11)))));
            this.lblValQuaHan.Location = new System.Drawing.Point(0, 26);
            this.lblValQuaHan.Name = "lblValQuaHan";
            this.lblValQuaHan.Size = new System.Drawing.Size(268, 44);
            this.lblValQuaHan.TabIndex = 1;
            this.lblValQuaHan.Text = "0 Lượt (0%)";
            this.lblValQuaHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleQuaHan
            // 
            this.lblTitleQuaHan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleQuaHan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleQuaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(102)))), ((int)(((byte)(8)))));
            this.lblTitleQuaHan.Location = new System.Drawing.Point(0, 0);
            this.lblTitleQuaHan.Name = "lblTitleQuaHan";
            this.lblTitleQuaHan.Size = new System.Drawing.Size(268, 26);
            this.lblTitleQuaHan.TabIndex = 0;
            this.lblTitleQuaHan.Text = "QUÁ HẠN";
            this.lblTitleQuaHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiDungHan
            // 
            this.pnlKpiDungHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(234)))));
            this.pnlKpiDungHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiDungHan.Controls.Add(this.lblValDungHan);
            this.pnlKpiDungHan.Controls.Add(this.lblTitleDungHan);
            this.pnlKpiDungHan.Location = new System.Drawing.Point(310, 8);
            this.pnlKpiDungHan.Name = "pnlKpiDungHan";
            this.pnlKpiDungHan.Size = new System.Drawing.Size(270, 72);
            this.pnlKpiDungHan.TabIndex = 1;
            // 
            // lblValDungHan
            // 
            this.lblValDungHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValDungHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValDungHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.lblValDungHan.Location = new System.Drawing.Point(0, 26);
            this.lblValDungHan.Name = "lblValDungHan";
            this.lblValDungHan.Size = new System.Drawing.Size(268, 44);
            this.lblValDungHan.TabIndex = 1;
            this.lblValDungHan.Text = "0 Lượt (0%)";
            this.lblValDungHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleDungHan
            // 
            this.lblTitleDungHan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleDungHan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDungHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.lblTitleDungHan.Location = new System.Drawing.Point(0, 0);
            this.lblTitleDungHan.Name = "lblTitleDungHan";
            this.lblTitleDungHan.Size = new System.Drawing.Size(268, 26);
            this.lblTitleDungHan.TabIndex = 0;
            this.lblTitleDungHan.Text = "ĐÃ TRẢ ĐÚNG HẠN";
            this.lblTitleDungHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiMuon
            // 
            this.pnlKpiMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pnlKpiMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKpiMuon.Controls.Add(this.lblValLuotMuon);
            this.pnlKpiMuon.Controls.Add(this.lblTitleMuon);
            this.pnlKpiMuon.Location = new System.Drawing.Point(20, 8);
            this.pnlKpiMuon.Name = "pnlKpiMuon";
            this.pnlKpiMuon.Size = new System.Drawing.Size(270, 72);
            this.pnlKpiMuon.TabIndex = 0;
            // 
            // lblValLuotMuon
            // 
            this.lblValLuotMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValLuotMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValLuotMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lblValLuotMuon.Location = new System.Drawing.Point(0, 26);
            this.lblValLuotMuon.Name = "lblValLuotMuon";
            this.lblValLuotMuon.Size = new System.Drawing.Size(268, 44);
            this.lblValLuotMuon.TabIndex = 1;
            this.lblValLuotMuon.Text = "0 Lượt";
            this.lblValLuotMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleMuon
            // 
            this.lblTitleMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleMuon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitleMuon.Location = new System.Drawing.Point(0, 0);
            this.lblTitleMuon.Name = "lblTitleMuon";
            this.lblTitleMuon.Size = new System.Drawing.Size(268, 26);
            this.lblTitleMuon.TabIndex = 0;
            this.lblTitleMuon.Text = "TỔNG LƯỢT MƯỢN";
            this.lblTitleMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilterUC13
            // 
            this.pnlFilterUC13.Controls.Add(this.btnLamMoi);
            this.pnlFilterUC13.Controls.Add(this.btnXemThongKe);
            this.pnlFilterUC13.Controls.Add(this.dtpDenNgay);
            this.pnlFilterUC13.Controls.Add(this.lblDenNgay);
            this.pnlFilterUC13.Controls.Add(this.dtpTuNgay);
            this.pnlFilterUC13.Controls.Add(this.lblTuNgay);
            this.pnlFilterUC13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterUC13.Location = new System.Drawing.Point(3, 53);
            this.pnlFilterUC13.Name = "pnlFilterUC13";
            this.pnlFilterUC13.Size = new System.Drawing.Size(1186, 57);
            this.pnlFilterUC13.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(920, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 36);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXemThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongKe.ForeColor = System.Drawing.Color.White;
            this.btnXemThongKe.Location = new System.Drawing.Point(640, 10);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(250, 36);
            this.btnXemThongKe.TabIndex = 4;
            this.btnXemThongKe.Text = "Xem báo cáo thống kê";
            this.btnXemThongKe.UseVisualStyleBackColor = false;
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(440, 13);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(160, 30);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(340, 17);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(91, 23);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(120, 13);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(160, 30);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(25, 17);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(80, 23);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblHeaderUC13
            // 
            this.lblHeaderUC13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lblHeaderUC13.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderUC13.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderUC13.ForeColor = System.Drawing.Color.White;
            this.lblHeaderUC13.Location = new System.Drawing.Point(3, 3);
            this.lblHeaderUC13.Name = "lblHeaderUC13";
            this.lblHeaderUC13.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblHeaderUC13.Size = new System.Drawing.Size(1186, 50);
            this.lblHeaderUC13.TabIndex = 0;
            this.lblHeaderUC13.Text = "BÁO CÁO THỐNG KÊ HOẠT ĐỘNG THƯ VIỆN - [UC13: TaoBaoCaoThongKe]";
            this.lblHeaderUC13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabUC10
            // 
            this.tabUC10.Controls.Add(this.lblFooterUC10);
            this.tabUC10.Controls.Add(this.pnlBottomUC10);
            this.tabUC10.Controls.Add(this.dgvQuaHan);
            this.tabUC10.Controls.Add(this.grpFilterUC10);
            this.tabUC10.Controls.Add(this.lblHeaderUC10);
            this.tabUC10.Location = new System.Drawing.Point(4, 32);
            this.tabUC10.Name = "tabUC10";
            this.tabUC10.Padding = new System.Windows.Forms.Padding(3);
            this.tabUC10.Size = new System.Drawing.Size(1192, 684);
            this.tabUC10.TabIndex = 1;
            this.tabUC10.Text = "Tra cứu sách quá hạn (UC10 & UC14)";
            this.tabUC10.UseVisualStyleBackColor = true;
            // 
            // lblFooterUC10
            // 
            this.lblFooterUC10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.lblFooterUC10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooterUC10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterUC10.ForeColor = System.Drawing.Color.DimGray;
            this.lblFooterUC10.Location = new System.Drawing.Point(3, 656);
            this.lblFooterUC10.Name = "lblFooterUC10";
            this.lblFooterUC10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFooterUC10.Size = new System.Drawing.Size(1186, 25);
            this.lblFooterUC10.TabIndex = 4;
            this.lblFooterUC10.Text = "Tổng cộng: Tìm thấy 0 độc giả đang mượn quá hạn | Tổng tiền phạt tạm tính tích lũ" +
    "y: 0 VNĐ.";
            this.lblFooterUC10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottomUC10
            // 
            this.pnlBottomUC10.Controls.Add(this.btnInNoSach);
            this.pnlBottomUC10.Controls.Add(this.btnXuatExcelUC10);
            this.pnlBottomUC10.Controls.Add(this.btnGuiEmailUC14);
            this.pnlBottomUC10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomUC10.Location = new System.Drawing.Point(3, 591);
            this.pnlBottomUC10.Name = "pnlBottomUC10";
            this.pnlBottomUC10.Size = new System.Drawing.Size(1186, 65);
            this.pnlBottomUC10.TabIndex = 3;
            // 
            // btnInNoSach
            // 
            this.btnInNoSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInNoSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInNoSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInNoSach.ForeColor = System.Drawing.Color.White;
            this.btnInNoSach.Location = new System.Drawing.Point(680, 10);
            this.btnInNoSach.Name = "btnInNoSach";
            this.btnInNoSach.Size = new System.Drawing.Size(280, 45);
            this.btnInNoSach.TabIndex = 2;
            this.btnInNoSach.Text = "In thông báo nợ sách";
            this.btnInNoSach.UseVisualStyleBackColor = false;
            this.btnInNoSach.Click += new System.EventHandler(this.btnInNoSach_Click);
            // 
            // btnXuatExcelUC10
            // 
            this.btnXuatExcelUC10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnXuatExcelUC10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcelUC10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelUC10.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelUC10.Location = new System.Drawing.Point(350, 10);
            this.btnXuatExcelUC10.Name = "btnXuatExcelUC10";
            this.btnXuatExcelUC10.Size = new System.Drawing.Size(280, 45);
            this.btnXuatExcelUC10.TabIndex = 1;
            this.btnXuatExcelUC10.Text = "Xuất danh sách Excel";
            this.btnXuatExcelUC10.UseVisualStyleBackColor = false;
            this.btnXuatExcelUC10.Click += new System.EventHandler(this.btnXuatExcelUC10_Click);
            // 
            // btnGuiEmailUC14
            // 
            this.btnGuiEmailUC14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnGuiEmailUC14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiEmailUC14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiEmailUC14.ForeColor = System.Drawing.Color.White;
            this.btnGuiEmailUC14.Location = new System.Drawing.Point(20, 10);
            this.btnGuiEmailUC14.Name = "btnGuiEmailUC14";
            this.btnGuiEmailUC14.Size = new System.Drawing.Size(280, 45);
            this.btnGuiEmailUC14.TabIndex = 0;
            this.btnGuiEmailUC14.Text = "GỬI EMAIL NHẮC HẠN (UC14)";
            this.btnGuiEmailUC14.UseVisualStyleBackColor = false;
            this.btnGuiEmailUC14.Click += new System.EventHandler(this.btnGuiEmailUC14_Click);
            // 
            // dgvQuaHan
            // 
            this.dgvQuaHan.AllowUserToAddRows = false;
            this.dgvQuaHan.AllowUserToDeleteRows = false;
            this.dgvQuaHan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuaHan.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuaHan.ColumnHeadersHeight = 35;
            this.dgvQuaHan.Location = new System.Drawing.Point(10, 150);
            this.dgvQuaHan.MultiSelect = false;
            this.dgvQuaHan.Name = "dgvQuaHan";
            this.dgvQuaHan.ReadOnly = true;
            this.dgvQuaHan.RowHeadersWidth = 40;
            this.dgvQuaHan.RowTemplate.Height = 28;
            this.dgvQuaHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuaHan.Size = new System.Drawing.Size(1172, 435);
            this.dgvQuaHan.TabIndex = 2;
            // 
            // grpFilterUC10
            // 
            this.grpFilterUC10.Controls.Add(this.btnLamMoiQuaHan);
            this.grpFilterUC10.Controls.Add(this.btnTraCuuQuaHan);
            this.grpFilterUC10.Controls.Add(this.txtTimDocGia);
            this.grpFilterUC10.Controls.Add(this.lblTimDocGia);
            this.grpFilterUC10.Controls.Add(this.cboMucQuaHan);
            this.grpFilterUC10.Controls.Add(this.lblMucQuaHan);
            this.grpFilterUC10.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilterUC10.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilterUC10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.grpFilterUC10.Location = new System.Drawing.Point(3, 53);
            this.grpFilterUC10.Name = "grpFilterUC10";
            this.grpFilterUC10.Size = new System.Drawing.Size(1186, 90);
            this.grpFilterUC10.TabIndex = 1;
            this.grpFilterUC10.TabStop = false;
            this.grpFilterUC10.Text = "BỘ LỌC TRA CỨU DANH SÁCH QUÁ HẠN";
            // 
            // btnLamMoiQuaHan
            // 
            this.btnLamMoiQuaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLamMoiQuaHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiQuaHan.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiQuaHan.Location = new System.Drawing.Point(970, 32);
            this.btnLamMoiQuaHan.Name = "btnLamMoiQuaHan";
            this.btnLamMoiQuaHan.Size = new System.Drawing.Size(150, 35);
            this.btnLamMoiQuaHan.TabIndex = 5;
            this.btnLamMoiQuaHan.Text = "Làm mới";
            this.btnLamMoiQuaHan.UseVisualStyleBackColor = false;
            this.btnLamMoiQuaHan.Click += new System.EventHandler(this.btnLamMoiQuaHan_Click);
            // 
            // btnTraCuuQuaHan
            // 
            this.btnTraCuuQuaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTraCuuQuaHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraCuuQuaHan.ForeColor = System.Drawing.Color.White;
            this.btnTraCuuQuaHan.Location = new System.Drawing.Point(800, 32);
            this.btnTraCuuQuaHan.Name = "btnTraCuuQuaHan";
            this.btnTraCuuQuaHan.Size = new System.Drawing.Size(150, 35);
            this.btnTraCuuQuaHan.TabIndex = 4;
            this.btnTraCuuQuaHan.Text = "Tra cứu";
            this.btnTraCuuQuaHan.UseVisualStyleBackColor = false;
            this.btnTraCuuQuaHan.Click += new System.EventHandler(this.btnTraCuuQuaHan_Click);
            // 
            // txtTimDocGia
            // 
            this.txtTimDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDocGia.ForeColor = System.Drawing.Color.Gray;
            this.txtTimDocGia.Location = new System.Drawing.Point(540, 35);
            this.txtTimDocGia.Name = "txtTimDocGia";
            this.txtTimDocGia.Size = new System.Drawing.Size(230, 30);
            this.txtTimDocGia.TabIndex = 3;
            // 
            // lblTimDocGia
            // 
            this.lblTimDocGia.AutoSize = true;
            this.lblTimDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimDocGia.ForeColor = System.Drawing.Color.Black;
            this.lblTimDocGia.Location = new System.Drawing.Point(400, 38);
            this.lblTimDocGia.Name = "lblTimDocGia";
            this.lblTimDocGia.Size = new System.Drawing.Size(134, 23);
            this.lblTimDocGia.TabIndex = 2;
            this.lblTimDocGia.Text = "Tìm theo độc giả:";
            // 
            // cboMucQuaHan
            // 
            this.cboMucQuaHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMucQuaHan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMucQuaHan.FormattingEnabled = true;
            this.cboMucQuaHan.Location = new System.Drawing.Point(140, 35);
            this.cboMucQuaHan.Name = "cboMucQuaHan";
            this.cboMucQuaHan.Size = new System.Drawing.Size(230, 31);
            this.cboMucQuaHan.TabIndex = 1;
            // 
            // lblMucQuaHan
            // 
            this.lblMucQuaHan.AutoSize = true;
            this.lblMucQuaHan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucQuaHan.ForeColor = System.Drawing.Color.Black;
            this.lblMucQuaHan.Location = new System.Drawing.Point(20, 38);
            this.lblMucQuaHan.Name = "lblMucQuaHan";
            this.lblMucQuaHan.Size = new System.Drawing.Size(117, 23);
            this.lblMucQuaHan.TabIndex = 0;
            this.lblMucQuaHan.Text = "Mức quá hạn:";
            // 
            // lblHeaderUC10
            // 
            this.lblHeaderUC10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.lblHeaderUC10.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderUC10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderUC10.ForeColor = System.Drawing.Color.White;
            this.lblHeaderUC10.Location = new System.Drawing.Point(3, 3);
            this.lblHeaderUC10.Name = "lblHeaderUC10";
            this.lblHeaderUC10.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblHeaderUC10.Size = new System.Drawing.Size(1186, 50);
            this.lblHeaderUC10.TabIndex = 0;
            this.lblHeaderUC10.Text = "TRA CỨU VÀ THEO DÕI SÁCH MƯỢN QUÁ HẠN - [UC10: TraCuuMuonQuaHan]";
            this.lblHeaderUC10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Thống kê & Quá hạn";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tabMain.ResumeLayout(false);
            this.tabUC13.ResumeLayout(false);
            this.pnlBottomUC13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.pnlKpi.ResumeLayout(false);
            this.pnlKpiPhat.ResumeLayout(false);
            this.pnlKpiQuaHan.ResumeLayout(false);
            this.pnlKpiDungHan.ResumeLayout(false);
            this.pnlKpiMuon.ResumeLayout(false);
            this.pnlFilterUC13.ResumeLayout(false);
            this.pnlFilterUC13.PerformLayout();
            this.tabUC10.ResumeLayout(false);
            this.pnlBottomUC10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaHan)).EndInit();
            this.grpFilterUC10.ResumeLayout(false);
            this.grpFilterUC10.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabUC13;
        private System.Windows.Forms.Label lblHeaderUC13;
        private System.Windows.Forms.Panel pnlFilterUC13;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlKpi;
        private System.Windows.Forms.Panel pnlKpiMuon;
        private System.Windows.Forms.Label lblTitleMuon;
        private System.Windows.Forms.Label lblValLuotMuon;
        private System.Windows.Forms.Panel pnlKpiDungHan;
        private System.Windows.Forms.Label lblTitleDungHan;
        private System.Windows.Forms.Label lblValDungHan;
        private System.Windows.Forms.Panel pnlKpiQuaHan;
        private System.Windows.Forms.Label lblTitleQuaHan;
        private System.Windows.Forms.Label lblValQuaHan;
        private System.Windows.Forms.Panel pnlKpiPhat;
        private System.Windows.Forms.Label lblTitlePhat;
        private System.Windows.Forms.Label lblValTongPhat;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Panel pnlBottomUC13;
        private System.Windows.Forms.Button btnXuatExcelUC13;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnBieuDo;
        private System.Windows.Forms.Label lblFooterUC13;
        private System.Windows.Forms.TabPage tabUC10;
        private System.Windows.Forms.Label lblHeaderUC10;
        private System.Windows.Forms.GroupBox grpFilterUC10;
        private System.Windows.Forms.Label lblMucQuaHan;
        private System.Windows.Forms.ComboBox cboMucQuaHan;
        private System.Windows.Forms.Label lblTimDocGia;
        private System.Windows.Forms.TextBox txtTimDocGia;
        private System.Windows.Forms.Button btnTraCuuQuaHan;
        private System.Windows.Forms.Button btnLamMoiQuaHan;
        private System.Windows.Forms.DataGridView dgvQuaHan;
        private System.Windows.Forms.Panel pnlBottomUC10;
        private System.Windows.Forms.Button btnGuiEmailUC14;
        private System.Windows.Forms.Button btnXuatExcelUC10;
        private System.Windows.Forms.Button btnInNoSach;
        private System.Windows.Forms.Label lblFooterUC10;
    }
}

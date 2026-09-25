using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();
        readonly CultureInfo viCulture = new CultureInfo("vi-VN");

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            DinhDangLuoi();

            DateTime now = DateTime.Now;
            dtTu.Value = new DateTime(now.Year, now.Month, 1);
            dtDen.Value = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));

            ThucHienThongKe();
        }

        private void DinhDangLuoi()
        {
            dgvDV.EnableHeadersVisualStyles = false;
            dgvDV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 233, 246);
            dgvDV.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvDV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvDV.ColumnHeadersHeight = 30;
            dgvDV.RowTemplate.Height = 26;
            dgvDV.BackgroundColor = Color.White;
            dgvDV.BorderStyle = BorderStyle.Fixed3D;
            dgvDV.GridColor = Color.FromArgb(220, 220, 220);
            dgvDV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgvDV.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void DinhDangCotDV()
        {
            // 4 cột chuẩn ảnh Thầy: Mã DV | Tên dịch vụ | Tổng số lượng | Tổng tiền
            if (dgvDV.Columns["MaDV"] != null)
            {
                dgvDV.Columns["MaDV"].HeaderText = "Mã DV";
                dgvDV.Columns["MaDV"].FillWeight = 80;
            }
            if (dgvDV.Columns["TenDV"] != null)
            {
                dgvDV.Columns["TenDV"].HeaderText = "Tên dịch vụ";
                dgvDV.Columns["TenDV"].FillWeight = 160;
            }
            if (dgvDV.Columns["TongSoLuong"] != null)
            {
                dgvDV.Columns["TongSoLuong"].HeaderText = "Tổng số lượng";
                dgvDV.Columns["TongSoLuong"].FillWeight = 100;
                dgvDV.Columns["TongSoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDV.Columns["TongSoLuong"].DefaultCellStyle.Format = "N0";
            }
            if (dgvDV.Columns["TongTien"] != null)
            {
                dgvDV.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvDV.Columns["TongTien"].FillWeight = 120;
                dgvDV.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDV.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            DataTable dtTH = s.TongHop(dtTu.Value, dtDen.Value);
            if (dtTH.Rows.Count > 0)
            {
                var r = dtTH.Rows[0];
                int soPhieu = r["SoPhieuDat"] != DBNull.Value ? Convert.ToInt32(r["SoPhieuDat"]) : 0;
                int dangO = r["DangO"] != DBNull.Value ? Convert.ToInt32(r["DangO"]) : 0;
                int soHD = r["SoHoaDon"] != DBNull.Value ? Convert.ToInt32(r["SoHoaDon"]) : 0;
                decimal doanhThu = r["DoanhThuHoaDon"] != DBNull.Value ? Convert.ToDecimal(r["DoanhThuHoaDon"]) : 0m;
                decimal denBu = r["TongDenBu"] != DBNull.Value ? Convert.ToDecimal(r["TongDenBu"]) : 0m;

                lblPhieuDat.Text = "Phiếu đặt: " + soPhieu;
                lblDangO.Text = "Đang ở: " + dangO;
                lblHoaDon.Text = "Hóa đơn: " + soHD;
                lblDoanhThu.Text = string.Format(viCulture, "Doanh thu HĐ: {0:#,##0} đ", doanhThu);
                lblDenBu.Text = string.Format(viCulture, "Tổng đền bù: {0:#,##0} đ", denBu);
            }

            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
            DinhDangCotDV();
        }
    }
}

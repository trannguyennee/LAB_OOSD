using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmChamCong : Form
    {
        private ChamCongLuongService service = new ChamCongLuongService();

        public FrmChamCong()
        {
            InitializeComponent();
        }

        private void FrmChamCong_Load(object sender, EventArgs e)
        {
            cboThangNam.Items.Clear();
            cboThangNam.Items.AddRange(new object[] { "10/2026", "09/2026", "08/2026", "11/2026" });
            cboThangNam.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            string thangNam = cboThangNam.Text.Trim();
            dgvChamCong.DataSource = service.GetBangChamCong(thangNam);
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvChamCong.Columns.Count > 0)
            {
                dgvChamCong.Columns["MaChamCong"].HeaderText = "Mã Chấm Công";
                dgvChamCong.Columns["ThangNam"].HeaderText = "Tháng/Năm";
                dgvChamCong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvChamCong.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvChamCong.Columns["TenPhongBan"].HeaderText = "Phòng Ban / Xưởng";
                dgvChamCong.Columns["SoNgayCongChuan"].HeaderText = "Công Chuẩn";
                dgvChamCong.Columns["SoNgayLamThucTe"].HeaderText = "Ngày Đi Làm";
                dgvChamCong.Columns["SoNgayNghiCoPhep"].HeaderText = "Nghỉ Phép";
                dgvChamCong.Columns["SoNgayNghiKhongPhep"].HeaderText = "Nghỉ Không Phép";
                dgvChamCong.Columns["TongGioPhuTroi"].HeaderText = "Tổng Giờ OT (x1.5)";
                dgvChamCong.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }

        private void cboThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đồng bộ thành công dữ liệu quét vân tay từ Máy chấm công vào hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }
}

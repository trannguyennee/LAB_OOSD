using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmPhanCaPhuTroi : Form
    {
        private PhanCaPhuTroiService service = new PhanCaPhuTroiService();
        private NhanVienService nvService = new NhanVienService();

        public FrmPhanCaPhuTroi()
        {
            InitializeComponent();
        }

        private void FrmPhanCaPhuTroi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvKeHoach.DataSource = service.GetKeHoachPhanCa();
            dgvPhieuPT.DataSource = service.GetPhieuPhuTroi();

            cboNV.DataSource = nvService.GetAllNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNhanVien";

            cboHinhThuc.Items.Clear();
            cboHinhThuc.Items.AddRange(new object[] { "Tăng ca ngày thường (x1.5)", "Ngày nghỉ (x2.0)", "Ngày lễ (x3.0)" });
            cboHinhThuc.SelectedIndex = 0;

            FormatGrids();
        }

        private void FormatGrids()
        {
            if (dgvKeHoach.Columns.Count > 0)
            {
                dgvKeHoach.Columns["MaKeHoach"].HeaderText = "Mã Kế Hoạch";
                dgvKeHoach.Columns["TuanThu"].HeaderText = "Tuần";
                dgvKeHoach.Columns["TuNgay"].HeaderText = "Từ Ngày";
                dgvKeHoach.Columns["DenNgay"].HeaderText = "Đến Ngày";
                dgvKeHoach.Columns["TenPhongBan"].HeaderText = "Phòng Ban / Xưởng";
                dgvKeHoach.Columns["NguoiLap"].HeaderText = "Người Lập";
            }
            if (dgvPhieuPT.Columns.Count > 0)
            {
                dgvPhieuPT.Columns["SoPhieuPT"].HeaderText = "Số Phiếu";
                dgvPhieuPT.Columns["NgayPhuTroi"].HeaderText = "Ngày Phụ Trội";
                dgvPhieuPT.Columns["HinhThucPhuTroi"].HeaderText = "Hình Thức";
                dgvPhieuPT.Columns["HeSoPhuTroi"].HeaderText = "Hệ Số";
                dgvPhieuPT.Columns["NguoiLap"].HeaderText = "Người Lập";
            }
        }

        private void dgvKeHoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maKH = dgvKeHoach.Rows[e.RowIndex].Cells["MaKeHoach"].Value?.ToString();
                dgvChiTietPC.DataSource = service.GetChiTietPhanCa(maKH);
                if (dgvChiTietPC.Columns.Count > 0)
                {
                    dgvChiTietPC.Columns["MaNhanVien"].HeaderText = "Mã NV";
                    dgvChiTietPC.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvChiTietPC.Columns["ThuTrongTuan"].HeaderText = "Thứ";
                    dgvChiTietPC.Columns["CaLamViec"].HeaderText = "Ca Làm Việc";
                    dgvChiTietPC.Columns["GioBatDau"].HeaderText = "Bắt Đầu";
                    dgvChiTietPC.Columns["GioKetThuc"].HeaderText = "Kết Thúc";
                    dgvChiTietPC.Columns["CoPhuTroi"].HeaderText = "Có OT";
                    if (dgvChiTietPC.Columns.Contains("MaChiTietPC")) dgvChiTietPC.Columns["MaChiTietPC"].Visible = false;
                }
            }
        }

        private void dgvPhieuPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string soPhieu = dgvPhieuPT.Rows[e.RowIndex].Cells["SoPhieuPT"].Value?.ToString();
                txtSoPhieu.Text = soPhieu;
                dgvChiTietPT.DataSource = service.GetChiTietPhuTroi(soPhieu);
                if (dgvChiTietPT.Columns.Count > 0)
                {
                    dgvChiTietPT.Columns["MaNhanVien"].HeaderText = "Mã NV";
                    dgvChiTietPT.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvChiTietPT.Columns["TenPhongBan"].HeaderText = "Phòng Ban";
                    dgvChiTietPT.Columns["SoGioPhuTroi"].HeaderText = "Số Giờ OT";
                    dgvChiTietPT.Columns["NoiDungCongViec"].HeaderText = "Nội Dung";
                    if (dgvChiTietPT.Columns.Contains("MaChiTietPT")) dgvChiTietPT.Columns["MaChiTietPT"].Visible = false;
                }
            }
        }

        private void btnTaoPhieuPT_Click(object sender, EventArgs e)
        {
            string soPhieu = "PT-" + dtpNgayPT.Value.ToString("yyyyMMdd");
            string hinhThuc = cboHinhThuc.Text.Split('(')[0].Trim();
            decimal heSo = (cboHinhThuc.SelectedIndex == 0) ? 1.5m : (cboHinhThuc.SelectedIndex == 1 ? 2.0m : 3.0m);

            if (service.InsertPhieuPhuTroi(soPhieu, dtpNgayPT.Value, hinhThuc, heSo))
            {
                txtSoPhieu.Text = soPhieu;
                MessageBox.Show($"Tạo phiếu phụ trội {soPhieu} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                txtSoPhieu.Text = soPhieu;
                MessageBox.Show("Phiếu phụ trội ngày này đã tồn tại, bạn có thể thêm chi tiết nhân viên vào phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhieu.Text) || cboNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc tạo phiếu phụ trội trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = cboNV.SelectedValue.ToString();
            decimal soGio = nudSoGio.Value;
            string noiDung = txtNoiDung.Text.Trim();

            if (service.InsertChiTietPhuTroi(txtSoPhieu.Text.Trim(), maNV, soGio, noiDung))
            {
                MessageBox.Show("Ghi nhận số giờ phụ trội thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietPT.DataSource = service.GetChiTietPhuTroi(txtSoPhieu.Text.Trim());
            }
        }
    }
}

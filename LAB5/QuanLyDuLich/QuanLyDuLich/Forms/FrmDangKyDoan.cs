using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmDangKyDoan : Form
    {
        private DangKyDoanBaoHiemService service = new DangKyDoanBaoHiemService();
        private TourLichTrinhService tourService = new TourLichTrinhService();

        public FrmDangKyDoan()
        {
            InitializeComponent();
        }

        private void FrmDangKyDoan_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadPhieuDoan();
        }

        private void LoadCombos()
        {
            cboKhachDoan.DataSource = service.GetKhachHangDoan();
            cboKhachDoan.DisplayMember = "TenCoQuan";
            cboKhachDoan.ValueMember = "MaKH";

            cboTour.DataSource = tourService.GetAllTour();
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";

            cboGioiTinh.SelectedIndex = 0;
        }

        private void LoadPhieuDoan()
        {
            dgvPhieuDoan.DataSource = service.GetAllPhieuDoan();
            if (dgvPhieuDoan.Rows.Count > 0)
            {
                dgvPhieuDoan.Rows[0].Selected = true;
                LoadBaoHiem(dgvPhieuDoan.Rows[0].Cells["MaPhieuDangKy"].Value.ToString());
            }
        }

        private void dgvPhieuDoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuDoan.CurrentRow != null && dgvPhieuDoan.CurrentRow.Cells["MaPhieuDangKy"].Value != null)
            {
                string maPhieu = dgvPhieuDoan.CurrentRow.Cells["MaPhieuDangKy"].Value.ToString();
                txtMaPhieuBaoHiem.Text = maPhieu;
                LoadBaoHiem(maPhieu);
            }
        }

        private void LoadBaoHiem(string maPhieu)
        {
            dgvBaoHiem.DataSource = service.GetBaoHiemByPhieu(maPhieu);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Phiếu Đăng Ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maPhieu = txtMaPhieu.Text.Trim();
                string maKH = cboKhachDoan.SelectedValue.ToString();
                string maTour = cboTour.SelectedValue.ToString();
                DateTime ngayDi = dtpNgayDi.Value.Date;
                DateTime ngayVe = dtpNgayVe.Value.Date;
                int soKhach = (int)nudSoKhach.Value;
                string diaDiemDon = txtDiaDiemDon.Text.Trim();
                bool coBaoHiem = chkMuaBaoHiem.Checked;
                decimal tienCoc = decimal.Parse(txtTienCoc.Text.Replace(",", "").Replace(".", ""));

                if (service.LapPhieuDangKyDoan(maPhieu, maKH, maTour, ngayDi, ngayVe, soKhach, diaDiemDon, coBaoHiem, tienCoc))
                {
                    MessageBox.Show("Lập phiếu đăng ký tour theo đoàn và thu tiền cọc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuDoan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNguoiBH_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaBaoHiem.Text) || string.IsNullOrWhiteSpace(txtHoTenBH.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin người mua bảo hiểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maBH = txtMaBaoHiem.Text.Trim();
                string maPhieu = txtMaPhieuBaoHiem.Text.Trim();
                string hoTen = txtHoTenBH.Text.Trim();
                DateTime ngaySinh = dtpNgaySinh.Value.Date;
                string cccd = txtCCCD.Text.Trim();
                string gioiTinh = cboGioiTinh.Text;
                string quanHe = txtQuanHe.Text.Trim();

                if (service.ThemNguoiBaoHiem(maBH, maPhieu, hoTen, ngaySinh, cccd, gioiTinh, quanHe))
                {
                    MessageBox.Show("Thêm người tham gia bảo hiểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBaoHiem(maPhieu);
                    txtMaBaoHiem.Clear();
                    txtHoTenBH.Clear();
                    txtCCCD.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuyetToan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuDoan.CurrentRow != null && dgvPhieuDoan.CurrentRow.Cells["MaPhieuDangKy"].Value != null)
            {
                string maPhieu = dgvPhieuDoan.CurrentRow.Cells["MaPhieuDangKy"].Value.ToString();
                if (MessageBox.Show($"Xác nhận quyết toán toàn bộ kinh phí còn lại cho phiếu {maPhieu} sau khi kết thúc tour?", "Xác nhận quyết toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (service.QuyetToanKinhPhi(maPhieu))
                    {
                        MessageBox.Show("Quyết toán kinh phí đoàn hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPhieuDoan();
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmNhanVien : Form
    {
        private NhanVienService service = new NhanVienService();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            LoadData();
        }

        private void LoadComboboxes()
        {
            cboPhongBan.DataSource = service.GetAllPhongBan();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "MaPhongBan";

            cboChucVu.DataSource = service.GetAllChucVu();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Thử việc", "Chính thức", "Đã nghỉ việc" });
            cboTrangThai.SelectedIndex = 0;

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dgvNhanVien.DataSource = service.GetAllNhanVien();
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvNhanVien.Columns.Count > 0)
            {
                dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Phái";
                dgvNhanVien.Columns["CCCD"].HeaderText = "Số CCCD";
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện Thoại";
                dgvNhanVien.Columns["Email"].HeaderText = "Email";
                dgvNhanVien.Columns["TenPhongBan"].HeaderText = "Phòng Ban / Xưởng";
                dgvNhanVien.Columns["TenChucVu"].HeaderText = "Chức Vụ";
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng Thái";
                if (dgvNhanVien.Columns.Contains("MaPhongBan")) dgvNhanVien.Columns["MaPhongBan"].Visible = false;
                if (dgvNhanVien.Columns.Contains("MaChucVu")) dgvNhanVien.Columns["MaChucVu"].Visible = false;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ns))
                    dtpNgaySinh.Value = ns;
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                cboPhongBan.SelectedValue = row.Cells["MaPhongBan"].Value?.ToString();
                cboChucVu.SelectedValue = row.Cells["MaChucVu"].Value?.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "NV" + DateTime.Now.ToString("yyMMddHHmm");
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = service.InsertNhanVien(
                txtMaNV.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                cboGioiTinh.Text,
                txtCCCD.Text.Trim(),
                txtDienThoai.Text.Trim(),
                txtEmail.Text.Trim(),
                "TP.HCM",
                cboPhongBan.SelectedValue.ToString(),
                cboChucVu.SelectedValue.ToString(),
                cboTrangThai.Text
            );

            if (ok)
            {
                MessageBox.Show("Lưu thông tin nhân sự thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu hoặc mã NV/CCCD đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) return;

            bool ok = service.UpdateNhanVien(
                txtMaNV.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                cboGioiTinh.Text,
                txtCCCD.Text.Trim(),
                txtDienThoai.Text.Trim(),
                txtEmail.Text.Trim(),
                "TP.HCM",
                cboPhongBan.SelectedValue.ToString(),
                cboChucVu.SelectedValue.ToString(),
                cboTrangThai.Text
            );

            if (ok)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {txtMaNV.Text}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (service.DeleteNhanVien(txtMaNV.Text.Trim()))
                {
                    MessageBox.Show("Đã xóa nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnQDTuyenDung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để lập Quyết định tuyển dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soQD = "QDTD-" + DateTime.Now.ToString("yyyyMMdd") + "-" + txtMaNV.Text.Trim();
            decimal luongThuViec = 8500000;
            int thoiGian = 60;

            bool ok = service.InsertQuyetDinhTuyenDung(soQD, txtMaNV.Text.Trim(), thoiGian, luongThuViec, "Thử việc 60 ngày tại bộ phận tiếp nhận. Lương 85% lương chính ngạch.");
            if (ok)
            {
                MessageBox.Show($"Đã ban hành Quyết định tuyển dụng/thử việc số {soQD} cho nhân viên {txtHoTen.Text}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nhân viên này đã có Quyết định tuyển dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

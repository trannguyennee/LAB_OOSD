using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmDangKyHoSo : Form
    {
        private readonly BenhNhanService _bnService = new BenhNhanService();

        public FrmDangKyHoSo()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtMaBN.Text = _bnService.SinhMaBenhNhanMoi();
            cboGioiTinh.SelectedIndex = 0;
            dgvHoSo.DataSource = _bnService.LayTatCaHoSo();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text) || string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ: Họ tên, Số CCCD và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = _bnService.DangKyVaCapHoSo(
                txtMaBN.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                cboGioiTinh.SelectedItem.ToString(),
                txtDiaChi.Text.Trim(),
                txtSdt.Text.Trim(),
                txtCCCD.Text.Trim(),
                "avatar_3x4.jpg",
                txtTienSu.Text.Trim(),
                txtDiUng.Text.Trim(),
                nudPhiNam.Value,
                out string outMaHS,
                out string outMaPT);

            if (result == "Thành công")
            {
                MessageBox.Show($"Đăng ký thành công!\n\n- Cấp Mã Hồ Sơ: {outMaHS}\n- Mã Phiếu Thu Lệ Phí Năm: {outMaPT}\n- Đã thu phí năm: {nudPhiNam.Value:N0} VNĐ", 
                    "Thông báo cấp hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtHoTen.Clear();
                txtCCCD.Clear();
                txtSdt.Clear();
                txtDiaChi.Clear();
                txtTienSu.Clear();
                txtDiUng.Clear();
            }
            else
            {
                MessageBox.Show(result, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
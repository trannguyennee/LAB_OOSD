using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class FrmDatHang : Form
    {
        private readonly List<ItemGioHang> _danhSachHang;
        private readonly DonHangService _donHangService = new DonHangService();
        private readonly CultureInfo _vnCulture = new CultureInfo("vi-VN");

        private decimal _tongTienHang = 0;
        private decimal _phiShip = 30000;
        private decimal _tongThanhToan = 0;

        public FrmDatHang(List<ItemGioHang> danhSachHang)
        {
            InitializeComponent();
            _danhSachHang = danhSachHang ?? new List<ItemGioHang>();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            cboLoaiThe.SelectedIndex = 0; // Mặc định Visa

            // Tính tổng tiền hàng từ giỏ
            _tongTienHang = _danhSachHang.Sum(x => x.ThanhTien);
            lblTienHang.Text = _tongTienHang.ToString("N0", _vnCulture) + " đ";

            // Điền sẵn thông tin mẫu cho sinh viên demo nhanh chóng
            txtHoTen.Text = "Trần Nguyên";
            txtSoDienThoai.Text = "0908123456";
            txtEmail.Text = "trannguyen@gmail.com";
            txtDiaChi.Text = "236 Lê Trọng Tấn, P. Tây Thạnh, Q. Tân Phú, TP.HCM";

            txtTenChuThe.Text = "TRAN NGUYEN";
            txtSoThe.Text = "4532015012345678";
            txtNgayHetHan.Text = "12/28";
            txtCVV.Text = "888";

            CapNhatChiPhi();
        }

        private void radGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatChiPhi();
        }

        private string LayLoaiPhieuGiao()
        {
            if (radGiaoNhanh.Checked) return "Chuyển phát nhanh";
            if (radGiaoHoaToc.Checked) return "Chuyển phát nhanh trong ngày";
            return "Thường";
        }

        private void CapNhatChiPhi()
        {
            string loaiGiao = LayLoaiPhieuGiao();
            _phiShip = _donHangService.TinhPhiGiaoHang(loaiGiao, _tongTienHang);

            if (_phiShip == 0)
            {
                lblPhiShip.Text = "0 đ (Miễn phí vận chuyển)";
            }
            else
            {
                lblPhiShip.Text = _phiShip.ToString("N0", _vnCulture) + " đ";
            }

            _tongThanhToan = _tongTienHang + _phiShip;
            lblTongCong.Text = _tongThanhToan.ToString("N0", _vnCulture) + " đ";
        }

        private void cboLoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiThe = cboLoaiThe.SelectedItem?.ToString();
            if (loaiThe == "American Express")
            {
                txtSoThe.MaxLength = 15;
                txtCVV.MaxLength = 4;
                if (txtSoThe.Text.Length > 15) txtSoThe.Text = txtSoThe.Text.Substring(0, 15);
                if (txtCVV.Text.Length > 4) txtCVV.Text = txtCVV.Text.Substring(0, 4);
                lblGhiChuThe.Text = "* American Express: Số thẻ 15 chữ số, CVV 4 chữ số";
            }
            else
            {
                txtSoThe.MaxLength = 16;
                txtCVV.MaxLength = 3;
                if (txtSoThe.Text.Length > 16) txtSoThe.Text = txtSoThe.Text.Substring(0, 16);
                if (txtCVV.Text.Length > 3) txtCVV.Text = txtCVV.Text.Substring(0, 3);
                lblGhiChuThe.Text = $"* {loaiThe}: Số thẻ 16 chữ số, CVV 3 chữ số";
            }
        }

        private void btnXacNhanDatHang_Click(object sender, EventArgs e)
        {
            // Lấy thông tin thẻ
            var thongTinThe = new ThongTinTheTinDung
            {
                LoaiThe = cboLoaiThe.SelectedItem?.ToString(),
                TenChuThe = txtTenChuThe.Text?.Trim(),
                SoThe = txtSoThe.Text?.Trim(),
                NgayHetHan = txtNgayHetHan.Text?.Trim(),
                MaCVV = txtCVV.Text?.Trim()
            };

            // Gọi dịch vụ đặt hàng & thanh toán
            var ketQua = _donHangService.TaoVaLuuDonHang(
                txtHoTen.Text,
                txtSoDienThoai.Text,
                txtEmail.Text,
                txtDiaChi.Text,
                LayLoaiPhieuGiao(),
                _phiShip,
                _tongThanhToan,
                _danhSachHang,
                thongTinThe
            );

            if (ketQua.ThanhCong)
            {
                MessageBox.Show(
                    ketQua.ThongBao + "\n\nCảm ơn bạn đã mua hàng tại hệ thống e-SHOPPING!",
                    "Thanh Toán Thành Công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    ketQua.ThongBao,
                    "Lỗi Đặt Hàng / Thanh Toán",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

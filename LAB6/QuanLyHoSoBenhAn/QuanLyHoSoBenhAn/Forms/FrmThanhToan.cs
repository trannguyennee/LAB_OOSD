using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmThanhToan : Form
    {
        private readonly ThanhToanService _ttService = new ThanhToanService();

        public FrmThanhToan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvPhieuKham.DataSource = _ttService.LayPhieuKhamChoThanhToan();
            cboHinhThuc.SelectedIndex = 0;
            dgvHoaDon.DataSource = _ttService.LayDanhSachHoaDon();
        }

        private void dgvPhieuKham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuKham.CurrentRow != null && dgvPhieuKham.CurrentRow.Cells["MaPhieuKham"].Value != null)
            {
                string maPK = dgvPhieuKham.CurrentRow.Cells["MaPhieuKham"].Value.ToString();
                DataTable dtDetails = _ttService.TinhChiTietVienPhi(maPK, out decimal tk, out decimal txn, out decimal tt, out decimal mg, out decimal tong);

                dgvChiTiet.DataSource = dtDetails;
                lblValTienKham.Text = tk.ToString("N0") + " đ";
                lblValTienXN.Text = txn.ToString("N0") + " đ";
                lblValTienThuoc.Text = tt.ToString("N0") + " đ";
                lblValMienGiam.Text = mg.ToString("N0") + " đ" + (mg > 0 ? " (Miễn phí khám định kỳ quý!)" : "");
                lblValTongTien.Text = tong.ToString("N0") + " VNĐ";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgvPhieuKham.CurrentRow == null || dgvPhieuKham.CurrentRow.Cells["MaPhieuKham"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu khám cần thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPK = dgvPhieuKham.CurrentRow.Cells["MaPhieuKham"].Value.ToString();
            string hinhThuc = cboHinhThuc.SelectedItem.ToString();

            string res = _ttService.ThanhToanVaDongBenhAn(maPK, "TN001", hinhThuc, out string outMaHD);
            if (res == "Thành công")
            {
                MessageBox.Show($"Thanh toán viện phí thành công!\n\n- Xuất hóa đơn: {outMaHD}\n- Đã cập nhật trạng thái phiếu khám: 'Đã hoàn tất'\n- Đã đóng đợt khám và cập nhật hồ sơ bệnh án an toàn (Transaction)!", 
                    "Thanh toán hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(res, "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
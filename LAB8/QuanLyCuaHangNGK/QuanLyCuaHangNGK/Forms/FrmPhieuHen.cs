using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmPhieuHen : Form
    {
        private PhieuHenService _service = new PhieuHenService();

        public FrmPhieuHen()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvPhieuHen.DataSource = _service.GetAllPhieuHen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhanGiao_Click(object sender, EventArgs e)
        {
            if (dgvPhieuHen.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một Phiếu hẹn cần xuất giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPH = dgvPhieuHen.CurrentRow.Cells["SoPH"].Value.ToString();
            string trangThai = dgvPhieuHen.CurrentRow.Cells["TrangThai"].Value.ToString();

            if (trangThai == "Đã giao")
            {
                MessageBox.Show("Phiếu hẹn [" + soPH + "] này đã được giao rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _service.XacNhanGiaoHang(soPH);
                MessageBox.Show("Xác nhận đã giao đợt hẹn thành công! Số lượng hàng đã được tự động trừ vào tồn kho.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất giao đợt hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

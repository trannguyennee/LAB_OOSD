using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmPhieuGhiNo : Form
    {
        private PhieuGhiNoService _service = new PhieuGhiNoService();

        public FrmPhieuGhiNo()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvPGN.DataSource = _service.GetAllPhieuGhiNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phiếu ghi nợ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvPGN.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một Phiếu ghi nợ cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPGN = dgvPGN.CurrentRow.Cells["SoPGN"].Value.ToString();
            bool daTra = Convert.ToBoolean(dgvPGN.CurrentRow.Cells["DaTra"].Value);

            if (daTra)
            {
                MessageBox.Show("Phiếu ghi nợ [" + soPGN + "] này đã được tất toán rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _service.ThanhToanNo(soPGN);
                MessageBox.Show("Thu nợ và thanh toán thành công! Đã tự động giảm trừ công nợ của Khách hàng.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

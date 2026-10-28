using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmDonDatHang : Form
    {
        private DonDatHangService _ddhService = new DonDatHangService();
        private NuocGiaiKhatService _ngkService = new NuocGiaiKhatService();

        public FrmDonDatHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboNCU.DataSource = _ngkService.GetNhaCungUng();
                cboNCU.DisplayMember = "TenNCU";
                cboNCU.ValueMember = "MaNCU";

                cboNGK.DataSource = _ngkService.GetAllNGK();
                cboNGK.DisplayMember = "TenNGK";
                cboNGK.ValueMember = "MaNGK";

                dgvDDH.DataSource = _ddhService.GetAllDDH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoDDH_Click(object sender, EventArgs e)
        {
            try
            {
                string soDDH = txtSoDDH.Text.Trim();
                if (string.IsNullOrEmpty(soDDH))
                {
                    MessageBox.Show("Vui lòng nhập Số đơn đặt hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maNCU = cboNCU.SelectedValue.ToString();
                string maNGK = cboNGK.SelectedValue.ToString();
                int sl = (int)nudSLDat.Value;
                decimal gia = nudGiaNhap.Value;

                var items = new List<ChiTietNhapDto>
                {
                    new ChiTietNhapDto { MaNGK = maNGK, SoLuong = sl, DonGia = gia }
                };

                _ddhService.TaoDonDatHang(soDDH, dtpNgayNhan.Value, maNCU, "NV01", items);
                MessageBox.Show("Lập Đơn đặt hàng thành công! Đã gửi đến Nhà cung ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo ĐĐH: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kiểm tra và nhận giao hàng theo đợt (Tối đa 3 đợt)
        private void btnNhanGiaoHang_Click(object sender, EventArgs e)
        {
            if (dgvDDH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một Đơn đặt hàng từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soDDH = dgvDDH.CurrentRow.Cells["SoDDH"].Value.ToString();
            int soDotDaGiao = Convert.ToInt32(dgvDDH.CurrentRow.Cells["SoDotDaGiao"].Value);

            // Kiểm tra quy tắc nghiệp vụ: Mỗi ĐĐH giao tối đa 3 đợt
            if (soDotDaGiao >= 3)
            {
                MessageBox.Show("RÀNG BUỘC NGHIỆP VỤ BỊ CHẶN (Test Case 05):\nĐơn đặt hàng [" + soDDH + "] này ĐÃ GIAO ĐỦ TỐI ĐA 3 ĐỢT!\nHệ thống không cho phép nhận thêm bất kỳ đợt giao nào nữa.", "Chặn vi phạm nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                string soPGH = "PGH_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string maNGK = cboNGK.SelectedValue.ToString();
                int slGiao = (int)nudSLGiao.Value;
                decimal giaGiao = nudGiaNhap.Value;
                decimal tongTienPGH = slGiao * giaGiao;

                var chiTietGiao = new List<ChiTietNhapDto>
                {
                    new ChiTietNhapDto { MaNGK = maNGK, SoLuong = slGiao, DonGia = giaGiao }
                };

                _ddhService.TiepNhanPhieuGiaoHang(soPGH, soDDH, "NV03", tongTienPGH, chiTietGiao);

                int dotMoi = soDotDaGiao + 1;
                MessageBox.Show("Tiếp nhận Phiếu giao hàng thành công!\n- Số PGH: " + soPGH + "\n- Đợt giao: " + dotMoi + "/3\n- Tồn kho của mặt hàng đã được tự động cộng thêm " + slGiao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                dgvDDH_CellClick(null, new DataGridViewCellEventArgs(0, dgvDDH.CurrentRow.Index));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tiếp nhận giao hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string soDDH = dgvDDH.Rows[e.RowIndex].Cells["SoDDH"].Value.ToString();
                dgvCTDDH.DataSource = _ddhService.GetChiTietDDH(soDDH);
                dgvPGH.DataSource = _ddhService.GetPhieuGiaoHangByDDH(soDDH);
            }
        }
    }
}

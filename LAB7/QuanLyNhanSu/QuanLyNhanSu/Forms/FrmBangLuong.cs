using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmBangLuong : Form
    {
        private ChamCongLuongService service = new ChamCongLuongService();

        public FrmBangLuong()
        {
            InitializeComponent();
        }

        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            cboThangNam.Items.Clear();
            cboThangNam.Items.AddRange(new object[] { "10/2026", "09/2026", "08/2026", "11/2026" });
            cboThangNam.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            string thangNam = cboThangNam.Text.Trim();
            dgvBangLuong.DataSource = service.GetBangLuongThang(thangNam);
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvBangLuong.Columns.Count > 0)
            {
                dgvBangLuong.Columns["MaBangLuong"].HeaderText = "Mã Bảng Lương";
                dgvBangLuong.Columns["ThangNam"].HeaderText = "Tháng/Năm";
                dgvBangLuong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvBangLuong.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvBangLuong.Columns["TenPhongBan"].HeaderText = "Phòng Ban";
                dgvBangLuong.Columns["TenChucVu"].HeaderText = "Chức Vụ";
                dgvBangLuong.Columns["LuongCoBan"].HeaderText = "Lương CB";
                dgvBangLuong.Columns["LuongThucTeTheoCong"].HeaderText = "Lương Thực Tế";
                dgvBangLuong.Columns["PhuCapChucVu"].HeaderText = "PC Chức Vụ";
                dgvBangLuong.Columns["PhuCapDocHai"].HeaderText = "PC Độc Hại";
                dgvBangLuong.Columns["TienPhuTroi"].HeaderText = "Tiền OT (x1.5)";
                dgvBangLuong.Columns["TienKhenThuong"].HeaderText = "Tiền Thưởng";
                dgvBangLuong.Columns["TienPhatKyLuat"].HeaderText = "Tiền Phạt";
                dgvBangLuong.Columns["TienBaoHiem"].HeaderText = "Trừ BH (10.5%)";
                dgvBangLuong.Columns["ThucLinh"].HeaderText = "THỰC LĨNH";
                dgvBangLuong.Columns["ThucLinh"].DefaultCellStyle.Font = new Font("Times New Roman", 10.5f, FontStyle.Bold);
                dgvBangLuong.Columns["ThucLinh"].DefaultCellStyle.ForeColor = Color.DarkGreen;
                dgvBangLuong.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
        }

        private void cboThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            string thangNam = cboThangNam.Text.Trim();
            service.TinhLuongToanCongTy(thangNam);
            MessageBox.Show($"Đã tính toán hoàn tất bảng lương toàn công ty tháng {thangNam} theo đúng quy chế lương, phụ cấp độc hại và tiền phụ trội!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnInPhieuLuong_Click(object sender, EventArgs e)
        {
            if (dgvBangLuong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trong bảng lương để xem phiếu lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow r = dgvBangLuong.CurrentRow;
            string slip = "========================================================\n" +
                          "             CÔNG TY CỔ PHẦN SƠN ĐÔNG Á\n" +
                          "          PHIẾU LƯƠNG CÁ NHÂN (PAY SLIP)\n" +
                          "========================================================\n" +
                          $"Kỳ lương: {r.Cells["ThangNam"].Value}\n" +
                          $"Mã nhân viên: {r.Cells["MaNhanVien"].Value}   -   Họ tên: {r.Cells["HoTen"].Value}\n" +
                          $"Đơn vị: {r.Cells["TenPhongBan"].Value}   -   Chức vụ: {r.Cells["TenChucVu"].Value}\n" +
                          "--------------------------------------------------------\n" +
                          $"1. Lương cơ bản:           {Convert.ToDecimal(r.Cells["LuongCoBan"].Value):N0} VNĐ\n" +
                          $"2. Lương thực tế (công):   {Convert.ToDecimal(r.Cells["LuongThucTeTheoCong"].Value):N0} VNĐ\n" +
                          $"3. Phụ cấp chức vụ:        {Convert.ToDecimal(r.Cells["PhuCapChucVu"].Value):N0} VNĐ\n" +
                          $"4. Phụ cấp độc hại:        {Convert.ToDecimal(r.Cells["PhuCapDocHai"].Value):N0} VNĐ\n" +
                          $"5. Tiền phụ trội (OT x1.5): {Convert.ToDecimal(r.Cells["TienPhuTroi"].Value):N0} VNĐ\n" +
                          $"6. Khen thưởng:            {Convert.ToDecimal(r.Cells["TienKhenThuong"].Value):N0} VNĐ\n" +
                          $"7. Khấu trừ vi phạm:       {Convert.ToDecimal(r.Cells["TienPhatKyLuat"].Value):N0} VNĐ\n" +
                          $"8. Trích trừ BHXH/BHYT:    {Convert.ToDecimal(r.Cells["TienBaoHiem"].Value):N0} VNĐ\n" +
                          "--------------------------------------------------------\n" +
                          $"===> THỰC LĨNH:            {Convert.ToDecimal(r.Cells["ThucLinh"].Value):N0} VNĐ\n" +
                          "========================================================\n" +
                          "Người lập phiếu: Phòng Kế Toán     -     Giám đốc duyệt";

            MessageBox.Show(slip, "Phiếu Lương Cá Nhân (Pay Slip)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

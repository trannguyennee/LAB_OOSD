using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmKhenThuongKyLuat : Form
    {
        private KhenThuongKyLuatService service = new KhenThuongKyLuatService();
        private NhanVienService nvService = new NhanVienService();

        public FrmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void FrmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            LoadData();
        }

        private void LoadComboboxes()
        {
            cboNhanVien.DataSource = nvService.GetAllNhanVien();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";

            cboHinhThucChi.Items.Clear();
            cboHinhThucChi.Items.AddRange(new object[] { "Chi tiền mặt", "Cộng vào bảng lương" });
            cboHinhThucChi.SelectedIndex = 0;

            cboLoaiKT.Items.Clear();
            cboLoaiKT.Items.AddRange(new object[] { "Cá nhân", "Tập thể" });
            cboLoaiKT.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dgvKhenThuong.DataSource = service.GetAllQuyetDinhKhenThuong();
            dgvPhieuChi.DataSource = service.GetAllPhieuChiKhenThuong();
            dgvKyLuat.DataSource = service.GetAllQuyetDinhKyLuat();
            FormatGrids();
        }

        private void FormatGrids()
        {
            if (dgvKhenThuong.Columns.Count > 0)
            {
                dgvKhenThuong.Columns["SoQuyetDinhKT"].HeaderText = "Số QĐ Khen Thưởng";
                dgvKhenThuong.Columns["NgayQuyetDinh"].HeaderText = "Ngày QĐ";
                dgvKhenThuong.Columns["LoaiKhenThuong"].HeaderText = "Loại KT";
                dgvKhenThuong.Columns["TenDoiTuong"].HeaderText = "Đối Tượng Khen Thưởng";
                dgvKhenThuong.Columns["LyDoKhenThuong"].HeaderText = "Lý Do";
                dgvKhenThuong.Columns["SoTienThuong"].HeaderText = "Tiền Thưởng";
                dgvKhenThuong.Columns["HinhThucChi"].HeaderText = "Hình Thức Chi";
                dgvKhenThuong.Columns["TrangThaiChi"].HeaderText = "Trạng Thái";
            }
            if (dgvPhieuChi.Columns.Count > 0)
            {
                dgvPhieuChi.Columns["SoPhieuChi"].HeaderText = "Số Phiếu Chi";
                dgvPhieuChi.Columns["SoQuyetDinhKT"].HeaderText = "Theo QĐ Khen Thưởng";
                dgvPhieuChi.Columns["NgayChi"].HeaderText = "Ngày Chi";
                dgvPhieuChi.Columns["SoTienChi"].HeaderText = "Số Tiền";
                dgvPhieuChi.Columns["NguoiNhan"].HeaderText = "Người Nhận Tiền";
                dgvPhieuChi.Columns["NguoiChiTien"].HeaderText = "Thủ Quỹ Chi";
            }
            if (dgvKyLuat.Columns.Count > 0)
            {
                dgvKyLuat.Columns["SoQuyetDinhKL"].HeaderText = "Số QĐ Kỷ Luật";
                dgvKyLuat.Columns["NgayQuyetDinh"].HeaderText = "Ngày QĐ";
                dgvKyLuat.Columns["LoaiKyLuat"].HeaderText = "Loại KL";
                dgvKyLuat.Columns["TenDoiTuong"].HeaderText = "Đối Tượng Vi Phạm";
                dgvKyLuat.Columns["LyDoKyLuat"].HeaderText = "Lý Do Vi Phạm";
                dgvKyLuat.Columns["HinhThucPhat"].HeaderText = "Hình Thức Xử Lý";
                dgvKyLuat.Columns["SoTienPhat"].HeaderText = "Tiền Phạt";
                dgvKyLuat.Columns["TrangThaiThu"].HeaderText = "Trạng Thái";
            }
        }

        private void btnLapQDKhenThuong_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null) return;
            string maNV = cboNhanVien.SelectedValue.ToString();
            string soQD = "QDKT-" + DateTime.Now.ToString("yyMMddHHmm");
            string lyDo = txtLyDo.Text.Trim();
            if (string.IsNullOrEmpty(lyDo)) lyDo = "Hoàn thành xuất sắc nhiệm vụ sản xuất";
            decimal soTien = nudSoTien.Value;
            string hinhThuc = cboHinhThucChi.Text;

            // Khớp với Sequence Diagram Câu 6
            bool ok = service.LapQuyetDinhKhenThuong(soQD, cboLoaiKT.Text, maNV, lyDo, soTien, hinhThuc, "Giám đốc");
            if (ok)
            {
                string msg = $"Lập Quyết định khen thưởng số {soQD} thành công!";
                if (hinhThuc == "Chi tiền mặt")
                    msg += "\n(Hệ thống đã tự động xuất Phiếu chi khen thưởng tiền mặt)";
                else
                    msg += "\n(Khoản tiền thưởng sẽ được cộng vào kỳ tính lương tháng tiếp theo)";

                MessageBox.Show(msg, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi lập quyết định khen thưởng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLapQDKyLuat_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null) return;
            string maNV = cboNhanVien.SelectedValue.ToString();
            string soQD = "QDKL-" + DateTime.Now.ToString("yyMMddHHmm");
            string lyDo = "Vi phạm an toàn lao động / Nội quy phân xưởng sơn";
            decimal soTien = 500000;
            string hinhThuc = "Trừ vào bảng lương";

            if (service.LapQuyetDinhKyLuat(soQD, "Cá nhân", maNV, lyDo, hinhThuc, soTien, "Giám đốc"))
            {
                MessageBox.Show($"Lập Quyết định kỷ luật {soQD} thành công! Khoản phạt 500,000đ sẽ được trừ vào bảng lương tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}

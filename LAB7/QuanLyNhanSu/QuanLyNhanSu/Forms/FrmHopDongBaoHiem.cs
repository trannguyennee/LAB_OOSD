using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmHopDongBaoHiem : Form
    {
        private HopDongBaoHiemService service = new HopDongBaoHiemService();
        private NhanVienService nvService = new NhanVienService();

        public FrmHopDongBaoHiem()
        {
            InitializeComponent();
        }

        private void FrmHopDongBaoHiem_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            LoadData();
        }

        private void LoadComboboxes()
        {
            cboNhanVien.DataSource = nvService.GetAllNhanVien();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";

            cboLoaiHD.Items.Clear();
            cboLoaiHD.Items.AddRange(new object[] { "Dài hạn", "Ngắn hạn", "Không xác định thời hạn" });
            cboLoaiHD.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dgvHopDong.DataSource = service.GetAllHopDong();
            dgvBaoHiem.DataSource = service.GetAllBaoHiem();
            dgvQDLuong.DataSource = service.GetAllQuyetDinhLuong();
            FormatGrids();
        }

        private void FormatGrids()
        {
            if (dgvHopDong.Columns.Count > 0)
            {
                dgvHopDong.Columns["SoHopDong"].HeaderText = "Số HĐLĐ";
                dgvHopDong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvHopDong.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvHopDong.Columns["TenPhongBan"].HeaderText = "Bộ Phận";
                dgvHopDong.Columns["LoaiHopDong"].HeaderText = "Loại HĐ";
                dgvHopDong.Columns["NgayBatDau"].HeaderText = "Từ Ngày";
                dgvHopDong.Columns["NgayKetThuc"].HeaderText = "Đến Ngày";
                dgvHopDong.Columns["LuongThoaThuan"].HeaderText = "Lương HĐ";
                dgvHopDong.Columns["CoBaoHiem"].HeaderText = "Đóng BH";
            }
            if (dgvBaoHiem.Columns.Count > 0)
            {
                dgvBaoHiem.Columns["MaHoSoBH"].HeaderText = "Mã Hồ Sơ";
                dgvBaoHiem.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvBaoHiem.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvBaoHiem.Columns["SoTheBHYT"].HeaderText = "Thẻ BHYT";
                dgvBaoHiem.Columns["MaSoBHXH"].HeaderText = "Mã BHXH";
                dgvBaoHiem.Columns["MucDongBHXH"].HeaderText = "Mức Lương Đóng";
                dgvBaoHiem.Columns["TyLeDongNV"].HeaderText = "% Đóng";
            }
            if (dgvQDLuong.Columns.Count > 0)
            {
                dgvQDLuong.Columns["SoQuyetDinhL"].HeaderText = "Số QĐ Lương";
                dgvQDLuong.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvQDLuong.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvQDLuong.Columns["TenPhongBan"].HeaderText = "Phòng Ban";
                dgvQDLuong.Columns["LuongCoBan"].HeaderText = "Lương Cơ Bản";
                dgvQDLuong.Columns["PhuCapDocHai"].HeaderText = "Phụ Cấp Độc Hại";
                dgvQDLuong.Columns["NgayHieuLuc"].HeaderText = "Hiệu Lực";
            }
        }

        private void cboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkCoBaoHiem.Checked = (cboLoaiHD.Text != "Ngắn hạn");
        }

        private void btnKyHD_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null) return;
            string maNV = cboNhanVien.SelectedValue.ToString();
            string soHD = "HDLD-" + DateTime.Now.ToString("yyMMdd") + "-" + maNV;
            decimal luong = nudLuong.Value;
            bool coBH = chkCoBaoHiem.Checked;
            DateTime? ngayKT = (cboLoaiHD.Text == "Không xác định thời hạn") ? (DateTime?)null : dtpDenNgay.Value;

            bool ok = service.InsertHopDong(soHD, maNV, cboLoaiHD.Text, dtpTuNgay.Value, ngayKT, luong, coBH);
            if (ok)
            {
                if (coBH)
                {
                    string maBH = "BH-" + maNV;
                    string soBHYT = "DN4790" + maNV;
                    string soBHXH = "79" + DateTime.Now.ToString("yy") + maNV.Replace("NV", "");
                    service.InsertHoSoBaoHiem(maBH, maNV, soBHYT, soBHXH, luong);
                }

                decimal phuCapDocHai = chkDocHai.Checked ? nudDocHai.Value : 0;
                string soQDL = "QDL-" + maNV;
                service.InsertQuyetDinhLuong(soQDL, maNV, luong, phuCapDocHai);

                MessageBox.Show($"Ký hợp đồng và thiết lập chế độ thành công cho nhân viên {maNV}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi khi ký hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

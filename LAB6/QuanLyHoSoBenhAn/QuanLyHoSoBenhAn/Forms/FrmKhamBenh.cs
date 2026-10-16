using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKhamBenh : Form
    {
        private readonly KhamBenhService _kbService = new KhamBenhService();
        private readonly BenhNhanService _bnService = new BenhNhanService();

        public FrmKhamBenh()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtMaPK.Text = _kbService.SinhMaPhieuKhamMoi();

            cboHoSo.DataSource = _bnService.LayTatCaHoSo();
            cboHoSo.DisplayMember = "MaHoSo";
            cboHoSo.ValueMember = "MaHoSo";

            cboBacSi.DataSource = _kbService.LayDanhSachBacSi();
            cboBacSi.DisplayMember = "HoTen";
            cboBacSi.ValueMember = "MaNhanVien";

            cboXetNghiem.DataSource = _kbService.LayDanhSachXetNghiem();
            cboXetNghiem.DisplayMember = "TenXetNghiem";
            cboXetNghiem.ValueMember = "MaXetNghiem";

            cboThuoc.DataSource = _kbService.LayDanhSachThuoc();
            cboThuoc.DisplayMember = "TenThuoc";
            cboThuoc.ValueMember = "MaThuoc";

            chkCoXetNghiem.Checked = true;
            chkCoKeToa.Checked = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrieuChung.Text) || string.IsNullOrWhiteSpace(txtChanDoan.Text))
            {
                MessageBox.Show("Vui lòng nhập triệu chứng lâm sàng và chẩn đoán cuối cùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPK = txtMaPK.Text.Trim();
            string maHS = cboHoSo.SelectedValue.ToString();
            string maBS = cboBacSi.SelectedValue.ToString();
            string khoa = txtKhoa.Text.Trim();
            string trieuChung = txtTrieuChung.Text.Trim();
            decimal thanNhiet = nudThanNhiet.Value;
            string huyetAp = txtHuyetAp.Text.Trim();
            string chanDoan = txtChanDoan.Text.Trim();

            string maCD = chkCoXetNghiem.Checked ? ("CD" + maPK.Substring(2)) : null;
            string maXN = chkCoXetNghiem.Checked ? cboXetNghiem.SelectedValue.ToString() : null;
            string chiSoKQ = chkCoXetNghiem.Checked ? txtChiSoKQ.Text.Trim() : null;

            string maToa = chkCoKeToa.Checked ? ("TT" + maPK.Substring(2)) : null;
            string maThuoc = chkCoKeToa.Checked ? cboThuoc.SelectedValue.ToString() : null;
            int soLuong = chkCoKeToa.Checked ? (int)nudSoLuong.Value : 0;
            string cachDung = chkCoKeToa.Checked ? txtCachDung.Text.Trim() : null;

            string res = _kbService.KhamBenhVaKeToa(
                maPK, maHS, maBS, khoa, trieuChung, thanNhiet, huyetAp, chanDoan,
                maCD, maXN, chiSoKQ, maToa, maThuoc, soLuong, cachDung);

            if (res == "Thành công")
            {
                MessageBox.Show($"Lập phiếu khám {maPK} thành công!\n\n- Đã liên kết Phiếu khám với Xét nghiệm và Toa thuốc.\n- Trừ tồn kho thuốc thành công trong Transaction.", 
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLichSu.DataSource = _kbService.LayLichSuCacLanKham(maHS);
                txtMaPK.Text = _kbService.SinhMaPhieuKhamMoi();
            }
            else
            {
                MessageBox.Show(res, "Lỗi khám bệnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboHoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHoSo.SelectedValue != null)
            {
                string maHS = cboHoSo.SelectedValue.ToString();
                dgvLichSu.DataSource = _kbService.LayLichSuCacLanKham(maHS);
            }
        }
    }
}
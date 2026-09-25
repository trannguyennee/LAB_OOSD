using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        private readonly PhongTienNghiService s = new PhongTienNghiService();
        private readonly DanhMucService dm = new DanhMucService();

        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            NapComboBox();
            TaiDuLieu();
        }

        private void NapComboBox()
        {
            // Nạp khu vực
            cboKhu.DataSource = dm.LayKhuVuc();
            cboKhu.DisplayMember = "Ten";
            cboKhu.ValueMember = "Ma";

            // Nạp loại tiện nghi
            cboLoai.DataSource = dm.LayLoaiTienNghi();
            cboLoai.DisplayMember = "TenLoaiTN";
            cboLoai.ValueMember = "MaLoaiTN";

            // Nạp tiện nghi cho tab lắp đặt và quick bar
            var dtTN = s.LayTienNghi();
            cboTN.DataSource = dtTN;
            cboTN.DisplayMember = "MaTienNghi";
            cboTN.ValueMember = "MaTienNghi";

            cboTNQuick.DataSource = dtTN.Copy();
            cboTNQuick.DisplayMember = "MaTienNghi";
            cboTNQuick.ValueMember = "MaTienNghi";

            // Nạp phòng cho tab lắp đặt và quick bar
            var dtPhong = s.LayPhong();
            cboPhong.DataSource = dtPhong;
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "SoPhong";

            cboPhongQuick.DataSource = dtPhong.Copy();
            cboPhongQuick.DisplayMember = "SoPhong";
            cboPhongQuick.ValueMember = "SoPhong";

            // Nạp nhân viên cho tab lắp đặt
            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "Ten";
            cboNV.ValueMember = "Ma";
        }

        private void TaiDuLieu()
        {
            // 1. Phòng
            dgvPhong.DataSource = s.LayPhong();
            DinhDangPhong(dgvPhong);

            // 2. Tiện nghi
            dgvTN.DataSource = s.LayTienNghi();
            DinhDangTN(dgvTN);

            // 3. Lắp đặt
            dgvLD.DataSource = s.LayLapDat();
            DinhDangLD(dgvLD);
        }

        private void DinhDangPhong(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 238, 248);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 32;

            if (dgv.Columns.Contains("SoPhong")) { dgv.Columns["SoPhong"].HeaderText = "Phòng"; dgv.Columns["SoPhong"].FillWeight = 100; }
            if (dgv.Columns.Contains("TenKhuVuc")) { dgv.Columns["TenKhuVuc"].HeaderText = "Khu"; dgv.Columns["TenKhuVuc"].FillWeight = 100; }
            if (dgv.Columns.Contains("SoNguoiToiDa")) { dgv.Columns["SoNguoiToiDa"].HeaderText = "Sức chứa"; dgv.Columns["SoNguoiToiDa"].FillWeight = 90; }
            if (dgv.Columns.Contains("DonGiaNgay"))
            {
                dgv.Columns["DonGiaNgay"].HeaderText = "Đơn giá";
                dgv.Columns["DonGiaNgay"].FillWeight = 120;
                dgv.Columns["DonGiaNgay"].DefaultCellStyle.Format = "N0";
                dgv.Columns["DonGiaNgay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgv.Columns.Contains("TrangThai")) { dgv.Columns["TrangThai"].HeaderText = "Trạng thái"; dgv.Columns["TrangThai"].FillWeight = 110; }
            if (dgv.Columns.Contains("MaKhuVuc")) dgv.Columns["MaKhuVuc"].Visible = false;
        }

        private void DinhDangTN(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 238, 248);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 32;

            if (dgv.Columns.Contains("MaTienNghi")) { dgv.Columns["MaTienNghi"].HeaderText = "Mã tiện nghi"; dgv.Columns["MaTienNghi"].FillWeight = 120; }
            if (dgv.Columns.Contains("TenLoaiTN")) { dgv.Columns["TenLoaiTN"].HeaderText = "Loại tiện nghi"; dgv.Columns["TenLoaiTN"].FillWeight = 150; }
            if (dgv.Columns.Contains("SoThuTu")) { dgv.Columns["SoThuTu"].HeaderText = "Số thứ tự"; dgv.Columns["SoThuTu"].FillWeight = 90; }
            if (dgv.Columns.Contains("TinhTrangHienTai")) { dgv.Columns["TinhTrangHienTai"].HeaderText = "Tình trạng hiện tại"; dgv.Columns["TinhTrangHienTai"].FillWeight = 150; }
            if (dgv.Columns.Contains("MaLoaiTN")) dgv.Columns["MaLoaiTN"].Visible = false;
        }

        private void DinhDangLD(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 238, 248);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 32;

            if (dgv.Columns.Contains("SoPhieuLapDat")) { dgv.Columns["SoPhieuLapDat"].HeaderText = "Số phiếu"; dgv.Columns["SoPhieuLapDat"].FillWeight = 100; }
            if (dgv.Columns.Contains("MaTienNghi")) { dgv.Columns["MaTienNghi"].HeaderText = "Mã TN"; dgv.Columns["MaTienNghi"].FillWeight = 90; }
            if (dgv.Columns.Contains("TenLoaiTN")) { dgv.Columns["TenLoaiTN"].HeaderText = "Loại tiện nghi"; dgv.Columns["TenLoaiTN"].FillWeight = 120; }
            if (dgv.Columns.Contains("SoPhong")) { dgv.Columns["SoPhong"].HeaderText = "Phòng"; dgv.Columns["SoPhong"].FillWeight = 90; }
            if (dgv.Columns.Contains("NgayLap"))
            {
                dgv.Columns["NgayLap"].HeaderText = "Ngày lập";
                dgv.Columns["NgayLap"].FillWeight = 110;
                dgv.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgv.Columns.Contains("TinhTrang")) { dgv.Columns["TinhTrang"].HeaderText = "Tình trạng"; dgv.Columns["TinhTrang"].FillWeight = 110; }
            if (dgv.Columns.Contains("TenNV")) { dgv.Columns["TenNV"].HeaderText = "Nhân viên"; dgv.Columns["TenNV"].FillWeight = 130; }
            if (dgv.Columns.Contains("GhiChu")) { dgv.Columns["GhiChu"].HeaderText = "Ghi chú"; dgv.Columns["GhiChu"].FillWeight = 140; }
            if (dgv.Columns.Contains("MaNV")) dgv.Columns["MaNV"].Visible = false;
        }

        private string LayGiaTriCombo(ComboBox c)
        {
            return c.SelectedValue != null ? c.SelectedValue.ToString() : "";
        }

        private void HienThiKetQua(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK,
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (k.ThanhCong)
            {
                TaiDuLieu();
                NapComboBox();
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.ThemPhong(txtPhong.Text.Trim(), LayGiaTriCombo(cboKhu), (int)numMax.Value, numGia.Value));
            if (!string.IsNullOrWhiteSpace(txtPhong.Text))
            {
                txtPhong.Clear();
            }
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.ThemTienNghi(txtMaTN.Text.Trim(), LayGiaTriCombo(cboLoai), (int)numSTT.Value, txtTinhTrang.Text.Trim()));
            if (!string.IsNullOrWhiteSpace(txtMaTN.Text))
            {
                txtMaTN.Clear();
                numSTT.Value++;
            }
        }

        private void btnLapDat_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.LapDat(txtSoLD.Text.Trim(), LayGiaTriCombo(cboTN), LayGiaTriCombo(cboPhong), dtNgay.Value, txtTTLD.Text.Trim(), LayGiaTriCombo(cboNV), txtGhiChu.Text.Trim()));
            if (!string.IsNullOrWhiteSpace(txtSoLD.Text))
            {
                txtSoLD.Clear();
                txtGhiChu.Clear();
            }
        }

        private void btnLapDatQuick_Click(object sender, EventArgs e)
        {
            string maNV = "NV02";
            HienThiKetQua(s.LapDat(txtSoLDQuick.Text.Trim(), LayGiaTriCombo(cboTNQuick), LayGiaTriCombo(cboPhongQuick), DateTime.Now, txtTTLDQuick.Text.Trim(), maNV, "Lắp đặt tại phòng"));
            if (!string.IsNullOrWhiteSpace(txtSoLDQuick.Text))
            {
                txtSoLDQuick.Clear();
            }
        }
    }
}

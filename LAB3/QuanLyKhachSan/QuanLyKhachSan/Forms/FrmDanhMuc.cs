using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        // Định dạng chuẩn 5 cột y hệt ảnh thầy: Mã | Tên | Loại / Vai trò | Đơn vị | Đơn giá / Mức
        private void DinhDang5Cot(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 238, 248);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 32;

            if (dgv.Columns.Contains("Ma"))
            {
                dgv.Columns["Ma"].HeaderText = "Mã";
                dgv.Columns["Ma"].FillWeight = 85;
            }
            if (dgv.Columns.Contains("Ten"))
            {
                dgv.Columns["Ten"].HeaderText = "Tên";
                dgv.Columns["Ten"].FillWeight = 160;
            }
            if (dgv.Columns.Contains("LoaiVaiTro"))
            {
                dgv.Columns["LoaiVaiTro"].HeaderText = "Loại / Vai trò";
                dgv.Columns["LoaiVaiTro"].FillWeight = 140;
            }
            if (dgv.Columns.Contains("DonVi"))
            {
                dgv.Columns["DonVi"].HeaderText = "Đơn vị";
                dgv.Columns["DonVi"].FillWeight = 110;
            }
            if (dgv.Columns.Contains("DonGiaMuc"))
            {
                dgv.Columns["DonGiaMuc"].HeaderText = "Đơn giá / Mức";
                dgv.Columns["DonGiaMuc"].FillWeight = 130;
                dgv.Columns["DonGiaMuc"].DefaultCellStyle.Format = "N0";
                dgv.Columns["DonGiaMuc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Ẩn các cột phụ không cần hiển thị trên lưới nếu có
            if (dgv.Columns.Contains("MaLoaiTN")) dgv.Columns["MaLoaiTN"].Visible = false;
            if (dgv.Columns.Contains("TenLoaiTN")) dgv.Columns["TenLoaiTN"].Visible = false;
        }

        // Nạp lại toàn bộ dữ liệu lên 5 tab
        private void TaiDuLieu()
        {
            // 1. Khu vực
            dgvKhu.DataSource = s.LayKhuVuc();
            DinhDang5Cot(dgvKhu);

            // 2. Nhân viên
            dgvNV.DataSource = s.LayNhanVien();
            DinhDang5Cot(dgvNV);

            // 3. Loại tiện nghi
            dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
            DinhDang5Cot(dgvLoaiTN);

            // 4. Dịch vụ
            dgvDV.DataSource = s.LayDichVu();
            DinhDang5Cot(dgvDV);

            // 5. Quy định đền bù
            dgvQD.DataSource = s.LayQuyDinhDenBu();
            DinhDang5Cot(dgvQD);

            // Nạp dữ liệu vào ComboBox Loại tiện nghi ở tab Quy định
            cboQDLoai.DataSource = s.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";
        }

        // Hàm thông báo kết quả
        private void HienThiKetQua(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK,
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (k.ThanhCong)
            {
                TaiDuLieu();
            }
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim()));
            if (!string.IsNullOrWhiteSpace(txtKhuMa.Text))
            {
                txtKhuMa.Clear();
                txtKhuTen.Clear();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(),
                txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
            if (!string.IsNullOrWhiteSpace(txtNVMa.Text))
            {
                txtNVMa.Clear();
                txtNVTen.Clear();
                txtNVVaiTro.Clear();
                txtNVSDT.Clear();
            }
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim()));
            if (!string.IsNullOrWhiteSpace(txtLoaiMa.Text))
            {
                txtLoaiMa.Clear();
                txtLoaiTen.Clear();
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            HienThiKetQua(s.ThemDichVu(txtDVMa.Text.Trim(), txtDVTen.Text.Trim(),
                txtDVDVT.Text.Trim(), numDVGia.Value));
            if (!string.IsNullOrWhiteSpace(txtDVMa.Text))
            {
                txtDVMa.Clear();
                txtDVTen.Clear();
                txtDVDVT.Clear();
                numDVGia.Value = 0;
            }
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string maLoai = cboQDLoai.SelectedValue != null ? cboQDLoai.SelectedValue.ToString() : "";
            HienThiKetQua(s.ThemQuyDinh(txtQDMa.Text.Trim(), maLoai,
                txtQDMucDo.Text.Trim(), numQDTien.Value));
            if (!string.IsNullOrWhiteSpace(txtQDMa.Text))
            {
                txtQDMa.Clear();
                txtQDMucDo.Clear();
                numQDTien.Value = 0;
            }
        }

        private void dgvKhu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
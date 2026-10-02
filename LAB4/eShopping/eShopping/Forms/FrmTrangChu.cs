using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class FrmTrangChu : Form
    {
        private readonly SanPhamService _sanPhamService = new SanPhamService();
        private readonly BindingList<ItemGioHang> _gioHang = new BindingList<ItemGioHang>();
        private readonly CultureInfo _vnCulture = new CultureInfo("vi-VN");

        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieuGioHang();
            TaiDanhMucNhomSanPham();
            TaiDanhSachSanPham();
        }

        private void KhoiTaoDuLieuGioHang()
        {
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.Columns.Clear();

            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaSP",
                HeaderText = "Mã SP",
                Width = 70
            });
            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenSP",
                HeaderText = "Tên Sản Phẩm",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonGia",
                HeaderText = "Đơn Giá",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuong",
                HeaderText = "SL",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ThanhTien",
                HeaderText = "Thành Tiền",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvGioHang.DataSource = _gioHang;
            CapNhatTongTienGioHang();
        }

        private void TaiDanhMucNhomSanPham()
        {
            try
            {
                DataTable dtNhom = _sanPhamService.LayTatCaNhomSanPham();

                DataTable dtCombo = dtNhom.Clone();
                var rowAll = dtCombo.NewRow();
                rowAll["MaNhom"] = "ALL";
                rowAll["TenNhom"] = "-- Tất cả danh mục --";
                dtCombo.Rows.Add(rowAll);

                foreach (DataRow r in dtNhom.Rows)
                {
                    dtCombo.ImportRow(r);
                }

                cboNhomSanPham.DataSource = dtCombo;
                cboNhomSanPham.DisplayMember = "TenNhom";
                cboNhomSanPham.ValueMember = "MaNhom";
                cboNhomSanPham.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nhóm sản phẩm: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDanhSachSanPham()
        {
            try
            {
                string maNhom = cboNhomSanPham.SelectedValue?.ToString();
                string tuKhoa = txtTimKiem.Text?.Trim();

                DataTable dtSP = _sanPhamService.LayDanhSachSanPham(maNhom, tuKhoa);

                dgvSanPham.AutoGenerateColumns = false;
                dgvSanPham.Columns.Clear();

                dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaSP",
                    HeaderText = "Mã SP",
                    Width = 75
                });
                dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenSP",
                    HeaderText = "Tên Sản Phẩm",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NhaSanXuat",
                    HeaderText = "Nhà SX",
                    Width = 110
                });
                dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GiaHienHanh",
                    HeaderText = "Giá Hiện Hành (đ)",
                    Width = 130,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
                });
                dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TinhTrang",
                    HeaderText = "Tình Trạng",
                    Width = 95,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                });

                dgvSanPham.DataSource = dtSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNhomSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhomSanPham.SelectedIndex >= 0)
            {
                TaiDanhSachSanPham();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSachSanPham();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TaiDanhSachSanPham();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            if (cboNhomSanPham.Items.Count > 0)
                cboNhomSanPham.SelectedIndex = 0;
            TaiDanhSachSanPham();
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvSanPham.CurrentRow;
            string maSP = row.Cells[0].Value?.ToString();
            string tenSP = row.Cells[1].Value?.ToString();
            decimal gia = Convert.ToDecimal(row.Cells[3].Value ?? 0);
            int soLuong = (int)nudSoLuong.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng chọn mua phải lớn hơn 0!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
            var itemDaCo = _gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (itemDaCo != null)
            {
                itemDaCo.SoLuong += soLuong;
                dgvGioHang.ResetBindings();
            }
            else
            {
                _gioHang.Add(new ItemGioHang
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    DonGia = gia,
                    SoLuong = soLuong
                });
            }

            nudSoLuong.Value = 1;
            CapNhatTongTienGioHang();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món hàng cần xóa trong giỏ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvGioHang.CurrentRow.Index;
            if (index >= 0 && index < _gioHang.Count)
            {
                _gioHang.RemoveAt(index);
                CapNhatTongTienGioHang();
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ sản phẩm trong giỏ hàng?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _gioHang.Clear();
                CapNhatTongTienGioHang();
            }
        }

        private void CapNhatTongTienGioHang()
        {
            decimal tong = _gioHang.Sum(x => x.ThanhTien);
            lblGiaTriTongTien.Text = tong.ToString("N0", _vnCulture) + " đ";
        }

        private void btnTienHanhDatHang_Click(object sender, EventArgs e)
        {
            if (_gioHang == null || _gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống! Vui lòng chọn sản phẩm vào giỏ trước khi đặt hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form lập phiếu đặt hàng & thanh toán thẻ tín dụng
            using (var frm = new FrmDatHang(_gioHang.ToList()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Đặt hàng thành công: Xóa giỏ hàng
                    _gioHang.Clear();
                    CapNhatTongTienGioHang();
                }
            }
        }

        private void btnXemLichSu_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmLichSuDonHang())
            {
                frm.ShowDialog();
            }
        }
    }
}

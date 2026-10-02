using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class FrmLichSuDonHang : Form
    {
        private readonly DonHangService _donHangService = new DonHangService();
        private readonly CultureInfo _vnCulture = new CultureInfo("vi-VN");

        public FrmLichSuDonHang()
        {
            InitializeComponent();
        }

        private void FrmLichSuDonHang_Load(object sender, EventArgs e)
        {
            CauHinhBangDonHang();
            CauHinhBangChiTiet();
            TaiDanhSachDonHang();
        }

        private void CauHinhBangDonHang()
        {
            dgvDonHang.AutoGenerateColumns = false;
            dgvDonHang.Columns.Clear();

            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaDonHang",
                HeaderText = "Mã Đơn Hàng",
                Width = 140
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayDat",
                HeaderText = "Ngày Đặt",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenNguoiNhan",
                HeaderText = "Người Nhận",
                Width = 150
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SdtNguoiNhan",
                HeaderText = "Số ĐT",
                Width = 100
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LoaiPhieuGiao",
                HeaderText = "Loại Phiếu Giao",
                Width = 170
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PhiGiaoHang",
                HeaderText = "Phí Ship (đ)",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TongTien",
                HeaderText = "Tổng Tiền (đ)",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
        }

        private void CauHinhBangChiTiet()
        {
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.Columns.Clear();

            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaSP",
                HeaderText = "Mã SP",
                Width = 100
            });
            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenSP",
                HeaderText = "Tên Sản Phẩm Đã Mua",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonGiaBan",
                HeaderText = "Đơn Giá Bán (đ)",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuong",
                HeaderText = "Số Lượng",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvChiTiet.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ThanhTien",
                HeaderText = "Thành Tiền (đ)",
                Width = 160,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
        }

        private void TaiDanhSachDonHang()
        {
            try
            {
                string tuKhoa = txtTuKhoa.Text?.Trim();
                DataTable dt = _donHangService.LayLichSuDonHang(tuKhoa);
                dgvDonHang.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    dgvChiTiet.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDonHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null)
            {
                dgvChiTiet.DataSource = null;
                return;
            }

            try
            {
                string maDH = dgvDonHang.CurrentRow.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(maDH))
                {
                    DataTable dtCT = _donHangService.LayChiTietDonHang(maDH);
                    dgvChiTiet.DataSource = dtCT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            TaiDanhSachDonHang();
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TaiDanhSachDonHang();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            TaiDanhSachDonHang();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

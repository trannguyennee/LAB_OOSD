using System;
using System.Data;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmNuocGiaiKhat : Form
    {
        private NuocGiaiKhatService _service = new NuocGiaiKhatService();

        public FrmNuocGiaiKhat()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                cboLoai.DataSource = _service.GetLoaiNGK();
                cboLoai.DisplayMember = "TenLoai";
                cboLoai.ValueMember = "MaLoai";

                dgvNGK.DataSource = _service.GetAllNGK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                string dvt = txtDVT.Text.Trim();
                int ton = (int)nudTonKho.Value;
                decimal gia = nudDonGia.Value;
                string maLoai = cboLoai.SelectedValue != null ? cboLoai.SelectedValue.ToString() : "";

                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập Mã và Tên nước giải khát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _service.InsertNGK(ma, ten, dvt, ton, gia, maLoai);
                MessageBox.Show("Thêm nước giải khát mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                string ten = txtTen.Text.Trim();
                string dvt = txtDVT.Text.Trim();
                int ton = (int)nudTonKho.Value;
                decimal gia = nudDonGia.Value;
                string maLoai = cboLoai.SelectedValue != null ? cboLoai.SelectedValue.ToString() : "";

                _service.UpdateNGK(ma, ten, dvt, ton, gia, maLoai);
                MessageBox.Show("Cập nhật thông tin nước giải khát thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMa.Text.Trim();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng [" + ma + "] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _service.DeleteNGK(ma);
                    MessageBox.Show("Đã xóa nước giải khát thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btnLamMoi_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDVT.Text = "Lon";
            nudTonKho.Value = 0;
            nudDonGia.Value = 10000;
            txtMa.Focus();
        }

        private void dgvNGK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNGK.Rows[e.RowIndex];
                txtMa.Text = row.Cells["MaNGK"].Value.ToString();
                txtTen.Text = row.Cells["TenNGK"].Value.ToString();
                txtDVT.Text = row.Cells["DonViTinh"].Value.ToString();
                nudTonKho.Value = Convert.ToDecimal(row.Cells["SoLuongTon"].Value);
                nudDonGia.Value = Convert.ToDecimal(row.Cells["DonGiaBan"].Value);
                cboLoai.SelectedValue = row.Cells["MaLoai"].Value.ToString();
            }
        }
    }
}

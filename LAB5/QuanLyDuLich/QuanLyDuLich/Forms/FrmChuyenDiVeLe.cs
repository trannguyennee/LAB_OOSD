using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmChuyenDiVeLe : Form
    {
        private ChuyenDiVeLeService service = new ChuyenDiVeLeService();

        public FrmChuyenDiVeLe()
        {
            InitializeComponent();
        }

        private void FrmChuyenDiVeLe_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadChuyenDi();
        }

        private void LoadCombos()
        {
            cboTour.DataSource = service.GetTours();
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";

            cboKhachHang.DataSource = service.GetKhachHangLe();
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "MaKH";

            cboDiemBanVe.DataSource = service.GetDiemBanVe();
            cboDiemBanVe.DisplayMember = "TenDiemBanVe";
            cboDiemBanVe.ValueMember = "MaDiemBanVe";

            cboHinhThucTT.SelectedIndex = 0;
        }

        private void LoadChuyenDi()
        {
            dgvChuyenDi.DataSource = service.GetAllChuyenDi();
            if (dgvChuyenDi.Rows.Count > 0)
            {
                dgvChuyenDi.Rows[0].Selected = true;
                LoadVeChuyen(dgvChuyenDi.Rows[0].Cells["MaChuyen"].Value.ToString());
            }
        }

        private void dgvChuyenDi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChuyenDi.CurrentRow != null && dgvChuyenDi.CurrentRow.Cells["MaChuyen"].Value != null)
            {
                string maChuyen = dgvChuyenDi.CurrentRow.Cells["MaChuyen"].Value.ToString();
                txtMaChuyenDat.Text = maChuyen;
                LoadVeChuyen(maChuyen);
            }
        }

        private void LoadVeChuyen(string maChuyen)
        {
            dgvVe.DataSource = service.GetVeByChuyen(maChuyen);
        }

        private void btnTaoChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaChuyenMoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Chuyến Đi mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maTour = cboTour.SelectedValue.ToString();
                DateTime ngayDi = dtpNgayDi.Value.Date;
                DateTime ngayVe = dtpNgayVe.Value.Date;
                int soCho = (int)nudSoCho.Value;
                string diemDon = txtDiemDon.Text.Trim();

                if (service.InsertChuyenDi(txtMaChuyenMoi.Text.Trim(), maTour, ngayDi, ngayVe, soCho, diemDon))
                {
                    MessageBox.Show("Tạo Lịch Chuyến Đi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChuyenDi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaVe.Text) || string.IsNullOrWhiteSpace(txtMaChuyenDat.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Vé và chọn Chuyến Đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maVe = txtMaVe.Text.Trim();
                string maChuyen = txtMaChuyenDat.Text.Trim();
                string maKH = cboKhachHang.SelectedValue.ToString();
                string maDBV = cboDiemBanVe.SelectedValue.ToString();
                int soLuong = (int)nudSoVe.Value;
                string htTT = cboHinhThucTT.Text;

                if (service.DatVeKhachLe(maVe, maChuyen, maKH, maDBV, soLuong, htTT))
                {
                    MessageBox.Show("Xuất vé và thanh toán tiền vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChuyenDi();
                    LoadVeChuyen(maChuyen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt vé: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

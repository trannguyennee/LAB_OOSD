using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmPhanCongHDV : Form
    {
        private DieuHanhHDVService service = new DieuHanhHDVService();

        public FrmPhanCongHDV()
        {
            InitializeComponent();
        }

        private void FrmPhanCongHDV_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadData();
        }

        private void LoadCombos()
        {
            cboHDV.DataSource = service.GetAllHDV();
            cboHDV.DisplayMember = "HoTen";
            cboHDV.ValueMember = "MaNV";

            cboLoaiTour.SelectedIndex = 0;
            cboVaiTro.SelectedIndex = 0;
            UpdateTourOptions();
        }

        private void cboLoaiTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTourOptions();
        }

        private void UpdateTourOptions()
        {
            if (cboLoaiTour.Text == "CHUYEN_LE")
            {
                cboMaTourDung.DataSource = service.GetChuyenDiList();
                cboMaTourDung.DisplayMember = "MaChuyen";
                cboMaTourDung.ValueMember = "MaChuyen";
            }
            else
            {
                cboMaTourDung.DataSource = service.GetPhieuDoanList();
                cboMaTourDung.DisplayMember = "MaPhieuDangKy";
                cboMaTourDung.ValueMember = "MaPhieuDangKy";
            }
        }

        private void LoadData()
        {
            dgvHDV.DataSource = service.GetAllHDV();
            dgvPhanCong.DataSource = service.GetAllPhanCong();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaPhanCong.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Phân Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maPC = txtMaPhanCong.Text.Trim();
                string maNV = cboHDV.SelectedValue.ToString();
                string loaiTour = cboLoaiTour.Text;
                string maChuyen = loaiTour == "CHUYEN_LE" ? cboMaTourDung.SelectedValue.ToString() : null;
                string maPhieu = loaiTour == "DOAN" ? cboMaTourDung.SelectedValue.ToString() : null;
                DateTime ngayBD = dtpNgayBatDau.Value.Date;
                DateTime ngayKT = dtpNgayKetThuc.Value.Date;
                string vaiTro = cboVaiTro.Text;
                string ghiChu = txtGhiChu.Text.Trim();

                if (service.PhanCongTour(maPC, maNV, loaiTour, maChuyen, maPhieu, ngayBD, ngayKT, vaiTro, ghiChu))
                {
                    MessageBox.Show("Phân công Hướng dẫn viên thành công (Đã kiểm tra không trùng lịch)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phân công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

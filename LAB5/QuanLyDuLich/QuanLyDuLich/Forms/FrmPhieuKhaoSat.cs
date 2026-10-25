using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmPhieuKhaoSat : Form
    {
        private LuongKhaoSatService service = new LuongKhaoSatService();
        private TourLichTrinhService tourService = new TourLichTrinhService();
        private ChuyenDiVeLeService veService = new ChuyenDiVeLeService();

        public FrmPhieuKhaoSat()
        {
            InitializeComponent();
        }

        private void FrmPhieuKhaoSat_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadData();
        }

        private void LoadCombos()
        {
            cboKhachHang.DataSource = veService.GetKhachHangLe();
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "MaKH";

            cboTour.DataSource = tourService.GetAllTour();
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";

            cboLoaiLich.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dgvKhaoSat.DataSource = service.GetAllPhieuKhaoSat();
        }

        private void btnGuiKhaoSat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKhaoSat.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Phiếu Khảo Sát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maPKS = txtMaKhaoSat.Text.Trim();
                string maKH = cboKhachHang.SelectedValue.ToString();
                string loaiLich = cboLoaiLich.Text;
                string maTour = cboTour.SelectedValue.ToString();
                int d1 = (int)nudDiemPT.Value;
                int d2 = (int)nudDiemKS.Value;
                int d3 = (int)nudDiemAn.Value;
                int d4 = (int)nudDiemHDV.Value;
                int d5 = (int)nudDiemTong.Value;
                string yKien = txtYKien.Text.Trim();

                if (service.ThemPhieuKhaoSat(maPKS, maKH, loaiLich, null, null, maTour, d1, d2, d3, d4, d5, yKien))
                {
                    MessageBox.Show("Gửi và lưu trữ phiếu khảo sát chất lượng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txtMaKhaoSat.Clear();
                    txtYKien.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

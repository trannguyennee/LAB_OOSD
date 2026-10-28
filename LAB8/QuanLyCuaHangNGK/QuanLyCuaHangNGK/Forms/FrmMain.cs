using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmMain : Form
    {
        private BaoCaoService _bcService = new BaoCaoService();

        public FrmMain()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                int tongNGK, donChoGiao;
                decimal doanhThu, tongNo;
                _bcService.GetThongKeTongQuan(out tongNGK, out doanhThu, out tongNo, out donChoGiao);

                lblTongNGK.Text = tongNGK.ToString() + " Mặt hàng";
                lblDoanhThu.Text = doanhThu.ToString("N0") + " VNĐ";
                lblTongNo.Text = tongNo.ToString("N0") + " VNĐ";
                lblDonChoGiao.Text = donChoGiao.ToString() + " Phiếu hẹn";

                dgvGanDay.DataSource = _bcService.GetBaoCaoDoanhThu();
            }
            catch (Exception ex)
            {
                // Khi chưa nạp CSDL, hiển thị thông báo
                lblStatus.Text = "Trạng thái: Chưa kết nối CSDL hoặc CSDL chưa được khởi tạo. " + ex.Message;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm = new FrmHoaDon();
            frm.ShowDialog();
            LoadDashboard();
        }

        private void btnNGK_Click(object sender, EventArgs e)
        {
            FrmNuocGiaiKhat frm = new FrmNuocGiaiKhat();
            frm.ShowDialog();
            LoadDashboard();
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            FrmDonDatHang frm = new FrmDonDatHang();
            frm.ShowDialog();
            LoadDashboard();
        }

        private void btnPhieuHen_Click(object sender, EventArgs e)
        {
            FrmPhieuHen frm = new FrmPhieuHen();
            frm.ShowDialog();
            LoadDashboard();
        }

        private void btnPhieuGhiNo_Click(object sender, EventArgs e)
        {
            FrmPhieuGhiNo frm = new FrmPhieuGhiNo();
            frm.ShowDialog();
            LoadDashboard();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frm = new FrmBaoCao();
            frm.ShowDialog();
            LoadDashboard();
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            string msg;
            bool ok = Db.TestConnection(out msg);
            MessageBox.Show(msg, "Kiểm tra kết nối CSDL", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            LoadDashboard();
        }
    }
}

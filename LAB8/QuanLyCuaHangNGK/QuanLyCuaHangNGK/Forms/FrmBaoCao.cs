using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmBaoCao : Form
    {
        private BaoCaoService _service = new BaoCaoService();

        public FrmBaoCao()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvDoanhThu.DataSource = _service.GetBaoCaoDoanhThu();
                dgvCongNo.DataSource = _service.GetBaoCaoCongNo();
                dgvTonKhoCanhBao.DataSource = _service.GetBaoCaoTonKhoCanhBao(50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmLichDinhKy : Form
    {
        private readonly KhamBenhService _kbService = new KhamBenhService();
        private readonly BenhNhanService _bnService = new BenhNhanService();

        public FrmLichDinhKy()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cboHoSo.DataSource = _bnService.LayTatCaHoSo();
            cboHoSo.DisplayMember = "MaHoSo";
            cboHoSo.ValueMember = "MaHoSo";

            nudQuy.Value = (DateTime.Now.Month - 1) / 3 + 1;
            nudNam.Value = DateTime.Now.Year;
            txtGio.Text = "08:30";

            dgvLich.DataSource = _kbService.LayDanhSachLichDinhKy();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (cboHoSo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Mã hồ sơ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHS = cboHoSo.SelectedValue.ToString();
            int quy = (int)nudQuy.Value;
            int nam = (int)nudNam.Value;

            string res = _kbService.DatLichDinhKy(maHS, quy, nam, dtpNgayHen.Value, txtGio.Text.Trim(), txtGhiChu.Text.Trim());
            if (res == "Thành công")
            {
                MessageBox.Show($"Đặt lịch khám định kỳ Quý {quy}/{nam} thành công!\n\nQuyền lợi: Miễn phí 100% tiền khám bệnh theo lệ phí năm.", 
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLich.DataSource = _kbService.LayDanhSachLichDinhKy();
            }
            else
            {
                MessageBox.Show(res, "Lỗi đặt lịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
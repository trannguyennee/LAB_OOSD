using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmTraCuuLichSu : Form
    {
        private readonly BenhNhanService _bnService = new BenhNhanService();
        private readonly KhamBenhService _kbService = new KhamBenhService();

        public FrmTraCuuLichSu()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string kw = txtTuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(kw))
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ, Số CCCD, SĐT hoặc Họ tên để tra cứu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = _bnService.TraCuuHoSo(kw);
            dgvKetQua.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                string maHS = dt.Rows[0]["MaHoSo"].ToString();
                dgvLichSuKham.DataSource = _kbService.LayLichSuCacLanKham(maHS);
            }
            else
            {
                dgvLichSuKham.DataSource = null;
                MessageBox.Show("Không tìm thấy hồ sơ bệnh án nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKetQua_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKetQua.CurrentRow != null && dgvKetQua.CurrentRow.Cells["MaHoSo"].Value != null)
            {
                string maHS = dgvKetQua.CurrentRow.Cells["MaHoSo"].Value.ToString();
                dgvLichSuKham.DataSource = _kbService.LayLichSuCacLanKham(maHS);
            }
        }
    }
}
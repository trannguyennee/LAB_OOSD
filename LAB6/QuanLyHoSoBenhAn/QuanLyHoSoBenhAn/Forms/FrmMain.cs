using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new FrmDangKyHoSo().ShowDialog();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            new FrmTraCuuLichSu().ShowDialog();
        }

        private void btnLichDinhKy_Click(object sender, EventArgs e)
        {
            new FrmLichDinhKy().ShowDialog();
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            new FrmKhamBenh().ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            new FrmThanhToan().ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi Hệ thống Quản lý Hồ sơ Bệnh án không?",
                "Xác nhận thoát chương trình",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace eShopping.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // 1. Chức năng duy nhất trọng tâm của bài Lab: Chọn & Đặt mua hàng, Thanh toán thẻ
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new FrmTrangChu())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        // Các chức năng khác chưa phát triển trong bài Lab này: Nhấn vào không phản hồi gì
        private void btnChuaPhatTrien_Click(object sender, EventArgs e)
        {
            // Để trống - không phản hồi theo đúng yêu cầu phạm vi bài Lab
        }

        // 6. Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống e-SHOPPING?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

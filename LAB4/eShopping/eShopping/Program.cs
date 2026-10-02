using System;
using System.Windows.Forms;
using eShopping.Forms;

namespace eShopping
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của ứng dụng e-SHOPPING.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}

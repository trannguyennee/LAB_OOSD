using System;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Forms;

namespace QuanLyCuaHangNGK
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}

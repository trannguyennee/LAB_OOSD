using System;

namespace eShopping.Services
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }
        public object DuLieu { get; set; }

        public static KetQuaXuLy OK(string thongBao = "Thành công!", object duLieu = null)
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao, DuLieu = duLieu };
        }

        public static KetQuaXuLy Loi(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao, DuLieu = null };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongATM.Class
{
    static class ATMsystem
    {
        public static int SoLuongTo50k = 100000000;
        public static int SoLuongTo100k = 100000000;
        public static int SoLuongTo200k = 100000000;
        public static int SoLuongTo500k = 100000000;

        public static KhachHang KHDangNhap = null;

        public static bool DangNhap(string maThe, string maPin, ref string message)
        {
            if (!Data.Data.dtnKhachHang.ContainsKey(maThe))
            {
                message = "Mã thẻ không hợp lệ.";
                return false;
            }

            if (!(Data.Data.dtnKhachHang[maThe].MaPin == maPin))
            {
                message = "Mã PIN không hợp lệ.";
                return false;
            }

            KHDangNhap = Data.Data.dtnKhachHang[maThe];
            return true;
        }

        public bool RutTien(int amount, ref string message)
        {
            if (amount % 50000 != 0)
            {
                message = "Số tiền rút phải trên 50k và chỉ được rút tờ 50k 100k 200k 500k!";
                return false;
            }

            if (amount - SoDu < 50000)
            {
                message = "Số dư tối thiểu phải có trong tài khoản là 50.000đ, bạn không thể rút!";
                return false;
            }


        }
    }
}

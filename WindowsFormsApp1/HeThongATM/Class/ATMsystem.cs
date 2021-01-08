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

        public static bool DangNhap(string maThe, string maPin, out string message)
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
            message = null;
            return true;
        }

        public static bool RutTien(int amount, out string message)
        {
            if (amount < 50000 || amount % 50000 != 0)
            {
                message = "Số tiền rút phải trên 50k và chỉ được rút tờ 50k 100k 200k 500k!";
                return false;
            }

            if (amount - KHDangNhap.SoDu < 50000)
            {
                message = "Số dư không đủ, số dư tối thiểu phải có trong tài khoản là 50.000đ, bạn không thể rút!";
                return false;
            }

            message = null;
            KHDangNhap.TruTien(amount);
            return true;
        }

        public static bool ChuyenTien(int amount, string maTheNhan, out string message)
        {
            if (amount < 0)
            {
                message = "Lỗi! số tiền chuyển phải lớn hơn 0  !";
                return false;
            }

            if (amount - KHDangNhap.SoDu < 50000)
            {
                message = "Số dư không đủ, số dư tối thiểu phải có trong tài khoản là 50.000đ, bạn không thể chuyển!";
                return false;
            }

            KHDangNhap.TruTien(amount);
            Data.Data.dtnKhachHang[maTheNhan].ThemTien(amount);
            message = null;
            return true;
        }

        public static bool DoiMatKhau(string MaPinCu, string MaPinMoi1, string MaPinMoi2, out string message)
        {
            if (MaPinMoi1 != MaPinMoi2)
            {
                message = "Mật khẩu nhập lại không khớp.";
                return false;
            }

            if (KHDangNhap.MaPin != MaPinCu)
            {
                message = "Sai mật khẩu cũ.";
                return false;
            }

            KHDangNhap.MaPin = MaPinMoi1;
            message = null;
            return true;
        }

        public static void DangXuat()
        {
            KHDangNhap = null;
        }

    }


    enum MyTask
    {
        DoiMaPin = 1,
        KiemTraSoDu = 2,
        RutTien = 3,
        ChuyenTien = 4,
    }
}

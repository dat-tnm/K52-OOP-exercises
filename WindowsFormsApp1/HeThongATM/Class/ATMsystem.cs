﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongATM.Class
{
    static class ATMsystem
    {
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

            if (KHDangNhap.SoDu - amount < 50000)
            {
                message = "Số dư không đủ, số dư tối thiểu phải có trong tài khoản là 50.000đ !";
                return false;
            }

            message = null;
            KHDangNhap.TruTien(amount);
            return true;
        }

        public static bool ChuyenTien(int amount, string maTheNhan, out string message)
        {
            if (!Data.Data.dtnKhachHang.ContainsKey(maTheNhan))
            {
                message = "Mã thẻ nhận không tồn tại";
                return false;
            }

            if (maTheNhan == KHDangNhap.MaThe)
            {
                message = "Mã thẻ nhận phải khác mã thẻ chuyển tiền";
                return false;
            }

            if (amount < 50000)
            {
                message = "Số tiền chuyển tối thiểu là 50.000đ !";
                return false;
            }

            if (KHDangNhap.SoDu - amount < 50000)
            {
                message = "Số dư không đủ, số dư tối thiểu phải có trong tài khoản là 50.000đ !";
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

        public static bool KiemTraMaPin(string maPin)
        {
            if (KHDangNhap.MaPin == maPin)
            {
                return true;
            }

            return false;
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

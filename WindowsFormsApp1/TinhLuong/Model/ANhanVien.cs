using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLuong.Model
{
    abstract class ANhanVien
    {
        public string MaNV;
        public string HoTen;
        public DateTime NgaySinh;
        public string PhongBan;
        public string ChucVu;
        public double Luong;
        public int SoNgayLamViec;

        public abstract double TinhPhuCap();

        public virtual double TinhLuongThang()
        {
            return (Luong * SoNgayLamViec / 26);
        }

        public virtual double TinhTongLuong()
        {
            return TinhLuongThang() + TinhPhuCap();
        }

    }
}

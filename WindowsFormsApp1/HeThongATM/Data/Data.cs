using HeThongATM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongATM.Data
{
    static class Data
    {
        public static Dictionary<string, KhachHang> dtnKhachHang = new Dictionary<string, KhachHang>()
        {
            {"dat" , new KhachHang("dat", "123456", 1000000)},
            {"phuong" , new KhachHang("phuong", "654321", 1000000)}
        };


    }
}

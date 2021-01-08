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
            {"123456789" , new KhachHang("123456789", "123456", 1000000)},
            {"012345678" , new KhachHang("012345678", "654321", 1000000)}
        };


    }
}

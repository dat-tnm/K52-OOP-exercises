using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongATM.Class
{
    class KhachHang
    {
        public KhachHang(string maThe, string maPin, int soDu)
        {
            MaThe = maThe;
            MaPin = maPin;
            SoDu = soDu;
        }

        public string MaThe { get; private set; }
        public string MaPin { get; set; }
        public int SoDu { get; private set; }

        public void TruTien(int amount)
        {
            SoDu -= amount;
        }

        public void ThemTien(int amount)
        {
            SoDu += amount;
        }
    }
}

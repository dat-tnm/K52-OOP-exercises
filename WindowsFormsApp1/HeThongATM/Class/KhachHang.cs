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
        public string MaPin { get; private set; }
        public int SoDu { get; private set; }

        public bool RutTien(int amount, ref string message)
        {
            if (amount % 50000 != 0)
                return false;

            if (amount - SoDu < 50000)
                return false;

            SoDu -= amount;
            return true;
        }
    }
}

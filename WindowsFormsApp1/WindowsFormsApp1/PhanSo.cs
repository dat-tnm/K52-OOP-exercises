using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PhanSo
    {
        public int TuSo;
        public int MauSo;

        public PhanSo()
        {
            TuSo = 1;
            MauSo = 1;
        }

        public PhanSo(int t, int m)
        {
            TuSo = t;
            MauSo = m;
        }

        private PhanSo RutGon(int t, int m)
        {
            int uscln = 1;
            int j = (t < m) ? t : m;
            for (int i = 2; i <= j; i++)
            {
                if (t % i == 0 && m % i == 0)
                {
                    uscln = i;
                }
            }
            return new PhanSo(t/uscln, m/uscln);
        }

        public PhanSo Nhan(PhanSo ps)
        {
            int t = TuSo * ps.TuSo;
            int m = MauSo * ps.MauSo;
            return RutGon(t, m);
        }

        public PhanSo Chia(PhanSo ps)
        {
            int t = TuSo * ps.MauSo;
            int m = MauSo * ps.TuSo;
            return RutGon(t, m);
        }

        public PhanSo Cong(PhanSo ps)
        {
            int t = TuSo * ps.MauSo + MauSo * ps.TuSo;
            int m = MauSo * ps.MauSo;
            return RutGon(t, m);
        }

        public PhanSo Tru(PhanSo ps)
        {
            int t = TuSo * ps.MauSo - MauSo * ps.TuSo;
            int m = MauSo * ps.MauSo;
            return RutGon(t, m);
        }
    }
}

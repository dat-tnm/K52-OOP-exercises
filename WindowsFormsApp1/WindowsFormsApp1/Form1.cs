using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private PhanSo ps1;
        private PhanSo ps2;

        public Form1()
        {
            InitializeComponent();
            ps1 = new PhanSo(0, 0);
            ps2 = new PhanSo(0, 0);
        }

        private void ps1TuSo_TextChanged(object sender, EventArgs e)
        {
            ps1.TuSo = Convert.ToInt32(ps1TuSo.Text);
        }

        private void ps1MauSo_TextChanged(object sender, EventArgs e)
        {
            ps1.MauSo = Convert.ToInt32(ps1MauSo.Text);
        }

        private void ps2TuSo_TextChanged(object sender, EventArgs e)
        {
            ps2.TuSo = Convert.ToInt32(ps2TuSo.Text);
        }

        private void ps2MauSo_TextChanged(object sender, EventArgs e)
        {
            ps2.MauSo = Convert.ToInt32(ps2MauSo.Text);
        }

        private void showKetQua(PhanSo kq)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

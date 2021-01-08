using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongATM.Class;

namespace HeThongATM
{
    public partial class fMain : Form
    {
        List<string> fDoiMaPin;
        List<string> fKiemTraSoDu;
        List<string> fRutTien;
        List<string> fChuyenTien;

        public fMain()
        {
            InitializeComponent();
        }


        private void fMain_Load(object sender, EventArgs e)
        {
            fDoiMaPin = new List<string>() { "Mã pin cũ", "Mã pin mới", "Nhập lại mã pin" };
            fKiemTraSoDu = new List<string>() { "Mã thẻ", "Số dư" };
            fRutTien = new List<string>() { "Mã pin cũ", "Mã pin mới", "Nhập lại mã pin" };
            fChuyenTien = new List<string>() { "Mã pin cũ", "Mã pin mới", "Nhập lại mã pin" };
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ATMsystem.DangXuat();
            Application.OpenForms.OfType<fDangNhap>().First().Show();
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTraSD_Click(object sender, EventArgs e)
        {

        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}

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

        private bool isInputValid()
        {
            try
            {
                ps1.TuSo = Convert.ToInt32(ps1TuSo.Text);
                ps1.MauSo = Convert.ToInt32(ps1MauSo.Text);
                ps2.TuSo = Convert.ToInt32(ps2TuSo.Text);
                ps2.MauSo = Convert.ToInt32(ps2MauSo.Text);
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Hãy nhập số nguyên !", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return false;
            }

            if (ps1.MauSo == 0 || ps2.MauSo == 0)
            {
                DialogResult result = MessageBox.Show("Mẫu không được bằng 0 !", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                
                ps1MauSo.BackColor = Color.Red;
                return false;
            }



            return true;
        }





        private void showKetQua(PhanSo kq)
        {
            kqTuSo.Text = kq.TuSo.ToString();
            kqMauSo.Text = kq.MauSo.ToString();
        }





        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                showKetQua(ps1.Cong(ps2));
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                showKetQua(ps1.Tru(ps2));
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                showKetQua(ps1.Nhan(ps2));
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (isInputValid())
            {
                showKetQua(ps1.Chia(ps2));
            }
        }

        private void Lammoi_Click(object sender, EventArgs e)
        {
            ps1TuSo.Clear();
            ps1MauSo.Clear();
            ps2TuSo.Clear();
            ps2MauSo.Clear();
            kqTuSo.Clear();
            kqMauSo.Clear();

            ps1.TuSo = 0;
            ps1.MauSo = 0;
            ps2.TuSo = 0;
            ps2.MauSo = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

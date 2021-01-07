using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ListView
{
    public partial class Form1 : Form
    {
        struct SinhVien
        {
            public string HoTen;
            public float DTB;
        }

        SinhVien[] DSSV;
        float[] Mang;
        int i = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DSSV = new SinhVien[10];
            Mang = new float[10];

            tbHoTen.Focus();
            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Họ và tên", 200);
            listView1.Columns.Add("Điểm TB", 100);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (tbHoTen.Text == "" || tbDiemTB.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int STT = i + 1;
            DSSV[i].HoTen = tbHoTen.Text;
            DSSV[i].DTB = float.Parse(tbDiemTB.Text);
            ListViewItem item = new ListViewItem(STT.ToString());
            item.SubItems.Add(tbHoTen.Text);
            item.SubItems.Add(tbDiemTB.Text);
            listView1.Items.Add(item);
            tbDiemTB.Clear();
            tbHoTen.Clear(); tbHoTen.Focus();

            //Mang[i] = float.Parse(tbHoTen.Text);
            //listView1.Items.Add(tbHoTen.Text);
            //i++;
            //tbHoTen.Clear(); tbHoTen.Focus();
        }

        private void btnLonNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnNhoNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {

        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {

        }

    }
}

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
        int n = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DSSV = new SinhVien[10];
            //Mang = new float[10];

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

            int STT = n + 1;
            DSSV[n].HoTen = tbHoTen.Text;
            try
            {
                DSSV[n].DTB = float.Parse(tbDiemTB.Text);
            }
            catch (Exception) { return; }

            ListViewItem item = new ListViewItem(STT.ToString());
            item.SubItems.Add(tbHoTen.Text);
            item.SubItems.Add(tbDiemTB.Text);
            listView1.Items.Add(item);
            tbDiemTB.Clear();
            tbHoTen.Clear(); tbHoTen.Focus();
            n++;

            //Mang[i] = float.Parse(tbHoTen.Text);
            //listView1.Items.Add(tbHoTen.Text);
            //i++;
            //tbHoTen.Clear(); tbHoTen.Focus();
        }

        #region bottom buttons
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
        #endregion
        private void btnChen_Click(object sender, EventArgs e)
        {
            SinhVien svChen;
            int viTri = 0;
            svChen.HoTen = tbHoTen.Text;
            try
            {
                svChen.DTB = float.Parse(tbDiemTB.Text);
            }
            catch (Exception) { return; }

            int i;
            for (i = 0; i < n; i++)
            {
                if (DSSV[i].DTB > svChen.DTB)
                    break;
            }
            viTri = i;
            if (viTri == n)
            {
                DSSV[n] = svChen;
            }
            else
            {
                for (int j = n; j > viTri; j--)
                    DSSV[j] = DSSV[j - 1];
                DSSV[viTri] = svChen;
            }
            n++;
            LoadListView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int viTri = listView1.SelectedItems[0].Index;
                try
                {
                    DSSV[viTri].DTB = float.Parse(tbDiemTB.Text);
                }
                catch (Exception) { return; }
                DSSV[viTri].HoTen = tbHoTen.Text;
                listView1.SelectedItems[0].SubItems[1].Text = tbHoTen.Text;
                listView1.SelectedItems[0].SubItems[2].Text = tbDiemTB.Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                tbHoTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbDiemTB.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        void LoadListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(DSSV[i].HoTen);
                item.SubItems.Add(DSSV[i].DTB.ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            DialogResult key = MessageBox.Show("Bạn muốn xóa trường này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (key == DialogResult.No)
            {
                return;
            }

            int viTriXoa = listView1.SelectedItems[0].Index;
            int i=0;
            while (i < viTriXoa)
                i++;
            for (int j = i; j < n; j++)
                DSSV[j] = DSSV[j + 1];
            n--;
            LoadListView();
        }
    }
}

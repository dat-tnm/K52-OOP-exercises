using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinhLuong.Model;

namespace TinhLuong
{
    public partial class Form1 : Form
    {
        ANhanVien[] listNhanVien;
        int n = -1;

        public Form1()
        {
            InitializeComponent();

            listNhanVien = new ANhanVien[20];

            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Họ và tên", 150);
            listView1.Columns.Add("Ngày sinh", 100);
            listView1.Columns.Add("Đơn vị", 70);
            listView1.Columns.Add("Chức vụ", 90);
            listView1.Columns.Add("Lương tháng", 100);
            listView1.Columns.Add("Phụ cấp", 100);
            listView1.Columns.Add("Tổng lương", 100);

            cbbChucVu.DataSource = new List<string>() { Data.cv_BanGiamDoc, Data.cv_KeToanTruong, Data.cv_NhanVien, Data.cv_TruongPhong };
        }

        void LoadListView()
        {
            double tongLuong = 0;
            double tongPhuCap = 0;
            double tongChiTien;
            listView1.Items.Clear();

            for (int i = 0; i <= n; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(listNhanVien[i].HoTen);
                item.SubItems.Add(listNhanVien[i].NgaySinh.ToShortDateString());
                item.SubItems.Add(listNhanVien[i].PhongBan);
                item.SubItems.Add(listNhanVien[i].ChucVu);
                item.SubItems.Add(listNhanVien[i].TinhLuongThang().ToString("0,0"));
                item.SubItems.Add(listNhanVien[i].TinhPhuCap().ToString("0,0"));
                item.SubItems.Add(listNhanVien[i].TinhTongLuong().ToString("0,0"));

                listView1.Items.Add(item);
                tongLuong += listNhanVien[i].TinhLuongThang();
                tongPhuCap += listNhanVien[i].TinhPhuCap();
            }

            tongChiTien = tongLuong + tongPhuCap;
            tbTongLuong.Text = tongLuong.ToString("0,0");
            tbTongPhuCap.Text = tongPhuCap.ToString("0,0");
            tbTongChiTien.Text = tongChiTien.ToString("0,0");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int index = int.Parse(listView1.SelectedItems[0].SubItems[0].Text) - 1;

            tbMaNV.Text = listNhanVien[index].MaNV;
            tbHoTen.Text = listNhanVien[index].HoTen;
            dateTimePicker1.Value = listNhanVien[index].NgaySinh.Date;
            tbPhongBan.Text = listNhanVien[index].PhongBan;
            cbbChucVu.SelectedItem = listNhanVien[index].ChucVu;
            tbLuong.Text = listNhanVien[index].Luong.ToString();
            tbSoNgayLamViec.Text = listNhanVien[index].SoNgayLamViec.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ANhanVien nv;
            if (cbbChucVu.SelectedValue.ToString() == Data.cv_BanGiamDoc)
            {
                nv = new BanGiamDoc();
            }
            else if (cbbChucVu.SelectedValue.ToString() == Data.cv_KeToanTruong)
            {
                nv = new KeToanTruong();
            }
            else if (cbbChucVu.SelectedValue.ToString() == Data.cv_TruongPhong)
            {
                nv = new TruongPhong();
            }
            else
            {
                nv = new NhanVien();
            }

            nv.MaNV = tbMaNV.Text;
            nv.HoTen = tbHoTen.Text;
            nv.NgaySinh = dateTimePicker1.Value.Date;
            nv.PhongBan = tbPhongBan.Text;
            nv.ChucVu = cbbChucVu.SelectedValue.ToString();
            nv.Luong = double.Parse(tbLuong.Text);
            nv.SoNgayLamViec = int.Parse(tbSoNgayLamViec.Text);

            n++;
            listNhanVien[n] = nv;
            LoadListView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int index = int.Parse(listView1.SelectedItems[0].SubItems[0].Text) - 1;
            ANhanVien nv;
            if (cbbChucVu.SelectedValue.ToString() == Data.cv_BanGiamDoc)
            {
                nv = new BanGiamDoc();
            }
            else if (cbbChucVu.SelectedValue.ToString() == Data.cv_KeToanTruong)
            {
                nv = new KeToanTruong();
            }
            else if (cbbChucVu.SelectedValue.ToString() == Data.cv_TruongPhong)
            {
                nv = new TruongPhong();
            }
            else
            {
                nv = new NhanVien();
            }

            nv.MaNV = tbMaNV.Text;
            nv.HoTen = tbHoTen.Text;
            nv.NgaySinh = dateTimePicker1.Value.Date;
            nv.PhongBan = tbPhongBan.Text;
            nv.ChucVu = cbbChucVu.SelectedValue.ToString();
            nv.Luong = double.Parse(tbLuong.Text);
            nv.SoNgayLamViec = int.Parse(tbSoNgayLamViec.Text);

            listNhanVien[index] = nv;
            LoadListView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            int index = int.Parse(listView1.SelectedItems[0].SubItems[0].Text) - 1;

            for (int i = index; i < n; i++)
            {
                listNhanVien[i] = listNhanVien[i + 1];
            }

            listNhanVien[n] = null;
            n--;
            LoadListView();
        }
    }
}

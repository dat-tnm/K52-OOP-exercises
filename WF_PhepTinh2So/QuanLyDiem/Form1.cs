using QuanLyDiem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class Form1 : Form
    {
        Parcel[] listParcels;
        int n = -1;

        public Form1()
        {
            InitializeComponent();

            cbbMType.DataSource = new List<MailType>() { MailType.Normal, MailType.Fast };
            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Người nhận", 150);
            listView1.Columns.Add("Địa chỉ", 150);
            listView1.Columns.Add("Loại thư", 100);
            listView1.Columns.Add("Trọng lượng", 100);
            listParcels = new Parcel[20];
        }

        void LoadListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i <= n; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(listParcels[i].Receiver);
                item.SubItems.Add(listParcels[i].ToAddress);
                if (listParcels[i] is Mail)
                {
                    item.SubItems.Add(((Mail)listParcels[i]).Type.ToString());
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                    item.SubItems.Add(((TransferItem)listParcels[i]).Weight.ToString());
                }
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            if (listView1.SelectedItems[0].SubItems[3].Text != string.Empty)
            {
                tabControl1.SelectedTab = tabMail;
                tbMReceiver.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbMToAddress.Text = listView1.SelectedItems[0].SubItems[2].Text;
                var mt = listView1.SelectedItems[0].SubItems[3].Text;
                foreach (MailType item in cbbMType.Items)
                {
                    if (item.ToString() == mt)
                        cbbMType.SelectedItem = item;
                }
            }
            else
            {
                tabControl1.SelectedTab = tabItem;
                tbIReceiver.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbIToAddress.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tbIWeight.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        #region mail buttons
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            string receiver = tbMReceiver.Text;
            string toAddress = tbMToAddress.Text;
            var type = (MailType)cbbMType.SelectedValue;
            n++;

            listParcels[n] = new Mail(receiver, toAddress, type);
            LoadListView();
        }

        private void btnMEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView1.SelectedItems[0].SubItems[3].Text == string.Empty)
                return;

            int index = int.Parse(listView1.SelectedItems[0].SubItems[0].Text) - 1;
            listParcels[index].Receiver = tbMReceiver.Text;
            listParcels[index].ToAddress = tbMToAddress.Text;
            ((Mail)listParcels[index]).Type = (MailType)cbbMType.SelectedItem;

            LoadListView();
        }

        private void btnMDelete_Click(object sender, EventArgs e)
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
            int i = 0;
            while (i < viTriXoa)
                i++;
            for (int j = i; j < n; j++)
                listParcels[j] = listParcels[j + 1];
            n--;
            LoadListView();
        }
        #endregion

        #region transferitem buttons
        private void btnIAdd_Click(object sender, EventArgs e)
        {
            string receiver = tbIReceiver.Text;
            string toAddress = tbIToAddress.Text;
            double weight;
            try
            {
                weight = double.Parse(tbIWeight.Text);
            }
            catch (Exception) { MessageBox.Show("Trọng lượng phải nhập số"); return; }
            n++;

            listParcels[n] = new TransferItem(receiver, toAddress, weight);
            LoadListView();
        }

        private void btnIEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView1.SelectedItems[0].SubItems[3].Text != string.Empty)
                return;

            int index = int.Parse(listView1.SelectedItems[0].SubItems[0].Text) - 1;
            try
            {
                ((TransferItem)listParcels[index]).Weight = double.Parse(tbIWeight.Text);
            }
            catch (Exception) { MessageBox.Show("Trọng lượng phải nhập số"); return; }
            listParcels[index].Receiver = tbIReceiver.Text;
            listParcels[index].ToAddress = tbIToAddress.Text;

            LoadListView();
        }

        private void btnIDelete_Click(object sender, EventArgs e)
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
            int i = 0;
            while (i < viTriXoa)
                i++;
            for (int j = i; j < n; j++)
                listParcels[j] = listParcels[j + 1];
            n--;
            LoadListView();
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearch.Text;

            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.SubItems[1].Text.Contains(keyword) || !item.SubItems[2].Text.Contains(keyword))
                {
                    listView1.Items.Remove(item);
                }
            }
        }
    }
}

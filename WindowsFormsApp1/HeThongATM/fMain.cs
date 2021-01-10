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

        List<Label> listLabel;
        List<TextBox> listTextbox;

        MyTask CurrentTask;

        public fMain()
        {
            InitializeComponent();
        }


        private void fMain_Load(object sender, EventArgs e)
        {
            fDoiMaPin = new List<string>() { "Mã pin cũ", "Mã pin mới", "Nhập lại mã pin" };
            fKiemTraSoDu = new List<string>() { "Mã thẻ", "Số dư" };
            fRutTien = new List<string>() { "Số dư", "Số tiền rút", "Nhập mã pin" };
            fChuyenTien = new List<string>() { "Số tài khoản chuyển", "Số tiền", "Nhập mã pin" };


            listLabel = new List<Label>();
            listLabel.Add(label1);
            listLabel.Add(label2);
            listLabel.Add(label3);

            listTextbox = new List<TextBox>();
            listTextbox.Add(textBox1);
            listTextbox.Add(textBox2);
            listTextbox.Add(textBox3);

            button1.Hide();
            button2.Hide();

            lbTieuDe.Text = "Hãy chọn tác vụ!";

            for (int i = 0; i < listLabel.Count; i++)
            {
                listLabel[i].Hide();
                listTextbox[i].Hide();
            }
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
            var tbTexts = new List<string>() { "", "", "" };
            LoadLabels(fDoiMaPin, tbTexts , MyTask.DoiMaPin, "Đổi mã pin");
        }

        private void btnKiemTraSD_Click(object sender, EventArgs e)
        {
            var tbTexts = new List<string>() { ATMsystem.KHDangNhap.MaThe, ATMsystem.KHDangNhap.SoDu.ToString() };
            LoadLabels(fKiemTraSoDu, tbTexts, MyTask.KiemTraSoDu, "Số dư");
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            var tbTexts = new List<string>() { ATMsystem.KHDangNhap.SoDu.ToString(), "", "" };
            LoadLabels(fRutTien, tbTexts, MyTask.RutTien, "Rút tiền");
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            var tbTexts = new List<string>() { "", "", "" };
            LoadLabels(fChuyenTien, tbTexts, MyTask.ChuyenTien, "Chuyển tiền");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = null;
            switch (CurrentTask)
            {
                case MyTask.DoiMaPin:
                    ATMsystem.DoiMatKhau(textBox1.Text, textBox2.Text, textBox3.Text, out message);
                    break;
                case MyTask.RutTien:
                    if (ATMsystem.KiemTraMaPin(textBox3.Text))
                    {
                        int amount;
                        if(!int.TryParse(textBox2.Text, out amount))
                            message = "Nhập số please!";
                        else
                            ATMsystem.RutTien(amount, out message);
                    }
                    else
                        message = "Mã pin không hợp lệ";
                    break;
                case MyTask.ChuyenTien:
                    if (ATMsystem.KiemTraMaPin(textBox3.Text))
                    {
                        int amount;
                        if (!int.TryParse(textBox2.Text, out amount))
                            MessageBox.Show("Nhập số please!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            ATMsystem.ChuyenTien(amount, textBox1.Text, out message);
                    }
                    else
                        message = "Mã pin không hợp lệ";
                    break;
                default:
                    break;
            }

            if (message != null)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lbTieuDe.Text = "Thành công";

                for (int i = 0; i < listLabel.Count; i++)
                {
                    listLabel[i].Hide();
                    listTextbox[i].Hide();
                }
                button1.Hide();
                button2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbTieuDe.Text = "Hãy chọn tác vụ";

            for (int i = 0; i < listLabel.Count; i++)
            {
                listLabel[i].Hide();
                listTextbox[i].Hide();
            }
            button1.Hide();
            button2.Hide();
        }

        void LoadLabels(List<string> listTextLabel, List<string> tbTexts, MyTask myTask, string tieude)
        {
            int i;
            for (i = 0; i < listTextLabel.Count; i++)
            {
                listLabel[i].Text = listTextLabel[i];
                listLabel[i].Show();
                listTextbox[i].Clear();
                listTextbox[i].Text = tbTexts[i];
                listTextbox[i].Show();

                if (listTextLabel[i].Contains("pin"))
                {
                    listTextbox[i].UseSystemPasswordChar = true;
                }
                else
                {
                    listTextbox[i].UseSystemPasswordChar = false;
                }
            }

            for (int j = i; j < listLabel.Count; j++)
            {
                listLabel[j].Hide();
                listTextbox[j].Hide();
            }

            lbTieuDe.Text = tieude;

            button1.Show();
            button2.Show();

            CurrentTask = myTask;
        }
    }
}

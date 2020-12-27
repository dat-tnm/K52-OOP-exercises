using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        float a, b, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textFirstNumber.Text);
            b = float.Parse(textSecondNumber.Text);

            textResult.Text = (a + b).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textFirstNumber.Text);
            b = float.Parse(textSecondNumber.Text);

            textResult.Text = (a - b).ToString();
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textFirstNumber.Text);
            b = float.Parse(textSecondNumber.Text);

            textResult.Text = (a * b).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            a = float.Parse(textFirstNumber.Text);
            b = float.Parse(textSecondNumber.Text);
            if (b == 0)
            {
                MessageBox.Show("Số chia cần phải khác 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textResult.Text = (a / b).ToString();
            }
        }
    }
}

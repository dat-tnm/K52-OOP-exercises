using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_PhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        float a, b, c, delta;
        double x1, x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textX1.Clear();
            textX2.Clear();

            a = float.Parse(textA.Text);
            b = float.Parse(textB.Text);
            c = float.Parse(textC.Text);
            if (a == 0)
                if (b == 0)
                    if (c == 0)
                        MessageBox.Show("Phương trình vô số nghiệm", "Thông báo", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Phương trình vô nghiệm", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    x1 = -c / b;
                    textX1.Text = x1.ToString();
                    textX2.Text = x1.ToString();
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    MessageBox.Show("Phương trình vô nghiệm", "Thông báo", MessageBoxButtons.OK);
                else
                {
                    x1 = -b + Math.Sqrt(delta) / (2 * a);
                    x2 = -b - Math.Sqrt(delta) / (2 * a);
                    textX1.Text = x1.ToString();
                    textX2.Text = x2.ToString();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Game_ThapHaNoi
{
    public partial class Form1 : Form
    {
        float x, y, h, w;
        float[] node = new float[] { 1, 2, 3 };
        List<Color> listColor = new List<Color>() { Color.Red, Color.Orange, Color.Yellow, Color.GreenYellow, Color.Green, Color.Blue, Color.BlueViolet, Color.Violet };

        Plaform pl1 = new Plaform(29, 363, 200, 50);
        Plaform pl2 = new Plaform(273, 363, 200, 50);
        Plaform pl3 = new Plaform(517, 363, 200, 50);

        int nodeCount;

        Pen pen = new Pen(Color.Red, 2);
        Graphics graphics;

        Plaform source;
        Plaform destination;

        public Form1()
        {
            InitializeComponent();

            pl1.plafColumn = new PlafColumn(115, 128, 30, 237);
            pl2.plafColumn = new PlafColumn(358, 128, 30, 237);
            pl3.plafColumn = new PlafColumn(605, 128, 30, 237);

            graphics = this.CreateGraphics();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                if (!pl1.stack.isEmpty())
                {
                    source = pl1;
                    tbPl1.Text = "Source";
                }
                return;
            }

            destination = pl1;
            tbPl1.Text = "Destination";
            MoveNode();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                if (!pl2.stack.isEmpty())
                {
                    source = pl2;
                    tbPl2.Text = "Source";
                }
                return;
            }

            destination = pl2;
            tbPl2.Text = "Destination";
            MoveNode();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                if (!pl3.stack.isEmpty())
                {
                    source = pl3;
                    tbPl3.Text = "Source";
                }
                return;
            }

            destination = pl3;
            tbPl3.Text = "Destination";
            MoveNode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pl1.stack.items = new int[10];
            pl1.stack.Top = -1;
            nodeCount = 2;

            pl1.stack.Push(7);
            pl1.stack.Push(6);
            pl1.stack.Push(5);

            DrawPlaform(pl1);
            DrawPlaform(pl2);
            DrawPlaform(pl3);
        }

        void DrawPlaform(Plaform plaf)
        {
            pen.Color = Color.Black;
            graphics.FillRectangle(pen.Brush, plaf.x, plaf.y, plaf.w, plaf.h);
            pen.Color = Color.Brown;
            graphics.FillRectangle(pen.Brush, plaf.x + 1, plaf.y + 1, plaf.w - 2, plaf.h - 2);

            var plafColumn = plaf.plafColumn;

            pen.Color = Color.Black;
            graphics.FillRectangle(pen.Brush, plafColumn.x, plafColumn.y, plafColumn.w, plafColumn.h);
            pen.Color = Color.Brown;
            graphics.FillRectangle(pen.Brush, plafColumn.x + 1, plafColumn.y + 1, plafColumn.w - 2, plafColumn.h - 1);

            if (!plaf.stack.isEmpty())
            {
                var length = plaf.stack.Top;
                for (int i = 0; i <= length; i++)
                {
                    DrawNode(i, plaf.stack.items[i], plaf);
                }
            }
        }

        void DrawNode(int index, int node, Plaform pl)
        {
            w = 40 + 20 * node;
            h = 30;
            x = pl.x + (pl.w - w) / 2;
            y = pl.y - (index + 1) * h;

            pen.Color = Color.Black;
            graphics.FillRectangle(pen.Brush, x, y, w, h);
            pen.Color = listColor[node];
            graphics.FillRectangle(pen.Brush, x + 1, y + 1, w - 2, h - 2);
        }

        void MoveNode()
        {
            if (!destination.stack.isEmpty())
                if (source.stack.Peek() > destination.stack.Peek())
                {
                    source = null;
                    destination = null;
                    MessageBox.Show("Không thể chuyển node, node phải được xếp tăng dần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPl1.Clear();
                    tbPl2.Clear();
                    tbPl3.Clear();
                    return;
                }

            int node = source.stack.Peek();
            source.stack.Pop();
            destination.stack.Push(node);

            source = null;
            destination = null;
            tbPl1.Clear();
            tbPl2.Clear();
            tbPl3.Clear();

            graphics.Clear(Color.White);
            DrawPlaform(pl1);
            DrawPlaform(pl2);
            DrawPlaform(pl3);

            CheckWin();
        }

        void CheckWin()
        {
            if (pl2.stack.Top == nodeCount)
            {
                MessageBox.Show("Hoàn thành thử thách ^^ !", "You Won!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                graphics.Clear(Color.White);
            }
        }
    }
}

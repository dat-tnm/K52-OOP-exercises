using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        int item;
        bool isValidInput = true;
        MyStack stack1, stack2, stack3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stack1 = new MyStack();
            stack2 = new MyStack();
            stack3 = new MyStack();

            listView1.Columns.Add("Index");
            listView1.Columns.Add("Item");
            listView2.Columns.Add("Index");
            listView2.Columns.Add("Item");
            listView3.Columns.Add("Index");
            listView3.Columns.Add("Item");
        }
        

        private void btnPop_Click(object sender, EventArgs e)
        {
            stack1.Pop();
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem(stack1.ItemsToString()));
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            ConvertInput();
            if (isValidInput == false)
            {
                return;
            }
            stack1.Push(item);
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem(stack1.ItemsToString()));
        }

        private void ConvertInput()
        {
            if (!int.TryParse(textItem.Text, out item))
            {
                MessageBox.Show("Item phải là kiểu int", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidInput = false;
            }
        }


    }
}

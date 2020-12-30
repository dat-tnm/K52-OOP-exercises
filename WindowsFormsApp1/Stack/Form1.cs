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
        int input;
        bool isValidInput = true;
        MyStack stack1, stack2, stack3;

        public Form1()
        {
            InitializeComponent();

            stack1 = new MyStack();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }


        private void btnHeSo2_Click(object sender, EventArgs e)
        {
            ConvertInputToInt();
            if (!isValidInput)
                return;

            if (input == 0)
            {
                stack1.Push(input);
            }

            int item;
            while (input >= 1)
            {
                item = input % 2;
                input = input / 2;
                stack1.Push(item);
            }          

            while (!stack1.isEmpty())
            {
                textResult.Text += stack1.Peek();
                stack1.Pop();
            }
        }

        private void btnHeSo8_Click(object sender, EventArgs e)
        {

        }

        private void btnHeSo16_Click(object sender, EventArgs e)
        {

        }

        private void ConvertInputToInt()
        {
            textResult.Clear();
            if (!int.TryParse(textInput.Text, out input))
            {
                MessageBox.Show("Item phải là kiểu int", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidInput = false;
            }
        }


    }
}

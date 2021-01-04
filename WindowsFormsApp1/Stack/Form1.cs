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
        NumberType tpInput, tpOutput;
        bool isValidInput = true;
        MyStack stack1;

        class enumEle
        {
            public string Text { get; set; }
            public NumberType Value { get; set; }
                
            public enumEle(string text, NumberType value)
            {
                Text = text;
                Value = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            stack1 = new MyStack();
            var listEnum = new List<enumEle>() 
            { 
                new enumEle("Decimal", NumberType.Decimal),
                new enumEle("Binary", NumberType.Binary)
            };
            var listEnum2 = new List<enumEle>()
            {
                new enumEle("Decimal", NumberType.Decimal),
                new enumEle("Binary", NumberType.Binary)
            };
            comboBox1.DataSource = listEnum;
            comboBox1.DisplayMember = "Text";
            comboBox2.DataSource = listEnum2;
            comboBox2.DisplayMember = "Text";
        }

        private void Form1_Load(object sender, EventArgs e)
        { }


        private void btnHeSo2_Click(object sender, EventArgs e)
        {
            ReadInput();
            if (!isValidInput)
                return;

            textResult.Text = NumberConverter.Convert(tpInput, tpOutput, input).ToString();
        }


        void ReadInput()
        {
            textResult.Clear();

            tpInput = ((enumEle)comboBox1.SelectedItem).Value;
            tpOutput = ((enumEle)comboBox2.SelectedItem).Value;

            if (!int.TryParse(textInput.Text, out input))
            {
                MessageBox.Show("Item phải là kiểu int", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidInput = false;
            }
            else if (tpInput == NumberType.Binary)
            {
                var listChar = textInput.Text.ToCharArray();
                foreach (var item in listChar)
                {
                    if (!(item == '1' || item == '0'))
                    {
                        MessageBox.Show("Input kiểu binary chỉ được phép nhập 2 ký tự 0 or 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValidInput = false;
                        return;
                    }
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack
{
    class MyStack
    {
        int size = 100;
        public int Top = -1;

        public int[] items;

        public MyStack()
        {
            items = new int[size];
        }


        public bool isEmpty()
        {
            return Top < 0 ? true : false;
        }

        public bool isFull()
        {
            return Top == (size - 1) ? true : false;
        }

        public void Push(int item)
        {
            if (isFull())
                return;
            Top++;
            items[Top] = item;
        }

        public void Pop()
        {
            if (isEmpty())
                return;
            items[Top] = 0;
            Top--;
        }

        public int Peek()
        {
            return items[Top];
        }
    }

    enum NumberType
    {
        Decimal = 0,
        Binary = 1
    }

    static class NumberConverter
    {
        public static int Convert(NumberType typeInput, NumberType typeOutput, int input)
        {
            if (typeInput == typeOutput)
            {
                return input;
            }

            int temp = ToDecimal(typeInput, input);
            var stack = new MyStack();
            var result = new StringBuilder();
            if (typeOutput == NumberType.Binary)
            {
                if (temp == 0)
                {
                    stack.Push(temp);
                }

                int item;
                while (temp >= 1)
                {
                    item = temp % 2;
                    temp = temp / 2;
                    stack.Push(item);
                }

                while (!stack.isEmpty())
                {
                    result.Append(stack.Peek());
                    stack.Pop();
                }
            }
            else if (typeOutput == NumberType.Decimal)
            {
                return temp;
            }

            return int.Parse(result.ToString());
        }

        static int ToDecimal(NumberType tp, int num)
        {
            if (tp == NumberType.Decimal)
                return num;

            int output = 0;

            if (tp == NumberType.Binary)
            {
                var listChar = num.ToString().ToCharArray();
                int maxIndex = listChar.Length - 1;
                int temp;
                for (int i = 0; i <= maxIndex; i++)
                {
                    temp = int.Parse(listChar[i].ToString());
                    output += temp * (int)Math.Pow(2, maxIndex - i);
                };
            }

            return output;
        }
    }
}

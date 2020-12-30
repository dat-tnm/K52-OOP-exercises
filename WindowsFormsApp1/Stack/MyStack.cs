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
        int top = -1;

        public int[] items;

        public string[] ItemsToString()
        {
            return Array.ConvertAll(items, i => i.ToString());
        }

        public MyStack()
        {
            items = new int[size];
        }


        public bool isEmpty()
        {
            return top < 0 ? true : false;
        }

        public bool isFull()
        {
            return top == (size - 1) ? true : false;
        }

        public void Push(int item)
        {
            if (isFull())
                return;
            top++;
            items[top] = item;
        }

        public void Pop()
        {
            if (isEmpty())
                return;
            items[top] = 0;
            top--;
        }

        public int Peek()
        {
            return items[top];
        }
    }
}

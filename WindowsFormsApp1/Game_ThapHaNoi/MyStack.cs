using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Game_ThapHaNoi
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
}

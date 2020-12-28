using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyStack
{
    class MyStack
    {
        int size = 100;
        int top = 0;

        private int[] stack;

        public MyStack()
        {
            stack = new int[size];
        }


        public bool isEmpty()
        {
            return top == 0 ? true : false;
        }

        public bool isFull()
        {
            return top == size ? true : false;
        }

        public void Push(int item)
        {
            if (isFull())
                return;
            top++;
            stack[top] = item;
        }

        public void Pop()
        {
            if (isEmpty())
                return;
            stack[top] = 0;
            top--;
        }

        int peek()
        {
            return stack[top];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Q
    {
        private string[] Queue;
        private bool IsFull;

        private int front;
        private int back;
        public Q (int s)
        {
            Queue = new string[s];
            front = 0;
            back = 0;
            IsFull = false;
        }

        public bool Add(string s)
        {
            bool added = true;
            if(IsFull == false)
            {
                Queue[back] = s;
                back = (back + 1) % Queue.Length;
                if (front == back)
                {
                    added = false;
                    IsFull = true;
                }
            }
            return added;
        }
        public string Remove()
        {
            string value = "";
            if(front == back && IsFull == false)
            {
                Console.WriteLine("Cannot remove, queue is empty");
            }
            else
            {
                value = Queue[front];
                front = (front + 1) % Queue.Length;
            }
            return value;
        }

        public void Print()
        {
            int i = front;
            do
            {
                Console.WriteLine(Queue[i]);
                i = (i + 1) % Queue.Length;
            }
            while (i != back);
        }
    }
}

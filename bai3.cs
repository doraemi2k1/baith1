using System;
using System.Collections.Generic;
using System.Text;

namespace bài_thực_hành_1_kì_1_năm_2
{
    class stack
    {
        private int top;
        private int[] s;
        public stack()
        {
            top = -1;
            s = new int[20];
        }
        public stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        public bool empty()
        {
            if (top == -1)
                return true;
            else return false;
        }
        public bool full()
        {
            if (top == s.Length - 1)
                return true;
            else return false;
        }
        public void push(int x)
        {
            if (full()) Console.WriteLine("Stack day");
            else s[++top] = x;
        }
        public int pop()
        {
            if (empty()) throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
    }
    class App
    {
        static void Main()
        {
            int n;
            stack s = new stack();
            Console.Write("Nhap n="); n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                s.push(n % 2);
                n = n / 2;
            }
            while (!s.empty())
                Console.Write(s.pop());
            Console.ReadKey();
        }
    }
}

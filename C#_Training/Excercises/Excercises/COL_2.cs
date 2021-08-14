using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    class Stack
    {
        public int size;
        public int top;
        public char[] a;
        public Boolean isEmpty()
        {
            return (top < 0);
        }
        public Stack(int n)
        {
            top = -1;
            size = n;
            a = new char[size];
        }
        public Boolean push(char x)
        {
            if (top >= size)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                a[++top] = x;
                return true;
            }
        }
        public char pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return ' ';
            }
            else
            {
                char x = a[top--];
                return x;
            }
        }
    }

    class Program8
    {
        public static void reverse(StringBuilder str)
        {
            int n = str.Length;
            Stack obj = new Stack(n);
            int i;
            for (i = 0; i < n; i++)
                obj.push(str[i]);

            for (i = 0; i < n; i++)
            {
                char ch = obj.pop();
                str[i] = ch;
            }
        }
        public static void Main()
        {
            StringBuilder s = new StringBuilder("GeeksQuiz");

            reverse(s);

            Console.WriteLine("Reversed string is " + s);
        }
    }
}

using System;

namespace ConsoleApp9
{
    class Program
    {
        public delegate void Operations(int a, int b, int c);
        static void add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        static void sub(int a, int b, int c)
        {
            Console.WriteLine(a - b - c);
        }

        static void mul(int a, int b, int c)
        {
            Console.WriteLine(a * b * c);
        }

        static void div(int a, int b, int c)
        {
            Console.WriteLine(a / b / c);
        }
        static void Main(string[] args)
        {
            Operations A = new Operations(add);
            A(2, 4, 6);
            Operations S = new Operations(sub);
            A(12, 4, 26);
            Operations M= new Operations(mul);
            A(2, 4, 6);
            Operations D = new Operations(div);
            A(24, 4, 6);
            
        }
    }
}

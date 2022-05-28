using System;

namespace ConsoleApp8
{
    class Program
    {
        public delegate void Triangle(int a);
        static void tr2(int i)
        {
            int j;
            while (i > 0)
            {
                j = 1;
                while (j <= i)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                i--;
            }
        }
        static void Main(string[] args)
        {
            Triangle trs2 = new Triangle(tr2);
            trs2(7);
        }
    }
}

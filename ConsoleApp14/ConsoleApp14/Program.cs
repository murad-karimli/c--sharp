using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Prime(int a)
        {
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine(a);
            }
        }
        static void interval(int a,int b)
        {
            for(int i=a;i<=b;i++)
            {
                Prime(i);
            }
        }
        static void Main(string[] args)
        {
            interval(4, 15);
        }
    }
}

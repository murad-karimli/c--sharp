using System;

namespace ConsoleApp6
{
    class Program
    {
        public static void count(int[] a)
        {
            int count;
            bool same;
            for (int i = 0; i < a.Length; i++)
            {
                same = false;
                for (int j = i - 1; j > 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (!same)
                {
                    count = 1;
                    for (int k = i + 1; k < a.Length; k++)
                    {
                        if (a[i] == a[k])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{a[i]}--{count}");
                }
            }
        }
        public static void order(int[] a)
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j]=temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{ a[i]}-");
            }
        }
        static void Main(string[] args)
        {
            int[] g = { 1, 3, 2, 4,11,6,4,82,3, 5 };
            order(g);
            count(g);
        }
    }
}

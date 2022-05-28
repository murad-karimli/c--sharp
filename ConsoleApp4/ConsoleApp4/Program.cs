using System;

namespace ConsoleApp4
{
    class Program
    {
        static void stars(int a, int b)
        {
            while (a > 0)
            {
                b = 0;
                while (b < a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a--;
            }
        }

        static void array(int[] arr)
        {
            int count;
            bool same;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 1;
                same = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] == arr[i])
                    {
                        same = false;
                        break;
                    }

                }
                if (same)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"|{arr[i]}|--- {count} ");
                }
            }

        }


        static void aa(int i)
        {
            int j;
            while (i > 0)
            {
                j = 1;
                while (i > j)
                {
                    Console.Write(" ");
                    j++;
                }
                while (j < 6)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();

                i--;
            }
        }


    }

    }

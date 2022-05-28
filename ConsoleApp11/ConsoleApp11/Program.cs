using System;

namespace ConsoleApp11
{
    class Program
    {
       
        static void Main(string[] args)
        {
           int[,] a =
            {
                {1,2,3},
                {2,3,4},
                {1,4,8}
            };
            for(int i=0;i<a.GetLength(1);i++)
            {
                for(int j=0;j<a.GetLength(0);j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
    }

    
